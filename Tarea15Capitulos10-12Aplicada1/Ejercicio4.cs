using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15Capitulos10_12Aplicada1
{
    //Crear propiedades para la clase polígono que solamente permitan colocar valores válidos.

    public class Poligono2
    {
        
        public int NumeroLados
        {
            get
            {
                return NumeroLados;
            }
            set
            {
                if (NumeroLados > 0)
                    NumeroLados = value;
            }
        }
        public int NumeroVertices
        {
            get
            {
                return NumeroLados;
            }
            set
            {
                if (NumeroLados > 0)
                    NumeroLados = value;
            }
        }

        public Poligono2()
        {

        }

        public Poligono2(int numeroLados, int numeroVertices)
        {
            NumeroLados = numeroLados;
            NumeroVertices = numeroVertices;
        }

    }
}
