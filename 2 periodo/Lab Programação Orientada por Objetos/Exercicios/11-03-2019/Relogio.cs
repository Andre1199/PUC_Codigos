using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
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

        private int segundos;
        public int _segundos
        {
            get { return segundos; }
            set { segundos = value; }
        }


        public Data objData;

        private int [] diasAno = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Relogio()
        {
            _horas = 00;
            _minutos = 00;
            _segundos = 00;
        }

        public Relogio(int h, int m, int s, int dia, int mes, int ano)
        {
            _horas = h;
            _minutos = m;
            _segundos = s;
            objData = new Data(dia,mes,ano);
        }

        private void PassagemDia()
        {
            if (objData._dia > diasAno[objData._mes - 1])
            {
                objData._dia = 01;
                objData._mes++;
            }

            if (objData._mes > 12)
            {
                objData._mes = 01;
                objData._ano++;
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
                objData._dia++;
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
                        objData._dia = ddia;
                        PassagemDia();

                        objData._mes = mmes;
                        PassagemDia();

                        objData._ano = aano;
                    }
                }
                else
                {
                    if ((objData._mes >= 01 && objData._mes <= 12) &&
                        (objData._dia >= 01 && objData._dia <= this.diasAno[objData._mes - 1]))
                    {
                        this.objData._dia = objData._dia;
                        PassagemDia();

                        this.objData._mes = objData._mes;
                        PassagemDia();

                        this.objData._ano = objData._ano;
                    }
                }
            else
            {
                if ((aano >= 0000) &&
                    (mmes >= 01 && mmes <= 12) &&
                      (ddia >= 01 && ddia <= this.diasAno[objData._mes - 1]))
                {
                    this.objData._dia = ddia;
                    PassagemDia();

                    this.objData._mes = mmes;
                    PassagemDia();

                    this.objData._ano = aano;
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
            this.objData._dia = 01;
            this.objData._mes = 01;
            this.objData._ano = 2000;
        }
    }
}
