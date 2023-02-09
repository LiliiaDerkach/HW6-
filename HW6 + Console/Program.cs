using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6___Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Console.WriteLine("Welcome to the road traffic test (PDR)." + "\nFor each correct answer you will receive a certain number of points");
            //string[] questionOne = { "Аварійна сигналізація", "Ближнє світло фар", "Габаритні ліхтарі"};
            //Console.WriteLine("1. Який попереджувальний сигнал вмикається на транспортних засобах колони під час зупинки на дорозі?" + 
            //    "\nаварійна сигналізація"+
            //    "\n,лижнє світло фар" +
            //    "\nuабаритні ліхтарі");
            string[] answers = { "emergency alarm", "tram track", "yes" };
            Console.WriteLine("1. What warning signal is activated on convoy vehicles when stopped on the road?" +
                "\nemergency alarm" +
                "\ndipped beam headlights" +
                "\nposition lights");
            string questOne = Console.ReadLine();

            if (questOne == answers[0])
            {
                points = 1;
                Console.WriteLine("It's right");
            }
            else
            {
                Console.WriteLine("Unfortunately you are mistaken");
            }
            Console.WriteLine("2. The element of the road, intended for the movement of rail vehicles, which is limited in width by a specially allocated paving of the tram line or road markings is:" +
                "\ntram track" +
                "\nimproved coverage" +
                "\ntraffic lane");
            Console.WriteLine();
            string questTwo = Console.ReadLine();
            
            if (questTwo == answers[1]) 
            {
                points = 2;
                Console.WriteLine("It's right");
            }
            else
            {
                Console.WriteLine("Unfortunately you are mistaken");
            }

            Console.WriteLine("3. Does the carriageway have a bicycle lane?" +
                "\nyes" +
                "\nno");
            Console.WriteLine();
            string questThree = Console.ReadLine();

            if (questTwo == answers[2])
            {
                points = 3;
                Console.WriteLine("It's right");
            }
            else
            {
                Console.WriteLine("Unfortunately you are mistaken");
            }

            Console.ReadKey();
            
        }
    }
}
