using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        //Precisamos criar um método de bonificação para os funcionários baseado no salário

        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
