using Clase9.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.ClaseHija
{
    internal class Nintendo:ClsConsole
    {
        public bool esportable {  get; set; }
        public string mostrardetallenintendo()
        {
            string detallepadre = mostrardetalles();
            return detallepadre + " " + "Es portable:" + esportable;
        }
    }
}
