using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Domain.Models
{
    public class Acoes
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Pm { get; private set; }
        public decimal PmIr { get; private set; }
        public decimal Dividendos { get; private set; }
        public decimal TotalInv { get; private set; }

        public Acoes(string nome, int quantidade, decimal pm, decimal pmIr, decimal dividendos, decimal totalInv)
        {

            Nome = nome;
            Quantidade = quantidade;
            Pm = pm;
            PmIr = pmIr;
            Dividendos = dividendos;
            TotalInv = totalInv;

        }

        public void Atualizar(string nome, int quantidade, decimal pm, decimal pmIr, decimal dividendos, decimal totalInv)
        {
            Nome = nome;
            Quantidade = quantidade;
            Pm = pm;
            PmIr = pmIr;
            Dividendos = dividendos;
            TotalInv = totalInv;

        }

    }
}
