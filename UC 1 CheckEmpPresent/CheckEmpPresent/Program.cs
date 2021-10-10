using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEmpPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == isPresent)
            {
                Console.WriteLine("Employee  Present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee  Absent");
                Console.ReadLine();
            }
        }
    }
}
