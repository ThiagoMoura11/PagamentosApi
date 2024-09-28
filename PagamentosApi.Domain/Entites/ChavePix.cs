using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Domain.Entites
{
    public class ChavePix
    {
        public int Id { get; set; }
        public string TipoChave { get; set; } 
        public string ValorChave { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
