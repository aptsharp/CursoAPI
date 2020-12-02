using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.API.Models
{
    public class ValidaCampoViewModel
    {
        public IEnumerable<string> Erros { get; private set; }


        public ValidaCampoViewModel(IEnumerable<string> erros)
        {
            Erros = erros;
        }

    }
}
