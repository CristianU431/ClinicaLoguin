using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//namespace
using System.Web.Security;
using System.Data.SqlClient;

namespace SolSeguridad
{
    public partial class frmLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source = localhost; Initial Catalog = PClinica; Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Inicio_Authenticate(object sender, AuthenticateEventArgs e)
        {
            int rol = DropDownList1.SelectedIndex;

            if (rol == 0)
            {

            }
                   
            else if (rol == 1)
                    
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from TMedico where Usuario_idUsuario = '" + Inicio.UserName + "' and contrasenia = '" + Inicio.Password + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //Response.Redirect("/Intranet/frmCliente.aspx");
                    FormsAuthentication.RedirectFromLoginPage(Inicio.UserName, false);
                }
                else
                {
                    Inicio.FailureText = "Datos Incorrectos";
                }
                con.Close();

            }
            else if (rol == 2)
            {
                
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select * from TPaciente where usuario = '" + Inicio.UserName + "' and contrasenia = '" + Inicio.Password + "'", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.HasRows)
                {
                    
                    
                    Response.Redirect("frmPaciente.aspx");
                }
                else
                {
                    Inicio.FailureText = "Datos Incorrectos";
                }
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}