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
        public double LiquidSalary { get; private set; }
        double INSS = 0.12;
        
        
        public Register()
        {

        }
        
        public Register(string name, double baseSalary, DateTime birthDate, Enum services)
        {
            Name = name;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Services = services;
            Finance finance = new Finance();
            finance.taxs(this,INSS);

            }

        public Register(string name, double baseSalary, string email, DateTime birthDate, Enum services) : this (name,baseSalary,birthDate,services)
        {
          
            Email = email;
           
        }

        public void BaseSalaryFunction(double value)
        {
            BaseSalary = value;
        }
       
        public void LiquidSalaryFunction(double value)
        {
            LiquidSalary = value;
        }
        

        public override string ToString()
        {
            return "Nome: " + Name + 
                    "\nSalário Bruto: " + BaseSalary +
                    "\nSalário Líquido: " + LiquidSalary +
                    "\nData de Nascimento :" + BirthDate +
                    "\nServiço Prestado: " + Services +
                    "\nEmail " + Email!=null? Email:"Sem email";
        }

    }
}
