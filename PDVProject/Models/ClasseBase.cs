using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class ClasseBase
    {
        public int Id { get; protected set; }
        public string Nome { get; set; }
        public string Ide { get; set; } 
        public char[] ChaveAleatoria()
        {
            int tamanhoSenha = 15;
            string caracteres = "abcdefghijkmnopqrstuvwxyz1234567890";
            char[] arrayChars = new char[tamanhoSenha];

            Random random = new Random();

            for(int i = 0;i<tamanhoSenha;i++)
            {
                arrayChars[i] = caracteres[random.Next(0,caracteres.Length)];
            }
            return arrayChars;
        }
    }
}
