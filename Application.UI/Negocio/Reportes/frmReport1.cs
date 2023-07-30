using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using Application.UI.Negocio.Reportes.DataSetRepo1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Negocio.Reportes
{
    public partial class frmReport1 : Form, ILanguageObserver
    {
        BLL.Estudio estudio;
        public frmReport1()
        {
            InitializeComponent();
            estudio = new BLL.Estudio();

        }

        private void frmReport1_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);

            cmbEstudios.DataSource = estudio.EstudioList();
            cmbEstudios.ValueMember = "id";
            cmbEstudios.DisplayMember = "nombre";
            cmbEstudios.SelectedIndex = -1;

            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today.AddDays(1);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(dtpDesde.Value <= dtpHasta.Value)
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = (dtpHasta.Value - dtpHasta.Value.TimeOfDay).AddHours(23).AddMinutes(59);

                if (cmbEstudios.SelectedValue != null)
                {
                    this.turnosTableAdapter.Fill(this.dataSetRepo1.Turnos, desde, hasta, (int)cmbEstudios.SelectedValue);
                    this.reportViewer1.RefreshReport();
                }
                else
                    MessageBox.Show("Seleccione un estudio para continuar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);          
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmReport1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
