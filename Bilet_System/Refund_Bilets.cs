using System;
using System.Windows.Forms;

public class Refund_Bilets
{
	int id_bilet;
	int amount_return_bilets;
	int sum_return;

	public Refund_Bilets()
	{

	}

    public void Send()
    {
        try
        {
            Bilet_System.Bilet_SystemDataSetTableAdapters.Refund_BiletsTableAdapter refund_biletsTableAdapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.Refund_BiletsTableAdapter();
            refund_biletsTableAdapter.Insert(id_bilet, amount_return_bilets, sum_return);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Exception Message: " + ex.Message);
        }
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
