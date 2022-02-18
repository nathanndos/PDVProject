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
            if (ClienteDAL.find(cliente.Codigo))
            {
                ClienteDAL.create(cliente);
            }
            else
            {
                ClienteDAL.update(cliente);
            }
        }public static void getLast()
        {
           Cliente.Id = ClienteDAL.getLastId();
        }
        public static DataTable getListAll()
        {
            return ClienteDAL.getAll();
        }
        public static DataTable searchByName(string name)
        {
                return ClienteDAL.getByName(name);    
            //return ClienteDAL.consultCodigo(int.Parse(name));
        }
        public static Cliente getData(int codigo)
        {
            return ClienteDAL.get(codigo);
        }

        public static void delete(int codigo)
        {
            ClienteDAL.delete(codigo); 
        }
       public static DataTable searchByCodigo(int codigo)
        {
            return ClienteDAL.getById(codigo);
        }
    }
}

