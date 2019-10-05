using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._6_Enum
{
    class Enums
    {
        const string d1 = "Segunda";
        const string d2 = "Terça";
        const string d3 = "Quarta";
        const string d4 = "Quinta";
        const string d5 = "Sexta";
        const string d6 = "Sabado";
        const string d7 = "Domingo";
        public void Executar()
        {
            Console.WriteLine("Enums");
            DiasDaSemana mtDt = DiasDaSemana.Segunda | DiasDaSemana.Terca | DiasDaSemana.Quarta;
            Console.WriteLine(mtDt);
        }

        [Flags]
        enum DiasDaSemana
        {
            Segunda = 1 ,
            Terca = 2,
            Quarta = 4,
            Quinta = 8,
            Sexta = 16,
            Sabado = 32,
            Domingo = 64,
        }

    }
}
