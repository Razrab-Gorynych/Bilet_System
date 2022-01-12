using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

public class Users
{
	int id;
	public string email;
    public string password;
	int id_role;

	public Users()
	{

    }

    public void Login()
    {

    }

    private void login()
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