﻿using Descuentos.Entites__clases_;
using System;
using System.Net.Http;

namespace Descuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.PedirDatos();
        }
    }
}
