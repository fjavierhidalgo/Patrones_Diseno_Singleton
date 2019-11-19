using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            CentroRecogida sedeprinc_emisor1 = CentroRecogida.getInstance();
            CentroRecogida sedeprinc_emisor2 = CentroRecogida.getInstance();

            int grados = 12;
            sedeprinc_emisor1.setTempToledo(grados);
            Console.WriteLine(sedeprinc_emisor1.getTempToledo());

            grados = 15;
            sedeprinc_emisor2.setTempMadrid(grados);
            Console.WriteLine(sedeprinc_emisor2.getTempToledo());
            Console.WriteLine(sedeprinc_emisor2.getTempMadrid());

        }
    }
}
