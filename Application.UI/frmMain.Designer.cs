﻿
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
            this.menuCambiarClave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIdiomas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSucursales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEspacios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstudios = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrarTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportesTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.menuAdministrar,
            this.menuMaestros,
            this.menuTurnos,
            this.menuReportes,
            this.menuAyuda});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1389, 36);
            this.menu.TabIndex = 4;
            this.menu.Tag = "Menu";
            this.menu.Text = "Menu";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogout,
            this.menuCambiarClave,
            this.menuLanguage,
            this.menuCerrar});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.sesionToolStripMenuItem.Tag = "Sesion";
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(270, 36);
            this.menuLogin.Tag = "iniciar sesion";
            this.menuLogin.Text = "Iniciar Sesion";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(270, 36);
            this.menuLogout.Tag = "cerrar sesion";
            this.menuLogout.Text = "Cerrar Sesion";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuCambiarClave
            // 
            this.menuCambiarClave.Name = "menuCambiarClave";
            this.menuCambiarClave.Size = new System.Drawing.Size(270, 36);
            this.menuCambiarClave.Tag = "cambiar clave";
            this.menuCambiarClave.Text = "Cambiar Clave";
            this.menuCambiarClave.Visible = false;
            this.menuCambiarClave.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // menuLanguage
            // 
            this.menuLanguage.AutoToolTip = true;
            this.menuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDown});
            this.menuLanguage.Name = "menuLanguage";
            this.menuLanguage.Size = new System.Drawing.Size(270, 36);
            this.menuLanguage.Tag = "cambiar idioma";
            this.menuLanguage.Text = "Cambiar Idioma";
            this.menuLanguage.Visible = false;
            // 
            // DropDown
            // 
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(102, 34);
            // 
            // menuCerrar
            // 
            this.menuCerrar.Name = "menuCerrar";
            this.menuCerrar.Size = new System.Drawing.Size(270, 36);
            this.menuCerrar.Tag = "salir";
            this.menuCerrar.Text = "Salir";
            this.menuCerrar.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuAdministrar
            // 
            this.menuAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuPerfiles,
            this.menuIdiomas,
            this.menuBackupRestore});
            this.menuAdministrar.Name = "menuAdministrar";
            this.menuAdministrar.Size = new System.Drawing.Size(130, 32);
            this.menuAdministrar.Tag = "administrar";
            this.menuAdministrar.Text = "Administrar";
            this.menuAdministrar.Visible = false;
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuario,
            this.ModificarUsuario});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(260, 36);
            this.menuUsuarios.Tag = "usuarios";
            this.menuUsuarios.Text = "Usuarios";
            // 
            // crearUsuario
            // 
            this.crearUsuario.Name = "crearUsuario";
            this.crearUsuario.Size = new System.Drawing.Size(198, 36);
            this.crearUsuario.Tag = "crear";
            this.crearUsuario.Text = "Crear";
            this.crearUsuario.ToolTipText = "crear";
            this.crearUsuario.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Size = new System.Drawing.Size(198, 36);
            this.ModificarUsuario.Tag = "modificar";
            this.ModificarUsuario.Text = "Modificar";
            this.ModificarUsuario.ToolTipText = "modificar";
            this.ModificarUsuario.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // menuPerfiles
            // 
            this.menuPerfiles.Name = "menuPerfiles";
            this.menuPerfiles.Size = new System.Drawing.Size(260, 36);
            this.menuPerfiles.Tag = "perfiles";
            this.menuPerfiles.Text = "Perfiles";
            this.menuPerfiles.Click += new System.EventHandler(this.menuPerfiles_Click);
            // 
            // menuIdiomas
            // 
            this.menuIdiomas.Name = "menuIdiomas";
            this.menuIdiomas.Size = new System.Drawing.Size(260, 36);
            this.menuIdiomas.Tag = "idiomas";
            this.menuIdiomas.Text = "Idiomas";
            this.menuIdiomas.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // menuBackupRestore
            // 
            this.menuBackupRestore.Name = "menuBackupRestore";
            this.menuBackupRestore.Size = new System.Drawing.Size(260, 36);
            this.menuBackupRestore.Tag = "backup/restore";
            this.menuBackupRestore.Text = "Backup / Restore";
            this.menuBackupRestore.Click += new System.EventHandler(this.menuBackupRestore_Click);
            // 
            // menuMaestros
            // 
            this.menuMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSucursales,
            this.menuEspacios,
            this.menuClientes,
            this.menuEspecialidades,
            this.menuEstudios});
            this.menuMaestros.Name = "menuMaestros";
            this.menuMaestros.Size = new System.Drawing.Size(108, 32);
            this.menuMaestros.Tag = "maestros";
            this.menuMaestros.Text = "Maestros";
            this.menuMaestros.Visible = false;
            // 
            // menuSucursales
            // 
            this.menuSucursales.Name = "menuSucursales";
            this.menuSucursales.Size = new System.Drawing.Size(270, 36);
            this.menuSucursales.Tag = "sucursal";
            this.menuSucursales.Text = "Sucursal";
            this.menuSucursales.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // menuEspacios
            // 
            this.menuEspacios.Name = "menuEspacios";
            this.menuEspacios.Size = new System.Drawing.Size(270, 36);
            this.menuEspacios.Tag = "espacios";
            this.menuEspacios.Text = "Espacios";
            this.menuEspacios.Click += new System.EventHandler(this.menuGestionEspacios_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaciente,
            this.modificarPaciente});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(270, 36);
            this.menuClientes.Tag = "clientes";
            this.menuClientes.Text = "Clientes";
            // 
            // crearPaciente
            // 
            this.crearPaciente.Name = "crearPaciente";
            this.crearPaciente.Size = new System.Drawing.Size(198, 36);
            this.crearPaciente.Tag = "crear";
            this.crearPaciente.Text = "Crear";
            this.crearPaciente.ToolTipText = "crear";
            this.crearPaciente.Click += new System.EventHandler(this.crearPaciente_Click);
            // 
            // modificarPaciente
            // 
            this.modificarPaciente.Name = "modificarPaciente";
            this.modificarPaciente.Size = new System.Drawing.Size(198, 36);
            this.modificarPaciente.Tag = "modificar";
            this.modificarPaciente.Text = "Modificar";
            this.modificarPaciente.ToolTipText = "modificar";
            this.modificarPaciente.Click += new System.EventHandler(this.modificarPaciente_Click);
            // 
            // menuEspecialidades
            // 
            this.menuEspecialidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1});
            this.menuEspecialidades.Name = "menuEspecialidades";
            this.menuEspecialidades.Size = new System.Drawing.Size(270, 36);
            this.menuEspecialidades.Tag = "espacialidades";
            this.menuEspecialidades.Text = "Especialidades";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(270, 36);
            this.crearToolStripMenuItem1.Tag = "crear";
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.ToolTipText = "crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // menuEstudios
            // 
            this.menuEstudios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEstudio,
            this.modificarToolStripMenuItem});
            this.menuEstudios.Name = "menuEstudios";
            this.menuEstudios.Size = new System.Drawing.Size(270, 36);
            this.menuEstudios.Tag = "estudios";
            this.menuEstudios.Text = "Estudios";
            // 
            // crearEstudio
            // 
            this.crearEstudio.Name = "crearEstudio";
            this.crearEstudio.Size = new System.Drawing.Size(198, 36);
            this.crearEstudio.Tag = "crear";
            this.crearEstudio.Text = "Crear";
            this.crearEstudio.ToolTipText = "crear";
            this.crearEstudio.Click += new System.EventHandler(this.crearEstudio_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.modificarToolStripMenuItem.Tag = "modificar";
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // menuTurnos
            // 
            this.menuTurnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistrarTurno,
            this.menuAgenda});
            this.menuTurnos.Name = "menuTurnos";
            this.menuTurnos.Size = new System.Drawing.Size(87, 32);
            this.menuTurnos.Tag = "turnos";
            this.menuTurnos.Text = "Turnos";
            this.menuTurnos.Visible = false;
            // 
            // menuRegistrarTurno
            // 
            this.menuRegistrarTurno.Name = "menuRegistrarTurno";
            this.menuRegistrarTurno.Size = new System.Drawing.Size(191, 36);
            this.menuRegistrarTurno.Tag = "registrar";
            this.menuRegistrarTurno.Text = "Registrar";
            this.menuRegistrarTurno.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // menuAgenda
            // 
            this.menuAgenda.Name = "menuAgenda";
            this.menuAgenda.Size = new System.Drawing.Size(191, 36);
            this.menuAgenda.Tag = "agenda";
            this.menuAgenda.Text = "Agenda";
            this.menuAgenda.Click += new System.EventHandler(this.menuAgenda_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReportesTurnos});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(105, 32);
            this.menuReportes.Tag = "reportes";
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Visible = false;
            // 
            // menuReportesTurnos
            // 
            this.menuReportesTurnos.Name = "menuReportesTurnos";
            this.menuReportesTurnos.Size = new System.Drawing.Size(274, 36);
            this.menuReportesTurnos.Tag = "reporte de turnos";
            this.menuReportesTurnos.Text = "Reporte de Turnos";
            this.menuReportesTurnos.ToolTipText = "reporte de turnos";
            this.menuReportesTurnos.Click += new System.EventHandler(this.menuReportesTurnos_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(84, 32);
            this.menuAyuda.Tag = "ayuda";
            this.menuAyuda.Text = "Ayuda";
            this.menuAyuda.Visible = false;
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
        private System.Windows.Forms.ToolStripMenuItem menuAdministrar;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuMaestros;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuIdiomas;
        private System.Windows.Forms.ToolStripMenuItem menuCerrar;
        private System.Windows.Forms.ToolStripMenuItem menuEspacios;
        private System.Windows.Forms.ToolStripMenuItem menuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem menuEstudios;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarClave;
        private System.Windows.Forms.ToolStripMenuItem crearUsuario;
        private System.Windows.Forms.ToolStripMenuItem ModificarUsuario;
        private System.Windows.Forms.ToolStripMenuItem DropDown;
        private System.Windows.Forms.ToolStripMenuItem menuSucursales;
        private System.Windows.Forms.ToolStripMenuItem menuTurnos;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrarTurno;
        private System.Windows.Forms.ToolStripMenuItem menuBackupRestore;
        private System.Windows.Forms.ToolStripMenuItem menuPerfiles;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuAgenda;
        private System.Windows.Forms.ToolStripMenuItem crearPaciente;
        private System.Windows.Forms.ToolStripMenuItem modificarPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuReportesTurnos;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearEstudio;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}

