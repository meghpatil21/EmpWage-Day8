namespace EmpWageDay8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.WriteLine();

            Console.WriteLine("Select Option\n1.Employee Attendace \n2.Daily Wage \n3.Part Time Wage \n4.Switch Case \n5.Monthly Wage");
            int opt =Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1: PresentAbsent.empCheck();
                    break;
                case 2: DailyWage.dailyWge();
                    break;
                case 3: PartTimeWage.prtTimeWge();
                    break;
                case 4: SwitchCase.Switch();
                    break;
                case 5: WageForMonth.monthlyWage();
                    break;

                default: Console.WriteLine("Invaild Choice");
                    break;
            }
        }
    }
}