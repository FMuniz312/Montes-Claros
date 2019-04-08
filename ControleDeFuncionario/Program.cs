using System;
using System.Globalization;
using ControleDeFuncionario.Entities.Enums;
using ControleDeFuncionario.Entities;
using System.Collections.Generic;

namespace ControleDeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Register> WorkerList = new List<Register>();
            Finance finance = new Finance();

            Console.WriteLine("Qual operação quer fazer");
            Console.WriteLine("1.Registrar funcionários");
            Console.WriteLine("2. Aumentar salário");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1://Registrando funcionario

                    Console.WriteLine("Quantos funcionários serão registrados?");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Nome:");
                        string tname = Console.ReadLine();
                        Console.Write("Data de nascimento:");
                        DateTime tbrtdate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Ocupação:");
                        Services tservices = Enum.Parse<Services>(Console.ReadLine());
                        Console.Write("Salário Bruto:");
                        double tbasesalary = double.Parse(Console.ReadLine());
                        Console.Write("Email(opcional):");
                        string temail = Console.ReadLine();

                        Register Worker = new Register(tname, tbasesalary, temail, tbrtdate, tservices);
                        WorkerList.Add(Worker);
                    }; break;

                case 2: //Aumentando o salario do funcionario (Por valor)
                    Console.WriteLine("Aumentar o salário de qual funcionario?");
                    string tworker = Console.ReadLine();
                    foreach (Register worker in WorkerList)
                    {
                        if (worker.Name == tworker)
                        {
                            Console.WriteLine("De quanto será o aumento para o funcinario(a) {0}", worker);
                            double traise = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            finance.Raise(worker, traise);
                        }
                    }
                    ; break;


            }

        }


    }
}


