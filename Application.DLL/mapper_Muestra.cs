using Application.BE;
using System.Data.SqlClient;

namespace Application.DLL
{
    public class mapper_Muestra
    {
        readonly DBAccess accesso = new DBAccess();

        public bool Create(Muestra muestra)
        {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("turno", muestra.IdTurno);
                parameters[1] = new SqlParameter("usuario", muestra.Usuario);
                parameters[2] = new SqlParameter("fechaHora", muestra.Fechahora);
                parameters[3] = new SqlParameter("operacion", muestra.Operacion);                  

                var ok = accesso.Write("MuestraCrear", parameters);

                if (ok == 1)
                    return true;
                else
                    return false;
        }
    }
}