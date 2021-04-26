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
    public partial class InputEventForm : Form
    {
        private DBManager dbManager = new DBManager();
        public EventDetails EventDetailsData { get; set; }
        public InputEventForm()
        {
            InitializeComponent();

            this.radioBtnAppointment.Checked = true;
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save the new event?", "PFMS | Save Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                if (File.Exists(@"eventinputdata.xml"))
                {
                    this.dbManager.ReadXml(@"eventinputdata.xml");
                }

                DBManager.EventHeaderRow row = this.dbManager.EventHeader.NewEventHeaderRow();


                row.OccurrenceType = this.EventDetailsData.OccurrenceType;
                row.StartDate = this.EventDetailsData.StartDate;
                row.NumberOfAdditionalTimesRecurring_ = this.EventDetailsData.NumberOfAdditionalTimesRecurring;
                row.Description = this.EventDetailsData.Description;
                row.EventType = this.EventDetailsData.EventType;

                this.dbManager.EventHeader.AddEventHeaderRow(row);
                this.dbManager.AcceptChanges();

                this.dbManager.WriteXml(@"eventinputdata.xml");

                EventModel eventModel = new EventModel();

                eventModel.SaveEvent(EventDetailsData);

                this.dbManager.Reset();
                File.Delete(@"eventinputdata.xml");

                MessageBox.Show("Successfully Saved");

              

                this.radioBtnAppointment.Checked = true;
                this.textBoxAdditionalRecurring.Clear();
                this.textBoxDescription.Clear();

            }
        }
    }
}
