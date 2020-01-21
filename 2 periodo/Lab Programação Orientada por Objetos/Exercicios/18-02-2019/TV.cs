using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class TV
    {
        private int volume = 0;
        public int _volume
        {
            get { return volume; }
            set { volume = value; }
        }

        private int canal = 0;
        public int _canal
        {
            get { return canal; }
            set { canal = value; }
        }

        public TV(int v, int c)
        {
            _volume = v;
            _canal = c;
        }

        public void DesligarTV()
        {
            this._canal = 01;
            this._volume = 00;
            Environment.Exit(0);
        }

        public void AumentarVol(int novoV)
        {
            if (_volume == 100)
                Console.WriteLine("Não é possivel aumentar o volume.");
            else
                _volume++;
        }

        public void DiminuirVol(int novoV)
        {
            if(_volume == 0)
                Console.WriteLine("Não é possivel abaixar o volume.");
            else
                _volume--;
        }

        public void SubirCanal(int novoC)
        {
            if(_canal == 83)
            {
                _canal = 01;
            }
            else
                _canal++;
        }

        public void DescerCanal(int novoC)
        {
            if (_canal == 01)
            {
                _canal = 83;
            }
            _canal--;
        }
    }
}
