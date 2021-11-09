using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Funcionario
    {
        public static int IdFuncionarios { private get;  set; }  
        public int Id { get; private set; }    
        public string Name { get; set; } 
        public float Comissao { get;set; }  
        public string Funcao { get; set; }  

        public Funcionario()
        {
            IdFuncionarios++;
            Id = IdFuncionarios;
        }
    }
}
