using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Methods
{


    public int sum = 1; // sum was made to be used in the scaling of the recipes

    /*
     *Method ingrediants saves all the user ingrediants, quantities and measurements to arraylists
     *the data stored in the arraylist is meant for later use
     */
    public void Ingrediants(List<string> ingrediants, List<int> quantity, List<string> measurements, List<string> recipeN)
    {
        int ingrediantC, amount;
        string ingrediantName, measure, recipe;

        Console.WriteLine("Please enter the recipe name: ");
        recipe = Console.ReadLine();
        recipeN.Add(recipe);

        Console.WriteLine("Please enter the amount of ingrediants: ");
        ingrediantC = Convert.ToInt32(Console.ReadLine()); // this value will be used for the forloop 


        for (int i = 0; i < ingrediantC; i++)
        {

            /*
             * the next 3 inputs will be stored in the arraylists ingrediants, quantity and measurements
             */

            Console.WriteLine("Please enter your ingrediant name: ");
            ingrediantName = Console.ReadLine();
            ingrediants.Add(ingrediantName);

            Console.WriteLine("Please eneter the quantity: ");
            amount = Convert.ToInt32(Console.ReadLine());
            quantity.Add(amount);

            Console.WriteLine("Please enter your measuring method: ");
            measure = Console.ReadLine();
            measurements.Add(measure);


        }

    }

    /*
     * Method steps allows the user to right as many steps as is required for the recipe
     * the steps is saved to an arraylist steps
     */
    public void Steps(List<string> steps)
    {
        string step;
        int stepA;

        Console.WriteLine("Please enter the amount of steps: ");
        stepA = Convert.ToInt32(Console.ReadLine()); // this value will be used to determine the amount of times we go through the forloop

        for (int i = 0; i < stepA; i++) // forloop is used to output and gain a input for as many steps as is required
        {
            Console.WriteLine("Please enter step " + (i + 1));
            step = Console.ReadLine();
            steps.Add(step);
        }
    }

    /*
     * Method PrintRecipe is made to take all the information stored in the arraylists and print it out into a specific format
     */
    public void PrintRecipe(List<string> steps, List<string> ingrediants, List<int> quantity, List<string> measurements, List<string> recipeN)
    {   
        Console.WriteLine("Recipe: ");
        for (int i =0; i < recipeN.Count; i++)
        {
            Console.WriteLine(recipeN[i]);
        }

        Console.WriteLine("\n\nIngrediants:");
        for (int i = 0; i < ingrediants.Count; i++) // forloop is used to print out all values saved in the arraylists ingrediants, quantity and measurements
        {
            Console.WriteLine(ingrediants[i]);
            Console.WriteLine(quantity[i] + measurements[i]);
        }

        Console.WriteLine("\nSteps: ");
        for (int i = 0; i < steps.Count; i++) // forloop is used to print out all values stored in the arraylist steps
        {
            Console.WriteLine("Step " + (i + 1) + ":" + steps[i]);
        }
        Console.WriteLine("\n");
    }

    /*
     * ScaleRecipe is made to scale the information stored in the quantity arraylist for as many people the user needs
     */
    public void ScaleRecipe(List<int> quantity)
    {
        int amount, factor;

        Console.WriteLine("How many people will there be?");
        factor = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantity.Count; i++) // forloop is used to scale for the amount of people by multiplying the quantity at index i with the factor
        {
            quantity[i] *= factor;
        }
        sum *= factor; // sum will be used to reset the scale for 1 portion later on
    }

    /*
     * The method RestRecipe is made to reverse the effects of scale recipe
     * This ensures that if the user is done with the recipe he can scale it back down to a single portion
     */
    public void ResetRecipe(List<int> quantity)
    {
        int amount;

        for (int i = 0; i < quantity.Count; i++) // is made to reset the quantity to 1 portion by deviding with the product of sum and factor
        {
            quantity[i] /= sum;
            
        }
    }

    /*
     * The method ClearRecipe is made to clear all information from the arraylists
     * it removes all recipes saved
     */
    public void ClearRecipe(List<string> steps, List<string> ingrediants, List<int> quantity, List<string> measurements, List<string> recipeN)
    {
        quantity.Clear();
        ingrediants.Clear();
        measurements.Clear();
        steps.Clear();
        recipeN.Clear();
    }


}
