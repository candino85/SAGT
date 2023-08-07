using Application.ABSTRACTIONS;
using Application.BE;
using Application.Services;
using Application.UI.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmClient : Form, ILanguageObserver
    {
        BE.Client cliente_BE;
        BLL.Client cliente_BLL;

        private frmClientList _frmClientsList;
        private frmRegistrarTurno _frmRegistrarTurno;

        public frmClient()
        {
            InitializeComponent();

            cliente_BLL = new BLL.Client();

            btnModify.Enabled = false;
            btnRemove.Enabled = false;
        }

        //public frmClient(frmClientList frmClientList)
        //{
        //    InitializeComponent();
        //    _frmClientsList = frmClientList;

        //    cliente_BLL = new BLL.Client();

        //    btnModify.Enabled = false;
        //    btnRemove.Enabled = false;
        //}

        public frmClient(frmRegistrarTurno frmRegistrarTurno)
        {
            InitializeComponent();
            _frmRegistrarTurno = frmRegistrarTurno;

            cliente_BLL = new BLL.Client();

            btnModify.Enabled = false;
            btnRemove.Enabled = false;
        }

        public frmClient(BE.Client cliente, frmClientList frmClientList)
        {
            InitializeComponent();
            cliente_BE = cliente;

            _frmClientsList = frmClientList;

            cliente_BLL = new BLL.Client();

            btnCreate.Enabled = false;

            txtName.TextBoxText = cliente_BE.Name;
            txtLastname.TextBoxText = cliente_BE.Lastname;
            txtID.TextBoxText = cliente_BE.DNI;
            txtAddress.TextBoxText = cliente_BE.Address;
            chkActive.Checked = cliente_BE.Active;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            cliente_BE = new BE.Client();

            cliente_BE.Name = txtName.TextBoxText;
            cliente_BE.Lastname = txtLastname.TextBoxText;
            cliente_BE.DNI = txtID.TextBoxText;
            cliente_BE.Address = txtAddress.TextBoxText;
            cliente_BE.CreationDate = DateTime.Now;
            cliente_BE.Active = chkActive.Checked;

            bool operation = cliente_BLL.ClientCreate(cliente_BE);

            if (!operation)
                throw new Exception("Error al crear el cliente");
            
            if(_frmRegistrarTurno != null)
                _frmRegistrarTurno.LoadCmbClientes();

            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cliente_BE.Name = txtName.TextBoxText;
            cliente_BE.Lastname = txtLastname.TextBoxText;
            cliente_BE.DNI = txtID.TextBoxText;
            cliente_BE.Address = txtAddress.TextBoxText;
            cliente_BE.Active = chkActive.Checked;

            bool operation = cliente_BLL.ClientUpdate(cliente_BE);

            if (!operation)
                throw new Exception("Error al actualizar la entidad");


            _frmClientsList.Bind();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool operation = false;

            DialogResult dialogResult = MessageBox.Show("Eliminar el cliente implica eliminar el historico de turnos para el mismo de manera permanente. \nSi desea conservar el cliente y su historia puede deshabilitarlo.\nPresione Si: para inabilitar el cliente\nNo: para eliminarlo\nCancelar: para cancelar la operación","IMPORTANTE", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {

                cliente_BE.Name = txtName.TextBoxText;
                cliente_BE.Lastname = txtLastname.TextBoxText;
                cliente_BE.DNI = txtID.TextBoxText;
                cliente_BE.Address = txtAddress.TextBoxText;
                cliente_BE.Active = false;

                operation = cliente_BLL.ClientUpdate(cliente_BE);

                if (!operation)
                    throw new Exception("Error al actualizar el cliente");
            }
            if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResultConfirm = MessageBox.Show("Se procederá a eliminar el usuario, confirma la operación?", "IMPORTANTE", MessageBoxButtons.YesNoCancel);
                if (dialogResultConfirm == DialogResult.Yes) 
                {
                    operation = cliente_BLL.ClientRemove(cliente_BE.Id);

                    if (!operation)
                        throw new Exception("Error al eliminar el cliente");
                }
                return;
            }
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            _frmClientsList.Bind();
            this.Close();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
