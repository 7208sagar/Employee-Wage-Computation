using System;

namespace EmployeeWage
{
    class Program
    {
        //UC4
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee wage Computation");

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee wage is=" + empWage);
            }
            Console.ReadLine();
        }
    }
}
