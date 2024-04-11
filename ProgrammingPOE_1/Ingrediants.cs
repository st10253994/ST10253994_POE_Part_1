using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ingrediants
{
	public string ingrediants;
	public string unitOfMeasure;
	double amount;


	public String getIngrediants()
	{
		return ingrediants;
	}

	public void setIngrediants(String Value)
	{
		ingrediants = Value;
	}

	public String getUnitOfMeasure()
	{
		return unitOfMeasure;
	}

	public void setUnitOfMeasure(String Value)
	{
		unitOfMeasure = Value;
	}

	public double getAmount()
	{
		return amount;
	}

	public void setAmount(int Value)
	{
		amount = Value;
	}

}
