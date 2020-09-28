using System;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IsFullTime = 1;
            const int IsPartTime = 0;
            const int EmpRatePerHour = 20;
            //Variables & Calculation using switch
            int empWage = 0;
            int empHr = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IsPartTime:
                    empHr = 4;
                    empWage = empHr * EmpRatePerHour;
                    Console.WriteLine("Part time Employee is present");
                    Console.WriteLine("Part time Employee Wage = " + empWage);
                    break;

                case IsFullTime:
                    empHr = 8;
                    empWage = empHr * EmpRatePerHour;
                    Console.WriteLine("Full time Employee is present");
                    Console.WriteLine("Full time Employee Wage = " + empWage);
                    empHr = 8;
                    break;

                default:
                    Console.WriteLine("Neither Full Time nor Part time Employee is present!");
                    break;
            }
        
    }
}
