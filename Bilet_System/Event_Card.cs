using System;
using System.Windows.Forms;

public class Event_Card
{
	public int id_event_card;
	public string name_event_card;
	public string category_bilets;
	public int amount_of_visitors;
	public string topic_bilet;
	public string address_bilet;
	public string place_bilet;
	public DateTime date_bilet;
	public TimeSpan time_bilet;
	public int price_bilets;

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

}
