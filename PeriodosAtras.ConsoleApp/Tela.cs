using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class Tela
    {
        Periodo periodo = new Periodo();
        DateTime data = new DateTime();
        public void ReceberEntrada()
        {
            Console.Write("Digite a data passada: ");
            string entrada = Console.ReadLine();
            try
            {
                this.data = DateTime.Parse(entrada);
            }
            catch
            {
                Console.WriteLine("Erro! Entrada nula ou inválida!\nTente novamente...");
                Console.ReadLine();
                Console.Clear();
                ReceberEntrada();
            }
            Console.WriteLine(periodo.CalcularPeriodo(data));
        }
    }
}
