using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class CentroRecogida
    {

        private static CentroRecogida instancia = new CentroRecogida();
        private int tempToledo = 0;
        private int tempMadrid = 0;

        // El constructor privado evita que se instancie esta clase fuera de la misma
        private CentroRecogida() { }

        public static CentroRecogida getInstance()
        {
            return instancia;
        }

        public int getTempToledo()
        {
            return this.tempToledo;
        }

        public int getTempMadrid()
        {
            return this.tempMadrid;
        }

        public void setTempToledo(int grados)
        {
            this.tempToledo = grados;
        }

        public void setTempMadrid(int grados)
        {
            this.tempMadrid = grados;
        }

    }
}
