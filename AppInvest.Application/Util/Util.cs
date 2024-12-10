using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppInvest.Application.Util
{
    public class Util
    {
        public static bool ValidarEmail(string email)
        {

            if ((email == null) || (email.Length < 4))
                return false;

            var partes = email.Split('@');
            if (partes.Length < 2) return false;

            var pre = partes[0];

            if (pre.Length == 0) return false;

            var validadorPre = new Regex("^[a-zA-Z0-9_.-/+]+$");

            if (!validadorPre.IsMatch(pre))
                return false;

            var partesDoDominio = partes[1].Split(".");
            if (partesDoDominio.Length < 2) return false;

            var validadorDominio = new Regex("^[a-zA-Z0-9-]+$");
            for (int i = 0; i < partesDoDominio.Length; i++)
            {
                var parteDoDominio = partesDoDominio[i];
                if (partesDoDominio.Length == 0) return false;

                if (!validadorDominio.IsMatch(parteDoDominio))
                    return false;
            }

            return true;

        }
    }
}
