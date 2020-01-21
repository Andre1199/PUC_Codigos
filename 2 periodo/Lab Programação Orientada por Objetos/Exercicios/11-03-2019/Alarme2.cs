using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Alarme2
    {
        private Relogio r1 = new Relogio();

        public Relogio _r1
        {
            get { return r1; }
            set { r1 = value; }
        }

        private bool[] diasAlarme = new bool[] { false, true, true, true, true, true, false };

        public void ProgramarDespertador(int hr, int mn, int diaSem)
        {

            if((hr >= 0 && hr <= 24)&&
                (mn >= 0 && mn <= 60))
            {
                _r1._minutos = mn;
                _r1._horas = hr;
            }
            else
                Console.WriteLine("Hora e/ou minutos inválidos");

            diasAlarme[diaSem] = true;
        }

        public void DesprogramarDespertador(int hr, int mn, int diaSem)
        {
            if (VerificarDespertador(hr,mn,diaSem))
            {
                diasAlarme[diaSem] = false;
            }
            else
                Console.WriteLine("Não há despertador programado.");
        }

        public void AdiarDespertador(bool SorN)
        {
            if (SorN)
            {
                _r1._minutos += 5;
            }
        }

        public bool VerificarDespertador(int h, int m, int d)
        {
            if (diasAlarme[d] == true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
