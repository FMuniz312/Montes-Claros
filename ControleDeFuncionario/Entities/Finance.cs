using ControleDeFuncionario.Exceptions;

namespace ControleDeFuncionario.Entities
{
     class Finance 
    {


        public static void taxs(Register funcionario,double percentagetaxs)
        {
            double LiquidSalary = funcionario.BaseSalary;
            LiquidSalary -= LiquidSalary*percentagetaxs;
            funcionario.LiquidSalaryFunction(LiquidSalary);
        }

        public static void Raise(Register funcionario, double raise)
        {
            if(raise <0)
            {
                throw new FinanceExceptions("Valor negativo não é permitido!");
            }
            double NewValue = funcionario.BaseSalary;
            NewValue += raise;
            funcionario.BaseSalaryFunction(NewValue);
            taxs(funcionario, 0.12);
        }

        public static void Decrease(Register funcionario, double decrease)
        {
            if (decrease < 0)
            {
                throw new FinanceExceptions("Valor negativo não é permitido!");
            }
            double NewValue = funcionario.BaseSalary;
            NewValue -= decrease;
            funcionario.BaseSalaryFunction(decrease);
            taxs(funcionario, 0.12);

        }





    }
}
