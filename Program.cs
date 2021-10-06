using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee wage Computation");
            

            //UC1
            int employee = 1;
            Random random = new Random();
            int check = random.Next(0,2);//0,1
            if (check ==employee)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadLine();

        }

    }
}
