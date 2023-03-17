
namespace Application.UI
{
    partial class frmMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espacioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEspaciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPrestadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEstudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip.Location = new System.Drawing.Point(0, 797);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1389, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Tag = "Estado";
            this.statusStrip.Text = "Estado";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 25);
            this.lblEstado.Tag = "estado";
            this.lblEstado.Text = "Estado";
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.negocioToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1389, 33);
            this.menu.TabIndex = 4;
            this.menu.Tag = "Menu";
            this.menu.Text = "Menu";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogout,
            this.menuLanguage,
            this.cerrarToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.sesionToolStripMenuItem.Tag = "Sesion";
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(270, 34);
            this.menuLogin.Tag = "iniciar sesion";
            this.menuLogin.Text = "Iniciar Sesion";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(270, 34);
            this.menuLogout.Tag = "cerrar sesion";
            this.menuLogout.Text = "Cerrar Sesion";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuLanguage
            // 
            this.menuLanguage.AutoToolTip = true;
            this.menuLanguage.Name = "menuLanguage";
            this.menuLanguage.Size = new System.Drawing.Size(270, 34);
            this.menuLanguage.Tag = "idioma";
            this.menuLanguage.Text = "Idioma";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cerrarToolStripMenuItem.Tag = "salir";
            this.cerrarToolStripMenuItem.Text = "Salir";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomasToolStripMenuItem,
            this.entidadesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.gestionToolStripMenuItem.Tag = "gestion";
            this.gestionToolStripMenuItem.Text = "Gestión";
            this.gestionToolStripMenuItem.Visible = false;
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.idiomasToolStripMenuItem.Tag = "idiomas";
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.entidadesToolStripMenuItem.Tag = "entidades";
            this.entidadesToolStripMenuItem.Text = "Entidades";
            this.entidadesToolStripMenuItem.Click += new System.EventHandler(this.entidadesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usuariosToolStripMenuItem.Tag = "usuarios";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.espacioToolStripMenuItem,
            this.prestadorToolStripMenuItem,
            this.especialidadToolStripMenuItem,
            this.estudiosToolStripMenuItem});
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.negocioToolStripMenuItem.Tag = "negocio";
            this.negocioToolStripMenuItem.Text = "Negocio";
            this.negocioToolStripMenuItem.Visible = false;
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClientesToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clienteToolStripMenuItem.Tag = "cliente";
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.gestionarClientesToolStripMenuItem.Tag = "gestionar clientes";
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // espacioToolStripMenuItem
            // 
            this.espacioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEspaciosToolStripMenuItem});
            this.espacioToolStripMenuItem.Name = "espacioToolStripMenuItem";
            this.espacioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.espacioToolStripMenuItem.Tag = "espacio";
            this.espacioToolStripMenuItem.Text = "Espacio";
            // 
            // gestionarEspaciosToolStripMenuItem
            // 
            this.gestionarEspaciosToolStripMenuItem.Name = "gestionarEspaciosToolStripMenuItem";
            this.gestionarEspaciosToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.gestionarEspaciosToolStripMenuItem.Tag = "gestionar espacios";
            this.gestionarEspaciosToolStripMenuItem.Text = "Gestionar Espacios";
            this.gestionarEspaciosToolStripMenuItem.Click += new System.EventHandler(this.gestionarEspaciosToolStripMenuItem_Click);
            // 
            // prestadorToolStripMenuItem
            // 
            this.prestadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPrestadoresToolStripMenuItem});
            this.prestadorToolStripMenuItem.Name = "prestadorToolStripMenuItem";
            this.prestadorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.prestadorToolStripMenuItem.Tag = "prestador";
            this.prestadorToolStripMenuItem.Text = "Prestador";
            // 
            // gestionarPrestadoresToolStripMenuItem
            // 
            this.gestionarPrestadoresToolStripMenuItem.Name = "gestionarPrestadoresToolStripMenuItem";
            this.gestionarPrestadoresToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.gestionarPrestadoresToolStripMenuItem.Tag = "gestionar prestadores";
            this.gestionarPrestadoresToolStripMenuItem.Text = "Gestionar Prestadores";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEspecialidadesToolStripMenuItem});
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.especialidadToolStripMenuItem.Tag = "espacialidad";
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            // 
            // gestionarEspecialidadesToolStripMenuItem
            // 
            this.gestionarEspecialidadesToolStripMenuItem.Name = "gestionarEspecialidadesToolStripMenuItem";
            this.gestionarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.gestionarEspecialidadesToolStripMenuItem.Tag = "gestionar especialidades";
            this.gestionarEspecialidadesToolStripMenuItem.Text = "Gestionar Especialidades";
            // 
            // estudiosToolStripMenuItem
            // 
            this.estudiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEstudiosToolStripMenuItem});
            this.estudiosToolStripMenuItem.Name = "estudiosToolStripMenuItem";
            this.estudiosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.estudiosToolStripMenuItem.Tag = "estudios";
            this.estudiosToolStripMenuItem.Text = "Estudios";
            // 
            // gestionarEstudiosToolStripMenuItem
            // 
            this.gestionarEstudiosToolStripMenuItem.Name = "gestionarEstudiosToolStripMenuItem";
            this.gestionarEstudiosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gestionarEstudiosToolStripMenuItem.Tag = "gestionar estudios";
            this.gestionarEstudiosToolStripMenuItem.Text = "Gestionar Estudios";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.backupRestoreToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.seguridadToolStripMenuItem.Tag = "seguridad";
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Visible = false;
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rolesToolStripMenuItem.Tag = "roles";
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.backupRestoreToolStripMenuItem.Tag = "backup restore";
            this.backupRestoreToolStripMenuItem.Text = "Backup / Restore";
            this.backupRestoreToolStripMenuItem.Click += new System.EventHandler(this.backupRestoreToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.españolToolStripMenuItem.Text = "Español";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 829);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "principal";
            this.Text = "Sistema de Administración y Gestión de Turnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espacioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEspaciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPrestadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEstudiosToolStripMenuItem;
    }
}

