using System;

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
