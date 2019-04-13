using System;
using System.Collections.Generic;
using ControleDeFuncionario.Entities.Enums;
using System.Globalization;

namespace ControleDeFuncionario.Entities
{
    class RegisterWorkerFunctions
    {
        static List<Register> WorkerList = new List<Register>();

        public static void RegistrarFuncionario()//Registrando funcionario
        {
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

                if (temail == "") { Register Worker = new Register(tname, tbasesalary, tbrtdate, tservices);
                    WorkerList.Add(Worker);
                }

                else
                {
                    Register Worker = new Register(tname, tbasesalary, temail, tbrtdate, tservices);
                    WorkerList.Add(Worker);

                }

            }

        }
        public static void dandoAumento()//Aumentando o salario do funcionario (Por valor)
        {
            Console.WriteLine("Aumentar o salário de qual funcionario?");
            string tworker = Console.ReadLine();
            foreach (Register worker in WorkerList)
            {
                if (worker.Name == tworker)
                {
                    Console.WriteLine("De quanto será o aumento para o funcinario(a) {0}", worker);
                    double traise = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Finance.Raise(worker, traise);
                }
            }
        }

        public static void dandoRebaixamento()//Diminuindo o salario do funcionario (Por valor)
        {
            Console.WriteLine("Diminuir o salário de qual funcionario?");
            string t1worker = Console.ReadLine();
            foreach (Register worker in WorkerList)
            {
                if (worker.Name == t1worker)
                {
                    Console.WriteLine("De quanto será o aumento para o funcinario(a) {0}", worker);
                    double tdecrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Finance.Decrease(worker, tdecrease);
                }
            }

        }

        public static void demissao() //Retirando funcionario do registro
        {
            Console.WriteLine("Retirar qual funcionario?");
            string tremoveworker = Console.ReadLine();
            foreach (Register worker in WorkerList)
            {
                if (worker.Name == tremoveworker)
                {
                    WorkerList.Remove(worker);
                }
            }
        }
    }
}