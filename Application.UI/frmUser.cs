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

        private frmUsersList _frmUsersList;

        public frmUser(frmUsersList frmUsersList)
        {
            InitializeComponent();
            _frmUsersList = frmUsersList;

            usuario_BLL = new BLL.User();

            txtPassword.PasswordChar = '*';
            btnUpdateUsers.Enabled = false;
            
            ComboLanguageLoad();
        }

        public frmUser(BE.User usuario, frmUsersList frmUsersList)
        {
            InitializeComponent();
            usuario_BE = usuario;

            _frmUsersList = frmUsersList;

            usuario_BLL = new BLL.User();

            ComboLanguageLoad();

            txtPassword.PasswordChar = '*';
            btnCreateUser.Enabled = false;

            txtDNI.Text = usuario.DNI;
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtNombreUsuario.Text = usuario.LoginName;
            txtPassword.Text = Encrypt.GetSHA256(usuario.Password);            
        }        

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            usuario_BE = new BE.User();

            usuario_BE.Nombre = txtNombre.Text;
            usuario_BE.Apellido = txtApellido.Text;
            usuario_BE.DNI = txtDNI.Text;
            usuario_BE.LoginName = txtNombreUsuario.Text;
            usuario_BE.Password = Encrypt.GetSHA256(txtPassword.Text);

            bool operation = usuario_BLL.UserCreate(usuario_BE);

            if (!operation)
                throw new Exception("Error al crear el usuario");


            _frmUsersList.Bind();
            this.Close();
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            usuario_BE.DNI = txtDNI.Text;
            usuario_BE.Nombre = txtNombre.Text;
            usuario_BE.Apellido = txtApellido.Text;
            usuario_BE.LoginName = txtNombreUsuario.Text;
            if (txtPassword.Text != usuario_BE.Password)
                usuario_BE.Password = Encrypt.GetSHA256(txtPassword.Text);

            bool operation;
            operation = usuario_BLL.UserUpdate(usuario_BE);

            if (!operation)
                throw new Exception("Error al modificar el usuario");

            _frmUsersList.Bind();
            this.Close();
        }

        private void ComboLanguageLoad()
        {
            idioma_BLL = new BLL.Language();
            cmbLanguage.DataSource = idioma_BLL.Listar();
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.ValueMember = "Id";
            cmbLanguage.SelectedIndex = -1;
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
