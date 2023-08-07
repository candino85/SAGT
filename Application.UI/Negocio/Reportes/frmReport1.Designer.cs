namespace Application.UI.Negocio.Reportes
{
    partial class frmReport1
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
            this.turnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRepo1 = new Application.UI.Negocio.Reportes.DataSetRepo1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.turnosTableAdapter = new Application.UI.Negocio.Reportes.DataSetRepo1TableAdapters.TurnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRepo1)).BeginInit();
            this.SuspendLayout();
            // 
            // turnosBindingSource
            // 
            this.turnosBindingSource.DataMember = "Turnos";
            this.turnosBindingSource.DataSource = this.dataSetRepo1;
            // 
            // dataSetRepo1
            // 
            this.dataSetRepo1.DataSetName = "DataSetRepo1";
            this.dataSetRepo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.turnosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Application.UI.Negocio.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(929, 849);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(227, 37);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(237, 26);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2023, 7, 11, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpHasta.Location = new System.Drawing.Point(474, 37);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(237, 26);
            this.dtpHasta.TabIndex = 2;
            this.dtpHasta.Value = new System.DateTime(2023, 7, 11, 0, 0, 0, 0);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(717, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(224, 49);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Tag = "generar reporte";
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(223, 14);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Tag = "desde";
            this.lblDesde.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Tag = "hasta";
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Tag = "estudio";
            this.label3.Text = "Estudio";
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Location = new System.Drawing.Point(12, 35);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(209, 28);
            this.cmbEstudios.TabIndex = 7;
            // 
            // turnosTableAdapter
            // 
            this.turnosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 947);
            this.Controls.Add(this.cmbEstudios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport1";
            this.Tag = "frmReport1";
            this.Text = "Reporte de Turnos Asignados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReport1_FormClosed);
            this.Load += new System.EventHandler(this.frmReport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRepo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private DataSetRepo1 dataSetRepo1;
        private System.Windows.Forms.BindingSource turnosBindingSource;
        private DataSetRepo1TableAdapters.TurnosTableAdapter turnosTableAdapter;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstudios;
    }
}