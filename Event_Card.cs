using System;

public class Event_Card
{
	int id_event_card;
	string name_event_card;
	string category_bilets;
	int amount_of_visitors;
	string topic_bilet;
	string address_bilet;
	string place_bilet;
	DateTime date_bilet;
	DateTime time_bilet;
	int price_bilets;

	public Event_Card()
	{
	   
	}

	public int GetIDEventCard()
    {
		return id_event_card;
    }

	public string GetNameEventCard()
	{
		return name_event_card;
	}

	public string GetCategoryBilets()
	{
		return category_bilets;
	}

	public int GetAmountOfVisitors()
	{
		return amount_of_visitors;
	}

	public string GetTopicBilets()
	{
		return topic_bilet;
	}

	public string GetAddress()
	{
		return address_bilet;
	}

	public string GetPlace()
	{
		return place_bilet;
	}

	public DateTime GetDate()
	{
		return date_bilet;
	}

	public DateTime GetTime()
	{
		return time_bilet;
	}

	public int GetPrice()
	{
		return price_bilets;
	}
}
