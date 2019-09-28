using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._4_Boolean
{
    class Booleano
    {
        public void Executa()
        {
            Console.WriteLine("Boolean");
            double a = 10;
            double b = 20;
            double resultado = a + b;
            Console.WriteLine($"Valor igual: {(resultado==30)}");

            ExibeBoolean();
        }

        private static void ExibeBoolean()
        {
            Console.WriteLine("Boolean");
            double a = 10;
            double b = 20;
            double resultado = a + b;
            Console.WriteLine($"Valor igual: {resultado}");
            //bool checagem = resultado == 30;
            //string checagem = resultado == 30 ? "Sim" : "Não";
            Console.WriteLine($"Valor resultado = 30 - { (resultado == 30 ? "Sim" : "Não") }");
            Console.WriteLine($"Valor resultado = 30 - { (resultado == 30) }");
        }
    }
}
