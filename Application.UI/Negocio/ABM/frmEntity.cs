using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
using System;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmEntity : Form, ILanguageObserver
    {
        BE.Sucursal entidad_BE;
        BLL.Sucursal entidad_BLL;

        private frmEntityList _frmEntitiesList;

        public frmEntity()
        {
            InitializeComponent();
        }
        public frmEntity(frmEntityList frmEntityList)
        {
            InitializeComponent();
            _frmEntitiesList = frmEntityList;

            entidad_BLL = new BLL.Sucursal();

            btnUpdateEntity.Enabled = false;
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            entidad_BE = new BE.Sucursal();

            entidad_BE.Name = txtNombre.Text;
            entidad_BE.Address = txtDireccion.Text;
            entidad_BE.Phone = txtTelefono.Text;
            entidad_BE.Cuit = txtCuit.Text;
            entidad_BE.Active = chkActive.Checked;

            bool operation = entidad_BLL.SucursalCreate(entidad_BE);

            if (!operation)
                throw new Exception("Error al crear la entidad");


            _frmEntitiesList.Bind();
            this.Close();
        }

        public frmEntity(BE.Sucursal entidad, frmEntityList frmEntityList)
        {
            InitializeComponent();
            entidad_BE = entidad;

            _frmEntitiesList = frmEntityList;

            entidad_BLL = new BLL.Sucursal();

            btnCreateEntity.Enabled = false;

            txtNombre.Text = entidad_BE.Name;
            txtDireccion.Text = entidad_BE.Address;
            txtTelefono.Text = entidad_BE.Phone;
            txtCuit.Text = entidad_BE.Cuit;
            chkActive.Checked = entidad_BE.Active;
        }

        private void btnUpdateEntity_Click(object sender, EventArgs e)
        {
            entidad_BE.Name = txtNombre.Text;
            entidad_BE.Address = txtDireccion.Text;
            entidad_BE.Phone = txtTelefono.Text;
            entidad_BE.Cuit = txtCuit.Text;
            entidad_BE.Active = chkActive.Checked;

            bool operation = entidad_BLL.SucursalUpdate(entidad_BE);

            if (!operation)
                throw new Exception("Error al actualizar la entidad");


            _frmEntitiesList.Bind();
            this.Close();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmEntity_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmEntity_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
