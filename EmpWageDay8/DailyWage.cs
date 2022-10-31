using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageDay8
{
    internal class DailyWage
    {
        public static void dailyWge()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Todays Wage of employee is " + empWage);
        }
            
    }
}
