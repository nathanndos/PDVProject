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
    public class MovimentoProdutoBLL
    {
        public static void save(MovimentoProduto mp)
        {
            
                MovimentoProdutoDAL.create(mp);

        }
       // if (MovimentoProdutoDAL.find(mp.Codigo))
               // MovimentoProdutoDAL.create(mp);
          //  else
               // MovimentoProdutoDAL.update(mp);
        public static void getLast() => MovimentoProduto.Id = MovimentoProdutoDAL.getLastId();
        public static MovimentoProduto getData(int codigo) => MovimentoProdutoDAL.get(codigo);
        public static void delete(int codigo) => MovimentoProdutoDAL.delete(codigo);
    }
}
