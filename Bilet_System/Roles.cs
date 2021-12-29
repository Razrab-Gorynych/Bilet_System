using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Roles
{
	int id;
	string title;

	public Roles()
	{

	}

	public void Send()
	{
		try
		{
			Bilet_System.Bilet_SystemDataSetTableAdapters.RolesTableAdapter rolestableadapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.RolesTableAdapter();
			rolestableadapter.Insert(title);
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

	public string GetTitle()
    {
		return title;
    }
}
