namespace Code_Hog
{
    partial class AddNote
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
            this.ticketNumberLabel = new System.Windows.Forms.Label();
            this.ticketNumPrintLabel = new System.Windows.Forms.Label();
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.usernamePrintLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.noteTitleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticketNumberLabel
            // 
            this.ticketNumberLabel.AutoSize = true;
            this.ticketNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.ticketNumberLabel.Name = "ticketNumberLabel";
            this.ticketNumberLabel.Size = new System.Drawing.Size(50, 13);
            this.ticketNumberLabel.TabIndex = 0;
            this.ticketNumberLabel.Text = "Ticket #:";
            // 
            // ticketNumPrintLabel
            // 
            this.ticketNumPrintLabel.AutoSize = true;
            this.ticketNumPrintLabel.Location = new System.Drawing.Point(68, 9);
            this.ticketNumPrintLabel.Name = "ticketNumPrintLabel";
            this.ticketNumPrintLabel.Size = new System.Drawing.Size(30, 13);
            this.ticketNumPrintLabel.TabIndex = 1;
            this.ticketNumPrintLabel.Text = "ERR";
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Location = new System.Drawing.Point(15, 26);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.userTitleLabel.TabIndex = 2;
            this.userTitleLabel.Text = "Username:";
            // 
            // usernamePrintLabel
            // 
            this.usernamePrintLabel.AutoSize = true;
            this.usernamePrintLabel.Location = new System.Drawing.Point(79, 26);
            this.usernamePrintLabel.Name = "usernamePrintLabel";
            this.usernamePrintLabel.Size = new System.Drawing.Size(30, 13);
            this.usernamePrintLabel.TabIndex = 3;
            this.usernamePrintLabel.Text = "ERR";
            // 
            // noteTextBox
            // 
            this.noteTextBox.AcceptsReturn = true;
            this.noteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.noteTextBox.Location = new System.Drawing.Point(15, 70);
            this.noteTextBox.MaxLength = 179;
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(223, 187);
            this.noteTextBox.TabIndex = 4;
            // 
            // noteTitleLabel
            // 
            this.noteTitleLabel.AutoSize = true;
            this.noteTitleLabel.Location = new System.Drawing.Point(15, 51);
            this.noteTitleLabel.Name = "noteTitleLabel";
            this.noteTitleLabel.Size = new System.Drawing.Size(82, 13);
            this.noteTitleLabel.TabIndex = 5;
            this.noteTitleLabel.Text = "New Note Text:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Note To Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noteTitleLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.usernamePrintLabel);
            this.Controls.Add(this.userTitleLabel);
            this.Controls.Add(this.ticketNumPrintLabel);
            this.Controls.Add(this.ticketNumberLabel);
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeHog: Add Note Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ticketNumberLabel;
        private System.Windows.Forms.Label ticketNumPrintLabel;
        private System.Windows.Forms.Label userTitleLabel;
        private System.Windows.Forms.Label usernamePrintLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label noteTitleLabel;
        private System.Windows.Forms.Button button1;
    }
}