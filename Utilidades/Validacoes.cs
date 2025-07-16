using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cafeteria.Utilidades
{
    internal class Validacoes
    {
        public static bool ValidarCPf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int resto1 = soma1 % 11;
            int digito1 = (resto1 < 2) ? 0 : 11 - resto1;

            if (int.Parse(cpf[9].ToString()) != digito1)
                return false;

            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(cpf[i].ToString()) * (11 - i);
            }

            int resto2 = soma2 % 11;
            int digito2 = (resto2 < 2) ? 0 : 11 - resto2;

            if (int.Parse(cpf[10].ToString()) != digito2)
                return false;

            return true;
        }

        public static string FormatarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11)
                return cpf;

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public static string CapitalizarNome(string nome)
        {
            TextInfo ti= CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(nome.ToLower());
        }

        public static bool ValidarTelefone(string telefone)
        {
            telefone = Regex.Replace(telefone, "[^0-9]", "");

            return telefone.Length == 10 || telefone.Length == 11;
        }

        public static string FormatarTelefone(string telefone)
        {
            telefone = Regex.Replace(telefone, "[^0-9]", "");

            if (telefone.Length == 11)
            {
                return Regex.Replace(telefone, @"(\d{2})(\d{5})(\d{4})", "($1) $2-$3");
            }
            else if (telefone.Length == 10)
            {
                return Regex.Replace(telefone, @"(\d{2})(\d{4})(\d{4})", "($1) $2-$3");
            }
            else
            {
                return telefone;
            }
        }

        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        public static bool ValidarSexoPorExtenso(string sexo)
        {
            if (string.IsNullOrWhiteSpace(sexo))
                return false;

            sexo = sexo.Trim().ToLower();
            return sexo == "masculino" || sexo == "feminino";
        }
    }
}
