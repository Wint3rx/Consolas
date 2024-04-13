using Clase9.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.ClaseHija
{
    internal class SegaDreamCast:ClsConsole
    {
        public bool pantallaenjoystick {  get; set; }
        public string MostrarPantalla()
        {
            return mostrardetalles() + " Pantalla en Mando: " + pantallaenjoystick;
        }
    }
}
