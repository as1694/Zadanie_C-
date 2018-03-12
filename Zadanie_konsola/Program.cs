using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum What
{
    imię = 1, nazwisko = 2, adres = 3, telefon = 4
};

namespace Zadanie_konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            byte counter = 1;
            char decission = 's';
            String value = null;

            while(counter<5)
            {
                if (data.Get(counter) == null || decission == 's' || decission == 'S')
                {
                    data.Write();
                    Console.WriteLine("Podaj " + (What)counter + ":");
                    value = Console.ReadLine();
                    data.Set(counter, value);
                }

                Console.Clear();
                data.Write();

                if (counter==4)
                    Console.WriteLine("Koniec (N)/ Wstecz (B)/ Zmień "+(What)counter+" (S)");
                else if (counter>1)
                    Console.WriteLine("Dalej (N)/ Wstecz (B)/ Zmień " + (What)counter + " (S)");
                else
                    Console.WriteLine("Dalej (N)/ Zmień " + (What)counter + " (S)");

                decission = Console.ReadKey().KeyChar;
                if(decission == 's' || decission == 'S')
                {
                    Console.Clear();
                    continue;
                }
                else if (counter > 1 && decission == 'b' || decission == 'B')
                    counter--;
                else if (decission == 'n' || decission == 'N')
                    counter++;
               

                Console.Clear();
            }
            Console.WriteLine("Twoje dane:");
            Console.WriteLine();
            data.Write();
            decission = Console.ReadKey().KeyChar;
        }
    }
}
