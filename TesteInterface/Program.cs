using System;
using TesteInterface.Domain;
using TesteInterface.Processors;

namespace TesteInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var valida = new Valida();
            var cadastro = new Cadastro();

            var clienteManager = new ClienteManager(cadastro, valida);
            var cliente1 = new Cliente
            {
                Cpf = "343434",
                Nome = "Jessica"
            };

            clienteManager.Processar(cliente1);
        }
    }
}
