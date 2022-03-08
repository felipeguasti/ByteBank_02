using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{   
    public class Diretor : FuncionarioAutenticavel 
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor " + this.Nome);
        }
        public bool Autenticar(string senha)
        {
            return true;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // Não é mais necessário as atribuições abaixo,
        // pois o diretor agora herda as atribuições do funcionário
        // por causa dos dois pontos

        /*
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        */

        //Precisamos criar um método de bonificação para os funcionários baseado no salário

        // O override sobrescreve o método criado em funcionário.
        // A instrução virtual em funcionário permite criar essa sobrescrita. 
        public override double GetBonificacao()
        {
            return Salario * 0.50;
        }
    }
}       
    