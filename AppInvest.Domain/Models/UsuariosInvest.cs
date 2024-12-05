using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInvest.Domain.Models;

public class UsuariosInvest
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public UsuariosInvest(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void Atualizar(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }


}
