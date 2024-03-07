﻿using System;
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
    public void Ingrediants(List<string> ingrediants, List<int> quantity, List<string> measurements)
    {
        int ingrediantC, amount;
        string ingrediantName, measure;

        Console.WriteLine("Please enter the amount of ingrediants: ");
        ingrediantC = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < ingrediantC; i++)
        {

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
        stepA = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < stepA; i++)
        {
            Console.WriteLine("Please enter step " + (i + 1));
            step = Console.ReadLine();
            steps.Add(step);
        }
    }

    /*
     * Method PrintRecipe is made to take all the information stored in the arraylists and print it out into a specific format
     */
    public void PrintRecipe(List<string> steps, List<string> ingrediants, List<int> quantity, List<string> measurements)
    {
        Console.WriteLine("Recipe:\n\nIngrediants:");
        for (int i = 0; i < ingrediants.Count; i++)
        {
            Console.WriteLine(ingrediants[i]);
            Console.WriteLine(quantity[i] + measurements[i]);
        }

        Console.WriteLine("\nSteps: ");
        for (int i = 0; i < steps.Count; i++)
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

        for (int i = 0; i < quantity.Count; i++)
        {
            amount = quantity[i] * factor;
            quantity[i] = amount;
        }
        sum = sum * factor;
    }

    /*
     * The method RestRecipe is made to reverse the effects of scale recipe
     * This ensures that if the user is done with the recipe he can scale it back down to a single portion
     */
    public void ResetRecipe(List<int> quantity)
    {
        int amount;

        for (int i = 0; i < quantity.Count; i++)
        {
            amount = quantity[i] / sum;
            quantity[i] = amount;
        }
    }

    /*
     * The method ClearRecipe is made to clear all information from the arraylists
     * it removes all recipes saved
     */
    public void ClearRecipe(List<string> steps, List<string> ingrediants, List<int> quantity, List<string> measurements)
    {
        quantity.Clear();
        ingrediants.Clear();
        measurements.Clear();
        steps.Clear();
    }


}