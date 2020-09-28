using System;
using System.Collections.Generic;

namespace Cadeteria4
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Pedidos Ya! - ingrese la cantidad de cadetes del dia de hoy: ");
            op = Convert.ToInt32(Console.ReadLine());
            Cadeteria cadeteria = Helper.cargarCadeteria("Pedidos Ya!");
            cadeteria.Cadetes = Helper.cargarCadetes(op);//cargamos cadetes a la cadeteria
            Helper.mostrarDetallesDelDia(cadeteria.Cadetes);
        }
    }//podemos cargar la lista de cadetes vacia, la cual incluiria la lista de pedidos vacia, y la cual cada pedido tendria un cliente vacio
}
