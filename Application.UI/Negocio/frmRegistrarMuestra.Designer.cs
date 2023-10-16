namespace Application.UI.Negocio
{
    partial class frmRegistrarMuestra
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPacienteApellido = new System.Windows.Forms.TextBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPacienteNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPacienteDNI = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.txtPacienteDireccion = new System.Windows.Forms.TextBox();
            this.gbEstudio = new System.Windows.Forms.GroupBox();
            this.txtEstudioNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.GroupBox();
            this.txtFechaHoraTurno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSucursalNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarMuestra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPaciente.SuspendLayout();
            this.gbEstudio.SuspendLayout();
            this.z.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Tag = "apellido";
            this.label1.Text = "Apellido";
            // 
            // txtPacienteApellido
            // 
            this.txtPacienteApellido.Enabled = false;
            this.txtPacienteApellido.Location = new System.Drawing.Point(193, 74);
            this.txtPacienteApellido.Name = "txtPacienteApellido";
            this.txtPacienteApellido.Size = new System.Drawing.Size(267, 26);
            this.txtPacienteApellido.TabIndex = 1;
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.label5);
            this.gbPaciente.Controls.Add(this.textBox2);
            this.gbPaciente.Controls.Add(this.Direccion);
            this.gbPaciente.Controls.Add(this.txtPacienteDireccion);
            this.gbPaciente.Controls.Add(this.label3);
            this.gbPaciente.Controls.Add(this.txtPacienteDNI);
            this.gbPaciente.Controls.Add(this.label2);
            this.gbPaciente.Controls.Add(this.txtPacienteNombre);
            this.gbPaciente.Controls.Add(this.label1);
            this.gbPaciente.Controls.Add(this.txtPacienteApellido);
            this.gbPaciente.Location = new System.Drawing.Point(12, 12);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(473, 441);
            this.gbPaciente.TabIndex = 2;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Tag = "paciente";
            this.gbPaciente.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Tag = "nombre";
            this.label2.Text = "Nombre";
            // 
            // txtPacienteNombre
            // 
            this.txtPacienteNombre.Enabled = false;
            this.txtPacienteNombre.Location = new System.Drawing.Point(10, 74);
            this.txtPacienteNombre.Name = "txtPacienteNombre";
            this.txtPacienteNombre.Size = new System.Drawing.Size(177, 26);
            this.txtPacienteNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Tag = "dni";
            this.label3.Text = "DNI";
            // 
            // txtPacienteDNI
            // 
            this.txtPacienteDNI.Enabled = false;
            this.txtPacienteDNI.Location = new System.Drawing.Point(10, 217);
            this.txtPacienteDNI.Name = "txtPacienteDNI";
            this.txtPacienteDNI.Size = new System.Drawing.Size(210, 26);
            this.txtPacienteDNI.TabIndex = 5;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(6, 269);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(75, 20);
            this.Direccion.TabIndex = 6;
            this.Direccion.Tag = "direccion";
            this.Direccion.Text = "Dirección";
            // 
            // txtPacienteDireccion
            // 
            this.txtPacienteDireccion.Enabled = false;
            this.txtPacienteDireccion.Location = new System.Drawing.Point(6, 292);
            this.txtPacienteDireccion.Multiline = true;
            this.txtPacienteDireccion.Name = "txtPacienteDireccion";
            this.txtPacienteDireccion.Size = new System.Drawing.Size(450, 118);
            this.txtPacienteDireccion.TabIndex = 7;
            // 
            // gbEstudio
            // 
            this.gbEstudio.Controls.Add(this.textBox1);
            this.gbEstudio.Controls.Add(this.label4);
            this.gbEstudio.Controls.Add(this.txtEstudioNombre);
            this.gbEstudio.Location = new System.Drawing.Point(498, 12);
            this.gbEstudio.Name = "gbEstudio";
            this.gbEstudio.Size = new System.Drawing.Size(466, 147);
            this.gbEstudio.TabIndex = 3;
            this.gbEstudio.TabStop = false;
            this.gbEstudio.Tag = "estudio";
            this.gbEstudio.Text = "Estudio";
            // 
            // txtEstudioNombre
            // 
            this.txtEstudioNombre.Enabled = false;
            this.txtEstudioNombre.Location = new System.Drawing.Point(6, 34);
            this.txtEstudioNombre.Name = "txtEstudioNombre";
            this.txtEstudioNombre.Size = new System.Drawing.Size(454, 26);
            this.txtEstudioNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Tag = "especialidad";
            this.label4.Text = "Especialidad";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(10, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Tag = "email";
            this.label5.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(10, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 26);
            this.textBox2.TabIndex = 9;
            // 
            // z
            // 
            this.z.Controls.Add(this.txtSucursalNombre);
            this.z.Controls.Add(this.label8);
            this.z.Controls.Add(this.txtFechaHoraCreacion);
            this.z.Controls.Add(this.label7);
            this.z.Controls.Add(this.txtFechaHoraTurno);
            this.z.Controls.Add(this.label6);
            this.z.Location = new System.Drawing.Point(498, 171);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(466, 227);
            this.z.TabIndex = 4;
            this.z.TabStop = false;
            this.z.Tag = "turno";
            this.z.Text = "Turno";
            // 
            // txtFechaHoraTurno
            // 
            this.txtFechaHoraTurno.Enabled = false;
            this.txtFechaHoraTurno.Location = new System.Drawing.Point(10, 52);
            this.txtFechaHoraTurno.Name = "txtFechaHoraTurno";
            this.txtFechaHoraTurno.Size = new System.Drawing.Size(448, 26);
            this.txtFechaHoraTurno.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 8;
            this.label6.Tag = "fecha hora turno";
            this.label6.Text = "Fecha Hora Turno";
            // 
            // txtFechaHoraCreacion
            // 
            this.txtFechaHoraCreacion.Enabled = false;
            this.txtFechaHoraCreacion.Location = new System.Drawing.Point(12, 111);
            this.txtFechaHoraCreacion.Name = "txtFechaHoraCreacion";
            this.txtFechaHoraCreacion.Size = new System.Drawing.Size(448, 26);
            this.txtFechaHoraCreacion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 10;
            this.label7.Tag = "fecha hora creacion";
            this.label7.Text = "Fecha Hora Creación";
            // 
            // txtSucursalNombre
            // 
            this.txtSucursalNombre.Enabled = false;
            this.txtSucursalNombre.Location = new System.Drawing.Point(12, 172);
            this.txtSucursalNombre.Name = "txtSucursalNombre";
            this.txtSucursalNombre.Size = new System.Drawing.Size(448, 26);
            this.txtSucursalNombre.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 12;
            this.label8.Tag = "sucursal";
            this.label8.Text = "Sucursal";
            // 
            // btnRegistrarMuestra
            // 
            this.btnRegistrarMuestra.Location = new System.Drawing.Point(739, 404);
            this.btnRegistrarMuestra.Name = "btnRegistrarMuestra";
            this.btnRegistrarMuestra.Size = new System.Drawing.Size(225, 49);
            this.btnRegistrarMuestra.TabIndex = 5;
            this.btnRegistrarMuestra.Tag = "registrar muestra";
            this.btnRegistrarMuestra.Text = "Registrar Muestra";
            this.btnRegistrarMuestra.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(498, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Tag = "cancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 473);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarMuestra);
            this.Controls.Add(this.z);
            this.Controls.Add(this.gbEstudio);
            this.Controls.Add(this.gbPaciente);
            this.Name = "frmRegistrarMuestra";
            this.Text = "frmRegistrarMuestra";
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbEstudio.ResumeLayout(false);
            this.gbEstudio.PerformLayout();
            this.z.ResumeLayout(false);
            this.z.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPacienteApellido;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPacienteNombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox txtPacienteDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPacienteDNI;
        private System.Windows.Forms.GroupBox gbEstudio;
        private System.Windows.Forms.TextBox txtEstudioNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox z;
        private System.Windows.Forms.TextBox txtFechaHoraCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaHoraTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSucursalNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarMuestra;
        private System.Windows.Forms.Button btnCancelar;
    }
}