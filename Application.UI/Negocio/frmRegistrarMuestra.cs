using Application.BE;
using Application.Services;
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Application.ABSTRACTIONS;
using Application.UI.Language;

namespace Application.UI.Negocio
{
    public partial class frmRegistrarMuestra : Form, ILanguageObserver
    {
        BLL.Client client_BLL;
        BLL.Estudio estudio_BLL;
        BLL.Sucursal sucursal_BLL;
        BLL.Muestra muestra_BLL;

        BE.Muestra muestra;
        BE.Turno turno;
        BE.Turno turno2;
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
                if (cmbOperacion.SelectedItem.ToString() == "Recepción de muestra") 
                { 
                    frmRegistrarMuestraQRPreview frmRegistrarMuestraQRPreview = new frmRegistrarMuestraQRPreview(turno);
                    frmRegistrarMuestraQRPreview.Show();
                }

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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != string.Empty)
            {
                string json = JsonConvert.SerializeObject(turno);
                File.WriteAllText(dialog.SelectedPath + "\\Turno.json", json);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }

                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    turno2 = JsonConvert.DeserializeObject<BE.Turno>(json);

                    MessageBox.Show($"El turno importado es: \n {turno2.ToString()}");
                }
            }

        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmRegistrarMuestra_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmRegistrarMuestra_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
