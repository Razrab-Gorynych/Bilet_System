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

    public void Send(int id, string ti)
    {
		
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
