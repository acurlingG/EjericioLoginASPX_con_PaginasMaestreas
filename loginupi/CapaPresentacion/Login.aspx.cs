﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginupi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {

           
        }


        private void ValidarLogin(String Usuario, string Clave)
        {
            Clsusuario.SetUsuario(Usuario);
            Clsusuario.Setclave(Clave);
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select usuario, clave from login where usuario = '" + Clsusuario.Getusuario()+ "' " +
                "and clave = '" + Clsusuario.Getclave() + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Response.Redirect("inicio.aspx");
            }
            else
            {
                //lmensaje.Text = " usuario o contraseña incorrecto";

                MostrarAlerta(this, "usuario o contraseña incorrecto");
            }
            conexion.Close();


        }

            public static void MostrarAlerta(Page page, string message)
            {
                string script = $"<script type='text/javascript'>alert('{message}');</script>";
                ClientScriptManager cs = page.ClientScript;
                cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
            }
   
        protected void bingresar_Click1(object sender, EventArgs e)
        {
            ValidarLogin(tusuario.Text, tclave.Text);
        }
    }
}