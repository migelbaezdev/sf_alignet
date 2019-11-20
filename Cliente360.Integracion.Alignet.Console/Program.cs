using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente360.Integracion.Alignet
{
    class Program
    {
        static void Main(string[] args)
        {
           new IntegracionAlignetManager().Start();         
            Console.Read();
        }
    }
}
