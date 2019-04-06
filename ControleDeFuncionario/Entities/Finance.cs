using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeFuncionario.Entities
{
     class Finance 
    {



        public void taxs(Register funcionario,double percentagetaxs)
        {
            double LiquidSalary = funcionario.BaseSalary;
            LiquidSalary -= LiquidSalary*percentagetaxs;
            funcionario.LiquidSalaryFunction(LiquidSalary);
        }

        public void Raise(Register funcionario, double raise)
        {

            double NewValue = funcionario.BaseSalary;
            NewValue += raise;
            funcionario.BaseSalaryFunction(NewValue);
        }

        public void Decrease(Register funcionario, double decrease)
        {
            double NewValue = funcionario.BaseSalary;
            NewValue -= decrease;
            funcionario.BaseSalaryFunction(decrease);
        }



    }
}
