
namespace CW2_W1830820
{
    partial class EditContactForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnPayee = new System.Windows.Forms.RadioButton();
            this.radioBtnPayer = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(123, 92);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 20);
            this.textName.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnPayee);
            this.groupBox1.Controls.Add(this.radioBtnPayer);
            this.groupBox1.Location = new System.Drawing.Point(123, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 46);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radioBtnPayee
            // 
            this.radioBtnPayee.AutoSize = true;
            this.radioBtnPayee.Location = new System.Drawing.Point(113, 14);
            this.radioBtnPayee.Name = "radioBtnPayee";
            this.radioBtnPayee.Size = new System.Drawing.Size(55, 17);
            this.radioBtnPayee.TabIndex = 1;
            this.radioBtnPayee.Text = "Payee";
            this.radioBtnPayee.UseVisualStyleBackColor = true;
            // 
            // radioBtnPayer
            // 
            this.radioBtnPayer.AutoSize = true;
            this.radioBtnPayer.Checked = true;
            this.radioBtnPayer.Location = new System.Drawing.Point(22, 14);
            this.radioBtnPayer.Name = "radioBtnPayer";
            this.radioBtnPayer.Size = new System.Drawing.Size(52, 17);
            this.radioBtnPayer.TabIndex = 0;
            this.radioBtnPayer.TabStop = true;
            this.radioBtnPayer.Text = "Payer";
            this.radioBtnPayer.UseVisualStyleBackColor = true;
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
            this.btnEdit.Location = new System.Drawing.Point(107, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 49);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.EditContact);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type";
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 248);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditContactForm";
            this.Text = "EditContactForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnPayee;
        private System.Windows.Forms.RadioButton radioBtnPayer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}