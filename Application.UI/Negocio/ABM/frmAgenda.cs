﻿using System;
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
    public partial class frmAgenda : Form
    {

        BE.Estudio estudio_BE;
        BLL.Estudio estudio_BLL;
        
        BE.Agenda agenda_BE;
        BLL.Agenda agenda_BLL;

        List<BE.Agenda> agendas;

        public frmAgenda()
        {
            InitializeComponent();

            estudio_BE = new BE.Estudio();
            estudio_BLL = new BLL.Estudio();

            agenda_BLL = new BLL.Agenda();

            cmbEstudio.DataSource = estudio_BLL.EstudioList();
            cmbEstudio.ValueMember = "id";
            cmbEstudio.DisplayMember = "nombre";
            cmbEstudio.SelectedIndex = -1;

            dtpFechaDesde.Value = DateTime.Parse(DateTime.Today.ToString("d"));
            dtpFechaHasta.Value = DateTime.Parse(DateTime.Today.ToString("d"));

        }

        private void btnCrearAgenda_Click(object sender, EventArgs e)
        {
            agendas = new List<BE.Agenda>();

            if (cmbEstudio.SelectedValue != null)
            {
                for (DateTime d = dtpFechaDesde.Value; d < dtpFechaHasta.Value.AddDays(1); d = d.AddDays(1))
                {
                    if ((d.DayOfWeek == DayOfWeek.Monday) && (chkLunes.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpLunesDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpLunesHasta.Value.TimeOfDay)
                        };
                    }
                    else if ((d.DayOfWeek == DayOfWeek.Tuesday) && (chkMartes.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpMartesDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpMartesHasta.Value.TimeOfDay)
                        };
                    }
                    else if ((d.DayOfWeek == DayOfWeek.Wednesday) && (chkMiercoles.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpMiercolesDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpMiercolesHasta.Value.TimeOfDay)
                        };
                    }
                    else if ((d.DayOfWeek == DayOfWeek.Thursday) && (chkJueves.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpJuevesDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpJuevesHasta.Value.TimeOfDay)
                        };
                    }
                    else if ((d.DayOfWeek == DayOfWeek.Friday) && (chkViernes.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpViernesDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpViernesHasta.Value.TimeOfDay)
                        };
                    }
                    else if ((d.DayOfWeek == DayOfWeek.Saturday) && (chkSabado.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpSabadoDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpSabadoHasta.Value.TimeOfDay)
                        };
                    }
                    else if ((d.DayOfWeek == DayOfWeek.Sunday) && (chkDomingo.Checked))
                    {
                        agenda_BE = new BE.Agenda
                        {
                            estudio = (int)cmbEstudio.SelectedValue,
                            fechaDesde = d.Add(htpDomingoDesde.Value.TimeOfDay),
                            fechaHasta = d.Add(htpDomingoHasta.Value.TimeOfDay)
                        };
                    }

                    if (agenda_BE != null)
                    {
                        agendas.Add(agenda_BE);
                        agenda_BE = null;
                    }
                        
                }
                GuardarAgenda(agendas);
            }
            else
            {
                MessageBox.Show("Seleccione un Estudio!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarAgenda(List<BE.Agenda> agendasSchedules)
        {
            try
            {
                agenda_BLL.AgendasCreate(agendasSchedules);

                MessageBox.Show("La agenda se creó correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error al guardar la agenda\n{ex.Message}","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
