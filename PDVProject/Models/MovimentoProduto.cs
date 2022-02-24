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
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal TotalFinal { get; set; }
        #region Foreign Key
        public int movimento__id { get; set; }
        public int funcionario__id { get; set; }
        public int produto__id { get; set; }
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

        public MovimentoProduto(int produtoCodigo,
            string produtoNome,
            int quantidade, 
            decimal precoUnitario, 
            int funcionarioCodigo, 
            string funcionarioNome,
            DateTime datalancamento)
        {
            produto__id = produtoCodigo;
            ProdutoNome = produtoNome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            TotalFinal = precoUnitario * quantidade;
            funcionario__id = funcionarioCodigo;
            FuncionarioNome = funcionarioNome;
            DataLancamento = datalancamento;
        }
    }
}
