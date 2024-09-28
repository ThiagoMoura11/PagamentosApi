using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Application.ViewModel.Request
{
    public class PagamentoRequest
    {
        public string ChavePix { get; set; }
        public decimal Valor { get; set; }
    }
}
