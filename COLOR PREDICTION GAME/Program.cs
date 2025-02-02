
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLORPREDICTION
{
    class Program sunny kind
    {
        key sunny123
        static void Main(string[] args)
        {
            string inputPlayer, randomcolor;
            int randomInt;
            int limit=1;
            bool playAgain = true;

            while (playAgain)
            {

                int score = 0;
                

                while (limit <= 20 )
                {
                    colour 100%

                    Console.Write("Choose between RED,GREEN,BLUE,ORANGE,YELLOW,PINK and VIOLET:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 8);

                    switch (randomInt)
                    {
                        case 1:
                            randomcolor= "RED";
                            limit++;
                            Console.WriteLine("Color is Red");
                            if (inputPlayer == "RED")
                            {
                                Console.WriteLine("Your Prediction Is Correct");
                                score++;
                            }
                            else {
                                Console.WriteLine("Your Prediction Is InCorrect");
                            }
                            break;
                        case 2:
                            randomcolor = "GREEN";
                            limit++;
                            Console.WriteLine("Color Is Green");
                            if (inputPlayer == "GREEN")
                            {
                                Console.WriteLine("Your Prediction Is Correct");
                                score++;
                            }
                            else {
                             
                              Console.WriteLine("Your Prediction Is Incorrect");

                            }
                            break;
                        case 3:
                            randomcolor = "BLUE";
                            limit++;
                            Console.WriteLine("Color Is Blue");
                            if (inputPlayer == "BLUE")
                            {
                                Console.WriteLine("Your Prediction Is Correct");
                                score++;
                            }
                            else {
                                Console.WriteLine("Your Prediction Is InCorrect");
                            }
                            break;

                            case 4:
                             randomcolor="ORANGE";
                             limit++;
                             Console.WriteLine("Color Is Orange");
                              
                              if(inputPlayer == "ORANGE"){

                               Console.WriteLine("Your Prediction Is Correct");
                               score++;

                              }
                              else{
                                   
                             Console.WriteLine("Your Prediction Is Incorrect");

                              }

                            break;

                            case 5 :
                           
                            randomcolor="YELLOW";
                            limit++;
                            Console.WriteLine("Color Is Yellow");
                            if(inputPlayer == "YELLOW"){
                                  
                                Console.WriteLine("Your Prediction Is Correct");
                                score++;

                            }
                            else{

                           Console.WriteLine("Your Prediction Is InCorrect");

                            }

                            break;

                            case 6:
                            
                            randomcolor="PINK";
                            limit++;
                            Console.WriteLine("Color Is PINK");

                            if(inputPlayer == "PINK"){
                            
                             Console.WriteLine("Your Prediction Is Correct");
                             score++;

                            }

                            else{

                                Console.WriteLine("Your Prediction Is InCorrect");
                            }

                            break;
                           
                            case 7:

                             randomcolor="VIOLET";
                             limit++;
                             Console.WriteLine("Color Is Violet");

                             if(inputPlayer == "VIOLET"){

                             Console.WriteLine("Your Prediction Is Correct");
                              score++;

                             }

                             else{
                              
                              Console.WriteLine("Your Prediction Is InCorrect");

                             }

                           break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYERSCORE:\t{0}",score);

                }

                Console.WriteLine("Your Score Is {0} Out Of 20",score);
            

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {    
                    limit=1;
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                { 
                
                }

            }
        }
    }
}
