using System;
using System.Collections.Generic;
using System.Text;

namespace TesteInterface.Processors
{
    public class Valida : IValida
    {
        public bool ValidaCpf(string cpf)
        {
            Console.WriteLine("Cfp está validado! ");
            return true;
        }
    }
}
