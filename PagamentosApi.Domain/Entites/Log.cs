using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosApi.Domain.Entites
{
    namespace GrupoPadraoCheckInApi.Domain.Entities
    {
        public class Log
        {
            public int IdLog { get; set; }              
            public DateTime DataLog { get; set; }       
            public string NivelLog { get; set; }        
            public string MensagemLog { get; set; }     
            public string? ExcecaoLog { get; set; }   
            public string? OrigemLog { get; set; }     
            public string? DadosLog { get; set; }      
        }
    }

}
