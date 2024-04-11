using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintUtil
{
	
	public void PrintMenu()
	{
		Console.WriteLine(RecipeConstants.Welcome_Message);
	}

	public void PrintRecipeN()
	{
		Console.WriteLine(RecipeConstants.Recipe_Name);
	}

	public void PrintIAmount()
	{
		Console.WriteLine(RecipeConstants.Ingreadiat_Count);
	}

	public void PrintIName()
	{
		Console.WriteLine(RecipeConstants.Ingrediant_Name);
	}

	public void PrintAmountReq()
	{
		Console.WriteLine(RecipeConstants.Amount_Request);
	}

	public void PrintMeasure()
	{
		Console.WriteLine(RecipeConstants.Unit_Measure);
	}

	public void StepCountReq()
	{
		Console.WriteLine(RecipeConstants.Step_Count);
	}

	public String StepTrack()
	{
		return RecipeConstants.Step_Track;
	}

	public void Ingrediants()
	{
		Console.WriteLine(RecipeConstants.Ingrediants);
	}

	public void Recipe()
	{
		Console.WriteLine(RecipeConstants.Recipe);
	}

	public void Steps()
	{
		Console.WriteLine(RecipeConstants.Steps);
	}

	public void Guest()
	{
		Console.WriteLine(RecipeConstants.Guest_Request);
	}

	public void ReadLine()
	{
		Console.ReadLine();
	}

	public void ReadlineInt()
	{
		Convert.ToInt32(Console.ReadLine());
	}

}
