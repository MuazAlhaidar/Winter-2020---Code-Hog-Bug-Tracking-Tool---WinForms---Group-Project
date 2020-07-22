namespace Code_Hog {
    partial class CreateTicketMenu {
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
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextDesc = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeHogDataSet = new Code_Hog.CodeHogDataSet();
            this.ticketsTableAdapter = new Code_Hog.CodeHogDataSetTableAdapters.TicketsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioStat1 = new System.Windows.Forms.RadioButton();
            this.RadioStat2 = new System.Windows.Forms.RadioButton();
            this.RadioStat3 = new System.Windows.Forms.RadioButton();
            this.ButtonNewTicket = new System.Windows.Forms.Button();
            this.codeHogDataSet1 = new Code_Hog.CodeHogDataSet1();
            this.codeHogDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioPri1 = new System.Windows.Forms.RadioButton();
            this.radioPri2 = new System.Windows.Forms.RadioButton();
            this.radioPri4 = new System.Windows.Forms.RadioButton();
            this.radioPri3 = new System.Windows.Forms.RadioButton();
            this.radioPri5 = new System.Windows.Forms.RadioButton();
            this.ButtonReturnMain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(513, 202);
            this.TextName.Margin = new System.Windows.Forms.Padding(4);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(267, 22);
            this.TextName.TabIndex = 0;
            // 
            // TextDesc
            // 
            this.TextDesc.Location = new System.Drawing.Point(513, 259);
            this.TextDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TextDesc.Multiline = true;
            this.TextDesc.Name = "TextDesc";
            this.TextDesc.Size = new System.Drawing.Size(267, 184);
            this.TextDesc.TabIndex = 2;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ticketNameDataGridViewTextBoxColumn,
            this.TicketDescription});
            this.DataGridView1.DataSource = this.ticketsBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(13, 33);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(484, 446);
            this.DataGridView1.TabIndex = 3;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // ticketNameDataGridViewTextBoxColumn
            // 
            this.ticketNameDataGridViewTextBoxColumn.DataPropertyName = "TicketName";
            this.ticketNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.ticketNameDataGridViewTextBoxColumn.Name = "ticketNameDataGridViewTextBoxColumn";
            this.ticketNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // TicketDescription
            // 
            this.TicketDescription.DataPropertyName = "TicketDescription";
            this.TicketDescription.HeaderText = "Description";
            this.TicketDescription.Name = "TicketDescription";
            this.TicketDescription.ReadOnly = true;
            this.TicketDescription.Width = 300;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.codeHogDataSetBindingSource;
            // 
            // codeHogDataSetBindingSource
            // 
            this.codeHogDataSetBindingSource.DataSource = this.codeHogDataSet;
            this.codeHogDataSetBindingSource.Position = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // RadioStat1
            // 
            this.RadioStat1.AutoSize = true;
            this.RadioStat1.Location = new System.Drawing.Point(66, 11);
            this.RadioStat1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioStat1.Name = "RadioStat1";
            this.RadioStat1.Size = new System.Drawing.Size(33, 20);
            this.RadioStat1.TabIndex = 8;
            this.RadioStat1.TabStop = true;
            this.RadioStat1.Text = "1";
            this.RadioStat1.UseVisualStyleBackColor = true;
            // 
            // RadioStat2
            // 
            this.RadioStat2.AutoSize = true;
            this.RadioStat2.Location = new System.Drawing.Point(66, 39);
            this.RadioStat2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioStat2.Name = "RadioStat2";
            this.RadioStat2.Size = new System.Drawing.Size(33, 20);
            this.RadioStat2.TabIndex = 9;
            this.RadioStat2.TabStop = true;
            this.RadioStat2.Text = "2";
            this.RadioStat2.UseVisualStyleBackColor = true;
            // 
            // RadioStat3
            // 
            this.RadioStat3.AutoSize = true;
            this.RadioStat3.Location = new System.Drawing.Point(66, 67);
            this.RadioStat3.Margin = new System.Windows.Forms.Padding(4);
            this.RadioStat3.Name = "RadioStat3";
            this.RadioStat3.Size = new System.Drawing.Size(33, 20);
            this.RadioStat3.TabIndex = 10;
            this.RadioStat3.TabStop = true;
            this.RadioStat3.Text = "3";
            this.RadioStat3.UseVisualStyleBackColor = true;
            // 
            // ButtonNewTicket
            // 
            this.ButtonNewTicket.Location = new System.Drawing.Point(513, 451);
            this.ButtonNewTicket.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonNewTicket.Name = "ButtonNewTicket";
            this.ButtonNewTicket.Size = new System.Drawing.Size(108, 28);
            this.ButtonNewTicket.TabIndex = 13;
            this.ButtonNewTicket.Text = "New Ticket";
            this.ButtonNewTicket.UseVisualStyleBackColor = true;
            this.ButtonNewTicket.Click += new System.EventHandler(this.ButtonNewTicket_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Priority";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioStat3);
            this.panel1.Controls.Add(this.RadioStat2);
            this.panel1.Controls.Add(this.RadioStat1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(663, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 153);
            this.panel1.TabIndex = 22;
            // 
            // radioPri1
            // 
            this.radioPri1.AutoSize = true;
            this.radioPri1.Location = new System.Drawing.Point(70, 11);
            this.radioPri1.Margin = new System.Windows.Forms.Padding(4);
            this.radioPri1.Name = "radioPri1";
            this.radioPri1.Size = new System.Drawing.Size(33, 20);
            this.radioPri1.TabIndex = 13;
            this.radioPri1.TabStop = true;
            this.radioPri1.Text = "1";
            this.radioPri1.UseVisualStyleBackColor = true;
            // 
            // radioPri2
            // 
            this.radioPri2.AutoSize = true;
            this.radioPri2.Location = new System.Drawing.Point(70, 39);
            this.radioPri2.Margin = new System.Windows.Forms.Padding(4);
            this.radioPri2.Name = "radioPri2";
            this.radioPri2.Size = new System.Drawing.Size(33, 20);
            this.radioPri2.TabIndex = 23;
            this.radioPri2.TabStop = true;
            this.radioPri2.Text = "2";
            this.radioPri2.UseVisualStyleBackColor = true;
            // 
            // radioPri4
            // 
            this.radioPri4.AutoSize = true;
            this.radioPri4.Location = new System.Drawing.Point(70, 95);
            this.radioPri4.Margin = new System.Windows.Forms.Padding(4);
            this.radioPri4.Name = "radioPri4";
            this.radioPri4.Size = new System.Drawing.Size(33, 20);
            this.radioPri4.TabIndex = 24;
            this.radioPri4.TabStop = true;
            this.radioPri4.Text = "4";
            this.radioPri4.UseVisualStyleBackColor = true;
            // 
            // radioPri3
            // 
            this.radioPri3.AutoSize = true;
            this.radioPri3.Location = new System.Drawing.Point(70, 67);
            this.radioPri3.Margin = new System.Windows.Forms.Padding(4);
            this.radioPri3.Name = "radioPri3";
            this.radioPri3.Size = new System.Drawing.Size(33, 20);
            this.radioPri3.TabIndex = 25;
            this.radioPri3.TabStop = true;
            this.radioPri3.Text = "3";
            this.radioPri3.UseVisualStyleBackColor = true;
            // 
            // radioPri5
            // 
            this.radioPri5.AutoSize = true;
            this.radioPri5.Location = new System.Drawing.Point(70, 123);
            this.radioPri5.Margin = new System.Windows.Forms.Padding(4);
            this.radioPri5.Name = "radioPri5";
            this.radioPri5.Size = new System.Drawing.Size(33, 20);
            this.radioPri5.TabIndex = 26;
            this.radioPri5.TabStop = true;
            this.radioPri5.Text = "5";
            this.radioPri5.UseVisualStyleBackColor = true;
            // 
            // ButtonReturnMain
            // 
            this.ButtonReturnMain.Location = new System.Drawing.Point(680, 451);
            this.ButtonReturnMain.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonReturnMain.Name = "ButtonReturnMain";
            this.ButtonReturnMain.Size = new System.Drawing.Size(100, 28);
            this.ButtonReturnMain.TabIndex = 27;
            this.ButtonReturnMain.Text = "Return";
            this.ButtonReturnMain.UseVisualStyleBackColor = true;
            this.ButtonReturnMain.Click += new System.EventHandler(this.ButtonReturnMain_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.radioPri1);
            this.panel2.Controls.Add(this.radioPri5);
            this.panel2.Controls.Add(this.radioPri2);
            this.panel2.Controls.Add(this.radioPri3);
            this.panel2.Controls.Add(this.radioPri4);
            this.panel2.Location = new System.Drawing.Point(513, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 153);
            this.panel2.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Highlight Any Tickets You Would Like As Dependencies";
            // 
            // CreateTicketMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonReturnMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonNewTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.TextDesc);
            this.Controls.Add(this.TextName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTicketMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeHog: Create Ticket Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateTicketMenu_FormClosed);
            this.Load += new System.EventHandler(this.CreateTicketMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeHogDataSet1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextDesc;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.BindingSource codeHogDataSetBindingSource;
        private CodeHogDataSet codeHogDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private CodeHogDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioStat1;
        private System.Windows.Forms.RadioButton RadioStat2;
        private System.Windows.Forms.RadioButton RadioStat3;
        private System.Windows.Forms.Button ButtonNewTicket;
        private CodeHogDataSet1 codeHogDataSet1;
        private System.Windows.Forms.BindingSource codeHogDataSet1BindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioPri1;
        private System.Windows.Forms.RadioButton radioPri2;
        private System.Windows.Forms.RadioButton radioPri4;
        private System.Windows.Forms.RadioButton radioPri3;
        private System.Windows.Forms.RadioButton radioPri5;
        private System.Windows.Forms.Button ButtonReturnMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketDescription;
        private System.Windows.Forms.Label label5;
    }
}
