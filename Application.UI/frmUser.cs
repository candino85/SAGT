﻿using Application.Services;
using System;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmUser : Form
    {
        BE.User usuario_BE;
        BLL.User usuario_BLL;
        public frmUser()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';

            usuario_BLL = new BLL.User();
            usuario_BE = new BE.User();
            Enlazar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            usuario_BE = new BE.User();
            usuario_BE.Nombre = txtNombre.Text;
            usuario_BE.Apellido = txtApellido.Text;
            usuario_BE.DNI = txtDNI.Text;
            usuario_BE.LoginName = txtNombreUsuario.Text;
            usuario_BE.Password = Encrypt.GetSHA256(txtPassword.Text);

            bool operation = usuario_BLL.CrearUsuario(usuario_BE);
            
            if (!operation)
                throw new Exception("Error al crear el usuario");

            LimpiarControles();
            Enlazar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {           
            usuario_BE.DNI = txtDNI.Text;
            usuario_BE.Nombre = txtNombre.Text;
            usuario_BE.Apellido = txtApellido.Text;            
            usuario_BE.LoginName = txtNombreUsuario.Text;
            usuario_BE.Password = Encrypt.GetSHA256(txtPassword.Text);

            bool operation;
            operation = usuario_BLL.ModificarUsuario(usuario_BE);

            if (!operation)
                throw new Exception("Error al modificar el usuario");

            LimpiarControles();
            Enlazar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario_BE.Nombre = txtNombre.Text;
            usuario_BE.Apellido = txtApellido.Text;
            usuario_BE.DNI = txtDNI.Text;
            usuario_BE.LoginName = txtNombreUsuario.Text;
            usuario_BE.Password = txtPassword.Text;

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
            txtDNI.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtNombreUsuario.Text = null;
            txtPassword.Text = null;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario_BE = new BE.User();
            usuario_BE = (BE.User)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;
            txtDNI.Text = usuario_BE.DNI;
            txtNombre.Text = usuario_BE.Nombre;
            txtApellido.Text = usuario_BE.Apellido;
            txtNombreUsuario.Text = usuario_BE.LoginName;
            txtPassword.Text = usuario_BE.Password;
        }
    }
}