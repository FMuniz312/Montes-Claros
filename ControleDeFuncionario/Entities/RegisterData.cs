using System;
using System.Text;
using ControleDeFuncionario.Exceptions;

namespace ControleDeFuncionario.Entities
{
    class Register
    {
        public string Name { get; set; }
        public double BaseSalary { get; private set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }
        public Enum Services { get; set; }
        public double LiquidSalary { get; private set; }
        double INSS = 0.12;




        public Register(string name, double baseSalary, DateTime birthDate, Enum services)
        {
            Name = name;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Services = services;
            Finance finance = new Finance();
            Finance.taxs(this, INSS);
            Email = null;

        }

        public Register(string name, double baseSalary, string email, DateTime birthDate, Enum services) : this(name, baseSalary, birthDate, services)
        {

            Email = email;

        }

        public void BaseSalaryFunction(double value)
        {
            if (value < 0)
            {
                throw new FinanceExceptions("Valor negativo não é permitido!");
            }
            BaseSalary = value;
        }

        public void LiquidSalaryFunction(double value)
        {
            if (value < 0)
            {
                throw new FinanceExceptions("Valor negativo não é permitido!");
            }
            LiquidSalary = value;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + Name);
            sb.AppendLine("Salário Bruto: " + BaseSalary);
            sb.AppendLine("Salário Líquido: " + LiquidSalary);
            sb.AppendLine("Data de Nascimento :" + BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Serviço Prestado: " + Services);
            if (Email != null)
            {
                sb.AppendLine("Email: " + Email);
            }
            else
            {
                sb.AppendLine("Email: Sem email");
            } 
            return sb.ToString();
        }
    }
}
