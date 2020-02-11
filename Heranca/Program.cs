using Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // Downcasting
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

            /*  
             *  acc2.Loan(100.0); ERRO... primeiro necessário o downcasting            
             *  BusinessAccount acc5 = (BusinessAccount) acc3; ERRO... InvalidCastException (SavingsAccount)
            */

            // Testar se acc3 é uma instância de BusinessAccount, nesse caso, ele evita o erro pulando o casting
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc2;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            // Testar se acc3 é uma instância de SavingsAccount, nesse caso, o downcasting é feito com sucesso
            if (acc3 is SavingsAccount)
            {
                // Outra sintaxe para casting
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalace();
                Console.WriteLine("Update!");
            }

            Console.ReadLine();

        }
    }
}
