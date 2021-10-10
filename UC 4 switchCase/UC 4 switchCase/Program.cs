using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_4_switchCase
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empRatePerHour = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case isPartTime:
                    empHrs = 4;
                    break;
                case isFullTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 4;
                    break;

            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Emp wage : " + empWage);
            Console.ReadLine();
        }
    }
}
