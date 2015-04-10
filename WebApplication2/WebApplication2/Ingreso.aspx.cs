using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Ingreso : System.Web.UI.Page
    {
        List<Producto> Productos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto(TextBox1.Text, TextBox4.Text, Int32.Parse(TextBox2.Text), Int32.Parse(TextBox3.Text));
            Productos.Add(prod);
            Session["first"] = prod;
            Server.Transfer("Salida.aspx");
            Server.Transfer("Informacion.aspx");
        }
    }
}