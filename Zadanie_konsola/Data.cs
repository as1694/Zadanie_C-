using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_konsola
{
    public class Data
    {
        public String Name
        {
            get;
            private set;
        }

        public String Surname
        {
            get;
            private set;
        }

        public String Adress
        {
            get;
            private set;
        }

        public String Phone
        {
            get;
            private set;
        }

        public Data()
        {
            Name = null;
            Surname = null;
            Adress = null;
            Phone = null;
        }

        public void Set(byte what, String value)
        {
            switch (what)
            {
                case 1: Name = value; break;
                case 2: Surname = value; break;
                case 3: Adress = value; break;
                case 4: Phone = value; break;
                default: Console.WriteLine("Błąd"); break;
            }
        }

        public void Write()
        {
            Console.WriteLine("Imię: " + Name);
            Console.WriteLine("Nazwisko: " + Surname);
            Console.WriteLine("Adres: " + Adress);
            Console.WriteLine("Telefon: " + Phone);
            Console.WriteLine();
        }

    }
}
