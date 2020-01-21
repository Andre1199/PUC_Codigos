using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Relogio
    {
        private int horas;
        public int _horas
        {
            get { return horas; }
            set { horas = value; }
        }

        private int minutos;
        public int _minutos
        {
            get { return minutos; }
            set { horas = value; }
        }

        private int dia;
        public int _dia
        {
            get { return dia; }
            set { dia = value; }
        }

        private int[] diasAno = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int mes;
        public int _mes
        {
            get { return mes; }
            set { mes = value; }
        }

        private int ano;
        public int _ano
        {
            get { return ano; }
            set { ano = value; }
        }
        private Relogio()
        {
            horas = 00;
            minutos = 00;
            dia = 01;
            mes = 01;
            ano = 2000;
        }
        public Relogio(int h, int m, int d, int me, int a)
        {
            _horas = h;
            _minutos = m;
            _dia = d;
            _mes = me;
            _ano = a;
        }

        private void PassagemDia()
        {
            if (_dia > diasAno[_mes - 1])
            {
                _dia = 01;
                _mes++;
            }

            if (_mes > 12)
            {
                _mes = 01;
                _ano++;
            }
        }

        private void PassagemTempo()
        {
            if (_minutos > 60)
            {
                _horas++;
            }

            if (_horas > 24)
            {
                _dia++;
            }
        }

        public void AjustarData(int ddia, int mmes, int aano)
        {
            if ((aano % 4 == 0) &&
               (aano % 100 != 0))
                if (mmes == 02)
                {
                    if (ddia >= 01 && ddia <= 29)
                    {
                        this._dia = ddia;
                        PassagemDia();

                        this._mes = mmes;
                        PassagemDia();

                        this._ano = aano;
                    }
                }
                else
                {
                    if ((_mes >= 01 && _mes <= 12) &&
                        (_dia >= 01 && _dia <= this.diasAno[_mes - 1]))
                    {
                        this._dia = _dia;
                        PassagemDia();

                        this._mes = _mes;
                        PassagemDia();

                        this._ano = _ano;
                    }
                }
            else
            {
                if ((aano >= 0000) &&
                    (mmes >= 01 && mmes <= 12) &&
                      (ddia >= 01 && ddia <= this.diasAno[_mes - 1]))
                {
                    this._dia = ddia;
                    PassagemDia();

                    this._mes = mmes;
                    PassagemDia();

                    this._ano = aano;
                }
            }
        }

        public void AjustarHoras(int mminutos, int hhoras)
        {
            if (hhoras >= 00 && hhoras <= 24)
            {
                this.horas = hhoras;
                PassagemTempo();
            }
            else if (mminutos >= 00 & mminutos <= 60)
            {
                this._minutos = mminutos;
                PassagemTempo();
            }
        }

        public void Reiniciar()
        {
            this._horas = 00;
            this._minutos = 00;
            this._dia = 01;
            this._mes = 01;
            this._ano = 2000;
        }
    }
}
