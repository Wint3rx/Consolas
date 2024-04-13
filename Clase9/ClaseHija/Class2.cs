using Clase9.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.ClaseHija
{
    internal class Playstation:ClsConsole
    {
        public string modelocontrolador {  get; set; }
        public String mostrardetallesplay()
        {
            return mostrardetalles() + " Controlador:" + modelocontrolador;
        }
    }
}
