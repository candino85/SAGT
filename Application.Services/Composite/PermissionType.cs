namespace Application.Services
{
    public enum PermissionType
    {
        //Sesion
        menuCambiarIdioma,
        menuCambiarClave,

        //Administrar
        menuAdministrar,
        menuUsuarios,
        menuIdiomas,
        menuBackupRestore,
        menuPerfiles,
        menuBitacora,
        menuDV,

        //Maestros
        menuMaestros,
        menuSucursales,
        menuEspacios,
        menuClientes,
        menuEspecialidades,
        menuEstudios,

        //Turnos
        menuRegistrar,
        menuTurno,
        menuAgenda,
        menuMuestra,
        menuHistoricoDeCambios,

        //Reportes
        menuReportes,

        //Ayuda
        menuAyuda


        //Negocio
        //menuGestionNegocio,
        //menuGestionClientes,
        //menuGestionEspacios,
        //menuGestionEspecicialidades,
        //menuGestionEstudios,
        //menuRegistrarTurno,

        //Seguridad
        //menuGestionSeguridad,
        //menuGestionPermisos,
        //menuGestionRoles,
        //menuGestionBackup

    }
}
