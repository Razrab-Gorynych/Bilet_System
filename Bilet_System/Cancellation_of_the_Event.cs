using System;
using System.Windows.Forms;

public class Cancellation_of_the_Event
{
	int id_event_card;

	public Cancellation_of_the_Event()
	{

	}

	public void Send()
	{
		try
		{
			Bilet_System.Bilet_SystemDataSetTableAdapters.Cancellation_of_the_eventTableAdapter cancellation_of_the_eventTableAdapter = new Bilet_System.Bilet_SystemDataSetTableAdapters.Cancellation_of_the_eventTableAdapter();
			cancellation_of_the_eventTableAdapter.Insert(id_event_card);
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
}
