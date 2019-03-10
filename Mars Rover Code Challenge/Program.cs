using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = null;
            String[] botInfo = null;
            char[] movements = null;
            NavigationSystem navSystem = new NavigationSystem();
            Console.WriteLine("Welcome to the Mars Rover Project navigation system.");
            Console.WriteLine("Enter the maximum X any Y coordinates of the plain with a space separating them:");
            input = Console.ReadLine();
            botInfo = input.Split(' ');
            navSystem.setBounds(Convert.ToInt32(botInfo[0]), Convert.ToInt32(botInfo[1]));
            Console.WriteLine("Enter starting location and heading (viewing direction) e.g. 0 0 N:");
            input = Console.ReadLine();
            botInfo = input.Split(' ');
            if (navSystem.setLocation(Convert.ToInt32(botInfo[0]), Convert.ToInt32(botInfo[1])))
                Console.WriteLine("The value you entered was out of bounds, It was replaced with the value nearest to that point.");
            navSystem.setHeading(botInfo[2]);
            do
            {
                Console.WriteLine("Enter instruction set:");
                input = Console.ReadLine();
                input = input.ToUpper();
                movements = input.ToCharArray();
                for (int i = 0; i < movements.Length; i++)
                {
                    input = movements.GetValue(i).ToString();
                    if (input == "M")
                        navSystem.move();
                    else if (input == "R")
                        navSystem.rightTurn();
                    else if (input == "L")
                        navSystem.leftTurn();
                }
                Console.WriteLine("Final coordinates and direction are below: ");
                input = navSystem.getXLocation().ToString() + "\t";
                input += navSystem.getYLocation().ToString() + "\t";
                input += navSystem.getHeading();
                Console.WriteLine(input);
                Console.WriteLine("Are there any other commands? Y/N");
                input = Console.ReadLine();
                input = input.ToUpper();
            } while (input == "Y");
            Console.ReadKey();
        }
    }
}
