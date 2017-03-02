using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15Capitulos10_12Aplicada1
{
    //Programar el método ToString() para la clase polígono.

    public class Poligono3
    {
        public int NumeroLados { get; set; }
        public int NumeroVertices { get; set; }

        public Poligono3()
        {

        }

        public Poligono3(int numeroLados, int numeroVertices)
        {
            NumeroLados = numeroLados;
            NumeroVertices = numeroVertices;
        }

        public override string ToString()
        {
            return "Numero Lados: " + NumeroLados + " , Numero Vertices: " + NumeroVertices;
        }
    }
}
