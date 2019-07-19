using System;
using System.Collections.Generic;
using System.Text;
using TesteInterface.Domain;

namespace TesteInterface.Processors
{
    public class ClienteManager
    {
        private readonly IValida _ivalida;
        private readonly ICadastro _icadastro;
        public ClienteManager(ICadastro icadastro,IValida ivalida)
        {
            _ivalida = ivalida;
            _icadastro = icadastro;
        }

        public void Processar(Cliente cliente)
        {
            _icadastro.Insere(cliente);
            _ivalida.ValidaCpf(cliente.Cpf);
        }
    }
}
