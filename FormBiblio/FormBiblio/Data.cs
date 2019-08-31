using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBiblio
{
    public class Data
    {
        private int _dia;
        public int dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        private int _mes;
        public int mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        private int _ano;
        public int ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        private int[] diasMesBi = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int[] diasMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// Construtor data.
        /// </summary>
        /// <param name="d">dia</param>
        /// <param name="m">mês</param>
        /// <param name="a">ano</param>
        public Data(int d, int m, int a)
        {
            if (a > 0)
            {
                this.ano = a;

                if (m > 0 && m <= 12)
                {
                    this.mes = m;

                    if (d <= this.diasMesBi[m] && this.Bissexto())
                    {
                        this.dia = d;
                    }
                    if (this.dia <= this.diasMes[m])
                    {
                        this.dia = d;
                    }
                }
            }
        }

        /// <summary>
        /// Checar se é bissexto
        /// </summary>
        /// <returns>true se o ano for bissexto</returns>
        private bool Bissexto()
        {
            if (this.ano % 400 == 0 || (this.ano % 4 == 0 && this.ano % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Metodo para validar data.
        /// </summary>
        /// <returns>Validar data</returns>
        public bool ValidarData()
        {
            if (this.ano > 0)
            {
                if (this.mes > 0 && this.mes <= 12)
                {
                    if (this.dia <= this.diasMesBi[this.mes] && this.Bissexto())
                    {
                        return true;
                    }
                    if (this.dia <= this.diasMes[this.mes])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// Metodo para adicionar dias.
        /// </summary>
        /// <param name="a">Informe o quantos dias quer passar</param>
        public void AdicionarDias(int a)
        {
            this.dia = this.dia + a;

            if (this.Bissexto())
            {
                while (this.dia > this.diasMesBi[this.mes])
                {
                    this.dia = this.dia - this.diasMesBi[this.mes];
                    this.mes++;
                    if (this.mes == 13)
                    {
                        this.ano++;
                        this.mes = 1;
                    }

                }


            }
            else
            {
                while (this.dia > this.diasMes[this.mes])
                {

                    this.dia = this.dia - this.diasMes[this.mes];
                    this.mes++;
                    if (this.mes == 13)
                    {
                        this.ano++;
                        this.mes = 1;
                    }

                }
            }


        }

        /// <summary>
        /// Metodo para imprimir a data.
        /// </summary>
        public string ImprimirData()
        {
            string resposta = this.dia + "/" + this.mes + "/" + this.ano;
            return resposta;
        }

        /// <summary>
        /// Metodo para comparar duas datas
        /// </summary>
        /// <param name="dataAtual">Data um (pode ser a data atual)</param>
        /// <param name="novo1">Data dois(data que deseja fazer)</param>
        /// <returns></returns>
        public int VerDuasDatas(Data dataAtual, Data novo1)
        {
            int condicao = 0;
            int resultado_dias = 0;

            if (novo1.ano > dataAtual.ano)
            {
                while (condicao == 0)
                {
                    dataAtual.ano++;
                    if (novo1.ano == dataAtual.ano)
                    {
                        condicao = 1;
                    }
                    resultado_dias = resultado_dias + 365;
                }
                if (novo1.mes > dataAtual.mes)
                {
                    for (int j = dataAtual.mes; j < novo1.mes; j++)
                    {
                        resultado_dias = resultado_dias + diasMes[j];
                    }
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }
                }
                else if (novo1.mes < dataAtual.mes)
                {
                    for (int j = novo1.mes; j < dataAtual.mes; j++)
                    {
                        resultado_dias = resultado_dias + diasMes[j];
                    }
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }

                }
                else
                {
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }
                }
            }
            else if (novo1.ano < dataAtual.ano)
            {
                while (condicao == 0)
                {
                    novo1.ano++;
                    if (novo1.ano == dataAtual.ano)
                    {
                        condicao = 1;
                    }
                    resultado_dias = resultado_dias + 365;

                }
                if (novo1.mes > dataAtual.mes)
                {
                    for (int j = dataAtual.mes; j < novo1.mes; j++)
                    {
                        resultado_dias = resultado_dias + diasMes[j];
                    }
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }
                }
                else if (novo1.mes < dataAtual.mes)
                {
                    for (int j = novo1.mes; j < dataAtual.mes; j++)
                    {
                        resultado_dias = resultado_dias + diasMes[j];
                    }
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }

                }
                else
                {
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }
                }


            }
            else
            {
                if (novo1.mes > dataAtual.mes)
                {
                    for (int j = dataAtual.mes; j < novo1.mes; j++)
                    {
                        resultado_dias = resultado_dias + diasMes[j];
                    }
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }
                }
                else if (novo1.mes < dataAtual.mes)
                {
                    for (int j = novo1.mes; j < dataAtual.mes; j++)
                    {
                        resultado_dias = resultado_dias + diasMes[j];
                    }
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }

                }
                else
                {
                    if (novo1.dia > dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (novo1.dia - dataAtual.dia));
                    }
                    else if (novo1.dia < dataAtual.dia)
                    {
                        resultado_dias = (resultado_dias + (dataAtual.dia - novo1.dia));
                    }
                    else
                    {
                        resultado_dias = resultado_dias + 0;
                    }
                }

            }

            return resultado_dias;

        }

    }
}
