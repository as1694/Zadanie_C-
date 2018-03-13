using System;

namespace Zadanie_konsola
{
    enum What
    {
        imię = 1, nazwisko = 2, adres = 3, telefon = 4
    };

    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            byte counter = 1;
            char decision = 's';
            String value = null;

            while(counter<5)
            {
                if (data.Get(counter) == null || decision == 's' || decision == 'S')
                {
                    data.Write();
                    Console.WriteLine("Podaj " + (What)counter + ":");
                    value = Console.ReadLine();
                    data.Set(counter, value);
                }

                Console.Clear();
                data.Write();

                if (counter==4)
                    Console.WriteLine("Zmień "+(What)counter+ " (S)\nWstecz (B)\nKoniec (N)");
                else if (counter>1)
                    Console.WriteLine("Zmień " + (What)counter + " (S)\nWstecz (B)\nDalej (N)");
                else
                    Console.WriteLine("Zmień " + (What)counter + " (S)\nDalej (N)");

                decision = Console.ReadKey().KeyChar;
                if(decision == 's' || decision == 'S')
                {
                    Console.Clear();
                    continue;
                }
                else if (counter > 1 && decision == 'b' || decision == 'B')
                    counter--;
                else if (decision == 'n' || decision == 'N')
                    counter++;

                Console.Clear();
            }

            Console.WriteLine("Twoje dane:" + "\n");
            data.Write();
            Console.WriteLine("Naciśnij dowolny przycisk, by zakończyć.");
            decision = Console.ReadKey().KeyChar;
        }
    }
}
