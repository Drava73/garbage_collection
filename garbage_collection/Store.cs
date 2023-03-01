using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage_collection
{
    class Store: IDisposable
    {
          
        
            public string storename { get; set; }
            public string Address { get; set; }
            public string scvalif { get; set; }

            public Store(string storename, string Address, string scvalif)
            {
                this.storename = storename;
                this.Address = Address;
                this.scvalif = scvalif;
            }
            public void Print()
            {
                Console.Write($"\nName store:{storename}\nAddress:{Address}\nType store:{scvalif}");
            }
            ~Store()
            {
                Console.WriteLine("\nОсвобождение ресурсов.");
                Console.Beep();
            }
        }
    }

