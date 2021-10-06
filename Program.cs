using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee wage Computation");
            

            //UC3

            int Is_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOURS = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if(empCheck==Is_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee present as part time");
            }
            else if(empCheck==IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee present as full time");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent ");
            }

            empWage = empHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Employee wage is=" + empWage);
            Console.ReadLine();
        }
    }
}
