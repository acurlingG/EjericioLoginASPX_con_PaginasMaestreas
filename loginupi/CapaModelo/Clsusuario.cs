using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace loginupi
{
    public class Clsusuario
    {
        // atributos de la clase usuario
        private static int id;
        private static string usuario;
        private static string clave;

        // inicializar a los atributos de la clase
        public Clsusuario(string usuario, string clave)
        {
            usuario = usuario;
            clave = clave;
        }

        // getter y setter = Get = obtener un valor y Set para asignar
        
        public static string Getusuario()
        { 
            return usuario; 
        }
        
        public static void SetUsuario(string nombre)
        { 
            usuario = nombre;
        }

        public static string Getclave()
        {
            return clave;
        }

        public static void Setclave(string contrasenia)
        {
            clave = contrasenia;
        }



        public static int Getid()
        {
            return id;
        }

        public static void Setid(int usuarioid)
        {
            id = usuarioid;
        }

    }
}