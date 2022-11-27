using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.
                • Exemplu: citim 3,9,0 Afisam : 9 3 0
             */

            Console.WriteLine("Acest program va afisa 3 numere in ordine descrescatoare");

            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            int z = int.Parse(Console.ReadLine());

            int[] nums = { x, y, z };

            Array.Sort(nums);
            Array.Reverse(nums);

            Console.WriteLine(string.Join('\n', nums));
        }
    }
}
