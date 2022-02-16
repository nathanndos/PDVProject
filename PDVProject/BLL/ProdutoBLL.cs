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
    class ProdutoBLL
    {
        public static void save(Produto produto)
        {
            if (ProdutoDAL.find(produto.Codigo))
                ProdutoDAL.create(produto);
            else
                ProdutoDAL.update(produto);
        }
        public static void getLast()
        {
            Produto.Id = ProdutoDAL.getLastId();
        }
        public static DataTable getListAll()
        {
            return ProdutoDAL.getAll();
        }
        public static DataTable searchByName(string name)
        {
            return ProdutoDAL.getByName(name);
        }
        public static Produto getData(int codigo)
        {
            return ProdutoDAL.get(codigo);
        }
        public static void deleteFunc(int codigo)
        {
            ProdutoDAL.delete(codigo);
        }
        public static DataTable searchById(int codigo)
        {
            return ProdutoDAL.getById(codigo);
        }
    }
}
