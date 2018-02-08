using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab12
{
    class RoshamboApp
    {
        public static string playerName;
        //Hashtable hash = new Hashtable();
        //hash.Add(1, "Rock");



        public static void StartTheGame()
        {
            Console.WriteLine("Welcome to Roshambo, where the points matter!");
            System.Threading.Thread.Sleep(1000);
            UserPlayer up = new UserPlayer();
            playerName = up.TheName();
            WhoToPlay(up);
            
        }

        public static void WhoToPlay(UserPlayer up)
        {
            Hashtable ht = new Hashtable() { { 1, "rock" }, { 2, "paper" }, { 3, "scissors" } };
            Console.WriteLine("Would you like to play against (1)Billie or (2)Johnny?(Please enter 1 or 2)");

                if (int.TryParse(Console.ReadLine(), out int answer) && answer == 1)
                {
                Player1 p1 = new Player1();
                Console.WriteLine("Ok, lets begin!");
                Console.WriteLine(playerName + " uses " + ht[up.GenerateRoshambo()]);
                Console.WriteLine(p1.TheName() + " uses " + ht[p1.GenerateRoshambo()]);
                int telling = up.GenerateRoshambo() - p1.GenerateRoshambo();
                Console.WriteLine(telling);
                //WhoWins();
                }
                else if (answer == 2)
                {
                Player2 p2 = new Player2();
                Console.WriteLine("Ok, lets begin!");
                Console.WriteLine(playerName + " uses " + ht[up.GenerateRoshambo()]);
                Console.WriteLine(p2.TheName() + " uses " + ht[p2.GenerateRoshambo()]);
            }
                else
                {
                    Console.WriteLine("you did not enter a '1' or a '2', please try again.");
                    WhoToPlay(up);
                }

            }
        }
    }

