using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Domain.Entites
{
    public class TransacaoPix
    {
        public int Id { get; set; }
        public int PagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }
        public int ChavePixId { get; set; }
        public virtual ChavePix ChavePix { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}
