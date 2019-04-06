using System;
using ControleDeFuncionario.Entities.Enums;
using ControleDeFuncionario.Entities;
namespace ControleDeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string nome = "Filipe";
            DateTime data = DateTime.Parse("26/06/1996");
            Enum Servico = Enum.Parse<Services>("Gerenciamento");
            double salariobase = 2000;
            Register Funcionario = new Register(nome, salariobase, data, Servico);
            Console.WriteLine(Funcionario.LiquidSalary);
            Finance Controledofinanceiro = new Finance();

            
            

        }
    }
}
