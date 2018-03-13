using System;

namespace Zadanie_konsola
{
    public class Data
    {
        String name;
        String surname;
        String address;
        String phone;

        public Data()
        {
            name = null;
            surname = null;
            address = null;
            phone = null;
        }

        public void Set(byte what, String value)
        {
            switch (what)
            {
                case 1: name = value; break;
                case 2: surname = value; break;
                case 3: address = value; break;
                case 4: phone = value; break;
                default: Console.WriteLine("Błąd"); break;
            }
        }

        public String Get(byte what)
        {
            switch (what)
            {
                case 1: return name;
                case 2: return surname;
                case 3: return address;
                case 4: return phone;
                default: return null;
            }
        }

        public void Write()
        {
            Console.WriteLine("Imię [ " + name+" ]");
            Console.WriteLine("Nazwisko [ " + surname + " ]");
            Console.WriteLine("Adres [ " + address + " ]");
            Console.WriteLine("Telefon [ " + phone + " ]\n");
        }
    }
}
