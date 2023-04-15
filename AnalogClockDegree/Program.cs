using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClockDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*In an analog clock, there are 12 hours and 60 minutes. therefore the hour arrow moves 30 degrees for each hour,
             * while the minutes arrow moves 6 degrees per minute             
            */

            //Get the inputs from the user
            Console.Write("Enter the hour (1-12): ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter the minute (0-59): ");
            int minute = int.Parse(Console.ReadLine());

            //Angles
            double hourAngle = 30 * hour;
            double minuteAngle = 6 * minute;

            //the difference is an absolute value
            double Diff = Math.Abs(hourAngle - minuteAngle);

            //in angle difference in a circle, there is the lesser angle and grater one, & we want the lesser one
            double lesserAngle = Math.Min(Diff, 360 - Diff);

            //Output
            Console.WriteLine($"The lesser angle between the hour and minute hands is {lesserAngle} degrees.");

            //for the console not to close imediately after the output, we prompt input from user again
            Console.ReadLine();



        }
    }
}
