using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class ClasseBase
    {
        public int Codigo { get; protected set; }
        public string Nome { get; set; }
        public string Ide { get; set; } 
        public char[] ChaveAleatoria()
        {
            int tamanhoSenha = 23;
            string caracteres = "ABCDEFGHIJKMNOPQRSTUVWXYZ1234567890";
            char[] arrayChars = new char[tamanhoSenha];
            Random random = new Random();
            for(int i = 0;i<tamanhoSenha;i++)
            {
                arrayChars[i] = caracteres[random.Next(0,caracteres.Length)];
                if (i==5||i==11||i==16)
                {
                    arrayChars[i] = '-';
                }
            }
            return arrayChars;
        }
    }
}
