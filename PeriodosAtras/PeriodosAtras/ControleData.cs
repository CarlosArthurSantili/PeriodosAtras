using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    public class ControleData
    {
        DateTime dataRecebida;
        DateTime dataAtual = new DateTime(2021, 05, 26, 13, 30, 00);

        public ControleData(DateTime dataRecebida)
        {
            this.dataRecebida = dataRecebida;
        }

        public bool ValidaControleData() 
        {
            if ((100 > dataAtual.Year - dataRecebida.Year) && (dataAtual > dataRecebida))
                return true;
            else
                return false;
        }

        public int GetSegundosPassados()
        {
            int segundosPassados;
            if (dataAtual.Second >= dataRecebida.Second)
                segundosPassados = (dataAtual.Second - dataRecebida.Second);
            else
                segundosPassados = (dataAtual.Second - dataRecebida.Second + 60);
            return segundosPassados;
        }

        public bool GetSegundosVariante() 
        {
            if (dataAtual.Second >= dataRecebida.Second)
                return false;
            else
                return true;
        }

        public int GetMinutosPassados()
        {
            int minutosPassados;
            if (dataAtual.Minute >= dataRecebida.Minute)
                minutosPassados = (dataAtual.Minute - dataRecebida.Minute);
            else
                minutosPassados = (dataAtual.Minute - dataRecebida.Minute + 60);
            if (GetSegundosVariante())
                minutosPassados--;
            return minutosPassados;
        }

        public bool GetMinutosVariante()
        {
            if (dataAtual.Minute >= dataRecebida.Minute)
                return false;
            else
                return true;
        }

        public int GetHorasPassadas()
        {
            int horasPassadas;
            if (dataAtual.Hour >= dataRecebida.Hour)
                horasPassadas = (dataAtual.Hour - dataRecebida.Hour);
            else
                horasPassadas = (dataAtual.Hour - dataRecebida.Hour + 24);
            if (GetMinutosVariante())
                horasPassadas--;
            return horasPassadas;
        }

        public bool GetHorasVariante()
        {
            if (dataAtual.Hour >= dataRecebida.Hour)
                return false;
            else
                return true;
        }

        public int GetDiasPassados() 
        {
            int diasPassados;
            if (dataAtual.Day >= dataRecebida.Day)
                diasPassados = (dataAtual.Day - dataRecebida.Day);
            else
                diasPassados = (dataAtual.Day - dataRecebida.Day + 30);
            if (GetHorasVariante())
                diasPassados--;
            diasPassados = diasPassados % 7;
            return diasPassados;
        }

        public bool GetDiasVariante()
        {
            if (dataAtual.Day >= dataRecebida.Day)
                return true;
            else
                return false;
        }

        public int GetSemanasPassadas() 
        {
            int diasPassados;
            if (dataAtual.Day >= dataRecebida.Day)
                diasPassados = (dataAtual.Day - dataRecebida.Day);
            else
                diasPassados = (dataAtual.Day - dataRecebida.Day - +30);

            int semanasPassadas = diasPassados / 7;
            return semanasPassadas;
        }

        public int GetMesesPassados() 
        {
            int mesesPassados;
            if (dataAtual.Month >= dataRecebida.Month)
                mesesPassados = (dataAtual.Month - dataRecebida.Month);
            else
                mesesPassados = (dataAtual.Month - dataRecebida.Month + 12);
            return mesesPassados;
        }

        public bool GetMesesVariante() 
        {
            if (dataAtual.Month >= dataRecebida.Month)
                return false;
            else
                return true;
        }

        public int GetAnosPassados()
        {
            int anosPassados = dataAtual.Year - dataRecebida.Year;
            if (GetMesesVariante())
                anosPassados--;
            return anosPassados;
        } 

        public string IntegerParaStringPorExtenso(int numero)
        {
            string resposta = "";
            int unidade = numero % 10;
            int dezena = numero / 10;

            switch (dezena)
            {
                default:
                    {
                        resposta = "";
                        break;
                    }
                case 1:
                    {
                        if (unidade == 0)
                            resposta = "dez";
                        else if (unidade == 1)
                            resposta = "onze";
                        else if (unidade == 2)
                            resposta = "doze";
                        else if (unidade == 3)
                            resposta = "treze";
                        else if (unidade == 4)
                            resposta = "catorze";
                        else if (unidade == 5)
                            resposta = "quinze";
                        else if (unidade == 6)
                            resposta = "dezesseis";
                        else if (unidade == 7)
                            resposta = "dezessete";
                        else if (unidade == 8)
                            resposta = "dezoito";
                        else if (unidade == 9)
                            resposta = "dezenove";
                        break;
                    }
                case 2:
                    {
                        resposta = "vinte";
                        break;
                    }
                case 3:
                    {
                        resposta = "trinta";
                        break;
                    }
                case 4:
                    {
                        resposta = "quarenta";
                        break;
                    }
                case 5:
                    {
                        resposta = "cinquenta";
                        break;
                    }
                case 6:
                    {
                        resposta = "sessenta";
                        break;
                    }
                case 7:
                    {
                        resposta = "setenta";
                        break;
                    }
                case 8:
                    {
                        resposta = "oitenta";
                        break;
                    }
                case 9:
                    {
                        resposta = "noventa";
                        break;
                    }
            }

            if (dezena != 1)
            {
                if ((dezena != 0)&&(unidade != 0))
                    resposta += " e ";

                switch (unidade)
                {
                    default:
                        {
                            resposta += "";
                            break;
                        }
                    case 1:
                        {
                            resposta += "um";
                            break;
                        }
                    case 2:
                        {
                            resposta += "dois";
                            break;
                        }
                    case 3:
                        {
                            resposta += "três";
                            break;
                        }
                    case 4:
                        {
                            resposta += "quatro";
                            break;
                        }
                    case 5:
                        {
                            resposta += "cinco";
                            break;
                        }
                    case 6:
                        {
                            resposta += "seis";
                            break;
                        }
                    case 7:
                        {
                            resposta += "sete";
                            break;
                        }
                    case 8:
                        {
                            resposta += "oito";
                            break;
                        }
                    case 9:
                        {
                            resposta += "nove";
                            break;
                        }
                }
            }

            return resposta;
        }

        public string IntegerParaStringPorExtensoFeminino(int numero)
        {
            string resposta = "";
            int unidade = numero % 10;
            int dezena = numero / 10;

            switch (dezena)
            {
                default:
                    {
                        resposta = "";
                        break;
                    }
                case 1:
                    {
                        if (unidade == 0)
                            resposta = "dez";
                        else if (unidade == 1)
                            resposta = "onze";
                        else if (unidade == 2)
                            resposta = "doze";
                        else if (unidade == 3)
                            resposta = "treze";
                        else if (unidade == 4)
                            resposta = "catorze";
                        else if (unidade == 5)
                            resposta = "quinze";
                        else if (unidade == 6)
                            resposta = "dezesseis";
                        else if (unidade == 7)
                            resposta = "dezessete";
                        else if (unidade == 8)
                            resposta = "dezoito";
                        else if (unidade == 9)
                            resposta = "dezenove";
                        break;
                    }
                case 2:
                    {
                        resposta = "vinte";
                        break;
                    }
                case 3:
                    {
                        resposta = "trinta";
                        break;
                    }
                case 4:
                    {
                        resposta = "quarenta";
                        break;
                    }
                case 5:
                    {
                        resposta = "cinquenta";
                        break;
                    }
                case 6:
                    {
                        resposta = "sessenta";
                        break;
                    }
                case 7:
                    {
                        resposta = "setenta";
                        break;
                    }
                case 8:
                    {
                        resposta = "oitenta";
                        break;
                    }
                case 9:
                    {
                        resposta = "noventa";
                        break;
                    }
            }

            if (dezena != 1)
            {
                if ((dezena != 0) && (unidade != 0))
                    resposta += " e ";

                switch (unidade)
                {
                    default:
                        {
                            resposta += "";
                            break;
                        }
                    case 1:
                        {
                            resposta += "uma";
                            break;
                        }
                    case 2:
                        {
                            resposta += "duas";
                            break;
                        }
                    case 3:
                        {
                            resposta += "três";
                            break;
                        }
                    case 4:
                        {
                            resposta += "quatro";
                            break;
                        }
                    case 5:
                        {
                            resposta += "cinco";
                            break;
                        }
                    case 6:
                        {
                            resposta += "seis";
                            break;
                        }
                    case 7:
                        {
                            resposta += "sete";
                            break;
                        }
                    case 8:
                        {
                            resposta += "oito";
                            break;
                        }
                    case 9:
                        {
                            resposta += "nove";
                            break;
                        }
                }
            }

            return resposta;
        }
        public string RetornarStringSegundos()
        {
            int segundos = GetSegundosPassados();
            string respostaSegundos = IntegerParaStringPorExtenso(segundos);
            if (respostaSegundos != "")
            {
                if (segundos == 1)
                    respostaSegundos += " segundo";
                else
                    respostaSegundos += " segundos";
            }
            return respostaSegundos;
        }

        public string RetornarStringMinutos()
        {
            int minutos = GetMinutosPassados();
            string respostaMinutos = IntegerParaStringPorExtenso(minutos);
            if (respostaMinutos != "")
            {
                if (minutos == 1)
                    respostaMinutos += " minuto";
                else
                    respostaMinutos += " minutos";
            }
            return respostaMinutos;
        }

        public string RetornarStringHoras()
        {
            int horas = GetHorasPassadas();
            string respostaHoras = IntegerParaStringPorExtensoFeminino(horas);
            if (respostaHoras != "")
            {
                if (horas == 1)
                    respostaHoras += " hora";
                else
                    respostaHoras += " horas";
            }
            return respostaHoras;
        }

        public string RetornarStringDias()
        {
            int dias = GetDiasPassados();
            string respostaDias = IntegerParaStringPorExtenso(dias);
            if (respostaDias != "")
            {
                if (dias == 1)
                    respostaDias += " dia";
                else
                    respostaDias += " dias";
            }
            return respostaDias;
        }

        public string RetornarStringSemanas()
        {
            int semanas = GetSemanasPassadas();
            string respostaSemanas = IntegerParaStringPorExtensoFeminino(semanas);
            if (respostaSemanas != "")
            {
                if (semanas == 1)
                    respostaSemanas += " semana";
                else
                    respostaSemanas += " semanas";
            }
            return respostaSemanas;
        }

        public string RetornarStringMeses()
        {
            int meses = GetMesesPassados();
            string respostaMeses = IntegerParaStringPorExtenso(meses);
            if (respostaMeses != "")
            {
                if (meses == 1)
                    respostaMeses += " mês";
                else
                    respostaMeses += " meses";
            }
            return respostaMeses;
        }

        public string RetornarStringAnos()
        {
            int anos = GetAnosPassados();
            string respostaAnos = IntegerParaStringPorExtenso(anos);
            if (respostaAnos != "")
            {
                if (anos == 1)
                    respostaAnos += " ano";
                else
                    respostaAnos += " anos";
            }
            return respostaAnos;
        }

        public string RetornarStringPrimeiraLetraMaiuscula(string numeroPorExtenso)
        {
            string resultado = char.ToUpper(numeroPorExtenso[0]) + numeroPorExtenso.Substring(1);

            return resultado;
        }

        public string CalcularPeriodosAtras()
        {
            string resposta = "";
            
            if (ValidaControleData())
            {
                resposta += RetornarStringAnos();
                if (resposta != "" && RetornarStringMeses() != "")
                    resposta += " e ";
                resposta += RetornarStringMeses();
                if (resposta != "" && RetornarStringSemanas() != "")
                    resposta += " e ";
                resposta += RetornarStringSemanas();
                if (resposta != "" && RetornarStringDias() != "")
                    resposta += " e ";
                resposta += RetornarStringDias();
                
                if (resposta == "")//mostrar horas, minutos e segundos
                {
                    resposta += RetornarStringHoras();
                    if (resposta != "" && RetornarStringMinutos() != "")
                        resposta += " e ";
                    resposta += RetornarStringMinutos();
                    if (resposta != "" && RetornarStringSegundos() != "")
                        resposta += " e ";
                    resposta += RetornarStringSegundos();
                }
                
                resposta += " atrás";
                resposta = RetornarStringPrimeiraLetraMaiuscula(resposta);
            }
            else 
            {
                resposta = "Data Inválida";
            }
            
            return resposta;
        }
    }
}
