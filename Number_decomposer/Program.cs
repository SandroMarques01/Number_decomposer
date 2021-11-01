using Number_decomposer_service.Interfaces;
using Number_decomposer_service.Services;
using System;
using System.Collections.Generic;

namespace Number_decomposer
{
    public class Program
    {
        private INumberService numberService;
        public Program(INumberService numberService)
        {
            this.numberService = numberService;
        }

        static void Main(string[] args)
        {
            NumberService number = new NumberService(); 
            Program program = new Program(number);

            int valor = Convert.ToInt32(Console.Read());

            program.getDivisoresPrimos(valor);
        }

        public void getDivisoresPrimos(int valor)
        {
            List<List<int>> retorno = numberService.GetTechnicalChallenge(valor);

            List<int> divisores = retorno[0];
            List<int> primos = retorno[1];

            divisores.ForEach(f => Console.Write(f + ", "));
            Console.WriteLine();
            primos.ForEach(f => Console.Write(f + ", "));
        }
    }
}
