using System;
using System.Windows.Forms;


public class Pokupatel
{
	int id;
	string familia;
	string imya;
	string otchestvo;
	int id_bilet;

	public Pokupatel()
	{

	}

	public void Send()
    {
        try
        {
            Bilet_System.Bilet_SystemDataSetTableAdapters.PokupatelTableAdapter pokupatelTableAdapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.PokupatelTableAdapter();
            pokupatelTableAdapter.Insert(id, familia, imya, otchestvo, id_bilet);
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

	public int GetIDBilet()
	{
		return id_bilet;
	}
}
