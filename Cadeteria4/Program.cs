using System;
using System.Collections.Generic;

namespace Cadeteria4
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;            
            Console.WriteLine("Nombre de empresa: ");
            Cadeteria cadeteria = Helper.cargarCadeteria(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de cadetes disponibles hoy: ");
            cadeteria.Cadetes = Helper.cargarCadetes(Convert.ToInt32(Console.ReadLine()));//cargamos cadetes a la cadeteria
            do {
                Console.WriteLine("1 Informe Simplificado\n2 Empleado del dia\n3 Promedio Entregados\n4 Listado Total\n0 SALIR!!!:");
                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    cadeteria.informeSimple(cadeteria.Cadetes);
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Helper.mostrarEmpleados(cadeteria.empleadoDelDia(cadeteria.Cadetes));
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Promedio entregados: {0}",cadeteria.promedioEntregados(cadeteria.Cadetes));
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Helper.mostrarDetallesDelDia(cadeteria.Cadetes);
                }
            } while (op != 0);
        }
    }//podemos cargar la lista de cadetes vacia, la cual incluiria la lista de pedidos vacia, y la cual cada pedido tendria un cliente vacio
}
