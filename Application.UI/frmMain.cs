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
    public partial class frmMain : Form
    {
        LoginService _login;
        
        public frmMain()
        {
            InitializeComponent();           
            _login = new LoginService();
            ValidarForm();
            
        }

        public void ValidarForm()
        {
            this.menuLogin.Enabled = !SessionManager.GetInstance.IsLogged;
            this.menuLogout.Enabled = SessionManager.GetInstance.IsLogged;
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            _login.Logout();
            lblSession.Text = null;
            ValidarForm();
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermission frm = new frmPermission();
            frm.MdiParent = this;
            frm.Show();
        }

        //private void MostrarPermisos()
        //{
        //    Rol rolAdministrador = new Rol(1, "Administrador", null);
        //    Rol rolOperador = new Rol(2, "Operador", null);            

        //    Rol ABM_Clientes = new Rol(3, "ABM Clientes", rolOperador);
        //    Rol ABM_Entidades = new Rol(4, "ABM Entidades", rolAdministrador);

        //    Permiso AltaCliente = new Permiso(1, "Alta", ABM_Clientes);
        //    Permiso BajaCliente = new Permiso(1, "Baja", ABM_Clientes);
        //    Permiso ModificacionCliente = new Permiso(1, "Modificación", ABM_Clientes);

        //    Permiso AltaEntidad = new Permiso(1, "Alta", ABM_Entidades);
        //    Permiso BajaEntidad = new Permiso(1, "Baja", ABM_Entidades);
        //    Permiso ModificacionEntidad = new Permiso(1, "Modificación", ABM_Entidades);

        //    rolAdministrador.AddHijo(ABM_Entidades);

        //    rolOperador.AddHijo(ABM_Clientes);
        //    rolOperador.AddHijo(AltaCliente);

        //}

        //private void MostrarUsuario()
        //{
        //    if (_session.Equals(Guid.Empty))
        //        this.lblSession.Text = "Por favor, inicie session";
        //    else
        //    {
        //        this.lblSession.Text = _usuario.Application.BLL(Usuario);
        //    }
        //}
    }
}
