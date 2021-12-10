using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Funcionario:ClasseBase
    {
        public static int Id { private get;  set; }  
        public float Comissao { get;set; }  
        public string Funcao { get; set; }  

        public Funcionario()
        {
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
        }
    }
}
