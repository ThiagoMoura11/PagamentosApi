using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Application.ViewModel.Response
{
    public class PagamentoResponse
    {
        public int Id { get; set; }
        public string ChavePix { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
