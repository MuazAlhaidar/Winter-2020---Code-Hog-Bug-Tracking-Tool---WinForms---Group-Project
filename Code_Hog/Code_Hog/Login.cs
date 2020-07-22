using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog {

    public partial class Login : Form {

        public Login() {

            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e) {
            CodeHogEntities hogEntities = new CodeHogEntities();
            string email = emailTextBox.Text;
            string pass = passwordTextBox.Text;
            var query = hogEntities.Users.Where(s => s.Email == email);
            if (query.FirstOrDefault() != null)
            {
                User temp = query.FirstOrDefault();
                if (temp.Password == pass)
                {
                    MainMenu menu = new MainMenu();
                    menu.SetUser(temp.UserID, temp.Username, temp.RoleID);
                    menu.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Failed login.");
            }
            else
                MessageBox.Show("Login Failed: Please Check Email and Password");
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) {

            if (System.Windows.Forms.Application.MessageLoop) {

                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else {

                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
