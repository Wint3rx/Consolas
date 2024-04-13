using Clase9.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.ClaseHija
{
    internal class Xbox:ClsConsole
    {
        public bool compatibilidadpc {  get; set; }
        public string Mostrarcompatibilidad()
        {
            return mostrardetalles + " Compatibilidad" + compatibilidadpc;
        }
    }
}
