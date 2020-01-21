using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static string bancoDados = "PUC" + "GOOGLE" + "PAREDE" + "RELOGIO";

        public static string Select (string busca)
        {
            for(int pos = 0; pos < bancoDados.Length; pos++)
            {
                int posBusca = 0;
                if (bancoDados[pos] == busca[posBusca])
                {
                    posBusca++;
                    if(posBusca > busca.Length)
                    { return busca;
                    }
                }
                else
                { posBusca = 0;
                }  
            }
            return " ";
        }
        public static void Create(ref string palavra)
        {
            bancoDados += palavra;
        }
        public static void Drop (ref string palavra)
        {
            for (int pos = 0; pos < bancoDados.Length; pos++)
            {
                int posPalavra = 0, posI;
                if (bancoDados[pos] == palavra[posPalavra])
                {
                    posPalavra++;
                    if(posPalavra == 0)
                    {
                        posI = pos;
                    }
                    if (posPalavra > palavra.Length)
                    {
                        for ()
                        {
                            bancoDados[posI] = " ";
                        }
                    }
                }
                else
                {
                    posPalavra = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
