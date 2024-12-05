using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Domain.Models.Command
{
    public class AtualizarUsuariosCommand
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
