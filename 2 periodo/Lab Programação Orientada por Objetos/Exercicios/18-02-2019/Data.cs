using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Data
    {
        private int[] vetMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int[] vetMesBi = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int dia;
        public int _dia
        {
            get { return dia; }
            set { dia = value; }
        }

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


        public Data(int d, int m, int a)
        {
            _dia = d;
            _mes = m;
            _ano = a;
        }

        public void MostrarData()
        {
            Console.WriteLine("\n{0:D2}/{1:D2}/{2:D4}", _dia, _mes, _ano);
            Console.ReadKey();
        }

        public bool VerificarData()
        {
            if (this.AnoBisexto())
                if((this._mes == 02 )&&
                    (this._dia == 29))
                {
                    if (this._dia >= 01 && this._dia <= 29)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    if ((this._mes >= 01 && this._mes <= 12) &&
                        (this._dia >= 01 && this._dia <= this.vetMes[this._mes - 1]))
                    {
                        return true;
                    }
                    else
                        return false;
                }
            else
            {
                if (this._ano >= 0000)
                {
                    if (this._mes == 2 && this._dia <= 28)
                    {
                        return true;
                    }
                    else if (this._mes >= 01 && this.mes <= 12)
                    {

                        if (this._dia >= 01 && this._dia <= this.vetMes[this._mes - 1])
                        {
                            return true;
                        }
                    }
                }

                else
                    return false;
            }
            return false;
        }

        //public void AdicionarDias(int n)
        //{
        //    this.dia = (this.dia + n);
        //    if (this.dia > 31)
        //    {
        //        this.dia = this.dia - 31;
        //        this.mes = this.mes + 1;
        //        if (this.mes > 12)
        //        {
        //            this.mes = 1;
        //            this.ano = this.ano + 1;
        //        }
        //    }
        //    Console.WriteLine("A nova data será: {0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
        //}

        public bool AnoBisexto()
        {
            if ((this._ano % 4 == 0) &&
            (this._ano % 100 != 0))
            {
                return true;
            }
            
            else
                return false;
        }

        public void DiaAno()
        {
            int somaMes = 0;

            if (AnoBisexto())
            {
                for (int i = 1; i < this._mes; i++)
                {
                    somaMes = somaMes + this.vetMesBi[i-1];
                }
                somaMes = somaMes + this._dia;
                Console.WriteLine("Esse é o " + somaMes + "º dia do ano.");
                Console.ReadKey();
            }
            else
            {
                for (int j = 1; j < this._mes; j++)
                {
                    somaMes = somaMes + this.vetMes[j-1];
                }
                somaMes = somaMes + this._dia;
                Console.WriteLine("Esse é o " + somaMes + "º dia do ano.");
                Console.ReadKey();
            }

        }

        //Falta fazer
        public void AdicionarDias()
        {
            Console.WriteLine("Quantos dias deseja somar a data? ");
            int n = int.Parse(Console.ReadLine());

            if (VerificarData())
            {
                for (int i = 0; i < n; i++)
                {
                    if(this._mes == 12 && this.AnoBisexto() && this._dia == 28)
                    {
                        this._dia++;
                    }
                        
                    if (this._mes == 12 && this._dia == this.vetMes[this._mes - 1])
                    {
                        this._dia ++;
                        this._mes = 1;
                        this._ano = 1;
                    }

                    else if (this._dia == this.vetMes[this._mes - 1])
                    {
                        this._dia = 1;
                        this._mes ++;
                    }

                    else
                    {
                        this._dia++;
                    }
                }
                Console.WriteLine("A nova data será: {0:D2}/{1:D2}/{2:D4}", _dia, _mes, _ano);
            }
            else
            Console.WriteLine("A data informada está incorreta.");
        }

        public void DiferençaDias()
        {
            int difAnos = 0;
            int difMeses = 0;
            int difDias = 0;

            Console.WriteLine("Qual a data desejada para o calculo? ");
            Console.WriteLine("\nInsira o dia: ");
            int numd = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o mês: ");
            int numm = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o ano: ");
            int numa = int.Parse(Console.ReadLine());

            if (VerificarData())
            {
                if (numd > _dia && numm > _mes && numa > _ano)
                {
                    if((numa - _ano) > 0)
                    {
                        difAnos = numa - _ano;
                    }
                    if ((numm - _mes) > 0)
                    {
                        difMeses = numm - _mes;
                    }
                    if((numd - _dia) > 0)
                    {
                        difDias = numd - _dia;
                    }
                    Console.WriteLine("A diferença é de "+difAnos+" anos, "+difMeses+" meses e "+difDias+" dias.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Data é menor que a atual.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Data inválida.");
                Console.ReadKey();
            }
        }

    }
}
