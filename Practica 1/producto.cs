using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class producto
    {
        //Variables de la clase
        public int codigo;
        public string nombre;
        public double precio;
        public int cantidad;


        public int Codigo { set; get; }
        public string Nombre { set; get; }
        public double Precio { set; get; }
        public int Cantidad { set; get; }

        //Constructor
        public producto()
        {
            this.codigo = 0;
            this.nombre = string.Empty;
            this.precio = 0;
            this.cantidad = 0;
        }

        //Funciones

    }
}
