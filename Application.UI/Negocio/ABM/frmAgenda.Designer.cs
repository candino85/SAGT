namespace Application.UI.Negocio.ABM
{
    partial class frmAgenda
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
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.htpLunesDesde = new System.Windows.Forms.DateTimePicker();
            this.htpLunesHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.htpMartesHasta = new System.Windows.Forms.DateTimePicker();
            this.htpMartesDesde = new System.Windows.Forms.DateTimePicker();
            this.htpMiercolesHasta = new System.Windows.Forms.DateTimePicker();
            this.htpMiercolesDesde = new System.Windows.Forms.DateTimePicker();
            this.htpJuevesHasta = new System.Windows.Forms.DateTimePicker();
            this.htpViernesHasta = new System.Windows.Forms.DateTimePicker();
            this.htpViernesDesde = new System.Windows.Forms.DateTimePicker();
            this.htpSabadoHasta = new System.Windows.Forms.DateTimePicker();
            this.htpSabadoDesde = new System.Windows.Forms.DateTimePicker();
            this.htpDomingoHasta = new System.Windows.Forms.DateTimePicker();
            this.htpDomingoDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCrearAgenda = new System.Windows.Forms.Button();
            this.htpJuevesDesde = new System.Windows.Forms.DateTimePicker();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.FormattingEnabled = true;
            this.cmbEstudio.Location = new System.Drawing.Point(27, 35);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(418, 28);
            this.cmbEstudio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Tag = "estudio";
            this.label1.Text = "Estudio";
            // 
            // htpLunesDesde
            // 
            this.htpLunesDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpLunesDesde.Location = new System.Drawing.Point(168, 232);
            this.htpLunesDesde.Name = "htpLunesDesde";
            this.htpLunesDesde.ShowUpDown = true;
            this.htpLunesDesde.Size = new System.Drawing.Size(134, 26);
            this.htpLunesDesde.TabIndex = 9;
            this.htpLunesDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // htpLunesHasta
            // 
            this.htpLunesHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpLunesHasta.Location = new System.Drawing.Point(311, 232);
            this.htpLunesHasta.Name = "htpLunesHasta";
            this.htpLunesHasta.ShowUpDown = true;
            this.htpLunesHasta.Size = new System.Drawing.Size(134, 26);
            this.htpLunesHasta.TabIndex = 18;
            this.htpLunesHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(29, 164);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(198, 26);
            this.dtpFechaDesde.TabIndex = 19;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(233, 164);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(198, 26);
            this.dtpFechaHasta.TabIndex = 20;
            // 
            // htpMartesHasta
            // 
            this.htpMartesHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpMartesHasta.Location = new System.Drawing.Point(311, 272);
            this.htpMartesHasta.Name = "htpMartesHasta";
            this.htpMartesHasta.ShowUpDown = true;
            this.htpMartesHasta.Size = new System.Drawing.Size(134, 26);
            this.htpMartesHasta.TabIndex = 22;
            this.htpMartesHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // htpMartesDesde
            // 
            this.htpMartesDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpMartesDesde.Location = new System.Drawing.Point(168, 272);
            this.htpMartesDesde.Name = "htpMartesDesde";
            this.htpMartesDesde.ShowUpDown = true;
            this.htpMartesDesde.Size = new System.Drawing.Size(134, 26);
            this.htpMartesDesde.TabIndex = 21;
            this.htpMartesDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // htpMiercolesHasta
            // 
            this.htpMiercolesHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpMiercolesHasta.Location = new System.Drawing.Point(311, 312);
            this.htpMiercolesHasta.Name = "htpMiercolesHasta";
            this.htpMiercolesHasta.ShowUpDown = true;
            this.htpMiercolesHasta.Size = new System.Drawing.Size(134, 26);
            this.htpMiercolesHasta.TabIndex = 24;
            this.htpMiercolesHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // htpMiercolesDesde
            // 
            this.htpMiercolesDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpMiercolesDesde.Location = new System.Drawing.Point(168, 312);
            this.htpMiercolesDesde.Name = "htpMiercolesDesde";
            this.htpMiercolesDesde.ShowUpDown = true;
            this.htpMiercolesDesde.Size = new System.Drawing.Size(134, 26);
            this.htpMiercolesDesde.TabIndex = 23;
            this.htpMiercolesDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // htpJuevesHasta
            // 
            this.htpJuevesHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpJuevesHasta.Location = new System.Drawing.Point(311, 352);
            this.htpJuevesHasta.Name = "htpJuevesHasta";
            this.htpJuevesHasta.ShowUpDown = true;
            this.htpJuevesHasta.Size = new System.Drawing.Size(134, 26);
            this.htpJuevesHasta.TabIndex = 26;
            this.htpJuevesHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // htpViernesHasta
            // 
            this.htpViernesHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpViernesHasta.Location = new System.Drawing.Point(311, 391);
            this.htpViernesHasta.Name = "htpViernesHasta";
            this.htpViernesHasta.ShowUpDown = true;
            this.htpViernesHasta.Size = new System.Drawing.Size(134, 26);
            this.htpViernesHasta.TabIndex = 28;
            this.htpViernesHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // htpViernesDesde
            // 
            this.htpViernesDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpViernesDesde.Location = new System.Drawing.Point(168, 391);
            this.htpViernesDesde.Name = "htpViernesDesde";
            this.htpViernesDesde.ShowUpDown = true;
            this.htpViernesDesde.Size = new System.Drawing.Size(134, 26);
            this.htpViernesDesde.TabIndex = 27;
            this.htpViernesDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // htpSabadoHasta
            // 
            this.htpSabadoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpSabadoHasta.Location = new System.Drawing.Point(311, 430);
            this.htpSabadoHasta.Name = "htpSabadoHasta";
            this.htpSabadoHasta.ShowUpDown = true;
            this.htpSabadoHasta.Size = new System.Drawing.Size(134, 26);
            this.htpSabadoHasta.TabIndex = 30;
            this.htpSabadoHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // htpSabadoDesde
            // 
            this.htpSabadoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpSabadoDesde.Location = new System.Drawing.Point(168, 430);
            this.htpSabadoDesde.Name = "htpSabadoDesde";
            this.htpSabadoDesde.ShowUpDown = true;
            this.htpSabadoDesde.Size = new System.Drawing.Size(134, 26);
            this.htpSabadoDesde.TabIndex = 29;
            this.htpSabadoDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // htpDomingoHasta
            // 
            this.htpDomingoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpDomingoHasta.Location = new System.Drawing.Point(311, 470);
            this.htpDomingoHasta.Name = "htpDomingoHasta";
            this.htpDomingoHasta.ShowUpDown = true;
            this.htpDomingoHasta.Size = new System.Drawing.Size(134, 26);
            this.htpDomingoHasta.TabIndex = 32;
            this.htpDomingoHasta.Value = new System.DateTime(2023, 7, 6, 18, 0, 0, 0);
            // 
            // htpDomingoDesde
            // 
            this.htpDomingoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpDomingoDesde.Location = new System.Drawing.Point(168, 470);
            this.htpDomingoDesde.Name = "htpDomingoDesde";
            this.htpDomingoDesde.ShowUpDown = true;
            this.htpDomingoDesde.Size = new System.Drawing.Size(134, 26);
            this.htpDomingoDesde.TabIndex = 31;
            this.htpDomingoDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 33;
            this.label2.Tag = "fecha desde";
            this.label2.Text = "Fecha desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 34;
            this.label3.Tag = "fecha hasta";
            this.label3.Text = "Fecha Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 35;
            this.label4.Tag = "hora desde";
            this.label4.Text = "Hora Desde";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 42;
            this.label11.Tag = "hora hasta";
            this.label11.Text = "Hora Hasta";
            // 
            // btnCrearAgenda
            // 
            this.btnCrearAgenda.Location = new System.Drawing.Point(168, 520);
            this.btnCrearAgenda.Name = "btnCrearAgenda";
            this.btnCrearAgenda.Size = new System.Drawing.Size(277, 38);
            this.btnCrearAgenda.TabIndex = 43;
            this.btnCrearAgenda.Tag = "crear agenda";
            this.btnCrearAgenda.Text = "Crear Agenda";
            this.btnCrearAgenda.UseVisualStyleBackColor = true;
            this.btnCrearAgenda.Click += new System.EventHandler(this.btnCrearAgenda_Click);
            // 
            // htpJuevesDesde
            // 
            this.htpJuevesDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.htpJuevesDesde.Location = new System.Drawing.Point(168, 352);
            this.htpJuevesDesde.Name = "htpJuevesDesde";
            this.htpJuevesDesde.ShowUpDown = true;
            this.htpJuevesDesde.Size = new System.Drawing.Size(134, 26);
            this.htpJuevesDesde.TabIndex = 25;
            this.htpJuevesDesde.Value = new System.DateTime(2023, 7, 6, 8, 0, 0, 0);
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(8, 21);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(79, 24);
            this.chkLunes.TabIndex = 11;
            this.chkLunes.Tag = "lunes";
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(8, 61);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(84, 24);
            this.chkMartes.TabIndex = 12;
            this.chkMartes.Tag = "martes";
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(8, 99);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(102, 24);
            this.chkMiercoles.TabIndex = 13;
            this.chkMiercoles.Tag = "miercoles";
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(8, 139);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(85, 24);
            this.chkJueves.TabIndex = 14;
            this.chkJueves.Tag = "jueves";
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(8, 178);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(89, 24);
            this.chkViernes.TabIndex = 15;
            this.chkViernes.Tag = "viernes";
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(8, 217);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(91, 24);
            this.chkSabado.TabIndex = 16;
            this.chkSabado.Tag = "sabado";
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(8, 257);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(99, 24);
            this.chkDomingo.TabIndex = 17;
            this.chkDomingo.Tag = "domingo";
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDomingo);
            this.panel1.Controls.Add(this.chkSabado);
            this.panel1.Controls.Add(this.chkViernes);
            this.panel1.Controls.Add(this.chkJueves);
            this.panel1.Controls.Add(this.chkMiercoles);
            this.panel1.Controls.Add(this.chkMartes);
            this.panel1.Controls.Add(this.chkLunes);
            this.panel1.Location = new System.Drawing.Point(22, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 289);
            this.panel1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 46;
            this.label5.Tag = "sucursal";
            this.label5.Text = "Sucursal";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(27, 98);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(418, 28);
            this.cmbSucursal.TabIndex = 45;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 589);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearAgenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.htpDomingoHasta);
            this.Controls.Add(this.htpDomingoDesde);
            this.Controls.Add(this.htpSabadoHasta);
            this.Controls.Add(this.htpSabadoDesde);
            this.Controls.Add(this.htpViernesHasta);
            this.Controls.Add(this.htpViernesDesde);
            this.Controls.Add(this.htpJuevesHasta);
            this.Controls.Add(this.htpJuevesDesde);
            this.Controls.Add(this.htpMiercolesHasta);
            this.Controls.Add(this.htpMiercolesDesde);
            this.Controls.Add(this.htpMartesHasta);
            this.Controls.Add(this.htpMartesDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.htpLunesHasta);
            this.Controls.Add(this.htpLunesDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEstudio);
            this.Name = "frmAgenda";
            this.Tag = "frmAgenda";
            this.Text = "Creador de Agendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker htpLunesDesde;
        private System.Windows.Forms.DateTimePicker htpLunesHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker htpMartesHasta;
        private System.Windows.Forms.DateTimePicker htpMartesDesde;
        private System.Windows.Forms.DateTimePicker htpMiercolesHasta;
        private System.Windows.Forms.DateTimePicker htpMiercolesDesde;
        private System.Windows.Forms.DateTimePicker htpJuevesHasta;
        private System.Windows.Forms.DateTimePicker htpViernesHasta;
        private System.Windows.Forms.DateTimePicker htpViernesDesde;
        private System.Windows.Forms.DateTimePicker htpSabadoHasta;
        private System.Windows.Forms.DateTimePicker htpSabadoDesde;
        private System.Windows.Forms.DateTimePicker htpDomingoHasta;
        private System.Windows.Forms.DateTimePicker htpDomingoDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCrearAgenda;
        private System.Windows.Forms.DateTimePicker htpJuevesDesde;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSucursal;
    }
}