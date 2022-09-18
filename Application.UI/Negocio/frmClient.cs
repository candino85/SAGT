using Application.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Negocio
{
    public partial class frmClient : Form
    {
        BE.Client cliente_BE;
        BLL.Client cliente_BLL;

        private frmClientList _frmClientsList;
        public frmClient(frmClientList frmClientList)
        {
            InitializeComponent();
            _frmClientsList = frmClientList;

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

            _frmClientsList.Bind();
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
    }
}
