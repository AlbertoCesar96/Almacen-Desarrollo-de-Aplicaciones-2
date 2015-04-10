using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Informacion : System.Web.UI.Page
    {
       //List<Producto> Productos = (List<Producto>)Session["first"];
       protected void Page_Load(object sender, EventArgs e)
        {
           //List<Producto> Productos = (List<Producto>)Session["first"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Producto prod2 = (Producto)Session["first"];
            List<Producto> Productos = new List<Producto>();
            Productos.Add(prod2);
            string codi2 = "";
            foreach (Producto prod in Productos)
            {
                codi2 = prod.getCodigo();
                if (codi2 == TextBox1.Text)
                {
                    TextBox2.Text = prod.getNombre();
                    TextBox4.Text = (prod.getPrecioVenta()).ToString();
                    TextBox3.Text = (prod.getValorNeto()).ToString();
                    TextBox5.Text = (prod.getStock()).ToString();
                    break;
                }
            }
        }
    }
}