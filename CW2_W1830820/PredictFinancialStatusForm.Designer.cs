
namespace CW2_W1830820
{
    partial class PredictFinancialStatusForm
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
            this.btnPredict = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFinancialStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPredict.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnPredict.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPredict.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPredict.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPredict.Location = new System.Drawing.Point(136, 133);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(169, 49);
            this.btnPredict.TabIndex = 34;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(205, 38);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Financial Status";
            // 
            // textBoxFinancialStatus
            // 
            this.textBoxFinancialStatus.Location = new System.Drawing.Point(205, 73);
            this.textBoxFinancialStatus.Name = "textBoxFinancialStatus";
            this.textBoxFinancialStatus.Size = new System.Drawing.Size(200, 20);
            this.textBoxFinancialStatus.TabIndex = 35;
            // 
            // PredictFinancialStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 213);
            this.Controls.Add(this.textBoxFinancialStatus);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Name = "PredictFinancialStatusForm";
            this.Text = "PredictFinancialStatusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFinancialStatus;
    }
}