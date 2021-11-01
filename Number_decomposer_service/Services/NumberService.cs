using Number_decomposer_service.Interfaces;
using System.Collections.Generic;

namespace Number_decomposer_service.Services
{
    public class NumberService : INumberService
    {

        public List<List<int>> GetTechnicalChallenge(int numero)
        {
            List<int> divisores = new List<int>();
            List<int> primos = new List<int>();
            divisores = GetDivisores(numero);

            if (divisores.Count > 0)
            {
                foreach (var item in divisores)
                {
                    if (GetDivisores(item).Count == 0)
                        primos.Add(item);
                }
            }
            else
            {
                primos.Add(numero);
            }

            divisores.Insert(0, numero);
            divisores.Add(1);

            List<List<int>> result = new List<List<int>>();
            result.Add(divisores);
            result.Add(primos);
            return result;
        }


        private List<int> GetDivisores(int numero)
        {
            List<int> divisores = new List<int>();

            for (int i = numero/2; i > 1; i--)
            {
                if (numero % i == 0)
                    divisores.Add(i);
            }
            return divisores;
        }
    }
}
