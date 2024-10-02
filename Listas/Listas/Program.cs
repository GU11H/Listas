using System;
using System.Runtime.CompilerServices;

namespace Listas {
    class Exercicio {
        public static void Main(String[] args) {

            Console.WriteLine("Quantos funcionários serão cadastrados?");
            int qtdFuncionario = int.Parse(Console.ReadLine());

            List <Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= qtdFuncionario; i++) {
                Console.WriteLine("Funcionario " + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = int.Parse(Console.ReadLine());

                list.Add(new Funcionario (id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Informe o Id do funcionário que tera aumento");
            int idBusca = int.Parse(Console.ReadLine());

            Funcionario func = list.Find( x=> x.Id == idBusca );

            if (func != null) {
                Console.Write("Informe a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                func.AumentoSalarial(porcentagem);
            } else {
                Console.WriteLine("Id não existente!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios");
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}