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

            int choice = 0;
            try
            {
                while (choice != 5)
                {
                    Console.WriteLine("Qual operação quer fazer?");
                    Console.WriteLine("1.Registrar funcionários");
                    Console.WriteLine("2. Aumentar salário");
                    Console.WriteLine("3. Diminuir salário");
                    Console.WriteLine("4. Demissão");

                    choice = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            RegisterWorkerFunctions.RegistrarFuncionario();
                            ; break;

                        case 2:
                            RegisterWorkerFunctions.dandoAumento();
                            ; break;

                        case 3:
                            RegisterWorkerFunctions.dandoRebaixamento();
                            ; break;

                        case 4:
                            RegisterWorkerFunctions.demissao();
                            ; break;

                    }
                }//Dentro do loop 
            }
             catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }


    }
}


