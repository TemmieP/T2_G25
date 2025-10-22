using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Producto
    {
        // Propiedades públicas para que Form1 pueda acceder a ellas
        public string G25_Nombre { get; set; }
        public string G25_Categoria { get; set; }
        public decimal G25_Precio { get; set; } // Se usa decimal para una precisión mayor con el precio
        public int G25_Cantidad { get; set; }

        // Método para mostrar el producto de forma legible en el ListBox
        public override string ToString()
        {
         
            return $"{G25_Nombre} - Cat: {G25_Categoria} - Precio: S/.{G25_Precio} - Stock: {G25_Cantidad}";
        }
    }
}
