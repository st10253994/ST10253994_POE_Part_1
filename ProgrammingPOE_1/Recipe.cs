using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Recipes
{


    private double sum = 1; // sum was made to be used in the scaling of the recipes
    PrintUtil obj = new PrintUtil();
    Ingrediants ing = new Ingrediants();
    

    /*
     *Method ingrediants saves all the user ingrediants, quantities and measurements to arraylists
     *the data stored in the arraylist is meant for later use
     */
    public void ingrediants(List<string> ingrediants, List<double> quantity, List<string> measurements, List<string> recipeN)
    {
        int ingrediantC;
       
        string recipe;

        obj.PrintRecipeN();
        recipe = Console.ReadLine();
        recipeN.Add(recipe);

        obj.PrintIAmount();
        ingrediantC = Convert.ToInt32(Console.ReadLine()); // this value will be used for the forloop 


        for (int i = 0; i < ingrediantC; i++)
        {

            /*
             * the next 3 inputs will be stored in the arraylists ingrediants, quantity and measurements
             */

            obj.PrintIName();
            ing.setIngrediants(Console.ReadLine());
            ingrediants.Add(ing.getIngrediants());

            obj.PrintAmountReq();
            ing.setAmount(Convert.ToInt32(Console.ReadLine()));
            quantity.Add(ing.getAmount());

            obj.PrintMeasure();
            ing.setUnitOfMeasure(Console.ReadLine());
            measurements.Add(ing.getUnitOfMeasure());


        }

    }

    /*
     * Method steps allows the user to right as many steps as is required for the recipe
     * the steps is saved to an arraylist steps
     */
    public void steps(List<string> steps)
    {
        string step;
        int stepA;

        obj.StepCountReq();
        stepA = Convert.ToInt32(Console.ReadLine()); // this value will be used to determine the amount of times we go through the forloop

        for (int i = 0; i < stepA; i++) // forloop is used to output and gain a input for as many steps as is required
        {
            Console.WriteLine(obj.StepTrack() + (i + 1));
            step = Console.ReadLine();
            steps.Add(step);
        }
    }

    /*
     * Method PrintRecipe is made to take all the information stored in the arraylists and print it out into a specific format
     */
    public void printRecipe(List<string> steps, List<string> ingrediants, List<double> quantity, List<string> measurements, List<string> recipeN)
    {
        obj.Recipe();
        for (int i =0; i < recipeN.Count; i++)
        {
            Console.WriteLine(recipeN[i]);
        }

       obj.Ingrediants();
        for (int i = 0; i < ingrediants.Count; i++) // forloop is used to print out all values saved in the arraylists ingrediants, quantity and measurements
        {
            Console.WriteLine(ingrediants[i]);
            Console.WriteLine(quantity[i] + " " + measurements[i] + "\n");
        }

        obj.Steps();
        for (int i = 0; i < steps.Count; i++) // forloop is used to print out all values stored in the arraylist steps
        {
            Console.WriteLine("Step " + (i + 1) + ": " + steps[i]);
        }
        Console.WriteLine("\n");
    }

    /*
     * ScaleRecipe is made to scale the information stored in the quantity arraylist for as many people the user needs
     */
    public void scaleRecipe(List<double> quantity)
    {
        double factor;

        obj.Guest();
        factor = Convert.ToDouble(Console.ReadLine());

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
    public void resetRecipe(List<double> quantity)
    {
        for (int i = 0; i < quantity.Count; i++) // is made to reset the quantity to 1 portion by deviding with the product of sum and factor
        {
            quantity[i] /= sum;
        }
    }

    /*
     * The method ClearRecipe is made to clear all information from the arraylists
     * it removes all recipes saved
     */
    public void clearRecipe(List<string> steps, List<string> ingrediants, List<double> quantity, List<string> measurements, List<string> recipeN)
    {
        quantity.Clear();
        ingrediants.Clear();
        measurements.Clear();
        steps.Clear();
        recipeN.Clear();
    }


}
