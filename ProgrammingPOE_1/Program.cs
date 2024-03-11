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
            Recipes obj = new Recipes(); //Object created to access methods from other class

            obj.displayMenu("Main Menu");



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
                            obj.ingrediants(ingrediants, quantity, measurements, recipeN);
                            break;
                        }
                    case 1:
                        {
                            obj.steps(steps);
                            break;
                        }
                    case 2:
                        {
                            obj.printRecipe(steps, ingrediants, quantity, measurements, recipeN);
                            break;
                        }
                    case 3:
                        {
                            obj.scaleRecipe(quantity);
                            break;
                        }
                    case 4:
                        {
                            obj.resetRecipe(quantity);
                            break;
                        }
                    case 5:
                        {
                            obj.clearRecipe(steps, ingrediants, quantity, measurements, recipeN);
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
                /*
                 * the choices are placed at the end of the case statement to provide a constant choice for the user
                 */
                obj.displayMenu("Main Menu");

                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
