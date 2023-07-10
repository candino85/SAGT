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

namespace Application.UI.Negocio
{
    public partial class frmArea : Form, ILanguageObserver
    {
        private BE.Area _area_be;
        private BE.Area _area_be_old;
        private BLL.Area _area_bll;
        private frmAreaList _formAreaList;

        private BLL.Sucursal _entity;

        public frmArea(frmAreaList formAreaList)
        {
            InitializeComponent();
            _formAreaList = formAreaList;

            _area_be = new BE.Area();
            _area_bll = new BLL.Area();

            btnUpdate.Enabled = false;
            btnRemove.Enabled = false; 
            btnSchedule.Enabled = false;

            LoadComboBox();
            cmbEntity.SelectedIndex = -1;
        }

        public frmArea(BE.Area area, frmAreaList formAreaList)
        {
            InitializeComponent();
            _formAreaList = formAreaList;

            _area_be_old = area;
            _area_bll = new BLL.Area();

            btnCreate.Enabled = false;

            LoadComboBox();

            txtName.Text = _area_be_old.Name;
            txtAreaDesc.Text = _area_be_old.Description;
            cmbEntity.SelectedValue = _area_be_old.Entity.Id;
            chkActivo.Checked = _area_be_old.Active;
        }
        public frmArea()
        {
            InitializeComponent();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void LoadComboBox()
        {
            _entity = new BLL.Sucursal();

            cmbEntity.DataSource = _entity.SucursalList();
            cmbEntity.DisplayMember = "Name";
            cmbEntity.ValueMember = "Id";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && cmbEntity.SelectedIndex != -1)
            {
                try
                {
                    _area_be = GetValuesFromForm();

                    _area_be = _area_bll.GetAreaByName(_area_be);

                    if (_area_be.Id == 0)
                    {
                        bool operation;
                        operation = _area_bll.AreaCreate(_area_be);

                        if (!operation)
                            throw new Exception("Error al crear el espacio");
                    }
                    else
                        MessageBox.Show($"El espacio {_area_be.Name} ya existe para la entidad {_area_be.Entity.Name}");

                    _formAreaList.Bind();
                    this.Close();
                }
                catch (DataException dae) { throw dae; }
                catch (BusinessLogicException ble) { throw ble; }
                catch (Exception ex) { throw new Exception(ex.Message, ex); }
            }
            else
                MessageBox.Show($"Complete los campos", "Atención");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && cmbEntity.SelectedIndex != -1)
            {
                try
                {
                    _area_be = GetValuesFromForm();

                    BE.Area area = _area_bll.GetAreaByName(_area_be);
                    //RESOLVER NOMBRE ESPACIO Y ENTIDAD YA CREADOS
                    if (area.Id == 0)
                    {
                        _area_be.Id = _area_be_old.Id;
                        bool operation;
                        operation = _area_bll.AreaUpdate(_area_be);

                        if (!operation)
                            throw new Exception("Error al actualizar el espacio");
                    }
                    else
                        MessageBox.Show($"El espacio {area.Name} ya existe para la entidad {area.Entity.Name}");

                    _formAreaList.Bind();

                    this.Close();
                }
                catch (DataException dae) { throw dae; }
                catch (BusinessLogicException ble) { throw ble; }
                catch (Exception ex) { throw new Exception(ex.Message, ex); }
            }
            else
                MessageBox.Show($"Complete los campos", "Atención");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && cmbEntity.SelectedIndex != -1)
            {
                try
                {
                    _area_be = new BE.Area();

                    _area_be.Name = txtName.Text;
                    _area_be.Entity = (BE.Sucursal)cmbEntity.SelectedItem;

                    _area_be = _area_bll.GetAreaByName(_area_be);

                    if (_area_be.Id > 0)
                    {
                        bool operation;
                        operation = _area_bll.AreaRemove(_area_be.Id);
                        if (!operation)
                            throw new Exception("Error al eliminar el espacio");
                    }
                    _formAreaList.Bind();

                    this.Close();
                }
                catch (DataException dae) { throw dae; }
                catch (BusinessLogicException ble) { throw ble; }
                catch (Exception ex) { throw new Exception(ex.Message, ex); }
            }
            else
                MessageBox.Show($"Complete los campos", "Atención");

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {

        }

        private void frmArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private BE.Area GetValuesFromForm()
        {
            _area_be = new BE.Area();
            _area_be.Name = txtName.Text;
            _area_be.Description = txtAreaDesc.Text;
            _area_be.Entity = _entity.GetSucursalById((int)cmbEntity.SelectedValue);
            _area_be.Active = chkActivo.Checked;
            return _area_be;
        }
    }
}
