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
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        #region foreign key
        public int funcionario__Id { get; set; }
        public int cliente__Id { get; set; }
        #endregion
        #region inner join
        public string cliente_Nome { get; set;}
        public string funcionario_Nome { get; set;} 
        #endregion

        public Movimento() => createEntity();
   
        public Movimento(int codigo) => Codigo = codigo;
        public Movimento(decimal totalFinal, 
            decimal totalDesconto, 
            int funcionarioCodigo, 
            int clienteCodigo)
        {
            createEntity();
            TotalFinal = totalFinal;    
            TotalDesconto = totalDesconto;
            funcionario__Id = funcionarioCodigo;
            cliente__Id = clienteCodigo;   
            DataCriacao = DateTime.Now;
            DataAlteracao = DateTime.Now;
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
