using ByteBank.Funcionarios;
using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "542.879.965-20";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.568.523-85";
            roberta.Salario = 5000;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
        }
    }
}