using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
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
        BLL.Entity entity;
        BLL.Permission permission;

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
            entity = new BLL.Entity();
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
                // TODO implementar validaciones con controles customs
                if (!string.IsNullOrEmpty(txtDNI.Text) &&
                    !string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtApellido.Text) &&
                    !string.IsNullOrEmpty(txtNombreUsuario.Text) &&
                    !string.IsNullOrEmpty(txtEmail.Text) &&
                    cmbRole.SelectedValue != null &&
                    cmbLanguage.SelectedValue != null &&
                    cmbEntity.SelectedValue != null)
                {

                    var tmpusr = usuario_BLL.GetByLoginName(txtNombreUsuario.Text); // usuario temporal para comprobar si existe el username o email en el sistema
                    
                    if (txtNombreUsuario.Text != tmpusr.LoginName && txtEmail.Text != tmpusr.Email)
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
                        usuario_BE.Entity = entity.GetEntityById(int.Parse(cmbEntity.SelectedValue.ToString()));
                        usuario_BE.Language = languageService.GetLanguage(cmbLanguage.Text);
                        usuario_BE.Password = Encrypt.GetSHA256(Encrypt.GetRandomPassword());
                        usuario_BE.Email = txtEmail.Text;
                        usuario_BE.Blocked = false; 

                        usuario_BE.Id = usuario_BLL.UserCreate(usuario_BE);

                        if (usuario_BE.Id == 0)
                            MessageBox.Show("Error al crear el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Usuario creado correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // guardo el Rol del usuario
                        if (cmbRole.SelectedValue != null)
                        {
                            usuario_BE.Role = (int)cmbRole.SelectedValue;
                            permission.SaveUserPermission(usuario_BE.Id, usuario_BE.Role);
                        }
                    }
                    if (txtNombreUsuario.Text == tmpusr.LoginName)
                        MessageBox.Show("Este usuario ya está registrado en el sistema", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (txtEmail.Text == tmpusr.Email)
                        MessageBox.Show("Este email ya está registrado en el sistema", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            //_frmUsersList.Bind();
            Close();
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == usuario_BE.LoginName) // si el nombre de usuario es el mismo
            {
                //usuario_BE = GetValuesFromForm();
                usuario_BE.DNI = txtDNI.Text;
                usuario_BE.Name = txtNombre.Text;
                usuario_BE.Lastname = txtApellido.Text;
                usuario_BE.LoginName = txtNombreUsuario.Text;
                usuario_BE.Address = txtAddress.Text;
                usuario_BE.Email = txtEmail.Text;
                usuario_BE.Active = chkActive.Checked;
                usuario_BE.Blocked = chkBlocked.Checked;
                usuario_BE.Role = int.Parse(cmbRole.SelectedValue.ToString());
                usuario_BE.Entity = entity.GetEntityById(int.Parse(cmbEntity.SelectedValue.ToString()));
                usuario_BE.Language = languageService.GetLanguage(cmbLanguage.Text);
                usuario_BE.Email = txtEmail.Text;

                userDB = usuario_BLL.GetByLoginName(txtNombreUsuario.Text);

                UpdateUser(usuario_BE, userDB);
            }
            else // si el nombre de usuario es distinto
            {
                var tmpusr = usuario_BLL.GetByLoginName(txtNombreUsuario.Text); // traigo temp user para comparar sus loginnames
                if (tmpusr.LoginName is null) // si son distintos
                {
                    usuario_BE.DNI = txtDNI.Text;
                    usuario_BE.Name = txtNombre.Text;
                    usuario_BE.Lastname = txtApellido.Text;
                    usuario_BE.LoginName = txtNombreUsuario.Text;
                    usuario_BE.Address = txtAddress.Text;
                    usuario_BE.Email = txtEmail.Text;
                    usuario_BE.Active = chkActive.Checked;
                    usuario_BE.Blocked = chkBlocked.Checked;
                    usuario_BE.Role = int.Parse(cmbRole.SelectedValue.ToString());
                    usuario_BE.Entity = entity.GetEntityById(int.Parse(cmbEntity.SelectedValue.ToString()));
                    usuario_BE.Language = languageService.GetLanguage(cmbLanguage.Text);
                    usuario_BE.Email = txtEmail.Text;

                    UpdateUser(usuario_BE, userDB);
                }
                else
                    MessageBox.Show("El usuario ya se encuentra registrado, por favor, elija uno diferente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateUser(BE.User newUser, BE.User currentUser)
        {
            try
            {

                bool operation = false;

                if (!usuario_BE.Equals(userDB))
                {
                    operation = usuario_BLL.UserUpdate(usuario_BE);

                    // refactorizar
                    if (cmbRole.SelectedValue != null)
                    {
                        usuario_BE.Role = (int)cmbRole.SelectedValue;
                        int permissionSaved = permission.SaveUserPermission(usuario_BE.Id, usuario_BE.Role);
                    }

                    if (!operation)
                        MessageBox.Show($"Se ha producido un error al modificar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show($"El usuario se modificó correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            user.Entity = entity.GetEntityById(int.Parse(cmbEntity.SelectedValue.ToString()));            
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

            entity = new BLL.Entity();
            cmbEntity.DataSource = entity.EntityList();
            cmbEntity.DisplayMember = "Name";
            cmbEntity.ValueMember = "Id";
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
