    using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 5
                Se citesc doua numere de la tastatura, x,y.Scrieti un program care va afisa cele doua valori in ordine crescatoare.
                • Exemplu: citim 9,0 Afisam: 0 9 */
            Console.WriteLine("Introduceti primul numar:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            { 
                Console.WriteLine("Numbers in order: "+ y + ' ' + x);
            }
            else if (x < y)
            {
                Console.WriteLine("Numbers in order: "+ x + ' ' + y);
            }    
          

        }
    }
}
