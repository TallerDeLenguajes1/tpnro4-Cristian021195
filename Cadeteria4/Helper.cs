using System;
using System.Collections.Generic;
using System.Text;
namespace Cadeteria4
{
    static class Helper
    {
        enum tipo_pedido
        {
            expres,
            dedicado,
            ecologico
        }
        //como constantes
        private static double costoPedido = 150;
        //de referencia aleatoria
        private static Random rand = new Random();
        private static string[] _cliente = { "cristian", "ismael", "js", "node", "angular", "mongo" };
        private static string[] _cadete = { "cadete_rojo", "cadete_azul", "cadete_amarillo", "cadete_morado", "cadete_naranja", "cadete_verde" };
        private static string[] _direcciones = { "san luis", "libano", "formosa", "sarmiento", "san martin", "independencia" };
        private static string[] _telefonos = { "+543865332311", "+543256989859", "+543819595986", "+541123659856", "+543863456789", "+39415623515" };
        private static string[] _observaciones = { "tiene perro malo", "porton negro", "roban mucho", "es lejos", "es cerca", "api graph" };
        private static bool estado;
        private static bool cupon;

        //cargar cadeteria
        public static Cadeteria cargarCadeteria(string nombre)
        {
            Cadeteria cadeteria = new Cadeteria(nombre);
            return cadeteria;
        }
        //cargar cadetes
        public static List<Cadete> cargarCadetes(int cant_cadetes)
        {
            List<Cadete> cadetes = new List<Cadete>();

            for (int i = 0; i < cant_cadetes; i++) {
                Cadete cadete = new Cadete();
                cadete.Nombre = _cadete[rand.Next(5)];
                cadete.Direccion = _direcciones[rand.Next(5)];
                cadete.Telefono = _telefonos[rand.Next(5)];
                cadete.Id = "cad-"+rand.Next(1000,10000).ToString();
                cadete.pedidos = cargarPedidos();
                cadetes.Add(cadete);
            }
            return cadetes;
        }
        //cargar pedido
        public static List<Pedido> cargarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            for (int i = 0; i < rand.Next(1,7); i++)
            {
                Cliente cliente = new Cliente();
                Pedido pedido = new Pedido(cliente);
                pedido.Cliente = cargarCliente();
                pedido.Numero = "ped-"+rand.Next(1000, 10000);
                pedido.Observacion = _observaciones[rand.Next(6)];
                pedido.TipoPedido = (Cadeteria4.tipo_pedido)rand.Next(1,4);
                pedido.Cupon = cargarBooleano();
                pedido.Estado = cargarBooleano();
                pedidos.Add(pedido);
            }
            return pedidos;
        }
        public static Cliente cargarCliente() {
            Cliente cliente = new Cliente();
            cliente.Id = "cli-" + rand.Next(1000, 10000);
            cliente.Nombre = _cliente[rand.Next(6)];
            cliente.Direccion = _direcciones[rand.Next(6)];
            cliente.Telefono = _telefonos[rand.Next(6)];

            return cliente;
        }
        public static bool cargarBooleano() {
            int evaluar = rand.Next(2);
            bool res;
            if (evaluar == 1) {
                res = true;
            }
            else { 
                res = false; 
            }
            return res;
        }
        //mostrar cadetes
        public static void mostrarDetallesDelDia(List<Cadete> cadetes) {
            foreach (Cadete cadete in cadetes)
            {
                Console.WriteLine("CADETE: {0} ({1}), direccion: {2}, telefono: {3}\n", cadete.Nombre, cadete.Id, cadete.Direccion, cadete.Telefono);
                foreach (Pedido pedido in cadete.pedidos)
                {
                    Console.WriteLine("\tpedido: ({0}), observacion: {1}, entregado: {2}, tipo: {3}, Costo Total: {4}", pedido.Numero, pedido.Observacion, pedido.Estado, pedido.TipoPedido, pedido.costo());
                    Console.WriteLine("\tcliente: {0} ({1}), direccion: {2}, telefono: {3}", pedido.Cliente.Nombre, pedido.Cliente.Id, pedido.Cliente.Direccion, pedido.Cliente.Telefono);
                    Console.WriteLine("\t-----------------------------------");
                }
                Console.WriteLine("***************************************");
            }
        }
        public static void mostrarEmpleado(Cadete cadete) {
            Console.WriteLine("CADETE: {0} ({1}), direccion: {2}, telefono: {3}\n", cadete.Nombre, cadete.Id, cadete.Direccion, cadete.Telefono);
        }
        public static void mostrarEmpleados(List<Cadete> cadetes)
        {
            foreach (Cadete cadete in cadetes)
            {
                Console.WriteLine("CADETE: {0} ({1}), direccion: {2}, telefono: {3}\n", cadete.Nombre, cadete.Id, cadete.Direccion, cadete.Telefono);
            }
        }
    }
}
