using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingTutorial.WinformUI2
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }        

        public void Guardar()
        {
            Console.WriteLine("Valores Guardados: Nombre :" + this.Nombre + " Apellidos: " + this.Nombre);
        }
    }
}
