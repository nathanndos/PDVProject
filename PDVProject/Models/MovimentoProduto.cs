using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MovimentoProduto:ClasseBase
    {
        public static int Id { private get; set; }
        public decimal TotalFinal { get; set; }
        public decimal TotalOriginal { get; set; }
        #region Foreign Key
        public int movimento__id { get; set; }
        public int funcionario__id { get; set; }
        #endregion
        public string ProdutoNome { get; set; }
        public string FuncionarioNome { get; set; }
        public DateTime DataLancamento { get; set; }    

        public MovimentoProduto()
        {
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
            Status = 0;

        }
        public MovimentoProduto(int codigo) => Codigo = codigo;
    }
}
