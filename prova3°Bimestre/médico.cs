using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova3_Bimestre
{
    internal class médico: Funcionario
    {
       
        public double hrextra { get; set; }
        public string especialidade { get; set; }
        public string Crm { get; set; }

       
        public  médico(string nome, string cpf, double matricula, DateTime DataNasc, string sexo, double salário) 
        {
           
            hrextra = hrextra;
            this.especialidade = especialidade;
            Crm = Crm;
        }

        public médico(string nome, string cpf, DateTime data, string sexo, double salário)
        {
            this.nome = nome;
            hrextra = hrextra;
            this.especialidade = especialidade;
            Crm = Crm;
        }

        public void recebimento()
        {
            salário = (salário + 0.20);
        }

    }
}
