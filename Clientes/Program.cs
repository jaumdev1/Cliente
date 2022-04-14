using Clientes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var clientes = Cliente.LerClientes();
            foreach(Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);

            }

            Console.ReadLine();

            
        }
    }
}
