using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Users
{
	int id;
	string email;
	string password;
	int id_role;

	public Users()
	{

    }

    public void Send()
    {
        
    }

    public int GetID()
	{
		return id;

    }

	public string GetEmail()
    {
		return email;
    }

	public string GetPassword()
    {
		return password;
    }

	public int GetIDRole()
    {
		return id_role;
    }
}