using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Microondas
    {
        Alarme2 Temporizador = null;
        int potencia;
        bool estado;
        bool porta;

        public void Ligar()
        {
                estado = true;
        }
        public void Desligar()
        {
            estado = false;
        }
        public void AbrirPorta()
        {
            porta = true;
        }
        public void FecharPorta()
        {
            porta = false;
        }
        public void Ativar(int m, int s)
        {
            if(porta == false && estado == true)
            {
                Temporizador._r1._minutos = m;
                Temporizador._r1._segundos = s;

                Console.WriteLine("Ativado.");
                while (Temporizador._r1._minutos == 0 )
                {
                    Temporizador._r1._minutos--;
                }
                while (Temporizador._r1._segundos == 0)
                {
                    Temporizador._r1._segundos--;
                }
                Console.WriteLine("Fim");
            }
        }

        public void AumentarPotencia()
        {
            if(potencia <=10)
            potencia++;
            else
                Console.WriteLine("Potencia no máximo.");
        }

        public void DiminuirPotencia()
        {
            if (potencia > 0)
                potencia--;
            else
                Console.WriteLine("Potencia no mínimo.");
        }
    }
}
