﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15Capitulos10_12Aplicada1
{
    //Crear el diseño de una clase para llevar el inventario de una tienda

    public class Inventario
    {
        public List<Producto> Productos { get; set; }
        public int CantidadProductos { get; set; }
        public float PrecioTotalProductos { get; set; }

        public Inventario()
        {

        }

        public void AgregarProducto(string descripcion, float precio)
        {
            Productos.Add(new Producto(0, descripcion, 0, precio));
        }

        public void EliminarProducto(Producto producto)
        {
            Productos.Remove(producto);
        }

        public class Producto
        {
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public int CantidadExistencia { get; set; }
            public float Precio { get; set; }

            public Producto()
            {

            }

            public Producto(int codigo, string descripcion, int cantidadExistencia, float precio)
            {
                Codigo = codigo;
                Descripcion = descripcion;
                CantidadExistencia = cantidadExistencia;
                Precio = precio;
            }
        }
    }
}
