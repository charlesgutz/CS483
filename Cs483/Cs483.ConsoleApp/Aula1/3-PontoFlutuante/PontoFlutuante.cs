using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._3_PontoFlutuante
{
    class PontoFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Ponto Flutuante");

            Float();
            Double();
            decimal salario = 1050.00m;
            decimal salarioAdicional = 581.00m;
            decimal somaSalario = salario + salarioAdicional;
            Console.WriteLine($"Salario professor: {salario} + Adicional {salarioAdicional} = {somaSalario}");

            ExibirPontoFlutuante();

        }

        private static void Double()
        {
            double vlBeerD = 6.15;
            double vlBeerAD = 2.10;
            double somaD = vlBeerD + vlBeerAD;
            Console.WriteLine($"VlB: {vlBeerD}  +  VlBA: {vlBeerAD} = {somaD}");
            if ((vlBeerD + vlBeerAD) == somaD)
            {
                Console.WriteLine("É igual");
            }
            if (somaD == 8.25)
            {
                Console.WriteLine("Soma igual a 8,25");
            }

            double massaT = 5.972e24;
            Console.WriteLine($"Massa da terra é {massaT}");
        }

        private static void Float()
        {
            float vlBeer = 6.00f;
            float vlBeerA = 2.00f;
            float soma = vlBeer + vlBeerA;
            Console.WriteLine($"VlB: {vlBeer}  +  VlBA: {vlBeerA} = {soma}");
        }

        private static void ExibirPontoFlutuante()
        {
            // ===== float => Single
            Console.WriteLine($"Valor Minimo : {float.MinValue}");
            Console.WriteLine($"Valor Maximo : {float.MaxValue}");

            // ===== double => Double
            Console.WriteLine($"Valor Minimo : {double.MinValue}");
            Console.WriteLine($"Valor Maximo : {double.MaxValue}");

            // ===== decimal => Decimal
            Console.WriteLine($"Valor Minimo : {decimal.MinValue}");
            Console.WriteLine($"Valor Maximo : {decimal.MaxValue}");
        }
    }
}
