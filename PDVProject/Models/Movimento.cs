using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Movimento:ClasseBase
    {
        public static int Id { private get; set; }
        public decimal TotalFinal { get; set; }
        public decimal TotalDesconto { get; set; }
        //---
        public int funcionario__Id { get; set; }
        public int cliente__Id { get; set; }

        public Movimento()
        {
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
            Status = 0;

        }
        public Movimento(int codigo) => Codigo = codigo;
    }
}
