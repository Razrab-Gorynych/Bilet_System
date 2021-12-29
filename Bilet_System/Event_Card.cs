using System;
using System.Windows.Forms;

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
	TimeSpan time_bilet;
	int price_bilets;

	public Event_Card()
	{
	   
	}

	public void Send()
    {
        try
        {
            Bilet_System.Bilet_SystemDataSetTableAdapters.Event_CardTableAdapter event_CardTableAdapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.Event_CardTableAdapter();
            event_CardTableAdapter.Insert(name_event_card, category_bilets, amount_of_visitors, topic_bilet, address_bilet, place_bilet, date_bilet, time_bilet, price_bilets);
        }
        catch (Exception ex)
        {
			MessageBox.Show("Exception Message: " + ex.Message);
		}

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

	public TimeSpan GetTime()
	{
		return time_bilet;
	}

	public int GetPrice()
	{
		return price_bilets;
	}
}
