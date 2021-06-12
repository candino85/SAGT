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
    public partial class frmPermisos : Form
    {
        private List<Rol> roles;
        private List<Permiso> permisos;
        public frmPermisos()
        {
            InitializeComponent();
            roles = new List<Rol>();
            permisos = new List<Permiso>();
        }

        private void btnCrearPermiso_Click(object sender, EventArgs e)
        {

        }
    }
}
