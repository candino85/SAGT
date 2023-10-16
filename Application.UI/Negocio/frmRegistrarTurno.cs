﻿using Application.ABSTRACTIONS;
using Application.BE;
using Application.BLL;
using Application.Services;
using Application.UI.Language;
using Application.UI.Negocio.ABM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace Application.UI.Negocio
{
    public partial class frmRegistrarTurno : Form, ILanguageObserver
    {
        BE.Estudio estudio_BE;
        BLL.Estudio estudio_BLL;

        BE.Sucursal sucursal_BE;
        BLL.Sucursal sucursal_BLL;

        BE.Client paciente_BE;
        BLL.Client paciente_BLL;

        List<CalendarItem> itemsAgenda;
        List<CalendarItem> itemsTurnos;

        BE.Turno turno;
        BLL.Turno turno_BLL;
        BLL.Agenda agenda_BLL;


        CalendarItem calendarItemSelected;


        public frmRegistrarTurno()
        {
            InitializeComponent();

            estudio_BLL = new BLL.Estudio();
            sucursal_BLL = new BLL.Sucursal();
            paciente_BLL = new BLL.Client();

            turno_BLL = new BLL.Turno();
            agenda_BLL = new BLL.Agenda();
            
            itemsAgenda = new List<CalendarItem>();
            itemsTurnos = new List<CalendarItem>();
            
            calendar1.ScrollToTime(8);
            
            LoadCombos();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbEstudio.SelectedValue != null && cmbSucursal.SelectedValue != null)
            {
                estudio_BE = estudio_BLL.GetEstudioById((int)cmbEstudio.SelectedValue);
                sucursal_BE = sucursal_BLL.GetSucursalById((int)cmbSucursal.SelectedValue);

                SetTimeScale(estudio_BE.Tiempo);
                RemoveItems();

                if (rbtDisponibles.Checked)
                {
                    GetAgenda((int)cmbEstudio.SelectedValue, (int)cmbSucursal.SelectedValue);
                    GetTurnos((int)cmbEstudio.SelectedValue, (int)cmbSucursal.SelectedValue);

                    PlaceItemsAgenda();
                }
                if (rbtAsignados.Checked)
                {
                    GetTurnos((int)cmbEstudio.SelectedValue, (int)cmbSucursal.SelectedValue);
                    PlaceItemsTurnos();
                }
            }
            else if(cmbEstudio.SelectedValue is null)
                MessageBox.Show("Seleccione un Estudio!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cmbSucursal.SelectedValue is null)
                MessageBox.Show("Seleccione una Sucursal!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetTimeScale(int timeScale)
        {
            switch (timeScale)
            {
                case 5:
                    calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
                    break;
                case 10:
                    calendar1.TimeScale = CalendarTimeScale.TenMinutes;
                    break;
                case 15:
                    calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
                    break;
                case 30:
                    calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
                    break;
                case 60:
                    calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
                    break;
                default:
                    calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
                    break;
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            if (cmbEstudio.SelectedIndex != -1)
            {
                calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
                btnBuscar_Click(sender, e);
                EnableButtons();
            }
            else
                MessageBox.Show("Por favor seleccione un Estudio para continuar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {

        }

        private void frmRegistrarTurno_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void GetAgenda(int estudio, int sucursal)
        {
            List<BE.Agenda> lstAgenda = new List<BE.Agenda>();

            lstAgenda = agenda_BLL.GetByEstudioSucursal(estudio, sucursal);
            itemsAgenda.Clear();

            foreach (BE.Agenda a in lstAgenda)
            {
                for (DateTime i = a.fechaDesde; i < a.fechaHasta; i=i.AddMinutes(estudio_BE.Tiempo))
                {
                    if(!itemsTurnos.Exists(turno => turno.StartDate.Equals(i))) 
                    { 
                        CalendarItem cal = new CalendarItem(calendar1, i, i.AddMinutes(estudio_BE.Tiempo), "Disponible");
                        cal.Tag = a;
                        cal.ApplyColor(Color.LightGreen);
                        itemsAgenda.Add(cal);
                    }
                }
            }
        }

        private void GetTurnos(int estudio, int sucursal)
        {
            List<BE.Turno> lstTurno = new List<BE.Turno>();

            lstTurno = turno_BLL.GetTurnosByEstudioSucursal(estudio, sucursal);

            itemsTurnos.Clear();

            foreach (BE.Turno t in lstTurno)
            {
                CalendarItem tur = new CalendarItem(
                    calendar1, 
                    t.fechaTurno, 
                    t.fechaTurno.AddMinutes(estudio_BE.Tiempo), 
                    $"{paciente_BLL.GetClientById(t.client).FullName} - {t.fechaTurno} - Sucursal: {sucursal_BLL.GetSucursalById(t.sucursal)}");
                tur.Tag = t;
                tur.ApplyColor(Color.LightCoral);
                itemsTurnos.Add(tur);
            }
        }
        private void PlaceItemsAgenda()
        {
            foreach (CalendarItem item in itemsAgenda)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void PlaceItemsTurnos()
        {
            foreach (CalendarItem item in itemsTurnos)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void LoadCombos()
        {
            cmbEstudio.DataSource = estudio_BLL.EstudioList();
            cmbEstudio.ValueMember = "id";
            cmbEstudio.DisplayMember = "nombre";
            cmbEstudio.SelectedIndex = -1;

            cmbSucursal.DataSource = sucursal_BLL.SucursalList();
            cmbSucursal.ValueMember = "id";
            cmbSucursal.DisplayMember = "name";
            cmbSucursal.SelectedIndex = -1;

            LoadCmbClientes();
        }

        public void LoadCmbClientes()
        {
            cmbPaciente.DataSource = paciente_BLL.ClientList();
            cmbPaciente.ValueMember = "id";
            cmbPaciente.DisplayMember = "fullname";
            cmbPaciente.SelectedIndex = -1;
        }

        private void calendar1_ItemSelected(object sender, CalendarItemEventArgs e)
        {
            EnableButtons();

            calendarItemSelected = (CalendarItem)e.Item;
            if (estudio_BE != null)
            {
                txtFecha.Text = calendarItemSelected.DayStart.ToString();
                txtHora.Text = calendarItemSelected.StartDate.ToShortTimeString();
                txtEstudio.Text = estudio_BE.Nombre;

                if(rbtAsignados.Checked)
                {   
                    turno = (BE.Turno)calendarItemSelected.Tag;
                    cmbPaciente.SelectedValue = turno.client;
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un Estudio para continuar", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EnableButtons()
        {
            if (rbtDisponibles.Checked)
            {
                btnRegistrarTurno.Visible = true;
                btnCancelarTurno.Visible = false;
                btnEliminarTurno.Visible = false;
            }
            else if (rbtAsignados.Checked)
            {
                btnCancelarTurno.Visible = true;
                btnCancelarTurno.Enabled = true;
                btnEliminarTurno.Visible = true;
                btnEliminarTurno.Enabled = true;
                btnRegistrarTurno.Visible = false;
            }
        }

        private void RemoveItems()
        {
            foreach (var item in itemsAgenda)
            {
                calendar1.Items.Remove(item);
            }

            foreach (var item in itemsTurnos)
            {
                calendar1.Items.Remove(item);
            }
        }

        private void rbtDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtDisponibles.Checked)
                btnBuscar_Click(sender, e);
        }

        private void rbtAsignados_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtAsignados.Checked)
                btnBuscar_Click(sender, e);
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            frmClient frmClient = new frmClient(this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmClient.Show();
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            if(cmbPaciente.SelectedValue != null) 
            { 
                turno = new BE.Turno
                {
                    client = (int)cmbPaciente.SelectedValue,
                    estado = 'A',
                    estudio = estudio_BE.Id,
                    fechaCreacion = DateTime.Now,
                    fechaTurno = calendarItemSelected.StartDate,
                    agenda = ((BE.Agenda)calendarItemSelected.Tag).Id,
                    fechaEntrega = DateTime.Now,
                    sucursal = sucursal_BE.Id,
                };

                //calendarItemSelected.Tag = turno;

                bool ok = turno_BLL.TurnoCreate(turno, SessionManager.GetInstance.Usuario);
                if (ok)
                {
                    //enviar correo con el turno al paciente
                    MessageBox.Show("El turno se ha registrado correctamente y se envío la información al paciente vía email", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if (rbtDisponibles.Checked)
                    //{
                    //    btnRegistrarTurno.Enabled = false;
                    //    btnCancelarTurno.Visible = false;
                    //}
                    //else if (rbtAsignados.Checked)
                    //{
                    //    btnCancelarTurno.Visible = true;
                    //    btnRegistrarTurno.Visible = false;
                    //}
                    rbtDisponibles_CheckedChanged(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Se produjo un error al crear el nuevo turno", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Paciente para poder registrar el turno", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            if(turno.estado == 'A')
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de que desea cancelar el turno?", "CANCELACIÓN DE TURNO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    turno.estado = 'C';
                    var ok = turno_BLL.TurnoUpdate(turno, SessionManager.GetInstance.Usuario);

                    if (ok)
                        MessageBox.Show("El turno se ha cancelado correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ocurrió un error al intentar cancelar el turno seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    rbtAsignados_CheckedChanged(sender, new EventArgs());
                }
            }
            else
                MessageBox.Show("El turno seleccionado se encuentra vencido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void cmbPacienteFormat(object sender, ListControlConvertEventArgs e)
        {
            string dni = ((BE.Client)e.ListItem).DNI;
            string fullname = ((BE.Client)e.ListItem).FullName;
            e.Value = dni + " - " + fullname;
        }

        private void btnCrearEstudio_Click(object sender, EventArgs e)
        {
            frmEstudio frmEstudio = new frmEstudio(this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmEstudio.Show();
        }

        private void frmRegistrarTurno_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (turno.estado == 'A')
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de que desea eliminar el turno permanentemente?", "ELIMINACIÓN DE TURNO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dialogResult == DialogResult.Yes)
                {
                    var ok = turno_BLL.TurnoEliminar(turno, SessionManager.GetInstance.Usuario);

                    if (ok)
                        MessageBox.Show("El turno se ha eliminado correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ocurrió un error al intentar eliminar el turno seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    rbtAsignados_CheckedChanged(sender, new EventArgs());
                }
            }
            else
                MessageBox.Show("El turno seleccionado se encuentra vencido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
