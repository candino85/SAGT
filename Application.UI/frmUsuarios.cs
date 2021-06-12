using Application.BE;
using Application.BLL;
using Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmUsuarios : Form
    {
        UsuarioBE usuario_BE;
        BLL.UsuarioBLL usuario_BLL;
        public frmUsuarios()
        {
            InitializeComponent();
            
            txtPassword.IsPassword('*');

            usuario_BLL = new UsuarioBLL();
            usuario_BE = new BE.UsuarioBE();
            Enlazar();
        }

        private void txtCrear_Click(object sender, EventArgs e)
        {
            usuario_BE = new BE.UsuarioBE();
            usuario_BE.Nombre = txtNombre.TextBox;
            usuario_BE.Apellido = txtApellido.TextBox;
            usuario_BE.DNI = txtDNI.TextBox;
            usuario_BE.LoginName = txtNombreUsuario.TextBox;
            usuario_BE.Password = Encriptacion.GetSHA256(txtPassword.TextBox);

            bool operation = usuario_BLL.CrearUsuario(usuario_BE);
            
            if (!operation)
                throw new Exception("Error al crear el usuario");

            LimpiarControles();
            Enlazar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {           
            usuario_BE.DNI = txtDNI.TextBox;
            usuario_BE.Nombre = txtNombre.TextBox;
            usuario_BE.Apellido = txtApellido.TextBox;            
            usuario_BE.LoginName = txtNombreUsuario.TextBox;
            usuario_BE.Password = Encriptacion.GetSHA256(txtPassword.TextBox);

            bool operation;
            operation = usuario_BLL.ModificarUsuario(usuario_BE);

            if (!operation)
                throw new Exception("Error al modificar el usuario");

            LimpiarControles();
            Enlazar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario_BE.Nombre = txtNombre.TextBox;
            usuario_BE.Apellido = txtApellido.TextBox;
            usuario_BE.DNI = txtDNI.TextBox;
            usuario_BE.LoginName = txtNombreUsuario.TextBox;
            usuario_BE.Password = txtPassword.TextBox;

            bool operation = usuario_BLL.EliminarUsuario(usuario_BE.Id);

            if (!operation)
                throw new Exception("Error al modificar el usuario");

            LimpiarControles();
            Enlazar();
        }

        void Enlazar()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuario_BLL.Listar();            
        }

        void LimpiarControles()
        {
            txtDNI.TextBox = null;
            txtNombre.TextBox = null;
            txtApellido.TextBox = null;
            txtNombreUsuario.TextBox = null;
            txtPassword.TextBox = null;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario_BE = new BE.UsuarioBE();
            usuario_BE = (UsuarioBE)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
            txtDNI.TextBox = usuario_BE.DNI;
            txtNombre.TextBox = usuario_BE.Nombre;
            txtApellido.TextBox = usuario_BE.Apellido;
            txtNombreUsuario.TextBox = usuario_BE.LoginName;
            txtPassword.TextBox = usuario_BE.Password;
        }
    }
}
