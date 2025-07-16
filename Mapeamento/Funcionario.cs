using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeteria.Mapeamento
{
    internal class Funcionario
    {
        public int idFuncionario {  get; set; }
        public string CPF { get; set; }
        public string nome { get; set; }
        public DateTime dataContratacao { get; set; }
        public double salario { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
    }
}
