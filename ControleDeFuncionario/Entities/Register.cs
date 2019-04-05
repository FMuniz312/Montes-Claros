using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeFuncionario.Entities
{
    class Register
    {
        public string Name { get; set; }
        public double BaseSalary { get; private set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }
        public Enum Services { get; set; }
        public double LiquidSalary { get; set; }

        public Register()
        {

        }
        
        public Register(string name, double baseSalary, DateTime birthDate, Enum services)
        {
            Name = name;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Services = services;
        }

        public Register(string name, double baseSalary, string email, DateTime birthDate, Enum services) : this (name,baseSalary,birthDate,services)
        {
          
            Email = email;
           
        }

        public void SalaryChangesPlus(double value)
        {
            BaseSalary += value;

        }

        

        public override string ToString()
        {
            return "Nome: " + Name + 
                    "\nSalário Salário: " + Salary +
                    "\nData de Nascimento :" + BirthDate +
                    "\nServiço Prestado: " + Services +
                    "\nEmail " + Email!=null? Email:"Sem email";
        }

    }
}
