using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Negocio.ABM
{
    public partial class frmEstudio : Form
    {
        BE.Estudio estudio_BE;
        BLL.Estudio estudio_BLL;

        BLL.Especialidad especialidad_BLL;

        //private frmClientList _frmClientsList;
        private frmRegistrarTurno _frmRegistrarTurno;

        public frmEstudio()
        {
            InitializeComponent();

            estudio_BLL = new BLL.Estudio();

            btnModify.Enabled = false;
            btnRemove.Enabled = false;
        }

        public frmEstudio(frmRegistrarTurno frmRegistrarTurno)
        {
            InitializeComponent();
            _frmRegistrarTurno = frmRegistrarTurno;

            estudio_BLL = new BLL.Estudio();
            especialidad_BLL = new BLL.Especialidad();

            cmbEspecialidad.DataSource = especialidad_BLL.EspecialidadList();
            cmbEspecialidad.ValueMember = "Id";
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.SelectedValue = -1;

            btnModify.Enabled = false;
            btnRemove.Enabled = false;

            txtTiempo.Enabled = false;
            chkActive.Enabled = false;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedValue != null)
            {
                estudio_BE = new BE.Estudio()
                {
                    Nombre = txtName.TextBoxText,
                    Especialidad = (int)cmbEspecialidad.SelectedValue,
                    Tiempo = 15,
                    Activo = false
                };
            }
            else
                MessageBox.Show("Seleccione una Especialidad!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            bool operation = estudio_BLL.EstudioCreate(estudio_BE);

            if (!operation)
                throw new Exception("Error al crear el cliente");
            else
                MessageBox.Show("El nueo estudio se guardó correctamente para futuros reportes", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
