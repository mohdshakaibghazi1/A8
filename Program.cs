using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment8
{
    public class employees { 
    public double csalary(double wHour,double nWDays,double projectHandles, double extras) {
        double salary = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
        return salary;
    }
     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employees emp = new employees();
            Console.WriteLine("CHOOSE EMPLOYEE TYPE\n press 1 for HR\n PRess 2 for Admin\n Press 3 for Software Developer");
            int em = int.Parse(Console.ReadLine());
            double wHour, nWDays, projectHandles, extras,salary=0;
            switch (em)
            {
                case 1:
                    Console.WriteLine("enter working hours ");
                    wHour = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter number of  working days ");
                    nWDays= double.Parse(Console.ReadLine());
                   salary= emp.csalary(wHour, nWDays,1, 0);
                    break;
                case 2:
                    Console.WriteLine("enter working hours ");
                    wHour = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter number of  working days ");
                    nWDays = double.Parse(Console.ReadLine());
                    salary = emp.csalary(wHour, nWDays, 1, 0);
                    Console.WriteLine("Enter number of project handles:");
                    projectHandles = double.Parse(Console.ReadLine());
                    salary = emp.csalary(wHour, nWDays, projectHandles,0);
                    break;
                case 3:
                    Console.WriteLine("enter working hours ");
                    wHour = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter number of  working days ");
                    nWDays = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of project handles:");
                    projectHandles = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of extras:");
                    extras = double.Parse(Console.ReadLine());
                    salary = emp.csalary(wHour, nWDays, 1, 0);
                    break;
                default:
                    Console.WriteLine("Invalid Employee type");
                    break;

            }
            Console.WriteLine("Monthly Salary of employee" + salary);
        }
    }
}
