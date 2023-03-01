using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage_collection
{
    class Piessa: IDisposable
    {
        public string piesname { get; set; }
        public string FIO { get; set; }
        public string genre { get; set; }
        public string issue { get; set; }

        public Piessa(string piesname, string FIO, string genre, string issue)
        {
            this.piesname = piesname;
            this.FIO = FIO;
            this.genre = genre;
            this.issue = issue; 
        }
        public void Print()
        {
            Console.Write($"\nName:{piesname}\nFIO:{FIO}\nGenre:{genre}\nYear issue:{issue}");
        }
        ~Piessa()
        {
            Console.WriteLine("\nОсвобождение ресурсов.");
            Console.Beep();
        }
    }
}
