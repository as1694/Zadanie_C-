using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            String what = null;

            while(counter<5)
            {
                switch(counter)
                {
                    case 1:
                        {
                            what = "imie";
                            if (data.Name == null || decission == 's' || decission == 'S')
                            {
                                data.Write();
                                Console.WriteLine("Podaj imię:");
                                value = Console.ReadLine();
                                data.Set(counter, value);
                            }
                        } break;
                    case 2:
                        {
                            what = "nazwisko";
                            if (data.Surname == null || decission == 's' || decission == 'S')
                            {
                                data.Write();
                                Console.WriteLine("Podaj nazwisko:");
                                value = Console.ReadLine();
                                data.Set(counter, value);
                            }
                        } break;
                    case 3:
                        {
                            what = "adres";
                            if (data.Adress == null || decission == 's' || decission == 'S')
                            {
                                data.Write();
                                Console.WriteLine("Podaj adres:");
                                value = Console.ReadLine();
                                data.Set(counter, value);
                            }
                        } break;
                    case 4:
                        {
                            what = "telefon";
                            if (data.Phone == null || decission == 's' || decission == 'S')
                            {
                                data.Write();
                                Console.WriteLine("Podaj telefon:");
                                value = Console.ReadLine();
                                data.Set(counter, value);
                            }
                        } break;

                    default:
                        Console.WriteLine("błąd");
                        break;
                }
                Console.Clear();
                data.Write();

                if (counter==4)
                    Console.WriteLine("Koniec (N)/ Wstecz (B)/ Zmień "+what+" (S)");
                else if (counter>1)
                    Console.WriteLine("Dalej (N)/ Wstecz (B)/ Zmień " + what + " (S)");
                else
                    Console.WriteLine("Dalej (N)/ Zmień " + what + " (S)");

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
            Console.Read();
        }
    }
}
