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
    public class MovimentoBLL
    {
        public static void save(Movimento movimento)
        {
            if (MovimentoDAL.find(movimento.Codigo))
                MovimentoDAL.create(movimento);
            else
                MovimentoDAL.update(movimento);
        }
        public static void getLast()
        {
            Movimento.Id = MovimentoDAL.getLastId();
        }
        public static DataTable getListAll()
        {
            return MovimentoDAL.getAll();
        }
        public static Movimento getData(int codigo)
        {
            return MovimentoDAL.get(codigo);
        }
        public static void delete(int codigo)
        {
            MovimentoDAL.delete(codigo);
        }
        public static DataTable searchById(int codigo)
        {
            return MovimentoDAL.getById(codigo);
        }
    }
}
