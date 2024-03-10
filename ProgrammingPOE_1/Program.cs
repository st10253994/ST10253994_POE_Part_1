using System;

namespace ProgrammingPOE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            List<string> ingrediants = new List<string>();
            List<int> quantity = new List<int>();
            List<string> steps = new List<string>();
            List<string> measurements = new List<string>();
            List<string> recipeN = new List<string>();


                Console.WriteLine("""
                                  Please enter the following
                                  1)Enter your ingrediants
                                  2) Add steps
                                  3) Print recipe
                                  4) Scale recipe
                                  5) Reset recipe
                                  6) Clear recipe
                                  Enter your choice:
                                  """);

            Methods m = new Methods(); //Object created to access methods from other class

            int choice = Convert.ToInt32(Console.ReadLine());

            /*
             * choice is made for the switch case, if any value is entered that is less than or not 7 the switch case will be looped
             * if the user wishes to exit the program he/she will have to enter number 7
             */

            while (choice != 7)
            {
                /* choice - 1 insures that when the user enters 1 it will go to case 0
                 * it ensures that the user is guided into the correct case statement
                 */
                switch (choice -= 1)
                {
                    case 0:
                        {
                            m.Ingrediants(ingrediants, quantity, measurements, recipeN);
                            break;
                        }
                    case 1:
                        {
                            m.Steps(steps);
                            break;
                        }
                    case 2:
                        {
                            m.PrintRecipe(steps, ingrediants, quantity, measurements, recipeN);
                            break;
                        }
                    case 3:
                        {
                            m.ScaleRecipe(quantity);
                            break;
                        }
                    case 4:
                        {
                            m.ResetRecipe(quantity);
                            break;
                        }
                    case 5:
                        {
                            m.ClearRecipe(steps, ingrediants, quantity, measurements, recipeN);
                            break;
                        }

                }
                /*
                 * the choices are placed at the end of the case statement to provide a constant choice for the user
                 */
                Console.WriteLine("""
                                  Please enter the following
                                  1)Enter your ingrediants
                                  2) Add steps
                                  3) Print recipe
                                  4) Scale recipe
                                  5) Reset recipe
                                  6) Clear recipe
                                  Enter your choice:
                                  """);

                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
