using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL.Pantallas.Formularios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("admi") && txtPass.Text.Equals("1234"))
            {
                Response.Redirect("Mantenimientos.aspx");
                //Mantenimientos Obj = new Mantenimientos();
                //Obj.Visible = true;
            }
            else

            if (txtId.Text.Trim()!= "admi")

            {
                string script = String.Format(@"<script type='text/javascript'>alert('Usuario incorrecto' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
        }
        }
    }
