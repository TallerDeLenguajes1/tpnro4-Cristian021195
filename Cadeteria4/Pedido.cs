﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria4
{
    enum tipo_pedido
    {
        expres,
        dedicado,
        ecologico
    }
    public class Pedido: Cliente
    {
        //private Random rand = new Random();
        private string numero;
        private string observacion;
        private tipo_pedido tipoPedido;
        private bool estado;
        private bool cupon;
        private Cliente cliente;

        public Pedido(Cliente cliente) {
            this.cliente = cliente;
        }

        public string Numero { get => numero; set => numero = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        internal tipo_pedido TipoPedido { get => tipoPedido; set => tipoPedido = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public bool Cupon { get => cupon; set => cupon = value; }

        public double costo() {
            double estandar = 150;
            if (Cupon) {
                estandar = estandar * 0.9;
            }

            if (tipo_pedido.dedicado == tipoPedido)
            {
                estandar = estandar * 1.3;
            }
            else if (tipo_pedido.ecologico == tipoPedido)
            {
                estandar = estandar * 1.05;
            }
            else if (tipo_pedido.expres == tipoPedido)
            {
                estandar = estandar * 1.25;
            }

            return estandar;
        }
    }
}
