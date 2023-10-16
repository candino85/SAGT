using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Bitacora
{
    public partial class FrmBitacora : Form, ILanguageObserver
    {
        private BE.Bitacora bitacoraFiltro;
        private BLL.Bitacora mapperBitacora;

        private BE.Filtro filtro;

        private BLL.User mapperUsuario;

        public FrmBitacora()
        {
            InitializeComponent();

            mapperBitacora = new BLL.Bitacora();
            bitacoraFiltro = new BE.Bitacora();

            mapperUsuario = new BLL.User();

            var listBitacora = mapperBitacora.GetAll();

            LoadCombos();
            DataGridViewConfig();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void LoadCombos()
        {
            cmbUsuario.DataSource = mapperUsuario.UserList();
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.DisplayMember = "loginname";
            cmbUsuario.SelectedItem = null;

            cmbOperacion.DataSource = mapperBitacora.GetAll().Select(o => o.Operacion).Distinct().ToList();
            cmbOperacion.DisplayMember = "Operacion";
            cmbOperacion.SelectedItem = null;

            cmbCriticidad.SelectedItem = null;
            
            cmbModulo.SelectedItem = null;

            dtpFechaDesde.Checked = false;
            dtpFechaHasta.Checked = false;

        }

        private void FrmBitacora_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtro = new Filtro { IdUsuario = cmbUsuario.SelectedValue == null ? -10 : (int)cmbUsuario.SelectedValue,
                                  Modulo = cmbModulo.SelectedIndex == -1 ? null : cmbModulo.SelectedItem.ToString(),
                                  Operacion = cmbOperacion.SelectedIndex == -1 ? null : cmbOperacion.SelectedItem.ToString(),
                                  Criticidad = cmbCriticidad.SelectedIndex == -1 ? -10 : cmbCriticidad.SelectedIndex + 1 ,
                                  FechaHoraDesde = dtpFechaDesde.Checked == true ? dtpFechaDesde.Value : DateTime.MinValue,
                                  FechaHoraHasta = dtpFechaHasta.Checked == true ? dtpFechaHasta.Value : DateTime.MaxValue};
            
            dgvBitacora.DataSource = mapperBitacora.Get(filtro);
            dgvBitacora.Columns["Id"].Visible = false;
        }

        private void DataGridViewConfig()
        {
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.AllowUserToResizeRows = false;
            dgvBitacora.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBitacora.ReadOnly = true;
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.RowHeadersVisible = false;
            dgvBitacora.MultiSelect = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LoadCombos();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
            DgvDataBinding();
        }

        private void DgvDataBinding()
        {
            dgvBitacora.DataSource = mapperBitacora.GetAll();
            dgvBitacora.Columns["Id"].Visible = false;
            dgvBitacora.Columns["IdUsuario"].Visible = false;
        }
    }
}
