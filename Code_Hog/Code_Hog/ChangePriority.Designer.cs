namespace Code_Hog
{
    partial class ChangePriority
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // usernamePrintLabel
            // 
            this.usernamePrintLabel.AutoSize = true;
            this.usernamePrintLabel.Location = new System.Drawing.Point(76, 31);
            this.usernamePrintLabel.Name = "usernamePrintLabel";
            this.usernamePrintLabel.Size = new System.Drawing.Size(30, 13);
            this.usernamePrintLabel.TabIndex = 7;
            this.usernamePrintLabel.Text = "ERR";
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Location = new System.Drawing.Point(12, 31);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.userTitleLabel.TabIndex = 6;
            this.userTitleLabel.Text = "Username:";
            // 
            // ticketNumPrintLabel
            // 
            this.ticketNumPrintLabel.AutoSize = true;
            this.ticketNumPrintLabel.Location = new System.Drawing.Point(68, 9);
            this.ticketNumPrintLabel.Name = "ticketNumPrintLabel";
            this.ticketNumPrintLabel.Size = new System.Drawing.Size(30, 13);
            this.ticketNumPrintLabel.TabIndex = 5;
            this.ticketNumPrintLabel.Text = "ERR";
            // 
            // ticketNumberLabel
            // 
            this.ticketNumberLabel.AutoSize = true;
            this.ticketNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.ticketNumberLabel.Name = "ticketNumberLabel";
            this.ticketNumberLabel.Size = new System.Drawing.Size(50, 13);
            this.ticketNumberLabel.TabIndex = 4;
            this.ticketNumberLabel.Text = "Ticket #:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(15, 61);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(211, 26);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "New Priority Level:\r\n(1 = Not Important, 5 = Extremely Important)";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(151, 161);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 38);
            this.ChangeButton.TabIndex = 10;
            this.ChangeButton.Text = "Change Priority";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 90);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.RadioButt1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.RadioButt2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 136);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.RadioButt3_CLick);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 159);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.RadioButt4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(18, 182);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.RadioButt5_Click);
            // 
            // ChangePriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 210);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.usernamePrintLabel);
            this.Controls.Add(this.userTitleLabel);
            this.Controls.Add(this.ticketNumPrintLabel);
            this.Controls.Add(this.ticketNumberLabel);
            this.Name = "ChangePriority";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeHog: Change Priority Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamePrintLabel;
        private System.Windows.Forms.Label userTitleLabel;
        private System.Windows.Forms.Label ticketNumPrintLabel;
        private System.Windows.Forms.Label ticketNumberLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}