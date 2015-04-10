using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Salida : System.Web.UI.Page
    {
        //List<Producto> Productos;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Producto prod2 = (Producto)Session["first"];
            List<Producto> Productos = new List<Producto>();
            Productos.Add(prod2);
            foreach (Producto prod in Productos)
            {
                if (prod.getCodigo() == TextBox1.Text)
                {
                    prod.setCantidad(Int32.Parse(TextBox2.Text));
                    break;
                }
            }
        }
    }
}