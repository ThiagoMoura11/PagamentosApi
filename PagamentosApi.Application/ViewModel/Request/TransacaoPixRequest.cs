using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Application.ViewModel.Request
{
    public class TransacaoPixRequest
    {
        public int PagamentoId { get; set; }
        public int ChavePixId { get; set; }
    }
}
