using System;
using System.Collections.Generic;
using System.Text;
using TesteInterface.Domain;
using TesteInterface.Processors;

namespace TesteInterface
{
    public class Cadastro2 : ICadastro
    {
        public void Insere(Cliente cliente)
        {
            Console.WriteLine("Cadastro 2 realizado com sucesso! ");
        }
    }
}
