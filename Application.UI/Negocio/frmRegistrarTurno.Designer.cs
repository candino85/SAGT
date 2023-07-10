namespace Application.UI.Negocio
{
    partial class frmRegistrarTurno
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange26 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange27 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange28 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange29 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange30 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.lblEstudios = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnRegistrarTurno = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.monthView1 = new System.Windows.Forms.Calendar.MonthView();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.monthView3 = new System.Windows.Forms.Calendar.MonthView();
            this.monthView2 = new System.Windows.Forms.Calendar.MonthView();
            this.rbtDisponibles = new System.Windows.Forms.RadioButton();
            this.rbtAsignados = new System.Windows.Forms.RadioButton();
            this.btnCancelarTurno = new System.Windows.Forms.Button();
            this.btnCrearEstudio = new System.Windows.Forms.Button();
            this.calendar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbEstudio.Location = new System.Drawing.Point(12, 46);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(255, 28);
            this.cmbEstudio.TabIndex = 0;
            this.cmbEstudio.SelectionChangeCommitted += new System.EventHandler(this.cmbEstudio_SelectedIndexChanged);
            // 
            // lblEstudios
            // 
            this.lblEstudios.AutoSize = true;
            this.lblEstudios.Location = new System.Drawing.Point(12, 23);
            this.lblEstudios.Name = "lblEstudios";
            this.lblEstudios.Size = new System.Drawing.Size(71, 20);
            this.lblEstudios.TabIndex = 2;
            this.lblEstudios.Tag = "estudios";
            this.lblEstudios.Text = "Estudios";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(423, 24);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 20);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.Tag = "sucursal";
            this.lblSucursal.Text = "Sucursal";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Enabled = false;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(423, 47);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(255, 28);
            this.cmbSucursal.TabIndex = 3;
            this.cmbSucursal.Tag = "sucursal";
            // 
            // lblPaciente
            // 
            this.lblPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(1289, 585);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(71, 20);
            this.lblPaciente.TabIndex = 7;
            this.lblPaciente.Tag = "paciente";
            this.lblPaciente.Text = "Paciente";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(1290, 608);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(468, 28);
            this.cmbPaciente.TabIndex = 6;
            this.cmbPaciente.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbPacienteFormat);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearPaciente.Location = new System.Drawing.Point(1288, 642);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(468, 55);
            this.btnCrearPaciente.TabIndex = 8;
            this.btnCrearPaciente.Tag = "crear paciente";
            this.btnCrearPaciente.Text = "Crear Paciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnRegistrarTurno
            // 
            this.btnRegistrarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarTurno.Location = new System.Drawing.Point(1288, 952);
            this.btnRegistrarTurno.Name = "btnRegistrarTurno";
            this.btnRegistrarTurno.Size = new System.Drawing.Size(468, 55);
            this.btnRegistrarTurno.TabIndex = 307;
            this.btnRegistrarTurno.Tag = "registrar turno";
            this.btnRegistrarTurno.Text = "Registrar Turno";
            this.btnRegistrarTurno.UseVisualStyleBackColor = true;
            this.btnRegistrarTurno.Visible = false;
            this.btnRegistrarTurno.Click += new System.EventHandler(this.btnRegistrarTurno_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1288, 859);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 303;
            this.label6.Tag = "hora";
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1288, 725);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 302;
            this.label5.Tag = "estudio";
            this.label5.Text = "Estudio";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1288, 790);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 301;
            this.label4.Tag = "fecha";
            this.label4.Text = "Fecha";
            // 
            // txtEstudio
            // 
            this.txtEstudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstudio.Enabled = false;
            this.txtEstudio.Location = new System.Drawing.Point(1288, 748);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(470, 26);
            this.txtEstudio.TabIndex = 312;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(1288, 813);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(470, 26);
            this.txtFecha.TabIndex = 313;
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(1288, 882);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(470, 26);
            this.txtHora.TabIndex = 314;
            // 
            // monthView1
            // 
            this.monthView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(1288, 23);
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(465, 529);
            this.monthView1.TabIndex = 310;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
            // 
            // calendar1
            // 
            this.calendar1.AllowItemEdit = false;
            this.calendar1.AllowItemResize = false;
            this.calendar1.AllowNew = false;
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.Controls.Add(this.monthView3);
            this.calendar1.Controls.Add(this.monthView2);
            this.calendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            calendarHighlightRange26.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange26.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange26.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange27.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange27.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange27.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange28.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange28.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange28.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange29.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange29.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange29.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange30.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange30.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange30.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange26,
        calendarHighlightRange27,
        calendarHighlightRange28,
        calendarHighlightRange29,
        calendarHighlightRange30};
            this.calendar1.Location = new System.Drawing.Point(16, 88);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(1253, 919);
            this.calendar1.TabIndex = 311;
            this.calendar1.Text = "calendar1";
            this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
            this.calendar1.ItemSelected += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemSelected);
            // 
            // monthView3
            // 
            this.monthView3.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView3.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView3.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView3.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView3.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView3.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView3.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView3.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView3.Location = new System.Drawing.Point(578, 171);
            this.monthView3.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView3.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView3.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView3.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView3.Name = "monthView3";
            this.monthView3.Size = new System.Drawing.Size(8, 8);
            this.monthView3.TabIndex = 1;
            this.monthView3.Text = "monthView3";
            this.monthView3.TodayBorderColor = System.Drawing.Color.Maroon;
            // 
            // monthView2
            // 
            this.monthView2.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView2.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView2.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView2.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView2.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView2.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView2.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView2.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView2.Location = new System.Drawing.Point(532, 200);
            this.monthView2.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView2.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView2.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView2.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView2.Name = "monthView2";
            this.monthView2.Size = new System.Drawing.Size(5, 5);
            this.monthView2.TabIndex = 0;
            this.monthView2.Text = "monthView2";
            this.monthView2.TodayBorderColor = System.Drawing.Color.Maroon;
            // 
            // rbtDisponibles
            // 
            this.rbtDisponibles.AutoSize = true;
            this.rbtDisponibles.Checked = true;
            this.rbtDisponibles.Location = new System.Drawing.Point(694, 47);
            this.rbtDisponibles.Name = "rbtDisponibles";
            this.rbtDisponibles.Size = new System.Drawing.Size(169, 24);
            this.rbtDisponibles.TabIndex = 315;
            this.rbtDisponibles.TabStop = true;
            this.rbtDisponibles.Tag = "turnos disponibles";
            this.rbtDisponibles.Text = "Turnos Disponibles";
            this.rbtDisponibles.UseVisualStyleBackColor = true;
            this.rbtDisponibles.CheckedChanged += new System.EventHandler(this.rbtDisponibles_CheckedChanged);
            // 
            // rbtAsignados
            // 
            this.rbtAsignados.AutoSize = true;
            this.rbtAsignados.Location = new System.Drawing.Point(694, 20);
            this.rbtAsignados.Name = "rbtAsignados";
            this.rbtAsignados.Size = new System.Drawing.Size(162, 24);
            this.rbtAsignados.TabIndex = 316;
            this.rbtAsignados.Tag = "turnos asignados";
            this.rbtAsignados.Text = "Turnos Asignados";
            this.rbtAsignados.UseVisualStyleBackColor = true;
            this.rbtAsignados.CheckedChanged += new System.EventHandler(this.rbtAsignados_CheckedChanged);
            // 
            // btnCancelarTurno
            // 
            this.btnCancelarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarTurno.Enabled = false;
            this.btnCancelarTurno.Location = new System.Drawing.Point(1293, 952);
            this.btnCancelarTurno.Name = "btnCancelarTurno";
            this.btnCancelarTurno.Size = new System.Drawing.Size(465, 55);
            this.btnCancelarTurno.TabIndex = 317;
            this.btnCancelarTurno.Tag = "cancelar turno";
            this.btnCancelarTurno.Text = "Cancelar Turno";
            this.btnCancelarTurno.UseVisualStyleBackColor = true;
            this.btnCancelarTurno.Visible = false;
            this.btnCancelarTurno.Click += new System.EventHandler(this.btnCancelarTurno_Click);
            // 
            // btnCrearEstudio
            // 
            this.btnCrearEstudio.Location = new System.Drawing.Point(273, 30);
            this.btnCrearEstudio.Name = "btnCrearEstudio";
            this.btnCrearEstudio.Size = new System.Drawing.Size(133, 52);
            this.btnCrearEstudio.TabIndex = 318;
            this.btnCrearEstudio.Tag = "crear estudio";
            this.btnCrearEstudio.Text = "Crear Estudio";
            this.btnCrearEstudio.UseVisualStyleBackColor = true;
            this.btnCrearEstudio.Click += new System.EventHandler(this.btnCrearEstudio_Click);
            // 
            // frmRegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 1019);
            this.Controls.Add(this.btnCrearEstudio);
            this.Controls.Add(this.btnRegistrarTurno);
            this.Controls.Add(this.btnCancelarTurno);
            this.Controls.Add(this.rbtAsignados);
            this.Controls.Add(this.rbtDisponibles);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.monthView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblEstudios);
            this.Controls.Add(this.cmbEstudio);
            this.Controls.Add(this.calendar1);
            this.Name = "frmRegistrarTurno";
            this.Tag = "frmRegistrarTurno";
            this.Text = "frmRegistrarTurno";
            this.Load += new System.EventHandler(this.frmRegistrarTurno_Load);
            this.calendar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.Label lblEstudios;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnRegistrarTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Calendar.MonthView monthView1;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Calendar.MonthView monthView2;
        private System.Windows.Forms.Calendar.MonthView monthView3;
        private System.Windows.Forms.RadioButton rbtDisponibles;
        private System.Windows.Forms.RadioButton rbtAsignados;
        private System.Windows.Forms.Button btnCancelarTurno;
        private System.Windows.Forms.Button btnCrearEstudio;
    }
}