using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClase1
{
    public class Estudiante
    {
        private int aId;
        private string aNombre;
        private int aEdad;
        private double aNota;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public int Edad { get { return aEdad; } set { aEdad = value; } }
        public double Nota { get { return aNota; } set { aNota = value; } }

        public override string ToString()
        {
            return "Mi nombre es: " + this.Nombre + " Mi edad es: " + this.Edad + " y mi nota es: " + this.Nota;
        }
        public Estudiante(int pId, string pNombre, int pEdad, double pNota)
        {            
            Id = pId;
            Nombre = pNombre;
            Edad = pEdad;
            Nota = pNota;
        }
    }
}
