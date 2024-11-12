using loginupi.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginupi.CapaPresentacion
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }

        }

        private void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Login"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        public static void MostrarAlerta(Page page, string message)
        {
            string script = $"<script type='text/javascript'>alert('{message}');</script>";
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            Clsusuario.Setid(int.Parse(tcodigo.Text));
            Clsusuario.SetUsuario(tnombre.Text);
            Clsusuario.Setclave(tclave.Text);

            Usuario_Logica usuario = new Usuario_Logica();

            if (usuario.Agregar() > 0)
                MostrarAlerta(this, "Usuario ingresado con exito");

            else
                MostrarAlerta(this, "Error al ingresar usuario");

            LlenarGrid();
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            Clsusuario.Setid(int.Parse(tcodigo.Text));
            Clsusuario.SetUsuario(tnombre.Text);
            Clsusuario.Setclave(tclave.Text);

            Usuario_Logica usuario = new Usuario_Logica();

            if (usuario.Borrar() > 0)
                MostrarAlerta(this, "Usuario borrado con exito");
            else
                MostrarAlerta(this, "Error al borrar usuario");

            LlenarGrid();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            Clsusuario.Setid(int.Parse(tcodigo.Text));
            Clsusuario.SetUsuario(tnombre.Text);
            Clsusuario.Setclave(tclave.Text);

            Usuario_Logica usuario = new Usuario_Logica();

            if (usuario.Modifiar() > 0)
                MostrarAlerta(this, "Usuario Modificado con exito");
            else
                MostrarAlerta(this, "Error al Modificar usuario");

            LlenarGrid();
        }
    }
}