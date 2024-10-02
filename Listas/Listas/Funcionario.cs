using System;
using System.Globalization;

namespace Listas {
    class Funcionario {
        
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string name, double salario) {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentoSalarial(double porcentagem) {
           double aumento = porcentagem * Salario / 100;
            Salario += aumento;            
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
