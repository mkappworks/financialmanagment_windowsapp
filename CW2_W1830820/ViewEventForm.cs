using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2_W1830820
{
    public partial class ViewEventForm : Form
    {
        public EventDetails EventDetailsData { get; set; }

        public ViewEventForm()
        {
            InitializeComponent();
        }



        private void ViewEventForm_Load(object sender, EventArgs e)
        {
            GetEventData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewEvent.Columns[e.ColumnIndex].Name == "Edit")
            {

                int selectId = (int)dataGridViewEvent.Rows[e.RowIndex].Cells[0].Value;
                string selectEventOccurrence = (string)dataGridViewEvent.Rows[e.RowIndex].Cells[1].Value;
                DateTime selectStartDate = (DateTime)dataGridViewEvent.Rows[e.RowIndex].Cells[2].Value;
                int selectNumberOfAdditionalTimesRecurring = (int)dataGridViewEvent.Rows[e.RowIndex].Cells[3].Value;
                string selectDescription = (string)dataGridViewEvent.Rows[e.RowIndex].Cells[4].Value;
                string selectEventType = (string)dataGridViewEvent.Rows[e.RowIndex].Cells[5].Value;


                this.EventDetailsData = new EventDetails();
                this.EventDetailsData.Id = selectId;
                this.EventDetailsData.OccurrenceType = selectEventOccurrence;
                this.EventDetailsData.StartDate = selectStartDate;
                this.EventDetailsData.AdditionalRecurring = selectNumberOfAdditionalTimesRecurring;
                this.EventDetailsData.Description = selectDescription;
                this.EventDetailsData.EventType = selectEventType;

                EditEventForm editEventForm = new EditEventForm(EventDetailsData);

                editEventForm.Activate();
                editEventForm.ShowDialog();

                GetEventData();


            }

            if (dataGridViewEvent.Columns[e.ColumnIndex].Name == "Delete")
            {


                if (MessageBox.Show("Do you want to delete the selected event?", "PFMS | Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int selectId = (int)dataGridViewEvent.Rows[e.RowIndex].Cells[0].Value;

                    EventModel eventModel = new EventModel();
                    eventModel.DeleteEvent(selectId);
                    
                    MessageBox.Show("Successfully Deleted");

                    eventDetailsBindingSource.RemoveCurrent();
                }

            }
        }

        private void GetEventData()
        {
            this.dataGridViewEvent.Rows.Clear();

            EventModel eventModel = new EventModel();
            var eventTable = eventModel.GetEvent();
            /*
            foreach (var event in eventTable)
            {

            this.eventDetailsBindingSource.Add(new EventDetails()
            {
                Id = event.Id,
                EventOccurrence= event.EventOccurrence ,
                StartDate=  event.StartDate ,
                NumberOfAdditionalTimesRecurring= event.NumberOfAdditionalTimesRecurring ,
                Description =  event.Description ,
                EventType= event.EventType ,
             });
            }
            */



}


    }
}
