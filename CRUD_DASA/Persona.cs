using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DASA
{
    public class Persona
    {
        public int  id { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }

        public decimal precio { get; set; }

        public int stock { get; set; }

        public Persona() { }

        public Persona(int id, string nombre, string tipo, string marca, decimal precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
