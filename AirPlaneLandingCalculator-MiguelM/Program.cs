using System;
using static System.Console;
/*Programmer: Miguel Miguel*/

namespace AirPlaneLandingCalculator_MiguelM
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared values for altitude, speed
            double planeAltitude = 0.00d;
            double planeSpeed = 0.00d;
            

            //declared time (minutes) and speed of plane in minutes (rate of descent is equal to 500 miles per hour)
            
            
           


            //input of data into console
            Clear();
            WriteLine("Descent Rate Calculator");
            WriteLine("-----------------------------");
            Write("Please enter the altitude in feet: ");
            planeAltitude = Convert.ToDouble(ReadLine());
            Write("Please enter speed in miles per hour: ");
            planeSpeed = Convert.ToDouble(ReadLine());       
           
            double numSpeedPerMinute = (double)planeSpeed / 60.00d;
            
            const double rateOfDescent = 500.00d;
            
            double numMinutesTotal = (double)rateOfDescent / (double)numSpeedPerMinute;
           
            double planeMilesAway = (double)planeAltitude / (double)numMinutesTotal;

            WriteLine($"The descent should be started {0d} miles away from the airport" , planeMilesAway);

            
            ReadKey();
        }
    }
}
