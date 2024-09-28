using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Application.ViewModel.Response
{
    public class TransacaoPixResponse
    {
        public int Id { get; set; }
        public int PagamentoId { get; set; }
        public PagamentoResponse Pagamento { get; set; }
        public int ChavePixId { get; set; }
        public ChavePixResponse ChavePix { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}
