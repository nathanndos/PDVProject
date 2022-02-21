using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Produto:ClasseBase
    {
        public static int Id { private get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Ncm { get; set; }    
        public string CodigoFornecedor { get; set; }
        public Produto(){
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
        }
        public Produto(int codigo) => Codigo = codigo;
    }
}
