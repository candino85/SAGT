    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public enum PermissionType
    {
        //Sesion
        //SesionToolStripMenu
        CambiarIdioma,
        CambiarClave,

        //Gestion
        //gestionToolStripMenuItem
        GestionarIdioma,
        GestionarUsuarios,
        GestionarEntidades,
        GestionarEspacios,

        //Seguridad
        //seguridadToolStripMenuItem
        ConfigurarSeguridadRoles,
        ConfigurarSeguridadUsuarios,

        //Negocio
        //negocioToolStripMenuItem
        ConfigurarNegocio,

        //Sistema
        BackupRestore
    }
}
