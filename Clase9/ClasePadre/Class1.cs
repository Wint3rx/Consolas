using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.ClasePadre
{
    internal class ClsConsole
    {
        public int aniolanzamiento { get; set; }
        public string marca { get; set; }
        public string mostrardetalles()
        {
            return ($"Marca:{marca} anio:{aniolanzamiento}");
        }
    }
}
