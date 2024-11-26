using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Application.ViewModel
{
    public class NovoAcoesViewModel
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Pm { get; set; }
        public decimal PmIr { get; set; }
        public decimal Dividendos { get; set; }
        public decimal TotalInv { get; set; }
    }
}
