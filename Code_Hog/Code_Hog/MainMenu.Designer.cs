namespace Code_Hog {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ticketsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet = new Code_Hog.CodeHogDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet1 = new Code_Hog.CodeHogDataSet1();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new Code_Hog.CodeHogDataSetTableAdapters.TicketsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_RolesTableAdapter = new Code_Hog.CodeHogDataSet1TableAdapters.User_RolesTableAdapter();
            this.usersTableAdapter = new Code_Hog.CodeHogDataSet1TableAdapters.UsersTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.EditDependenciesButton = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ChangeStatusButton = new System.Windows.Forms.Button();
            this.ChangePriorityButton = new System.Windows.Forms.Button();
            this.DeleteTicketButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.dependenciesLabel = new System.Windows.Forms.Label();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reporterNameLabel = new System.Windows.Forms.Label();
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketArchiveStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createNewTicketButton = new System.Windows.Forms.Button();
            this.archiveCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.userManagementButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsBindingSource1
            // 
            this.ticketsBindingSource1.DataMember = "Tickets";
            this.ticketsBindingSource1.DataSource = this.codeHogDataSet;
            // 
            // codeHogDataSet
            // 
            this.codeHogDataSet.DataSetName = "CodeHogDataSet";
            this.codeHogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.codeHogDataSet1BindingSource;
            // 
            // codeHogDataSet1BindingSource
            // 
            this.codeHogDataSet1BindingSource.DataSource = this.codeHogDataSet1;
            this.codeHogDataSet1BindingSource.Position = 0;
            // 
            // codeHogDataSet1
            // 
            this.codeHogDataSet1.DataSetName = "CodeHogDataSet1";
            this.codeHogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.codeHogDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "User_Roles";
            this.userRolesBindingSource.DataSource = this.codeHogDataSet1BindingSource;
            // 
            // user_RolesTableAdapter
            // 
            this.user_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1103, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Status:";
            // 
            // editDependenciesButton
            // 
            this.EditDependenciesButton.Enabled = false;
            this.EditDependenciesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDependenciesButton.Location = new System.Drawing.Point(871, 696);
            this.EditDependenciesButton.Name = "editDependenciesButton";
            this.EditDependenciesButton.Size = new System.Drawing.Size(132, 30);
            this.EditDependenciesButton.TabIndex = 60;
            this.EditDependenciesButton.Text = "Edit Dependencies";
            this.EditDependenciesButton.UseVisualStyleBackColor = true;
            this.EditDependenciesButton.Click += new System.EventHandler(this.EditDependenciesButton_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogout.Location = new System.Drawing.Point(1179, 12);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(75, 27);
            this.ButtonLogout.TabIndex = 59;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ChangeStatusButton
            // 
            this.ChangeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeStatusButton.Location = new System.Drawing.Point(1020, 696);
            this.ChangeStatusButton.Name = "ChangeStatusButton";
            this.ChangeStatusButton.Size = new System.Drawing.Size(108, 31);
            this.ChangeStatusButton.TabIndex = 58;
            this.ChangeStatusButton.Text = "Change Status";
            this.ChangeStatusButton.UseVisualStyleBackColor = true;
            this.ChangeStatusButton.Click += new System.EventHandler(this.ChangeStatusButton_Click);
            // 
            // ChangePriorityButton
            // 
            this.ChangePriorityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePriorityButton.Location = new System.Drawing.Point(1146, 695);
            this.ChangePriorityButton.Name = "ChangePriorityButton";
            this.ChangePriorityButton.Size = new System.Drawing.Size(107, 31);
            this.ChangePriorityButton.TabIndex = 57;
            this.ChangePriorityButton.Text = "Change Priority";
            this.ChangePriorityButton.UseVisualStyleBackColor = true;
            this.ChangePriorityButton.Click += new System.EventHandler(this.ChangePriorityButton_Click);
            // 
            // deleteTicketButton
            // 
            this.DeleteTicketButton.Enabled = false;
            this.DeleteTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTicketButton.Location = new System.Drawing.Point(570, 695);
            this.DeleteTicketButton.Name = "deleteTicketButton";
            this.DeleteTicketButton.Size = new System.Drawing.Size(96, 31);
            this.DeleteTicketButton.TabIndex = 56;
            this.DeleteTicketButton.Text = "Delete Ticket";
            this.DeleteTicketButton.UseVisualStyleBackColor = true;
            this.DeleteTicketButton.Click += new System.EventHandler(this.DeleteTicketButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "Select the Data Grid Headers to Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Filter by:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(1157, 102);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(14, 16);
            this.statusLabel.TabIndex = 53;
            this.statusLabel.Text = "..";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(973, 102);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(14, 16);
            this.priorityLabel.TabIndex = 52;
            this.priorityLabel.Text = "..";
            // 
            // dependenciesLabel
            // 
            this.dependenciesLabel.AutoSize = true;
            this.dependenciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependenciesLabel.Location = new System.Drawing.Point(780, 134);
            this.dependenciesLabel.Name = "dependenciesLabel";
            this.dependenciesLabel.Size = new System.Drawing.Size(0, 16);
            this.dependenciesLabel.TabIndex = 34;
            // 
            // addNoteButton
            // 
            this.addNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteButton.Location = new System.Drawing.Point(1170, 495);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(84, 27);
            this.addNoteButton.TabIndex = 51;
            this.addNoteButton.Text = "Add Note";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(675, 528);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(578, 161);
            this.noteTextBox.TabIndex = 50;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(676, 211);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(578, 278);
            this.descriptionTextBox.TabIndex = 49;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(729, 163);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(528, 22);
            this.nameTextBox.TabIndex = 48;
            // 
            // reporterNameLabel
            // 
            this.reporterNameLabel.AutoSize = true;
            this.reporterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporterNameLabel.Location = new System.Drawing.Point(744, 102);
            this.reporterNameLabel.Name = "reporterNameLabel";
            this.reporterNameLabel.Size = new System.Drawing.Size(14, 16);
            this.reporterNameLabel.TabIndex = 47;
            this.reporterNameLabel.Text = "..";
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketIDLabel.Location = new System.Drawing.Point(738, 72);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(14, 16);
            this.ticketIDLabel.TabIndex = 46;
            this.ticketIDLabel.Text = "..";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(674, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Dependencies:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Reporter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ticket #:";
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AllowUserToAddRows = false;
            this.ticketDataGridView.AllowUserToDeleteRows = false;
            this.ticketDataGridView.AllowUserToResizeColumns = false;
            this.ticketDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ticketDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketPriorityDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn,
            this.TicketArchiveStatus});
            this.ticketDataGridView.DataSource = this.ticketsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ticketDataGridView.Location = new System.Drawing.Point(12, 72);
            this.ticketDataGridView.MultiSelect = false;
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ticketDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ticketDataGridView.Size = new System.Drawing.Size(654, 617);
            this.ticketDataGridView.TabIndex = 37;
            this.ticketDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TicketDataGridView_RowHeaderMouseClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket #";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // ticketPriorityDataGridViewTextBoxColumn
            // 
            this.ticketPriorityDataGridViewTextBoxColumn.DataPropertyName = "TicketPriority";
            this.ticketPriorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.ticketPriorityDataGridViewTextBoxColumn.Name = "ticketPriorityDataGridViewTextBoxColumn";
            this.ticketPriorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketPriorityDataGridViewTextBoxColumn.Width = 55;
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            this.ticketNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketNameDataGridViewTextBoxColumn.Width = 400;
            // 
            // TicketArchiveStatus
            // 
            this.TicketArchiveStatus.DataPropertyName = "TicketArchiveStatus";
            this.TicketArchiveStatus.HeaderText = "Archived";
            this.TicketArchiveStatus.Name = "TicketArchiveStatus";
            this.TicketArchiveStatus.ReadOnly = true;
            this.TicketArchiveStatus.Width = 78;
            // 
            // createNewTicketButton
            // 
            this.createNewTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTicketButton.Location = new System.Drawing.Point(12, 695);
            this.createNewTicketButton.Name = "createNewTicketButton";
            this.createNewTicketButton.Size = new System.Drawing.Size(137, 31);
            this.createNewTicketButton.TabIndex = 36;
            this.createNewTicketButton.Text = "Create New Ticket";
            this.createNewTicketButton.UseVisualStyleBackColor = true;
            this.createNewTicketButton.Click += new System.EventHandler(this.CreateNewTicketButton_Click);
            // 
            // archiveCheckBox
            // 
            this.archiveCheckBox.AutoSize = true;
            this.archiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveCheckBox.Location = new System.Drawing.Point(592, 47);
            this.archiveCheckBox.Name = "archiveCheckBox";
            this.archiveCheckBox.Size = new System.Drawing.Size(72, 20);
            this.archiveCheckBox.TabIndex = 35;
            this.archiveCheckBox.Text = "Archive";
            this.archiveCheckBox.UseVisualStyleBackColor = true;
            this.archiveCheckBox.Click += new System.EventHandler(this.FilterDataGridChange);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Checked = true;
            this.activeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckBox.Location = new System.Drawing.Point(592, 21);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(64, 20);
            this.activeCheckBox.TabIndex = 33;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            this.activeCheckBox.Click += new System.EventHandler(this.FilterDataGridChange);
            // 
            // userManagementButton
            // 
            this.userManagementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementButton.Location = new System.Drawing.Point(12, 14);
            this.userManagementButton.Name = "userManagementButton";
            this.userManagementButton.Size = new System.Drawing.Size(112, 29);
            this.userManagementButton.TabIndex = 61;
            this.userManagementButton.Text = "Manage Users";
            this.userManagementButton.UseVisualStyleBackColor = true;
            this.userManagementButton.Click += new System.EventHandler(this.UserManagementButton);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 738);
            this.Controls.Add(this.userManagementButton);
            this.Controls.Add(this.EditDependenciesButton);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.ChangeStatusButton);
            this.Controls.Add(this.ChangePriorityButton);
            this.Controls.Add(this.DeleteTicketButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dependenciesLabel);
            this.Controls.Add(this.addNoteButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.reporterNameLabel);
            this.Controls.Add(this.ticketIDLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketDataGridView);
            this.Controls.Add(this.createNewTicketButton);
            this.Controls.Add(this.archiveCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeHog: Main Ticket Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CodeHogDataSet codeHogDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private CodeHogDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource ticketsBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.BindingSource codeHogDataSet1BindingSource;
        private CodeHogDataSet1 codeHogDataSet1;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private CodeHogDataSet1TableAdapters.User_RolesTableAdapter user_RolesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private CodeHogDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button EditDependenciesButton;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ChangeStatusButton;
        private System.Windows.Forms.Button ChangePriorityButton;
        private System.Windows.Forms.Button DeleteTicketButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label dependenciesLabel;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label reporterNameLabel;
        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private System.Windows.Forms.Button createNewTicketButton;
        private System.Windows.Forms.CheckBox archiveCheckBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button userManagementButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TicketArchiveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
    }
}

