using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Classes
{
    public class Cliente
    {
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;   
            this.CPF = cpf;
        }
        public Cliente()
        {
            
        }
        public string Nome;
        public string Telefone;
        public string CPF;


        public void Gravar()
        {

        }
        private static string caminhoBasesClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }
        public static List<Cliente> LerClientes()
        {
            var clientes = new List <Cliente>();

            if (File.Exists(caminhoBasesClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBasesClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;                                           
                        var clienteArquivo = linha.Split(';');
                       // var cliente = new Cliente { Nome = clienteArquivo[0], Telefone= clienteArquivo[1], CPF  = clienteArquivo[2]};
                        var cliente = new Cliente(clienteArquivo[0],clienteArquivo[1], clienteArquivo[2]);
                        clientes.Add(cliente);

                                   
                    }
                }
            }
            
            return clientes;
                       
        }

    }
}
