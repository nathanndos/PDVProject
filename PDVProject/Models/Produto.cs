using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Produto:ClasseBase
    {
        public static int Id { get; private set; }
        public float Preco { get; set; }
        public int Ncm { get; set; }    
        public int CodigoFornecedor { get; set; }
        public Produto(){
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
        }
    }
}
