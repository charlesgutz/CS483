using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula1._2_TiposInteiros
{
    class TiposInteiros
    {
        public void Executa()
        {
            Console.WriteLine("Tipos Inteiros");

            Conversoes();
            ExibeTiposInteiro();
        }

        private static void Conversoes()
        {
            char l = 'C';
            int n = l;
            Console.WriteLine($"Letra: {n}");

            int idM = 381;
            byte idade = (byte)idM;
            Console.WriteLine($"Idade Cliente: {idade}");
        }

        private void ExibeTiposInteiro()
        {
            // ===== char => Char
            Console.WriteLine($"Valor Minimo : {char.MinValue}");
            Console.WriteLine($"Valor Maximo : {char.MaxValue}");

            // ===== byte => Byte
            Console.WriteLine($"Valor Minimo : {byte.MinValue}");
            Console.WriteLine($"Valor Maximo : {byte.MaxValue}");
            // ===== sbyte => Sbyte
            Console.WriteLine($"Valor Minimo : {sbyte.MinValue}");
            Console.WriteLine($"Valor Maximo : {sbyte.MaxValue}");
            
            // ===== short => Int16
            Console.WriteLine($"Valor Minimo : {short.MinValue}");
            Console.WriteLine($"Valor Maximo : {short.MaxValue}");
            // ===== ushort => UInt16
            Console.WriteLine($"Valor Minimo : {ushort.MinValue}");
            Console.WriteLine($"Valor Maximo : {ushort.MaxValue}");

            // ===== int => Int32
            Console.WriteLine($"Valor Minimo : {int.MinValue}");
            Console.WriteLine($"Valor Maximo : {int.MaxValue}");
            // ===== uint => UInt32
            Console.WriteLine($"Valor Minimo : {uint.MinValue}");
            Console.WriteLine($"Valor Maximo : {uint.MaxValue}");

            // ===== long => Int64
            Console.WriteLine($"Valor Minimo : {long.MinValue}");
            Console.WriteLine($"Valor Maximo : {long.MaxValue}");
            // ===== ulong => UInt64
            Console.WriteLine($"Valor Minimo : {ulong.MinValue}");
            Console.WriteLine($"Valor Maximo : {ulong.MaxValue}");


        }
    }
}
