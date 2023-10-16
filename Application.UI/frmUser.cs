using Application.ABSTRACTIONS;
using Application.DLL;
using Application.Services;
using Application.UI.Language;
using System;
using System.Linq;
using System.Net.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Application.UI
{
    public partial class frmUser : Form, ILanguageObserver
    {
        BE.User usuario_BE;
        BE.User userDB;
        BLL.User usuario_BLL;

        BLL.LanguageService languageService;
        BLL.Sucursal entity;
        BLL.Permission permission;

        BLL.Bitacora bitacora;

        private frmUsersList _frmUsersList;

        public frmUser()
        {
            InitializeComponent();

            usuario_BLL = new BLL.User();
            permission = new BLL.Permission();

            btnUpdateUsers.Visible = false;
            btnCreateUser.Visible = true;

            CombosLoad();
            cmbLanguage.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
            cmbEntity.SelectedIndex = -1;
        }

        //public frmUser(frmUsersList frmUsersList)
        //{
        //    InitializeComponent();           

        //    usuario_BLL = new BLL.User();
        //    permission = new BLL.Permission();

        //    btnUpdateUsers.Enabled = false;

        //    CombosLoad();
        //    cmbLanguage.SelectedIndex = -1;
        //    cmbRole.SelectedIndex = -1;

        //}

        public frmUser(BE.User usuario, frmUsersList frmUsersList)
        {
            InitializeComponent();
            usuario_BE = usuario;

            usuario_BLL = new BLL.User();
            entity = new BLL.Sucursal();
            permission = new BLL.Permission();
            
            _frmUsersList = frmUsersList;

            btnCreateUser.Visible = false;
            btnUpdateUsers.Visible = true;

            txtDNI.Text = usuario.DNI;
            txtNombre.Text = usuario.Name;
            txtApellido.Text = usuario.Lastname;
            txtNombreUsuario.Text = usuario.LoginName;
            txtAddress.Text = usuario.Address;
            txtEmail.Text = usuario.Email;
            chkActive.Checked = usuario.Active;
            chkBlocked.Checked = usuario.Blocked;

            CombosLoad();
            cmbLanguage.SelectedValue = usuario.Language.Id;
            cmbRole.SelectedValue = usuario.Role;   
            cmbEntity.SelectedValue = usuario.Entity.Id;

            // traigo el rol actual del usuario
            var rol = 0;
            rol = permission.GetUserRole(usuario.Id);
            if (rol != 0)
                cmbRole.SelectedValue = rol;
            else
                cmbRole.SelectedIndex = -1;
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDNI.Text) &&
                    !string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtApellido.Text) &&
                    !string.IsNullOrEmpty(txtNombreUsuario.Text) &&
                    !string.IsNullOrEmpty(txtEmail.Text) &&
                    cmbRole.SelectedValue != null &&
                    cmbLanguage.SelectedValue != null &&
                    cmbEntity.SelectedValue != null)
                {

                    //var chckLoginname = usuario_BLL.GetByLoginName(txtNombreUsuario.Text); // usuario temporal para comprobar si existe el username o email en el sistema
                    //var checkEmail = usuario_BLL.UserList();
                    //if ((txtNombreUsuario.Text != chckLoginname.LoginName) || (txtEmail.Text != (checkEmail.FirstOrDefault(usr => usr.Email == txtEmail.Text)).Email));

                    var usrExist = usuario_BLL.UserExist(txtNombreUsuario.Text, txtEmail.Text, txtDNI.Text);
                    
                    if (usrExist[0] == 0 && usrExist[1] == 0 && usrExist[2] == 0)
                    {
                        //usuario_BE = GetValuesFromForm();
                        usuario_BE = new BE.User();
                        usuario_BE.DNI = txtDNI.Text;
                        usuario_BE.Name = txtNombre.Text;
                        usuario_BE.Lastname = txtApellido.Text;
                        usuario_BE.LoginName = txtNombreUsuario.Text;
                        usuario_BE.Address = txtAddress.Text;
                        usuario_BE.Email = txtEmail.Text;
                        usuario_BE.Active = chkActive.Checked;
                        usuario_BE.Blocked = chkBlocked.Checked;
                        usuario_BE.Role = int.Parse(cmbRole.SelectedValue.ToString());
                        usuario_BE.Entity = entity.GetSucursalById(int.Parse(cmbEntity.SelectedValue.ToString()));
                        usuario_BE.Language = languageService.GetLanguage(cmbLanguage.Text);
                            string tmppsw = Encrypt.GetRandomPassword();
                        usuario_BE.Password = Encrypt.GetSHA256(tmppsw);
                        usuario_BE.Email = txtEmail.Text;
                        usuario_BE.Blocked = false;

                        usuario_BE.Id = usuario_BLL.UserCreate(usuario_BE);

                        if (usuario_BE.Id == 0)
                            MessageBox.Show("Error al crear el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            EmailSender.NotificarContraseña(usuario_BE.LoginName, tmppsw, usuario_BE.Email);
                            MessageBox.Show("Usuario creado correctamente, las credenciales se enviaron al correo electrónico del nuevo usuario.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        // guardo el Rol del usuario
                        if (cmbRole.SelectedValue != null)
                        {
                            usuario_BE.Role = (int)cmbRole.SelectedValue;
                            permission.SaveUserPermission(usuario_BE.Id, usuario_BE.Role);
                        }
                    }
                    if (usrExist[0] > 0)
                        MessageBox.Show($"El nombre de usuario '{txtNombreUsuario.Text}' ya está registrado en el sistema, por favor, ingrese otro diferente\n", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    if (usrExist[1] > 0)
                        MessageBox.Show($"El correo '{txtEmail.Text}' ya está registrado en el sistema, por favor, ingrese otro diferente\n", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (usrExist[2] > 0)
                        MessageBox.Show($"El DNI '{txtDNI.Text}' ya está registrado en el sistema\n", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Verifique los campos para crear el nuevo usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error\n{ex}\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string msg = "Usuario actualizado correctamente.";
            var newUser = usuario_BE;

            if (txtNombreUsuario.Text == newUser.LoginName) // si el nombre de usuario es el mismo
            {               
                newUser.DNI = txtDNI.Text;
                newUser.Name = txtNombre.Text;
                newUser.Lastname = txtApellido.Text;
                //newUser.LoginName = txtNombreUsuario.Text;
                newUser.Address = txtAddress.Text;
                newUser.Email = txtEmail.Text;
                newUser.Active = chkActive.Checked;
                
                if (newUser.Blocked == true && chkBlocked.Checked == false)
                {
                    newUser.Attempts = 0;
                    msg = "Usuario desbloqueado correctamente.";
                }
                else if (newUser.Blocked == false && chkBlocked.Checked == true)
                {
                    msg = "Usuario bloqueado correctamente.";                    
                }
                newUser.Blocked = chkBlocked.Checked;
                newUser.Role = int.Parse(cmbRole.SelectedValue.ToString());
                newUser.Entity = entity.GetSucursalById(int.Parse(cmbEntity.SelectedValue.ToString()));
                newUser.Language = languageService.GetLanguage(cmbLanguage.Text);
                newUser.Email = txtEmail.Text;

                userDB = usuario_BLL.GetByLoginName(txtNombreUsuario.Text);                
                
                UpdateUser(newUser, userDB, msg);
            }
            else // si el nombre de usuario es distinto
            {
                var chckUser = usuario_BLL.GetByLoginName(txtNombreUsuario.Text); // traigo temp user para comparar sus loginnames
                if (chckUser.LoginName is null) // si son distintos
                {
                    newUser.DNI = txtDNI.Text;
                    newUser.Name = txtNombre.Text;
                    newUser.Lastname = txtApellido.Text;
                    newUser.LoginName = txtNombreUsuario.Text;
                    newUser.Address = txtAddress.Text;
                    newUser.Email = txtEmail.Text;
                    newUser.Active = chkActive.Checked;
                    newUser.Blocked = chkBlocked.Checked;
                    newUser.Role = int.Parse(cmbRole.SelectedValue.ToString());
                    newUser.Entity = entity.GetSucursalById(int.Parse(cmbEntity.SelectedValue.ToString()));
                    newUser.Language = languageService.GetLanguage(cmbLanguage.Text);
                    newUser.Email = txtEmail.Text;

                    msg = "Usuario actualizado correctamente.";

                    UpdateUser(newUser, userDB, msg);
                }
                else
                    MessageBox.Show("El usuario ya se encuentra registrado, por favor, elija uno diferente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateUser(BE.User newUser, BE.User currentUser, string msg)
        {
            try
            {
                bool operation = false;

                if (!usuario_BE.Equals(userDB))
                {
                    operation = usuario_BLL.UserUpdate(usuario_BE,msg);

                    // refactorizar
                    if (cmbRole.SelectedValue != null)
                    {
                        usuario_BE.Role = (int)cmbRole.SelectedValue;
                        int permissionSaved = permission.SaveUserPermission(usuario_BE.Id, usuario_BE.Role);
                    }

                    if (!operation)
                        MessageBox.Show($"Se ha producido un error al modificar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show($"{msg}", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("El usuario no presentó cambios");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error\n{ex}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _frmUsersList.Bind();
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private BE.User GetValuesFromForm()
        {
            BE.User user = new BE.User();//usuario_BLL.GetByLoginName(txtNombreUsuario.Text);
            user.DNI = txtDNI.Text;
            user.Name = txtNombre.Text;
            user.Lastname = txtApellido.Text;
            user.LoginName = txtNombreUsuario.Text;
            user.Address = txtAddress.Text;            
            user.Active = chkActive.Checked;
            user.Role = int.Parse(cmbRole.SelectedValue.ToString());
            user.Entity = entity.GetSucursalById(int.Parse(cmbEntity.SelectedValue.ToString()));            
            user.Language = languageService.GetLanguage(cmbLanguage.Text);
            if (_frmUsersList.Name != "frmUsersList")
                user.Password = Encrypt.GetSHA256(Encrypt.GetRandomPassword());

            return user;
        }

        private void CombosLoad()
        {
            languageService = new BLL.LanguageService();
            cmbLanguage.DataSource = null;
            cmbLanguage.DataSource = languageService.GetLanguages();
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.ValueMember = "Id";

            cmbRole.DataSource = null;
            cmbRole.DataSource = permission.GetAllRolesFromDB();
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";

            entity = new BLL.Sucursal();
            cmbEntity.DataSource = entity.SucursalList();
            cmbEntity.DisplayMember = "Name";
            cmbEntity.ValueMember = "Id";
        }

        private void btnPswRst_Click(object sender, EventArgs e)
        {
            usuario_BE.Attempts = 0;
            usuario_BE.Blocked = false;
            usuario_BLL.UserUpdate(usuario_BE,"Reseteo de clave");

            var updUser = usuario_BE;
            string tmppsw = Encrypt.GetRandomPassword();
            updUser.Password = Encrypt.GetSHA256(tmppsw);
            try
            {
                usuario_BLL.UpdatePassword(usuario_BE, updUser);
                EmailSender.NotificarContraseña(updUser.LoginName, tmppsw, updUser.Email);
                MessageBox.Show("Las credenciales se enviaron al correo electrónico del usuario.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    usuario_BE.Nombre = txtNombre.Text;
        //    usuario_BE.Apellido = txtApellido.Text;
        //    usuario_BE.DNI = txtDNI.Text;
        //    usuario_BE.LoginName = txtNombreUsuario.Text;
        //    usuario_BE.Password = txtPassword.Text;

        //    bool operation = usuario_BLL.UserRemove(usuario_BE.Id);

        //    if (!operation)
        //        throw new Exception("Error al modificar el usuario");

        //    LimpiarControles();
        //    //Enlazar();
        //}

        //void LimpiarControles()
        //{
        //    txtDNI.Text = null;
        //    txtNombre.Text = null;
        //    txtApellido.Text = null;
        //    txtNombreUsuario.Text = null;
        //    txtPassword.Text = null;
        //}
    }
}
