﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria4
{
    class Cadete: Persona
    {
        public List<Pedido> pedidos = new List<Pedido>();
        public override string Presertarse()
        {
            return "Hola soy un Cadete!";
        }
    }
}
