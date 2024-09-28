using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Application.ViewModel.Response
{
    public class ChavePixResponse
    {
        public int Id { get; set; }
        public string TipoChave { get; set; }
        public string ValorChave { get; set; }
        public int ClienteId { get; set; }
    }

}
