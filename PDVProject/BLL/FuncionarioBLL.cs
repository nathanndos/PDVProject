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
            if (FuncionarioDAL.findFuncionario(funcionario.Codigo))
                FuncionarioDAL.createFuncionario(funcionario);        
            else          
                FuncionarioDAL.updateFuncionario(funcionario);
        }
        public static void getLast()
        {
            Funcionario.Id = FuncionarioDAL.getLastId();
        }
        public static DataTable getDataTable()
        {
            return FuncionarioDAL.getData();
        }
        public static DataTable consultaNome(string name)
        {
            return FuncionarioDAL.consultFuncionario(name);
        }
        public static Funcionario getFunc(int codigo)
        {
            return FuncionarioDAL.get(codigo);
        }
        public static void deleteFunc(int codigo)
        {
            FuncionarioDAL.delete(codigo);
        }
        public static DataTable getFuncCodigo(int codigo)
        {
            return FuncionarioDAL.consultCodigo(codigo);
        }
    }
}
