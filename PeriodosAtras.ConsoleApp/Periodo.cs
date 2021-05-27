using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Periodo
    {
        DateTime dataPassada = new DateTime();
        DateTime dataAtual = DateTime.Now;
        Dominio numero = new Dominio();



        public string CalcularPeriodo(DateTime data)
        {
            
            dataPassada = data;
            string diff2 = (dataAtual - dataPassada).TotalDays.ToString();


            int indiceVirgula = diff2.LastIndexOf(",");

            int diff3 = int.Parse(diff2.Substring(0,indiceVirgula));


            return Calculate(diff3);
        }

        public string Calculate(int diff2)
        {
            string result = "";
            int anos = diff2 / 365;
            int meses = diff2 / 30;
            int semanas = diff2 / 7;
            int dias = diff2 / 1;

            if (diff2 == 3650)
                return "Uma década atrás";
            if (diff2 > 3650 && diff2 < 7300)
                return "Mais de uma década atrás";
            if (diff2 >= 7300)
                return "Décadas atrás";


            if (diff2 > 0)
            {
                result = ObterStringPeriodo(diff2, anos, meses, semanas, dias);
                
            }

            else if (dias < 1 && dias >= 0)
            {
                long elapsedTicks = dataAtual.Ticks - dataPassada.Ticks;
                TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);


                result = $"{ elapsedSpan.Hours} horas, { elapsedSpan.Minutes} minutos e {elapsedSpan.Seconds} segundos atrás.";

            }
            return result;

        }

        private string ObterStringPeriodo(int diff2, int anos, int meses, int semanas, int dias)
        {
            string result = "";
            int resto = 0;
            if (anos >= 1)
            {
                resto = diff2 % 365;
                meses = resto / 30;
                resto = resto % 30;
                semanas = resto / 7;
                resto = resto % 7;
                dias = resto;
            }

            else if (meses >= 1)
            {
                resto = diff2 % 30;
                semanas = resto / 7;
                resto = resto % 7;
                dias = resto;
            }

            else if (semanas >= 1)
            {
                resto = diff2 % 7;
                dias = resto;
            }


            string anosPalava = numero.DefinirUnidadesMasculino(anos.ToString());
            string prefixoAnos = numero.DefinirPrefixoAnos(anos);
            string mesesPalava = numero.DefinirUnidadesMasculino(meses.ToString());
            string prefixoMeses = numero.DefinirPrefixoMeses(meses);
            string semanasPalavra = numero.DefinirUnidadesFeminino(semanas.ToString());
            string prefixoSemanas = numero.DefinirPrefixoSemanas(semanas);
            string diasPalavra = numero.DefinirUnidadesMasculino(dias.ToString());
            string prefixoDias = numero.DefinirPrefixoDias(dias);


            if (anos >= 1)
            {
                if (meses >= 1)
                    result = $"{anosPalava} {prefixoAnos} e {mesesPalava} {prefixoMeses} atrás";

                else if (semanas >= 1)
                    result = $"{anosPalava} {prefixoAnos} e {semanasPalavra} {prefixoSemanas} atrás";

                else if (dias >= 1)
                    result = $"{anosPalava} {prefixoAnos} e {diasPalavra} {prefixoDias} atrás";

                else
                    result = $"{anosPalava} {prefixoAnos} atrás";

            }

            else if (meses >= 1)
            {
                if (semanas >= 1)
                    result = $"{mesesPalava} {prefixoMeses} e {semanasPalavra} {prefixoSemanas} atrás";

                else if (dias >= 1)
                    result = $"{mesesPalava} {prefixoMeses} e {diasPalavra} {prefixoDias} atrás";

                else
                    result = $"{mesesPalava} {prefixoMeses} atrás";

            }

            else if (semanas >= 1)
            {
                if (dias >= 1)
                    result = $"{semanasPalavra} {prefixoSemanas} e {diasPalavra} {prefixoDias} atrás";

                else
                    result = $"{semanasPalavra} {prefixoSemanas} atrás";

            }

            else if (dias >= 1)
                result = $"{diasPalavra} {prefixoDias} atrás";

            return result;
        }
    }
}
