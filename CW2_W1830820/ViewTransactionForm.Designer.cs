
namespace CW2_W1830820
{
    partial class ViewTransactionForm
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
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.transactionDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.AllowUserToAddRows = false;
            this.dataGridViewTransaction.AllowUserToDeleteRows = false;
            this.dataGridViewTransaction.AutoGenerateColumns = false;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewTransaction.DataSource = this.transactionDetailsBindingSource;
            this.dataGridViewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.ReadOnly = true;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(743, 463);
            this.dataGridViewTransaction.TabIndex = 0;
            this.dataGridViewTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 75;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 75;
            // 
            // transactionDetailsBindingSource
            // 
            this.transactionDetailsBindingSource.DataSource = typeof(CW2_W1830820.TransactionDetails);
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 463);
            this.Controls.Add(this.dataGridViewTransaction);
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            this.Load += new System.EventHandler(this.ViewTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource transactionDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}