using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingTutorial.WinformUI3    
{
    internal class Persona
    {
        private static int lastID = 0;

        public int ID;
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Persona()
        {

        }
        public Persona(string pNombre, string pApellidos)
        {
            ID = ++lastID; 
            Nombre = pNombre;   
            Apellidos = pApellidos;
        }
        public void Guardar()
        {
            Console.WriteLine("Valores Guardados: Nombre :" + this.Nombre + " Apellidos: " + this.Apellidos);
        }
    }
}
