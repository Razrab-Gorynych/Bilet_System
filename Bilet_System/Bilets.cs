using System;
using System.Windows.Forms;


public class Bilets
{
	int id_bilet;
    int sold_bilets;
	DateTime Date_pokupki;
	int ID;

	public void Send()
    {
        try
        {
            Bilet_System.Bilet_SystemDataSetTableAdapters.BiletTableAdapter biletstableadapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.BiletTableAdapter();
            biletstableadapter.Insert(sold_bilets, Date_pokupki, ID);
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

	public int GetSold_bilets()
    {
		return sold_bilets;
	}

    public DateTime GetDate_pokupki()
    {
        return Date_pokupki;
    }

    public int GetID()
    {
        return ID;
    }




}
