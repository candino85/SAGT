using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Negocio.Reportes
{
    public partial class frmReport2 : Form, ILanguageObserver
    {
        BLL.Estudio estudio;
        BLL.Client cliente;
        BLL.Turno turno;
        BLL.Sucursal sucursal;
        BLL.Agenda agenda;
        public frmReport2()
        {
            InitializeComponent();
            estudio = new BLL.Estudio();
            cliente = new BLL.Client();
            turno = new BLL.Turno();
            sucursal = new BLL.Sucursal();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmReport2_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);

            cmbSucursales.DataSource = sucursal.SucursalList();
            cmbSucursales.ValueMember = "id";
            cmbSucursales.DisplayMember = "Name";
            cmbSucursales.SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.muestrasTableAdapter.Fill(dataSetRepo1.Muestras, ((BE.Turno)cmbFechaEstudio.SelectedItem).fechaTurno, (int)cmbEstudios.SelectedValue, 
                (int)cmbPacientes.SelectedValue, (int)cmbSucursales.SelectedValue);
            this.reportViewer2.RefreshReport();
        }

        private void cmbSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPacientes.Enabled = true;
            cmbPacientes.DataSource = cliente.ClientList();
            cmbPacientes.ValueMember = "id";
            cmbPacientes.DisplayMember = "FullName";
            cmbPacientes.SelectedIndex = -1;
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstudios.Enabled = true;
            cmbEstudios.DataSource = estudio.EstudioList();
            cmbEstudios.ValueMember = "id";
            cmbEstudios.DisplayMember = "Nombre";
            cmbEstudios.SelectedIndex = -1;
        }

        private void cmbEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFechaEstudio.Enabled = true;
            cmbFechaEstudio.DataSource = turno.TurnoList().Where(x=>x.client == (int)cmbPacientes.SelectedValue &&
                                                                    x.sucursal == (int)cmbSucursales.SelectedValue).ToList();
            cmbFechaEstudio.ValueMember = "id";
            cmbFechaEstudio.DisplayMember = "fechaTurno";
            cmbFechaEstudio.SelectedIndex = -1;
        }

        private void frmReport2_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
