using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;


namespace BLL
{
    class ClienteBLL//modelo de negocio - chamada de ações
    {
       public static void save(Cliente cliente)
        { 
            if (ClienteDAL.findClient(cliente.Codigo))
            {
                ClienteDAL.createClient(cliente);
            }
            else
            {
                ClienteDAL.updateClient(cliente);
            }
        }public static void getLast()
        {
           Cliente.Id = ClienteDAL.getLastId();
        }
        public static DataTable getDataTable()
        {
            return ClienteDAL.getData();
        }
        public static DataTable consultaNome(string name)
        {
                return ClienteDAL.consultClient(name);    
            //return ClienteDAL.consultCodigo(int.Parse(name));
        }
        public static Cliente getClient(int codigo)
        {
            return ClienteDAL.get(codigo);
        }

        public static void deleteClient(int codigo)
        {
            ClienteDAL.delete(codigo); 
        }
       public static DataTable getClienteCodigo(int codigo)
        {
            return ClienteDAL.consultCodigo(codigo);
        }
    }
}

