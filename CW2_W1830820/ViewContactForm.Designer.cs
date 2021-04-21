
namespace CW2_W1830820
{
    partial class ViewContactForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contactDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHeaderDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHeaderTransactionHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHeaderDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderTransactionHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.AllowUserToAddRows = false;
            this.dataGridViewContact.AllowUserToDeleteRows = false;
            this.dataGridViewContact.AutoGenerateColumns = false;
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewContact.DataSource = this.contactDetailsBindingSource;
            this.dataGridViewContact.Location = new System.Drawing.Point(34, 29);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.ReadOnly = true;
            this.dataGridViewContact.Size = new System.Drawing.Size(689, 199);
            this.dataGridViewContact.TabIndex = 0;
            this.dataGridViewContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContact_CellContentClick);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // contactDetailsBindingSource
            // 
            this.contactDetailsBindingSource.DataSource = typeof(CW2_W1830820.ContactDetails);
            // 
            // contactHeaderTransactionHeaderBindingSource
            // 
            this.contactHeaderTransactionHeaderBindingSource.DataSource = this.contactHeaderBindingSource;
            // 
            // ViewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewContact);
            this.Name = "ViewContactForm";
            this.Text = "ViewContactForm";
            this.Load += new System.EventHandler(this.ViewContactLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderTransactionHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.BindingSource contactHeaderDataTableBindingSource;
        private System.Windows.Forms.BindingSource contactHeaderBindingSource;
        private System.Windows.Forms.BindingSource contactHeaderTransactionHeaderBindingSource;
        private System.Windows.Forms.BindingSource contactHeaderDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource contactDetailsBindingSource;
    }
}