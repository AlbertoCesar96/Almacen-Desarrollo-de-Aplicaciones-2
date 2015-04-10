using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Producto
    {
        string nombre, codigo;
        int stock = 0, precioIng, precioVen, incremento;
        double valNet;
        public Producto(string nomb, string cod, int cantEnt, int precIng)
        {
            this.nombre = nomb;
            this.codigo = cod;
            this.stock = cantEnt;
            this.precioIng = precIng;
            if (precIng <= 5)
            {
                incremento = 1;
            }
            if (precIng > 5 && precioIng <= 10)
            {
                incremento = 2;
            }
            if (precIng > 10 && precioIng <= 50)
            {
                incremento = 5;
            }
            if (precIng > 50 && precioIng <= 100)
            {
                incremento = 10;
            }
            if (precIng > 100)
            {
                incremento = 20;
            }
            this.precioVen = precIng + incremento;
            this.valNet = precioVen * stock;
        }
        public string getCodigo() { return this.codigo; }
        public string getNombre() { return nombre; }
        public int getStock() { return this.stock; }
        public int getPrecioVenta() { return this.precioVen; }
        public double getValorNeto() { return this.valNet; }

        /*string nombre, codigo;
    int stock=0, precioIng, precioVen, incremento;
    double valNet;*/
        public void setCantidad(int st) { this.stock = stock - st; }
    }
}