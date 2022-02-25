using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MovimentoProduto:ClasseBase
    {
        public static int Id {get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotalFinal { get; set; }
        #region Foreign Key
        public int movimento__id { get; set; }
        public int funcionario__id { get; set; }
        public int produto__id { get; set; }
        #endregion
        public string ProdutoNome { get; set; }
        public string Produto__ide { get; set; }
        public string FuncionarioNome { get; set; }     
        public DateTime DataLancamento { get; set; }    

        public MovimentoProduto()
        {
            createEntity();
        }
        public MovimentoProduto(int codigo) => Codigo = codigo;

        public MovimentoProduto(int produtoCodigo,
            string produtoNome,
            string produto__ide,
            int quantidade, 
            decimal precoUnitario,
            decimal desconto,
            int funcionarioCodigo, 
            string funcionarioNome,
            DateTime datalancamento)
        {
            createEntity();
            produto__id = produtoCodigo;
            ProdutoNome = produtoNome;
            Produto__ide = produto__ide;
            Quantidade = quantidade;
            Desconto = precoUnitario * (desconto/100);
            PrecoUnitario = precoUnitario - Desconto;
            TotalFinal = precoUnitario * quantidade;
            funcionario__id = funcionarioCodigo;
            FuncionarioNome = funcionarioNome;
            DataLancamento = datalancamento;
        }
        public void createEntity()
        {
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
            Status = 0;
        }
    }
}
