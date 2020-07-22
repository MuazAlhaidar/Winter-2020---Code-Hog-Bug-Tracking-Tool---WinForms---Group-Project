namespace Code_Hog
{
    partial class ChangeStatus
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
            this.usernamePrintLabel = new System.Windows.Forms.Label();
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.ticketNumPrintLabel = new System.Windows.Forms.Label();
            this.ticketNumberLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PrintStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernamePrintLabel
            // 
            this.usernamePrintLabel.AutoSize = true;
            this.usernamePrintLabel.Location = new System.Drawing.Point(76, 31);
            this.usernamePrintLabel.Name = "usernamePrintLabel";
            this.usernamePrintLabel.Size = new System.Drawing.Size(30, 13);
            this.usernamePrintLabel.TabIndex = 11;
            this.usernamePrintLabel.Text = "ERR";
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Location = new System.Drawing.Point(12, 31);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.userTitleLabel.TabIndex = 10;
            this.userTitleLabel.Text = "Username:";
            // 
            // ticketNumPrintLabel
            // 
            this.ticketNumPrintLabel.AutoSize = true;
            this.ticketNumPrintLabel.Location = new System.Drawing.Point(68, 9);
            this.ticketNumPrintLabel.Name = "ticketNumPrintLabel";
            this.ticketNumPrintLabel.Size = new System.Drawing.Size(30, 13);
            this.ticketNumPrintLabel.TabIndex = 9;
            this.ticketNumPrintLabel.Text = "ERR";
            // 
            // ticketNumberLabel
            // 
            this.ticketNumberLabel.AutoSize = true;
            this.ticketNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.ticketNumberLabel.Name = "ticketNumberLabel";
            this.ticketNumberLabel.Size = new System.Drawing.Size(50, 13);
            this.ticketNumberLabel.TabIndex = 8;
            this.ticketNumberLabel.Text = "Ticket #:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Unresolved";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Under Review";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Archived";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(115, 128);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(87, 48);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Confirm New\r\nTicket Status";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(15, 66);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(77, 13);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "Current Status:";
            // 
            // PrintStatusLabel
            // 
            this.PrintStatusLabel.AutoSize = true;
            this.PrintStatusLabel.Location = new System.Drawing.Point(98, 66);
            this.PrintStatusLabel.Name = "PrintStatusLabel";
            this.PrintStatusLabel.Size = new System.Drawing.Size(30, 13);
            this.PrintStatusLabel.TabIndex = 17;
            this.PrintStatusLabel.Text = "ERR";
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 188);
            this.Controls.Add(this.PrintStatusLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernamePrintLabel);
            this.Controls.Add(this.userTitleLabel);
            this.Controls.Add(this.ticketNumPrintLabel);
            this.Controls.Add(this.ticketNumberLabel);
            this.Name = "ChangeStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeHog: Change Status Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamePrintLabel;
        private System.Windows.Forms.Label userTitleLabel;
        private System.Windows.Forms.Label ticketNumPrintLabel;
        private System.Windows.Forms.Label ticketNumberLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PrintStatusLabel;
    }
}