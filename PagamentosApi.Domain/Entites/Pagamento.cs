using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Domain.Entites
{
    public class Pagamento
    {
        public int Id { get; set; }
        public string ChavePix { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
