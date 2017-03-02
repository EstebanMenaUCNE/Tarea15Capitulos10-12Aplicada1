using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15Capitulos10_12Aplicada1
{
    //Crear una clase para polígonos con sobrecarga del constructor.

    public class Poligono
    {
        public int NumeroLados { get; set; }
        public int NumeroVertices { get; set; }

        public Poligono()
        {

        }

        public Poligono(int numeroLados, int numeroVertices)
        {
            NumeroLados = numeroLados;
            NumeroVertices = numeroVertices;
        }
    }
}
