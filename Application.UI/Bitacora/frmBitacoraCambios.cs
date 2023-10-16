using Application.ABSTRACTIONS;
using Application.BE;
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
    public partial class frmBitacoraCambios : Form, ILanguageObserver    
    {
        BE.Turno turno;  
        BE.TurnoHistorico turnoHistorico;

        BLL.Turno mapperTurno;
        BLL.User mapperUsuario;
        BLL.Estudio mapperEstudio;

        BE.FiltroHistorico filtroHistorico;

        public frmBitacoraCambios()
        {
            InitializeComponent();
            mapperTurno = new BLL.Turno();
            mapperUsuario = new BLL.User();
            mapperEstudio = new BLL.Estudio();

            LoadDataGrid();
            DataGridViewConfig();
            LoadCombos();
        }

        private void LoadDataGrid()
        {
            dgvCambios.DataSource = mapperTurno.GetTurnosHistorico();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmBitacoraCambios_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void LoadCombos()
        {
            cmbUsuario.DataSource = mapperUsuario.UserList();
            cmbUsuario.DisplayMember = "loginname";
            cmbUsuario.SelectedItem = null;

            cmbEstudio.DataSource = mapperEstudio.EstudioList();
            cmbEstudio.DisplayMember = "estudio";
            cmbEstudio.SelectedItem = null;

            cmbOperacion.DataSource = mapperTurno.GetTurnosHistorico().Select(o => o.Operacion).Distinct().ToList();
            cmbOperacion.DisplayMember = "operacion";
            cmbOperacion.SelectedItem = null;

            dtpFechaDesde.Checked = false;
            dtpFechaHasta.Checked = false;
        }

        private void DataGridViewConfig()
        {
            dgvCambios.AllowUserToAddRows = false;
            dgvCambios.AllowUserToDeleteRows = false;
            dgvCambios.AllowUserToResizeRows = false;
            dgvCambios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCambios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCambios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCambios.ReadOnly = true;
            dgvCambios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCambios.RowHeadersVisible = false;
            dgvCambios.MultiSelect = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtroHistorico = new FiltroHistorico
            {
                usuario = cmbUsuario.SelectedIndex == -1 ? null : cmbUsuario.SelectedItem.ToString(),
                operacion = cmbOperacion.SelectedIndex == -1 ? null : cmbOperacion.SelectedItem.ToString(),
                estudio = cmbEstudio.SelectedIndex == -1 ? -10 : cmbEstudio.SelectedIndex + 1,
                fechaDesde = dtpFechaDesde.Checked == true ? dtpFechaDesde.Value : DateTime.MinValue,
                fechaHasta = dtpFechaHasta.Checked == true ? dtpFechaHasta.Value : DateTime.MaxValue
            };

            dgvCambios.DataSource = mapperTurno.GetTurnosHistorico(filtroHistorico);
            dgvCambios.Columns["Id"].Visible = false;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (turnoHistorico.activo == false)
            {
                DialogResult dialogResult = MessageBox.Show("Está a punto de reestablecer el turno seleccionado, ¿Está seguro?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    turno = new Turno
                    {
                        Id = turnoHistorico.idTurno,
                        agenda = turnoHistorico.agenda,
                        client = turnoHistorico.client,
                        estado = turnoHistorico.estado,
                        fechaCreacion = turnoHistorico.fechaCreacion,
                        fechaEntrega = turnoHistorico.fechaEntrega,
                        fechaTurno = turnoHistorico.fechaTurno
                    };

                    if (mapperTurno.TurnoList().Exists(t => t.Id == turno.Id))
                        mapperTurno.TurnoUpdate(turno, SessionManager.GetInstance.Usuario);
                    else
                        mapperTurno.TurnoCreate(turno, SessionManager.GetInstance.Usuario);

                    MessageBox.Show("El turno histórico seleccionado ha sido reestablecido correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                }
            }
            else
                MessageBox.Show("El turno histórico seleccionado se encuentra activo", "INFO", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void dgvCambios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            turnoHistorico = ((BE.TurnoHistorico)dgvCambios.Rows[e.RowIndex].DataBoundItem);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LoadCombos();
        }
    }
}
