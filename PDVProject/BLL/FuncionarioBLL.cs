using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;

namespace BLL
{
    class FuncionarioBLL
    {
        public static void save(Funcionario funcionario)
        {
            if (FuncionarioDAL.find(funcionario.Codigo))
                FuncionarioDAL.create(funcionario);        
            else          
                FuncionarioDAL.update(funcionario);
        }
        public static void getLast()
        {
            Funcionario.Id = FuncionarioDAL.getLastId();
        }
        public static DataTable getListAll()
        {
            return FuncionarioDAL.getAll();
        }
        public static DataTable searchByName(string name)
        {
            return FuncionarioDAL.getByName(name);
        }
        public static Funcionario getData(int codigo)
        {
            return FuncionarioDAL.get(codigo);
        }
        public static void delete(int codigo)
        {
            FuncionarioDAL.delete(codigo);
        }
        public static DataTable searchById(int codigo)
        {
            return FuncionarioDAL.getById(codigo);
        }
    }
}
