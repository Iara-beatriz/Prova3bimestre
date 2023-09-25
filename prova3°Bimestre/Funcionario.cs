using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3_Bimestre
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double matricula { get; set; }
        public DateTime DataNasc {  get; set; }
        public string sexo { get; set; }
        public double salário { get; set; }
        public Funcionario()
        {

        }
        public Funcionario(string nome, string cpf, double matricula, DateTime dataNasc, string sexo, double salário)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.matricula = matricula;
            DataNasc = dataNasc;
            this.sexo = sexo;
            this.salário = salário;
          
        }
    }
}
