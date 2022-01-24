using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente:ClasseBase//Entidade Cliente
    {
        public static int Id { private get; set; }
        public string Email { get; set; }
        public string SobreNome{get; set;}
        public string Cpf {get; set;}

        public Cliente()
        {
            Id++;
            Codigo = Id;
            Ide = new string(ChaveAleatoria());
            Status = 0;

        }
        public Cliente(int codigo)
        {
            Codigo = codigo;
        }
    }
}
