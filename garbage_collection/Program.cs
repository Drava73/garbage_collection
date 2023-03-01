using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Piessa[] obj1 = new Piessa[30];
            for (int i = 0; i < 30; i++) { };
            Piessa obj = new Piessa("Ревизор", "Николай Гоголь","Комедия", "1836");
            obj.Print();
            obj.Dispos();
            Store st1 = new Store("Silpo", "Derebon", "Odiag");
            st1.Print();
            st1.Dispos();
            Console.Read();
        }
    }
}
