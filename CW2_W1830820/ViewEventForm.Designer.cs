﻿
namespace CW2_W1830820
{
    partial class ViewEventForm
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
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OccurrenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.AllowUserToAddRows = false;
            this.dataGridViewEvent.AllowUserToDeleteRows = false;
            this.dataGridViewEvent.AutoGenerateColumns = false;
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OccurrenceType,
            this.startDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewEvent.DataSource = this.eventDetailsBindingSource1;
            this.dataGridViewEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.ReadOnly = true;
            this.dataGridViewEvent.Size = new System.Drawing.Size(748, 450);
            this.dataGridViewEvent.TabIndex = 1;
            this.dataGridViewEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eventDetailsBindingSource
            // 
            this.eventDetailsBindingSource.DataSource = typeof(CW2_W1830820.EventDetails);
            // 
            // eventDetailsBindingSource1
            // 
            this.eventDetailsBindingSource1.DataSource = typeof(CW2_W1830820.EventDetails);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // OccurrenceType
            // 
            this.OccurrenceType.DataPropertyName = "OccurrenceType";
            this.OccurrenceType.HeaderText = "OccurrenceType";
            this.OccurrenceType.Name = "OccurrenceType";
            this.OccurrenceType.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            this.eventTypeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ViewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.dataGridViewEvent);
            this.Name = "ViewEventForm";
            this.Text = "ViewEventForm";
            this.Load += new System.EventHandler(this.ViewEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventOccurrenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventDetailsBindingSource;
        private System.Windows.Forms.BindingSource eventDetailsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OccurrenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}