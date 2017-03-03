using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15Capitulos10_12Aplicada1
{
    //Crear una clase para llevar la información de los estudiantes de una escuela.

    public class Estudiante
    {
        public int NumeroOrden { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<int> NotasMensuales { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(int numeroOrden, string nombres, string apellidos, DateTime fechaNacimiento)
        {
            NumeroOrden = numeroOrden;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            NotasMensuales = new List<int>();
        }
    }
}
