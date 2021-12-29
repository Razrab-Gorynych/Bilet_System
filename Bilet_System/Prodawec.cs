using System;
using System.Windows.Forms;

public class Prodawec
{
	int id;
	string familia;
	string imya;
	string otchestvo;
	string passport_num_series;
	DateTime date_od_birth;
	int id_bilet;

	public Prodawec()
	{

	}

	public void Send()
    {
		try
		{
			Bilet_System.Bilet_SystemDataSetTableAdapters.ProdawecTableAdapter prodawecTableAdapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.ProdawecTableAdapter();
			prodawecTableAdapter.Insert(id, familia, imya, otchestvo, passport_num_series, date_od_birth, id_bilet);
		}
		catch (Exception ex)
        {
			MessageBox.Show("Exception Message: " + ex.Message);
        }

	}

	public int GetID()
	{
		return id;
	}

	public string GetFamilia()
	{
		return familia;
	}

	public string GetImya()
	{
		return imya;
	}

	public string GetOtchestvo()
	{
		return otchestvo;
	}

	public string GetPassportNumSeries()
    {
		return passport_num_series;
    }

	public DateTime GetDateOfBirth()
    {
		return date_od_birth;
    }

	public int GetIDBilet()
	{
		return id_bilet;
	}
}
