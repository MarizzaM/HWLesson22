using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson22
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp cheerleaders = new Camp(1000, 500, 60, 12, 24);
            Camp footballers = new Camp(2000, 2000, 101, 20, 50);

            if (cheerleaders > footballers)
            {
                Console.WriteLine($"\n {cheerleaders} \nlager \n{footballers}");
            }
            else {
                Console.WriteLine($"\n {footballers} \nlager \n{cheerleaders}");
            }

            Camp cheerleadersAndFootballers = cheerleaders + footballers;
            Console.WriteLine(cheerleadersAndFootballers);
        }
    }
}
