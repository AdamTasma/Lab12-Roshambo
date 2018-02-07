using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp
    {
        public static void StartTheGame()
        {
            Console.WriteLine("Welcome to Roshambo, where the points matter!");
            System.Threading.Thread.Sleep(1000);
            UserPlayer up = new UserPlayer();
            string playerName = up.TheName();
            WhoToPlay(up);
        }

        public static void WhoToPlay(UserPlayer up)
        {
            Console.WriteLine("Would you like to play against PlayerOne or PlayerTwo?(Please enter 1 or 2)");

                if (int.TryParse(Console.ReadLine(), out int answer) && answer == 1)
                {
                    up.GenerateRoshambo();
                }
                else if (answer == 2)
                {
                    up.GenerateRoshambo();
                }
                else
                {
                    Console.WriteLine("you did not enter a '1' or a '2', please try again.");
                    WhoToPlay(up);
                }

            }
        }
    }

