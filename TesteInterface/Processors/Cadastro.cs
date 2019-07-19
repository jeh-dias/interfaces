using System;
using System.Collections.Generic;
using System.Text;
using TesteInterface.Domain;

namespace TesteInterface.Processors
{
    public class Cadastro : ICadastro
    {
        public void Insere(Cliente cliente)
        {
            Console.WriteLine("Cadastro 1 realizado com sucesso! ");
        }
    }
}
