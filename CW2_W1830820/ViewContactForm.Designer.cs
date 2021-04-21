
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
            this.contactHeaderDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBManager = new CW2_W1830820.DBManager();
            this.contactHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHeaderTransactionHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHeaderDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.NameText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderTransactionHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.AllowUserToAddRows = false;
            this.dataGridViewContact.AllowUserToDeleteRows = false;
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameText,
            this.Type,
            this.Edit,
            this.Delete});
            this.dataGridViewContact.Location = new System.Drawing.Point(34, 29);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.ReadOnly = true;
            this.dataGridViewContact.Size = new System.Drawing.Size(447, 199);
            this.dataGridViewContact.TabIndex = 0;
            // 
            // contactHeaderDataTableBindingSource
            // 
            this.contactHeaderDataTableBindingSource.DataSource = typeof(CW2_W1830820.DBManager.ContactHeaderDataTable);
            // 
            // dBManager
            // 
            this.dBManager.DataSetName = "DBManager";
            this.dBManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactHeaderBindingSource
            // 
            this.contactHeaderBindingSource.DataMember = "ContactHeader";
            this.contactHeaderBindingSource.DataSource = this.dBManager;
            // 
            // contactHeaderTransactionHeaderBindingSource
            // 
            this.contactHeaderTransactionHeaderBindingSource.DataMember = "ContactHeader_TransactionHeader";
            this.contactHeaderTransactionHeaderBindingSource.DataSource = this.contactHeaderBindingSource;
            // 
            // contactHeaderDataTableBindingSource1
            // 
            this.contactHeaderDataTableBindingSource1.DataSource = typeof(CW2_W1830820.DBManager.ContactHeaderDataTable);
            // 
            // NameText
            // 
            this.NameText.HeaderText = "Name";
            this.NameText.Name = "NameText";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderTransactionHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHeaderDataTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.BindingSource contactHeaderDataTableBindingSource;
        private System.Windows.Forms.BindingSource contactHeaderBindingSource;
        private DBManager dBManager;
        private System.Windows.Forms.BindingSource contactHeaderTransactionHeaderBindingSource;
        private System.Windows.Forms.BindingSource contactHeaderDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}