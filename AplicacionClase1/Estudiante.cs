using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClase1
{
    internal class Estudiante(string pNombre , int pEdad , int pNota)
    {
        public string Nombre { get; set; } = pNombre;

        public int Edad { get; set; } = pEdad;

        public int Nota { get; set; } = pNota;


        public override string ToString()
        {
            return "Mi nombre es: " + this.Nombre + " Mi edad es: " + this.Edad + " y mi nota es: " + this.Nota; 
        }






    }
}
