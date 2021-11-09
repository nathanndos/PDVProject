using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Produto
    {
        public static int IdProdutos { get; private set; }
        public int Id { get; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int CodigoFornecedor { get; set; }

        public Produto()
        {
            IdProdutos++;
            Id = IdProdutos;
        }
    }
}
