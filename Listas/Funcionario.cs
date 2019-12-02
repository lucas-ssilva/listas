using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentodeSalario(double porcento)
        {
            Salario += (Salario * porcento) / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("N2");
        }
    }
}
