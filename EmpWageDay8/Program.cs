namespace EmpWageDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = 0;
           while(num ==0)
            {
                Console.WriteLine();
                Console.WriteLine("**************************************");
                Console.WriteLine("Welcome to Employee Wage Computation");
                Console.WriteLine();

                Console.WriteLine("Select Option\n1.Employee Attendace \n2.Daily Wage \n3.Part Time Wage \n4.Switch Case \n5.Monthly Wage \n6.100 Hours OR 20 Days \n7.Exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opt)
                {
                    case 1:
                        PresentAbsent.empCheck();
                        break;
                    case 2:
                        DailyWage.dailyWge();
                        break;
                    case 3:
                        PartTimeWage.prtTimeWge();
                        break;
                    case 4:
                        SwitchCase.Switch();
                        break;
                    case 5:
                        WageForMonth.monthlyWage();
                        break;
                    case 6:
                        WorkingHoursCondn.wrkingHrs();
                        break;
                    case 7: num++;
                        break;

                    default:
                        Console.WriteLine("Invaild Choice");
                        break;
                }
            }
           

        }
    }
}