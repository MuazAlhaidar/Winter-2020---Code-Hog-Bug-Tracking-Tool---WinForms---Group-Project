namespace Code_Hog
{
    partial class DependenciesMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addDependencyButton = new System.Windows.Forms.Button();
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteDependencyButton = new System.Windows.Forms.Button();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet = new Code_Hog.CodeHogDataSet();
            this.ticketsTableAdapter = new Code_Hog.CodeHogDataSetTableAdapters.TicketsTableAdapter();
            this.confirmChangesButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.codeHogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet1 = new Code_Hog.CodeHogDataSet1();
            this.codeHogDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet2 = new Code_Hog.CodeHogDataSet2();
            this.dependenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependenciesTableAdapter = new Code_Hog.CodeHogDataSet2TableAdapters.DependenciesTableAdapter();
            this.dependentTicketIDLabel = new System.Windows.Forms.Label();
            this.dependencyDataGridView = new System.Windows.Forms.DataGridView();
            this.dependencyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependentTicketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDTicketIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependencyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addDependencyButton
            // 
            this.addDependencyButton.Enabled = false;
            this.addDependencyButton.Location = new System.Drawing.Point(311, 465);
            this.addDependencyButton.Name = "addDependencyButton";
            this.addDependencyButton.Size = new System.Drawing.Size(110, 27);
            this.addDependencyButton.TabIndex = 1;
            this.addDependencyButton.Text = "Add Dependency";
            this.addDependencyButton.UseVisualStyleBackColor = true;
            this.addDependencyButton.Click += new System.EventHandler(this.AddDepnedncyButton);
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketIDLabel.Location = new System.Drawing.Point(82, 19);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(16, 18);
            this.ticketIDLabel.TabIndex = 49;
            this.ticketIDLabel.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ticket #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Current Dependencies:";
            // 
            // deleteDependencyButton
            // 
            this.deleteDependencyButton.Enabled = false;
            this.deleteDependencyButton.Location = new System.Drawing.Point(85, 465);
            this.deleteDependencyButton.Name = "deleteDependencyButton";
            this.deleteDependencyButton.Size = new System.Drawing.Size(110, 27);
            this.deleteDependencyButton.TabIndex = 52;
            this.deleteDependencyButton.Text = "Delete Dependency";
            this.deleteDependencyButton.UseVisualStyleBackColor = true;
            this.deleteDependencyButton.Click += new System.EventHandler(this.DeleteDependcyButton);
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AllowUserToAddRows = false;
            this.ticketDataGridView.AllowUserToDeleteRows = false;
            this.ticketDataGridView.AllowUserToResizeColumns = false;
            this.ticketDataGridView.AllowUserToResizeRows = false;
            this.ticketDataGridView.AutoGenerateColumns = false;
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn,
            this.ticketStatusDataGridViewTextBoxColumn,
            this.ticketPriorityDataGridViewTextBoxColumn});
            this.ticketDataGridView.DataSource = this.ticketsBindingSource;
            this.ticketDataGridView.Location = new System.Drawing.Point(311, 19);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ticketDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketDataGridView.Size = new System.Drawing.Size(446, 440);
            this.ticketDataGridView.TabIndex = 53;
            this.ticketDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TicketDataGridView_RowHeaderMouseClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            this.ticketNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketStatusDataGridViewTextBoxColumn
            // 
            this.ticketStatusDataGridViewTextBoxColumn.DataPropertyName = "TicketStatus";
            this.ticketStatusDataGridViewTextBoxColumn.HeaderText = "TicketStatus";
            this.ticketStatusDataGridViewTextBoxColumn.Name = "ticketStatusDataGridViewTextBoxColumn";
            this.ticketStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketPriorityDataGridViewTextBoxColumn
            // 
            this.ticketPriorityDataGridViewTextBoxColumn.DataPropertyName = "TicketPriority";
            this.ticketPriorityDataGridViewTextBoxColumn.HeaderText = "TicketPriority";
            this.ticketPriorityDataGridViewTextBoxColumn.Name = "ticketPriorityDataGridViewTextBoxColumn";
            this.ticketPriorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.codeHogDataSet;
            // 
            // codeHogDataSet
            // 
            this.codeHogDataSet.DataSetName = "CodeHogDataSet";
            this.codeHogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // confirmChangesButton
            // 
            this.confirmChangesButton.Enabled = false;
            this.confirmChangesButton.Location = new System.Drawing.Point(544, 465);
            this.confirmChangesButton.Name = "confirmChangesButton";
            this.confirmChangesButton.Size = new System.Drawing.Size(96, 27);
            this.confirmChangesButton.TabIndex = 54;
            this.confirmChangesButton.Text = "Confirm Changes";
            this.confirmChangesButton.UseVisualStyleBackColor = true;
            this.confirmChangesButton.Click += new System.EventHandler(this.ConfirmChangesButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(661, 465);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 27);
            this.cancelButton.TabIndex = 55;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // codeHogDataSetBindingSource
            // 
            this.codeHogDataSetBindingSource.DataSource = this.codeHogDataSet;
            this.codeHogDataSetBindingSource.Position = 0;
            // 
            // codeHogDataSet1
            // 
            this.codeHogDataSet1.DataSetName = "CodeHogDataSet1";
            this.codeHogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeHogDataSet1BindingSource
            // 
            this.codeHogDataSet1BindingSource.DataSource = this.codeHogDataSet1;
            this.codeHogDataSet1BindingSource.Position = 0;
            // 
            // codeHogDataSet2
            // 
            this.codeHogDataSet2.DataSetName = "CodeHogDataSet2";
            this.codeHogDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dependenciesBindingSource
            // 
            this.dependenciesBindingSource.DataMember = "Dependencies";
            this.dependenciesBindingSource.DataSource = this.codeHogDataSet2;
            // 
            // dependenciesTableAdapter
            // 
            this.dependenciesTableAdapter.ClearBeforeFill = true;
            // 
            // dependentTicketIDLabel
            // 
            this.dependentTicketIDLabel.AutoSize = true;
            this.dependentTicketIDLabel.Location = new System.Drawing.Point(308, 3);
            this.dependentTicketIDLabel.Name = "dependentTicketIDLabel";
            this.dependentTicketIDLabel.Size = new System.Drawing.Size(100, 13);
            this.dependentTicketIDLabel.TabIndex = 56;
            this.dependentTicketIDLabel.Text = "Dependent Ticket#";
            this.dependentTicketIDLabel.Visible = false;
            // 
            // dependencyDataGridView
            // 
            this.dependencyDataGridView.AllowUserToAddRows = false;
            this.dependencyDataGridView.AllowUserToDeleteRows = false;
            this.dependencyDataGridView.AllowUserToResizeColumns = false;
            this.dependencyDataGridView.AllowUserToResizeRows = false;
            this.dependencyDataGridView.AutoGenerateColumns = false;
            this.dependencyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dependencyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dependencyIDDataGridViewTextBoxColumn,
            this.dependentTicketIDDataGridViewTextBoxColumn});
            this.dependencyDataGridView.DataSource = this.dependenciesBindingSource;
            this.dependencyDataGridView.Location = new System.Drawing.Point(11, 78);
            this.dependencyDataGridView.Name = "dependencyDataGridView";
            this.dependencyDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dependencyDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dependencyDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dependencyDataGridView.Size = new System.Drawing.Size(274, 381);
            this.dependencyDataGridView.TabIndex = 57;
            this.dependencyDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DependencyDataGridView_RowHeaderMouseClick);
            // 
            // dependencyIDDataGridViewTextBoxColumn
            // 
            this.dependencyIDDataGridViewTextBoxColumn.DataPropertyName = "DependencyID";
            this.dependencyIDDataGridViewTextBoxColumn.HeaderText = "DependencyID";
            this.dependencyIDDataGridViewTextBoxColumn.Name = "dependencyIDDataGridViewTextBoxColumn";
            this.dependencyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dependencyIDDataGridViewTextBoxColumn.Width = 104;
            // 
            // dependentTicketIDDataGridViewTextBoxColumn
            // 
            this.dependentTicketIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dependentTicketIDDataGridViewTextBoxColumn.DataPropertyName = "DependentTicketID";
            this.dependentTicketIDDataGridViewTextBoxColumn.HeaderText = "DependentTicketID";
            this.dependentTicketIDDataGridViewTextBoxColumn.Name = "dependentTicketIDDataGridViewTextBoxColumn";
            this.dependentTicketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dependentTicketIDDataGridViewTextBoxColumn.Width = 126;
            // 
            // deleteDTicketIDLabel
            // 
            this.deleteDTicketIDLabel.AutoSize = true;
            this.deleteDTicketIDLabel.Location = new System.Drawing.Point(165, 62);
            this.deleteDTicketIDLabel.Name = "deleteDTicketIDLabel";
            this.deleteDTicketIDLabel.Size = new System.Drawing.Size(137, 13);
            this.deleteDTicketIDLabel.TabIndex = 58;
            this.deleteDTicketIDLabel.Text = "toDeleteDependentTicket#";
            this.deleteDTicketIDLabel.Visible = false;
            // 
            // DependenciesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 496);
            this.Controls.Add(this.deleteDTicketIDLabel);
            this.Controls.Add(this.dependencyDataGridView);
            this.Controls.Add(this.dependentTicketIDLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmChangesButton);
            this.Controls.Add(this.ticketDataGridView);
            this.Controls.Add(this.deleteDependencyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketIDLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDependencyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DependenciesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeHog: Edit Dependencies Menu";
            this.Load += new System.EventHandler(this.DependenciesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependencyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addDependencyButton;
        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteDependencyButton;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private CodeHogDataSet codeHogDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private CodeHogDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button confirmChangesButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource codeHogDataSetBindingSource;
        private CodeHogDataSet1 codeHogDataSet1;
        private System.Windows.Forms.BindingSource codeHogDataSet1BindingSource;
        private CodeHogDataSet2 codeHogDataSet2;
        private System.Windows.Forms.BindingSource dependenciesBindingSource;
        private CodeHogDataSet2TableAdapters.DependenciesTableAdapter dependenciesTableAdapter;
        private System.Windows.Forms.Label dependentTicketIDLabel;
        private System.Windows.Forms.DataGridView dependencyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependencyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependentTicketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label deleteDTicketIDLabel;
    }
}