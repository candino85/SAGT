using Application.ABSTRACTIONS;
using Application.BE;
using Application.Services;
using System;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmUser : Form/*, IObserver*/
    {
        BE.User usuario_BE;
        BLL.User usuario_BLL;

        BE.Language idioma_BE;
        BLL.Language idioma_BLL;

        BLL.Permission permission;

        private frmUsersList _frmUsersList;

        public frmUser(frmUsersList frmUsersList)
        {
            InitializeComponent();
            _frmUsersList = frmUsersList;

            usuario_BLL = new BLL.User();
            permission = new BLL.Permission();

            txtPassword.PasswordChar = '*';
            btnUpdateUsers.Enabled = false;

            CombosLoad();
        }

        public frmUser(BE.User usuario, frmUsersList frmUsersList)
        {
            InitializeComponent();
            usuario_BE = usuario;

            _frmUsersList = frmUsersList;

            usuario_BLL = new BLL.User();
            permission = new BLL.Permission();

            CombosLoad();

            txtPassword.PasswordChar = '*';
            btnCreateUser.Enabled = false;

            txtDNI.Text = usuario.DNI;
            txtNombre.Text = usuario.Name;
            txtApellido.Text = usuario.Lastname;
            txtNombreUsuario.Text = usuario.LoginName;
            txtPassword.Text = usuario.Password;
            chkActive.Checked = usuario.Active;

            // traigo el rol actual del usuario
            var rol = 0;
            rol = permission.GetUserRole(usuario.Id);
            if (rol != 0)
                cmbRole.SelectedValue = rol;
            else
                cmbRole.SelectedIndex = -1;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            usuario_BE = new BE.User();
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDNI.Text) && !string.IsNullOrEmpty(txtPassword.Text) && cmbRole.SelectedValue != null)
            {
                if (txtNombreUsuario.Text != (usuario_BLL.GetByLoginName(txtNombreUsuario.Text)).LoginName)
                {
                    usuario_BE.Name = txtNombre.Text;
                    usuario_BE.Lastname = txtApellido.Text;
                    usuario_BE.DNI = txtDNI.Text;
                    usuario_BE.LoginName = txtNombreUsuario.Text;
                    usuario_BE.Password = Encrypt.GetSHA256(txtPassword.Text);
                    usuario_BE.Active = true;
                                       

                    usuario_BE.Id = usuario_BLL.UserCreate(usuario_BE);

                    if (usuario_BE.Id == 0)
                        throw new Exception("Error al crear el usuario");
                    else
                    {
                        if (cmbRole.SelectedValue != null)
                        {
                            usuario_BE.Role = (int)cmbRole.SelectedValue;
                            permission.SaveUserPermission(usuario_BE.Id, usuario_BE.Role);
                        }
                    }
                    _frmUsersList.Bind();
                    this.Close();
                }
                else
                    MessageBox.Show("El usuario ya se encuentra registrado, por favor, elija uno diferente");
            }
            else
                MessageBox.Show("Verifique los campos para crear el nuevo usuario");
            
            _frmUsersList.Bind();
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == usuario_BE.LoginName)
            {                    
                usuario_BE.DNI = txtDNI.Text;
                usuario_BE.Name = txtNombre.Text;
                usuario_BE.Lastname = txtApellido.Text;
                usuario_BE.Active = chkActive.Checked;


                    if (txtPassword.Text != usuario_BE.Password)
                    {
                        DialogResult result = MessageBox.Show("La contraseña ingresada difiere de la contraseña guardada", "Desea cambiar la clave del usuario por la ingresada?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                            usuario_BE.Password = Encrypt.GetSHA256(txtPassword.Text);
                    }
            }
            else 
            { 
                if (txtNombreUsuario.Text != (usuario_BLL.GetByLoginName(txtNombreUsuario.Text)).LoginName)
                {
                    usuario_BE.LoginName = txtNombreUsuario.Text;
                }
                else
                    MessageBox.Show("El usuario ya se encuentra registrado, por favor, elija uno diferente");
            }


            bool operation;
            operation = usuario_BLL.UserUpdate(usuario_BE);

            if (!operation)
                throw new Exception("Error al modificar el usuario");


            // refactorizar
            if (cmbRole.SelectedValue != null)
            {
                usuario_BE.Role = (int)cmbRole.SelectedValue;
                permission.SaveUserPermission(usuario_BE.Id, usuario_BE.Role);
            }

            _frmUsersList.Bind();
            this.Close();
        }
        private void CombosLoad()
        {
            idioma_BLL = new BLL.Language();
            cmbLanguage.DataSource = idioma_BLL.Listar();
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.ValueMember = "Id";
            cmbLanguage.SelectedIndex = -1;

            cmbRole.DataSource = null;
            cmbRole.DataSource = permission.GetAllRolesFromDB();
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";
        }

        public void NotifyObserver(ILanguage languageObserver)
        {
            // tengo que traer las traducciones para el idioma seteado del usuario
            idioma_BE = idioma_BLL.GetLanguage(languageObserver.Name);

            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                    control.Text = idioma_BE.SearchTranslate(control.Tag.ToString());
                //control.Text = languageObserver.SearchTranslate(control.Tag.ToString());
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
