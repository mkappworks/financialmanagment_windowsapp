using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CW2_W1830820
{
    public partial class EditEventForm : Form

    {

        private DBManager dbManager = new DBManager();

        public EventDetails EventDetailsData { get; set; }


        public EditEventForm(EventDetails eventDetails)
        {
            InitializeComponent();

            this.EventDetailsData = new EventDetails();

            this.EventDetailsData.Id = eventDetails.Id;
            this.EventDetailsData.OccurrenceType = eventDetails.OccurrenceType;
            this.EventDetailsData.StartDate = eventDetails.StartDate;
            this.EventDetailsData.NumberOfAdditionalTimesRecurring = eventDetails.NumberOfAdditionalTimesRecurring;
            this.EventDetailsData.Description = eventDetails.Description;
            this.EventDetailsData.EventType = eventDetails.EventType;

            this.comboBoxOccurrenceType.SelectedItem = EventDetailsData.OccurrenceType;
            this.dateTimePickerStartDate.Value = EventDetailsData.StartDate;
            this.textBoxAdditionalRecurring.Text = EventDetailsData.NumberOfAdditionalTimesRecurring.ToString();
            this.textBoxDescription.Text = EventDetailsData.Description;


            if (this.EventDetailsData.EventType == "Appointment")
            {
                this.radioBtnAppointment.Checked = true;
            }
            else if (this.EventDetailsData.EventType == "Task")
            {
                this.radioBtnTask.Checked = true;
            }
        }

        private void EditEvent(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to edit the selected event?", "PFMS | Edit Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.EventDetailsData.OccurrenceType = (string)this.comboBoxOccurrenceType.SelectedItem;
                this.EventDetailsData.StartDate = this.dateTimePickerStartDate.Value;
                this.EventDetailsData.NumberOfAdditionalTimesRecurring = int.Parse(this.textBoxAdditionalRecurring.Text);
                this.EventDetailsData.Description = this.textBoxDescription.Text;

                if (this.radioBtnAppointment.Checked)
                {
                    this.EventDetailsData.EventType = "Appointment";
                }
                else if (this.radioBtnTask.Checked)
                {
                    this.EventDetailsData.EventType = "Task";
                }

                if (File.Exists(@"eventeditdata.xml"))
                {
                    this.dbManager.ReadXml(@"eventeditdata.xml");
                }

                DBManager.EventHeaderRow row = this.dbManager.EventHeader.NewEventHeaderRow();


                row.OccurrenceType = this.EventDetailsData.OccurrenceType;
                row.StartDate = this.EventDetailsData.StartDate;
                row.NumberOfAdditionalTimesRecurring_ = this.EventDetailsData.NumberOfAdditionalTimesRecurring;
                row.Description = this.EventDetailsData.Description;
                row.EventType = this.EventDetailsData.EventType;

                this.dbManager.EventHeader.AddEventHeaderRow(row);
                this.dbManager.AcceptChanges();

                this.dbManager.WriteXml(@"eventeditdata.xml");

                EventModel eventModel = new EventModel();

                eventModel.EditEvent(EventDetailsData);

                this.dbManager.Reset();
                File.Delete(@"eventeditdata.xml");

                MessageBox.Show("Successfully Edited");

                this.Close();

            }
        }
    }
}
