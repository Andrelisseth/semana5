using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaZapa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] catalogo = new string[4, 4] {
      {"Sandalias","Prada", "50", "10%"},
      {"Deportivos","Adida", "40", "20%"},
      {"Zapatillas"," Louboutin.", "79", "15%"},
      {"Botas","Jordan", "44", "25%"}
    };

            string[] tiendas = new string[] { "Tienda 1", "Tienda 2", "Tienda 3" };


            Console.WriteLine("Seleccione la tienda de su preferencia:");
            for (int i = 0; i < tiendas.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, tiendas[i]);
            }


            int tiendaSeleccionada = int.Parse(Console.ReadLine()) - 1;


            Console.WriteLine("Catálogo de zapatos para {0}:", tiendas[tiendaSeleccionada]);
            Console.WriteLine("Estilo\tMarca\tTalla\tDescuento");
            for (int i = 0; i < catalogo.GetLength(0); i++)
            {
                Console.WriteLine("{0} \t{1}\t{2}\t{3}", catalogo[i, 0], catalogo[i, 1], catalogo[i, 2], catalogo[i, 3]);
            }


            Console.WriteLine("Seleccione el zapato que desea:");
            int zapatoSeleccionado = int.Parse(Console.ReadLine()) - 1;



            Console.WriteLine("Su compra a sido realizada con exito {0} {1} talla {2} con el descuento del {3} en {4}.", catalogo[zapatoSeleccionado, 0], catalogo[zapatoSeleccionado, 1], catalogo[zapatoSeleccionado, 2], catalogo[zapatoSeleccionado, 3], tiendas[tiendaSeleccionada]);
            Console.ReadKey();
        }
    }

}