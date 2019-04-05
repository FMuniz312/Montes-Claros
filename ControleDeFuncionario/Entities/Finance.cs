using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeFuncionario.Entities
{
     class Finance : Register
    {

        double INSS = 0.12;
        public void LiquidSalary(double salarybase)
        {
            salarybase *= INSS;

        }
        public void Raise(double raise)
        {
            SalaryChangesPlus(raise);

        }

        public void Decrease(double decrease)
        {
            SalaryChangesPlus(-decrease);
        }



    }
}
