using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3_Bimestre
{
    internal class funAdm : Funcionario
    {
        public funAdm(string nome, string cpf, DateTime data, string sexo, double salário)
        {
            this.nome = nome;
        }

        public funAdm(string nome, string cpf, double matricula, DateTime dataNasc, string sexo, double salário) : base(nome, cpf, matricula, dataNasc, sexo, salário)
        {

        }
        public void recebimentoo()
        {
            salário = (salário + 150) + 0.15;
        }
    }
}
