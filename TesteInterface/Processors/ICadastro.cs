using System;
using System.Collections.Generic;
using System.Text;
using TesteInterface.Domain;

namespace TesteInterface.Processors
{
    public interface ICadastro
    {
        void Insere(Cliente cliente);
    }
}
