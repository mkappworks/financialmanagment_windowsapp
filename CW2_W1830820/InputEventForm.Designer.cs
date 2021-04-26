
namespace CW2_W1830820
{
    partial class InputEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxAdditionalRecurring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOccurrenceType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnTask = new System.Windows.Forms.RadioButton();
            this.radioBtnAppointment = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(128, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 49);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveEvent);
            // 
            // textBoxAdditionalRecurring
            // 
            this.textBoxAdditionalRecurring.Location = new System.Drawing.Point(218, 115);
            this.textBoxAdditionalRecurring.Name = "textBoxAdditionalRecurring";
            this.textBoxAdditionalRecurring.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdditionalRecurring.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Additional Recurring";
            // 
            // comboBoxOccurrenceType
            // 
            this.comboBoxOccurrenceType.FormattingEnabled = true;
            this.comboBoxOccurrenceType.Location = new System.Drawing.Point(218, 41);
            this.comboBoxOccurrenceType.Name = "comboBoxOccurrenceType";
            this.comboBoxOccurrenceType.Size = new System.Drawing.Size(191, 21);
            this.comboBoxOccurrenceType.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Occurrence Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnTask);
            this.groupBox2.Controls.Add(this.radioBtnAppointment);
            this.groupBox2.Location = new System.Drawing.Point(218, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 46);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // radioBtnTask
            // 
            this.radioBtnTask.AutoSize = true;
            this.radioBtnTask.Location = new System.Drawing.Point(113, 14);
            this.radioBtnTask.Name = "radioBtnTask";
            this.radioBtnTask.Size = new System.Drawing.Size(49, 17);
            this.radioBtnTask.TabIndex = 1;
            this.radioBtnTask.Text = "Task";
            this.radioBtnTask.UseVisualStyleBackColor = true;
            // 
            // radioBtnAppointment
            // 
            this.radioBtnAppointment.AutoSize = true;
            this.radioBtnAppointment.Checked = true;
            this.radioBtnAppointment.Location = new System.Drawing.Point(22, 14);
            this.radioBtnAppointment.Name = "radioBtnAppointment";
            this.radioBtnAppointment.Size = new System.Drawing.Size(84, 17);
            this.radioBtnAppointment.TabIndex = 0;
            this.radioBtnAppointment.TabStop = true;
            this.radioBtnAppointment.Text = "Appointment";
            this.radioBtnAppointment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Event Type";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(218, 77);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 48;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(218, 148);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(191, 20);
            this.textBoxDescription.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Start Date";
            // 
            // InputEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 349);
            this.Controls.Add(this.textBoxAdditionalRecurring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOccurrenceType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "InputEventForm";
            this.Text = "InputEventForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxAdditionalRecurring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOccurrenceType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnTask;
        private System.Windows.Forms.RadioButton radioBtnAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}