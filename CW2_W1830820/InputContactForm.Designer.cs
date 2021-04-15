
namespace CW2_W1830820
{
    partial class InputContactForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnPayer = new System.Windows.Forms.RadioButton();
            this.radioBtnPayee = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
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
            this.btnSave.Location = new System.Drawing.Point(94, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveContact);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(110, 88);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnPayee);
            this.groupBox2.Controls.Add(this.radioBtnPayer);
            this.groupBox2.Location = new System.Drawing.Point(110, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radioBtnPayer
            // 
            this.radioBtnPayer.AutoSize = true;
            this.radioBtnPayer.Location = new System.Drawing.Point(17, 19);
            this.radioBtnPayer.Name = "radioBtnPayer";
            this.radioBtnPayer.Size = new System.Drawing.Size(52, 17);
            this.radioBtnPayer.TabIndex = 0;
            this.radioBtnPayer.TabStop = true;
            this.radioBtnPayer.Text = "Payer";
            this.radioBtnPayer.UseVisualStyleBackColor = true;
            // 
            // radioBtnPayee
            // 
            this.radioBtnPayee.AutoSize = true;
            this.radioBtnPayee.Location = new System.Drawing.Point(113, 19);
            this.radioBtnPayee.Name = "radioBtnPayee";
            this.radioBtnPayee.Size = new System.Drawing.Size(55, 17);
            this.radioBtnPayee.TabIndex = 1;
            this.radioBtnPayee.TabStop = true;
            this.radioBtnPayee.Text = "Payee";
            this.radioBtnPayee.UseVisualStyleBackColor = true;
            // 
            // InputContactForm
            // 
            this.ClientSize = new System.Drawing.Size(369, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputContactForm";
            this.Text = "Input Contact Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnPayee;
        private System.Windows.Forms.RadioButton radioBtnPayer;
    }
}