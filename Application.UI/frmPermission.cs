using Application.BE;
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
    public partial class frmPermission : Form
    {
        //List<BE.Permission> _listaPermisos;
        BE.Permission _permisoBE;
        BE.Role _role;
        BLL.Permission _permisoBLL;

        public frmPermission()
        {
            InitializeComponent();
            //_listaPermisos = new List<Permission>();
            _permisoBLL = new BLL.Permission();
            _role = new Role(null, null);
        }

        void LimpiarTreeView()
        {
            txtNombrePermiso.Text = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            _permisoBE = new Permission(txtNombrePermiso.Text, _role);
            _role.AddHijo(_permisoBE);
            
            tvPermisos.Nodes.Add(_permisoBE.Nombre);
            LimpiarTreeView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombrePermiso.Text != null)
                _role.RemoveHijo(_role.GetPermission(txtNombrePermiso.Text));
            else
                MessageBox.Show("Seleccione el permiso que desea eliminar");

            tvPermisos.Nodes.Remove(tvPermisos.SelectedNode);
            LimpiarTreeView();
        }

        private void tvPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtNombrePermiso.Text = tvPermisos.SelectedNode.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<BE.Component> permisos = _role.GetHijos().ToList();
            foreach (Permission p in permisos)
            {
                _permisoBLL.CrearPermiso(p);              
            }
        }
    }
}
