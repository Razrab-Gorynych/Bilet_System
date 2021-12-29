using System;

public class Refund_Bilets
{
	int id_bilet;
	int amount_return_bilets;
	int sum_return;

	public Refund_Bilets()
	{

	}

	public int GetIDBilet()
	{
		return id_bilet;
	}

	public int GetAmountReturnBilets()
    {
		return amount_return_bilets;
    }

	public int GetSumReturn()
    {
		return sum_return;
    }
}
