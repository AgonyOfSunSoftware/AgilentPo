using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Console.Write("Сколько кораблей блять?!");
            points = Convert.ToInt32(Console.ReadLine());
            AgilentPO.MEASURE measure = new AgilentPO.MEASURE(points);
            if (measure.Connect("127.0.0.1")){
                measure.Start();
                for (int i = 0; i < measure.Points(); i++)
                {
                    Console.WriteLine(measure.GetMeasureData()[i].Frequency().ToString() + " -- " + measure.GetMeasureData()[i].Reflectivity().ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
