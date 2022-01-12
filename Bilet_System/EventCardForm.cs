using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_System
{
    public partial class EventCardForm : Form
    {
        public EventCardForm()
        {
            InitializeComponent();
        }

        Event_Card eventCard = new Event_Card();
        BiletsForm bForm = new BiletsForm();

        private void EventCardForm_Load(object sender, EventArgs e)
        {

        }


        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time;
                eventCard.name_event_card = Name_Organizacii.Text;
                eventCard.category_bilets = Kategori_Bilets.Text;
                eventCard.topic_bilet = Topic.Text;
                eventCard.amount_of_visitors = Convert.ToInt32(Amount_bilets.Text);
                eventCard.address_bilet = Address.Text;
                eventCard.place_bilet = Place.Text;
                eventCard.date_bilet = Convert.ToDateTime(Date.Text);
                time = Convert.ToDateTime(Time.Text);
                eventCard.time_bilet = time.TimeOfDay;
                eventCard.price_bilets = Convert.ToInt32(Price.Text);
                eventCard.Send();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность введённых данных                             " +
                    " Exception Message: " + ex.Message);

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            bForm.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
