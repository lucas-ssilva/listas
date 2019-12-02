using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)

        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>(n);
            
            for(var i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Emplyoee #{0}:", i);
                Console.Write("Id: ");
                var id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                var nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int increase = int.Parse(Console.ReadLine());
            Funcionario func = list.Find(x => x.Id == increase);

            if (func == null)
            {
                Console.WriteLine();
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Enter the percentage: ");
                Double aumento = double.Parse(Console.ReadLine());
                func.AumentodeSalario(aumento);
            }

            Console.WriteLine("Updated list of employees:");
            Console.WriteLine();
            foreach(Funcionario obj in list)
            {
                Console.WriteLine();
                Console.WriteLine(obj);
            }
        }
    }
}
