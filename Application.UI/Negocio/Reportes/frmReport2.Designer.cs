namespace Application.UI.Negocio.Reportes
{
    partial class frmReport2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport2));
            this.muestrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRepo1 = new Application.UI.Negocio.Reportes.DataSetRepo1();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.cmbFechaEstudio = new System.Windows.Forms.ComboBox();
            this.muestrasTableAdapter = new Application.UI.Negocio.Reportes.DataSetRepo1TableAdapters.MuestrasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muestrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRepo1)).BeginInit();
            this.SuspendLayout();
            // 
            // muestrasBindingSource
            // 
            this.muestrasBindingSource.DataMember = "Muestras";
            this.muestrasBindingSource.DataSource = this.dataSetRepo1;
            // 
            // dataSetRepo1
            // 
            this.dataSetRepo1.DataSetName = "DataSetRepo1";
            this.dataSetRepo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Tag = "paciente";
            this.label3.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Tag = "estudio";
            this.label1.Text = "Estudio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 12;
            this.label2.Tag = "fechaEstudio";
            this.label2.Text = "Fecha Estudio";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(859, 23);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(163, 41);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Tag = "generar reporte";
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.muestrasBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Application.UI.Negocio.Reportes.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 70);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1010, 866);
            this.reportViewer2.TabIndex = 15;
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(12, 30);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(214, 28);
            this.cmbSucursales.TabIndex = 17;
            this.cmbSucursales.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursales_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 16;
            this.label4.Tag = "sucursal";
            this.label4.Text = "Sucursal";
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacientes.Enabled = false;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(232, 30);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(209, 28);
            this.cmbPacientes.TabIndex = 9;
            this.cmbPacientes.SelectionChangeCommitted += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudios.Enabled = false;
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Location = new System.Drawing.Point(447, 30);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(230, 28);
            this.cmbEstudios.TabIndex = 11;
            this.cmbEstudios.SelectionChangeCommitted += new System.EventHandler(this.cmbEstudios_SelectedIndexChanged);
            // 
            // cmbFechaEstudio
            // 
            this.cmbFechaEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFechaEstudio.Enabled = false;
            this.cmbFechaEstudio.FormattingEnabled = true;
            this.cmbFechaEstudio.Location = new System.Drawing.Point(683, 30);
            this.cmbFechaEstudio.Name = "cmbFechaEstudio";
            this.cmbFechaEstudio.Size = new System.Drawing.Size(170, 28);
            this.cmbFechaEstudio.TabIndex = 13;
            // 
            // muestrasTableAdapter
            // 
            this.muestrasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 948);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbFechaEstudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstudios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPacientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport2";
            this.Tag = "frmReport2";
            this.Text = "Reporte de Cadena de Custodia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReport2_FormClosed);
            this.Load += new System.EventHandler(this.frmReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muestrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRepo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label label4;
        private DataSetRepo1TableAdapters.MuestrasTableAdapter muestrasTableAdapter;
        private DataSetRepo1 dataSetRepo1;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.ComboBox cmbEstudios;
        private System.Windows.Forms.ComboBox cmbFechaEstudio;
        private System.Windows.Forms.BindingSource muestrasBindingSource;
    }
}