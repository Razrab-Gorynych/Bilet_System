using System;

public class Bilets
{
	int id_bilet;
    int sold_bilets;


    

    public void Send()
    {
        Bilet_SystemDataSetTableAdapters.BiletTableAdapter bilettableadapter = new Bilet_SystemDataSetTableAdapters.BiletTableAdapter();
        bilettableadapter.Insert(id_bilet, sold_bilets);
    }

    public void SendAdd()
    {

    }

    public int GetIDBilet()
    {
        return id_bilet;
    }

	public int GetSold_bilets()
    {
		return sold_bilets;
	}


}
