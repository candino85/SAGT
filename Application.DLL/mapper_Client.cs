using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BE;
using System.Data.SqlClient;
using System.Data;

namespace Application.DLL
{
    public class Mapper_Client
    {
        readonly DBAccess accesso = new DBAccess();
        readonly mapper_Language mapper_Language = new mapper_Language();

        public int Create(Client client)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("nombre", client.Name);
            parametros[1] = new SqlParameter("apellido", client.Lastname);
            parametros[2] = new SqlParameter("dni", client.DNI);
            parametros[3] = new SqlParameter("fechaCreacion", client.CreationDate);
            parametros[4] = new SqlParameter("activo", client.Active);
            parametros[5] = new SqlParameter("direccion", client.Address);

            return accesso.Write("ClienteCrear", parametros);
        }

        public int Update(Client client)
        {
            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("id", client.Id);
            parametros[1] = new SqlParameter("nombre", client.Name);
            parametros[2] = new SqlParameter("apellido", client.Lastname);
            parametros[3] = new SqlParameter("dni", client.DNI);
            parametros[4] = new SqlParameter("fechaCreacion", client.CreationDate);
            parametros[5] = new SqlParameter("activo", client.Active);
            parametros[6] = new SqlParameter("direccion", client.Address);

            return accesso.Write("ClienteModificar", parametros);
        }

        public int Remove(int id)
        {
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("id", id);

            return accesso.Write("ClienteEliminar", parametro);
        }

        public List<Client> List()
        {
            List<Client> clientList = new List<Client>();
            DataTable dataTable = accesso.Read("ClientesListar", null);

            foreach (DataRow row in dataTable.Rows)
            {
                Client client = new Client
                {
                    Id = int.Parse(row["id"].ToString()),
                    Name = row["nombre"].ToString(),
                    Lastname = row["apellido"].ToString(),
                    DNI = row["dni"].ToString(),
                    CreationDate = DateTime.Parse(row["fechaCreacion"].ToString()),
                    Active = bool.Parse(row["activo"].ToString()),
                    Address = row["direccion"].ToString()
                };

                clientList.Add(client);
            }

            return clientList;
        }

        public Client GetClientById(int id)
        {
            BE.Client client = new Client();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@id", id);

            DataTable dataTable = accesso.Read("ClienteGetById", parametro);
            foreach (DataRow row in dataTable.Rows)
            {
                client.Id = int.Parse(row["id"].ToString());
                client.Name = row["nombre"].ToString();
                client.Lastname = row["apellido"].ToString();
                client.DNI= row["dni"].ToString();
                client.CreationDate = DateTime.Parse(row["fechaCreacion"].ToString());
                client.Active = bool.Parse(row["activo"].ToString());
                client.Address = row["direccion"].ToString();
            }
            return client;
        }             
    }
}
