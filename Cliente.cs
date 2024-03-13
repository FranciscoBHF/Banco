using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public int cuit {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public float saldo {get; set;}
        
        public Cliente(int cuit, string nombre, string apellido, float saldo)
            =>(Cuit, Nombre, Apellido, Saldo) = (cuit, nombre, apellido, saldo) 
    }
}