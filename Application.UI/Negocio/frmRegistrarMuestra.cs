using Application.BE;
using Application.Services;
using System;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmRegistrarMuestra : Form
    {
        BLL.Client client_BLL;
        BLL.Estudio estudio_BLL;
        BLL.Sucursal sucursal_BLL;
        BLL.Muestra muestra_BLL;

        BE.Muestra muestra;
        BE.Turno turno;
        BE.Client paciente;
        BE.Estudio estudio;

        public frmRegistrarMuestra()
        {
            InitializeComponent();
        }

        public frmRegistrarMuestra(Turno tur)
        {

            InitializeComponent();
            client_BLL = new BLL.Client();
            estudio_BLL = new BLL.Estudio();
            sucursal_BLL = new BLL.Sucursal();
            muestra_BLL = new BLL.Muestra();

            paciente = client_BLL.GetClientById(tur.client);

            txtPacienteNombre.Text = paciente.Name;
            txtPacienteApellido.Text = paciente.Lastname;
            txtPacienteDNI.Text = paciente.DNI;
            txtPacienteDireccion.Text = paciente.Address;
            txtPacienteEmail.Text = paciente.Email;

            estudio = estudio_BLL.GetEstudioById(tur.estudio);
            txtEstudioNombre.Text = estudio.Nombre;
            txtEspecialidadNombre.Text = estudio.Especialidad.Descripcion;

            turno = tur;
            txtFechaHoraTurno.Text = tur.fechaTurno.ToString();
            txtFechaHoraCreacion.Text = tur.fechaCreacion.ToString();
            txtSucursalNombre.Text = sucursal_BLL.GetSucursalById(tur.sucursal).Name;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarMuestra_Click(object sender, EventArgs e)
        {
            try
            {
                //frmRegistrarMuestraQRPreview frmRegistrarMuestraQRPreview = new frmRegistrarMuestraQRPreview(turno);
                //frmRegistrarMuestraQRPreview.Show();

                muestra = new Muestra
                {
                    IdTurno = turno.Id,
                    Usuario = SessionManager.GetInstance.Usuario.LoginName,
                    Fechahora = DateTime.Now,
                    Operacion = cmbOperacion.SelectedItem.ToString(),
                };

                var ok = muestra_BLL.Create(muestra);

                if (!ok)
                    MessageBox.Show("Error al registrar el movimiento de la muestra.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
