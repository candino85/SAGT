﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmEntity : Form
    {
        BE.Entity entidad_BE;
        BLL.Entity entidad_BLL;

        private frmEntityList _frmEntitiesList;
        public frmEntity(frmEntityList frmEntityList)
        {
            InitializeComponent();
            _frmEntitiesList = frmEntityList;

            entidad_BLL = new BLL.Entity();

            btnUpdateEntity.Enabled = false;
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            entidad_BE = new BE.Entity();

            entidad_BE.Name = txtNombre.Text;
            entidad_BE.Address = txtDireccion.Text;
            entidad_BE.Phone = txtTelefono.Text;
            entidad_BE.Cuit = txtCuit.Text;
            entidad_BE.Active = chkActive.Checked;

            bool operation = entidad_BLL.EntityCreate(entidad_BE);

            if (!operation)
                throw new Exception("Error al crear la entidad");


            _frmEntitiesList.Bind();
            this.Close();
        }

        public frmEntity(BE.Entity entidad,frmEntityList frmEntityList)
        {
            InitializeComponent();
            entidad_BE = entidad;

            _frmEntitiesList = frmEntityList;

            entidad_BLL = new BLL.Entity();

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

            bool operation = entidad_BLL.EntityUpdate(entidad_BE);

            if (!operation)
                throw new Exception("Error al actualizar la entidad");


            _frmEntitiesList.Bind();
            this.Close();
        }
    }
}
