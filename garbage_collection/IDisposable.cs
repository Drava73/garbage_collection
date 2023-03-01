using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage_collection
{
    class IDisposable
    {
        private bool disp = false;

        public void Dispos()
        {
            Dispos(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispos(bool disposing)
        {
            if (!disp)
            {
                if (disposing)
                {
                    Console.WriteLine("\n\tОбъект уничтожен");
                }
                disp = true;
            }
        }

        
    }
}
