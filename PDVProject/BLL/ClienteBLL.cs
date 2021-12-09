using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    class ClienteBLL//modelo de negocio - chamada de ações
    {
       public static void save(Cliente cliente)
        { 
            if (ClienteDAL.findClient(cliente.Id))
            {
                ClienteDAL.createClient(cliente);
            }
            else
            {
                ClienteDAL.updateClient(cliente);
            }
        }public static void getLast()
        {
           Cliente.Id_Clientes = ClienteDAL.getLastId();
        }
    }
}
