using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginupi.CapaModelo
{
    public class ClsProducto
    {

   
        public int codigo;

        public string nombre;
        public float precio;
        public float iva {  get; private set; }


        public ClsProducto(int codigo, string nombre, float precio, float iva)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.iva = iva;
        }

        public ClsProducto()
        {
            this.codigo = 1;
            this.nombre = "nombre";
            this.precio = 10;
            this.iva = 13.0f;
        }

       
    }
}