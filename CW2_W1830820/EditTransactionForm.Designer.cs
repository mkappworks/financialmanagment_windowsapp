
namespace CW2_W1830820
{
    partial class EditTransactionForm
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
            this.comboBoxContact = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnIncome = new System.Windows.Forms.RadioButton();
            this.radioBtnExpense = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxContact
            // 
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(125, 118);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(191, 21);
            this.comboBoxContact.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contact";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(125, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 22;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(125, 159);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(191, 20);
            this.textBoxAmount.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnIncome);
            this.groupBox1.Controls.Add(this.radioBtnExpense);
            this.groupBox1.Location = new System.Drawing.Point(125, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 46);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // radioBtnIncome
            // 
            this.radioBtnIncome.AutoSize = true;
            this.radioBtnIncome.Location = new System.Drawing.Point(113, 14);
            this.radioBtnIncome.Name = "radioBtnIncome";
            this.radioBtnIncome.Size = new System.Drawing.Size(60, 17);
            this.radioBtnIncome.TabIndex = 1;
            this.radioBtnIncome.Text = "Income";
            this.radioBtnIncome.UseVisualStyleBackColor = true;
            // 
            // radioBtnExpense
            // 
            this.radioBtnExpense.AutoSize = true;
            this.radioBtnExpense.Checked = true;
            this.radioBtnExpense.Location = new System.Drawing.Point(22, 14);
            this.radioBtnExpense.Name = "radioBtnExpense";
            this.radioBtnExpense.Size = new System.Drawing.Size(66, 17);
            this.radioBtnExpense.TabIndex = 0;
            this.radioBtnExpense.TabStop = true;
            this.radioBtnExpense.Text = "Expense";
            this.radioBtnExpense.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(107, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 49);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditTransaction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            // 
            // EditTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 314);
            this.Controls.Add(this.comboBoxContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTransactionForm";
            this.Text = "EditTransactionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnIncome;
        private System.Windows.Forms.RadioButton radioBtnExpense;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}