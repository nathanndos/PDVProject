using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente:ClasseBase//Entidade Cliente
    {
        public static int Id_Clientes { private get; set; }
        public string Email { get; set; }
        public string SobreNome{get; set;}
        public string Cpf {get; set;}

        public Cliente()
        {
            Id_Clientes++;
            Id = Id_Clientes;
            Ide = new string(ChaveAleatoria());
        }
    }
}
