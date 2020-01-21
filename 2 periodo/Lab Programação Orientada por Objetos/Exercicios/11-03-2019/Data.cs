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

        /// <summary>
        /// Imprime a data no console de acordo com o formato DD/MM/AAAA.
        /// </summary>
        public void MostrarData()
        {
            Console.WriteLine("\n{0:D2}/{1:D2}/{2:D4}", _dia, _mes, _ano);
            Console.ReadKey();
        }

        /// <summary>
        /// Verifica se a data inserida pelo usuário é válida ou não.
        /// </summary>
        /// <returns>True ou False</returns>
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

        /// <summary>
        /// Calcula e indica se o ano é bisexto ou não.
        /// </summary>
        /// <returns>True ou False</returns>
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

        /// <summary>
        /// Calcula o dia no ano.
        /// </summary>
        /// <returns>Retorna o dia do ano.</returns>
        public int DiaAno()
        {
            int somaMes = 0;

            if (AnoBisexto())
            {
                for (int i = 1; i < this._mes; i++)
                {
                    somaMes = somaMes + this.vetMesBi[i-1];
                }
                somaMes = somaMes + this._dia;
                return somaMes;
            }
            else
            {
                for (int j = 1; j < this._mes; j++)
                {
                    somaMes = somaMes + this.vetMes[j-1];
                }
                somaMes = somaMes + this._dia;
                return somaMes;
            }

        }

        /// <summary>
        /// Soma a qtd de dias que o usuario entra a data atual.
        /// </summary>
        /// <param name="n">Número de dias a ser adicionado</param>
        public void AdicionarDias(int n)
        {
            if (VerificarData())
            {
                for (int i = 0; i < n; i++)
                {
                    if (this.AnoBisexto())
                    {
                        if ((_mes == 12) && 
                            (this._dia == vetMesBi[_mes - 1] ))
                        {
                            _dia = 00;
                            _dia++;
                            _mes = 01;
                            _ano++;
                        }
                        else
                        {
                            if (this._dia == vetMesBi[_mes - 1])
                            {
                                _dia = 0;
                                _dia++;
                                _mes++;
                            }

                            else
                            {
                                _dia++;
                            }
                        }

                    }
                    else
                    {
                        if ((_mes == 12) &&
                            (this._dia == vetMesBi[_mes - 1]))
                        {
                            _dia = 00;
                            _dia++;
                            _mes = 01;
                            _ano++;
                        }
                        else
                        {
                            if (this._dia == vetMesBi[_mes - 1])
                            {
                                _dia = 0;
                                _dia++;
                                _mes++;
                            }

                            else
                            {
                                _dia++;
                            }
                        }

                    }
                }
                this.MostrarData();
            }
            else
            Console.WriteLine("A data informada está incorreta.");
        }

        public int MaiorData(Data dateC1, Data dateC2)
        {
            if (dateC1.ano == dateC2.ano)
            {
                if (dateC1.DiaAno() > dateC2.DiaAno())
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (dateC1.ano > dateC2.ano)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        /// <summary>
        /// Calcula o numero de dias de diferença entre a data atual e a que o usuario irá inserir.
        /// </summary>
        /// <param name="numd">O novo dia para o calculo</param>
        /// <param name="numm">O novo mes para o calculo</param>
        /// <param name="numa">O novo ano para o calculo</param>
        public int DiferençaDias(Data DataCompare1 , Data DataCompare2)
        {

            int difAnos =0;
            int difMes = 0;
            int difDia = 0;

            if (DataCompare1._dia == this._dia && DataCompare1._mes == this._mes && DataCompare1._ano == this._ano)
            {
                return 0;
            }

            if (DataCompare1.ano == DataCompare2.ano)
            {
                difDia = DataCompare1.DiaAno() + DataCompare2.DiaAno();
                return difDia; 
            }

            else
            {
                if(MaiorData(DataCompare1, DataCompare2) == 1)
                {
                    difAnos = DataCompare1.ano - DataCompare2.ano;

                    difDia = DataCompare1.DiaAno() + DataCompare2.DiaAno();

                    difAnos = (difAnos) * 365;

                    difDia = difAnos + difDia;

                    return difDia;
                }

                if (MaiorData(DataCompare1, DataCompare2) == 2)
                {
                    difAnos = DataCompare2.ano - DataCompare1.ano;

                    difDia = DataCompare2.DiaAno() + DataCompare1.DiaAno();

                    difAnos = (difAnos) * 365;

                    difDia = difAnos + difDia;

                    return difDia;
                }

                else
                    return 0; 
            }
            
        }
    }
}
