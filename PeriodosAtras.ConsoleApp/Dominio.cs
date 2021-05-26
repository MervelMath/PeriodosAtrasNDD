using System;

namespace PeriodosAtras.ConsoleApp
{
    public class Dominio
    {

        public string DefinirPrefixoAnos(int numero)
        {
            string result = "";
            if (numero == 1)
                result = "ano";

            else if (numero > 1)
                result = "anos";

            return result;
        }

        public string DefinirPrefixoDias(int numero)
        {
            string result = "";
            if (numero == 1)
                result = "dia";

            else if (numero > 1)
                result = "dias";

            return result;
        }

        public string DefinirPrefixoMeses(int numero)
        {
            string result = "";
            if (numero == 1)
                result = "mês";

            else if (numero > 1)
                result = "meses";

            return result;
        }

        public string DefinirPrefixoSemanas(int numero)
        {
            string result = "";
            if (numero == 1)
                result = "semana";

            else if (numero > 1)
                result = "semanas";

            return result;
        }

        public string DefinirUnidadesMasculino(string numero)
        {
            int _numero = Convert.ToInt32(numero);
            String nome = "";
            switch (_numero)
            {
                case 1:
                    nome = "um";
                    break;
                case 2:
                    nome = "dois";
                    break;
                case 3:
                    nome = "três";
                    break;
                case 4:
                    nome = "quatro";
                    break;
                case 5:
                    nome = "cinco";
                    break;
                case 6:
                    nome = "seis";
                    break;
                case 7:
                    nome = "sete";
                    break;
                case 8:
                    nome = "oito";
                    break;
                case 9:
                    nome = "nove";
                    break;
            }
            return nome;
        }

        public string DefinirUnidadesFeminino(string numero)
        {
            int _numero = Convert.ToInt32(numero);
            string nome = "";
            switch (_numero)
            {
                case 1:
                    nome = "uma";
                    break;
                case 2:
                    nome = "duas";
                    break;
                case 3:
                    nome = "três";
                    break;
                case 4:
                    nome = "quatro";
                    break;
                case 5:
                    nome = "cinco";
                    break;
                case 6:
                    nome = "seis";
                    break;
                case 7:
                    nome = "sete";
                    break;
                case 8:
                    nome = "oito";
                    break;
                case 9:
                    nome = "nove";
                    break;
            }
            return nome;
        }
    }
}