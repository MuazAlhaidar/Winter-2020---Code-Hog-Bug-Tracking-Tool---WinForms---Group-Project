using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog {

    public partial class UserManagementMenu : Form {

        CodeHogEntities codeHogEntities;
        UserLogin user;

        public UserManagementMenu(UserLogin currentUser) {

            InitializeComponent();

            codeHogEntities = new CodeHogEntities();

            user = currentUser;

            BindUserList();

            roleComboBox.SelectedIndex = 0;
        }

        private void BindUserList() {

            UserListBox.DataSource = codeHogEntities.Users.Where(s => !s.UserID.Equals(user.Id)).ToList();
            UserListBox.DisplayMember = "Username";
            UserListBox.ValueMember = "UserID";
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e) {

            User selectedUser = UserListBox.SelectedItem as User;

            userIDTextBox.Text = selectedUser.UserID.ToString();
            userNameTextBox.Text = selectedUser.Username;
            passwordTextBox.Text = selectedUser.Password;
            emailTextBox.Text = selectedUser.Email;
            roleComboBox.SelectedIndex = selectedUser.RoleID - 1;
        }

        private void AddUserButton_Click(object sender, EventArgs e) {

            AddUser();
        }

        private void UpdateUserButton_Click(object sender, EventArgs e) {

            UpdateUser();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e) {

            DeleteUser();
        }

        private void AddUser() {

            if (!String.IsNullOrWhiteSpace(userNameTextBox.Text) &&
                !String.IsNullOrWhiteSpace(passwordTextBox.Text) &&
                !String.IsNullOrWhiteSpace(emailTextBox.Text)) {

                User newUser = new User {

                    Username = userNameTextBox.Text,
                    Password = passwordTextBox.Text,
                    Email = emailTextBox.Text,
                    RoleID = roleComboBox.SelectedIndex + 1
                };

                codeHogEntities.Users.Add(newUser);

                try {

                    codeHogEntities.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindUserList();
            }
            else {

                MessageBox.Show("ERROR: One or more of the Textfeilds are Empty");
            }
        }

        private void UpdateUser() {

            if (!String.IsNullOrEmpty(userIDTextBox.Text)) {

                User selectedUser = UserListBox.SelectedItem as User;

                selectedUser.Username = userNameTextBox.Text;
                selectedUser.Password = passwordTextBox.Text;
                selectedUser.Email = emailTextBox.Text;
                selectedUser.RoleID = roleComboBox.SelectedIndex + 1;

                try {

                    codeHogEntities.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindUserList();
            }
        }

        private void DeleteUser() {

            if (!String.IsNullOrEmpty(userIDTextBox.Text)) {

                User selectedUser = UserListBox.SelectedItem as User;

                codeHogEntities.Users.Remove(selectedUser);

                try {

                    codeHogEntities.SaveChanges();
                }
                catch (DbUpdateException ex) {

                    MessageBox.Show(ex.Message);
                }

                BindUserList();
            }
        }

        private void ClearFieldsButton_Click(object sender, EventArgs e) {

            userIDTextBox.Text = userNameTextBox.Text = passwordTextBox.Text = emailTextBox.Text = "";
            roleComboBox.SelectedIndex = 0;
        }

        private void ReturnButton_Click(object sender, EventArgs e) {

            Return();
        }

        private void Return() {

            this.Hide();
            MainMenu menu = new MainMenu();
            menu.SetUser(user.Id, user.Name, user.RoleID);
            menu.Show();
        }

        private void UserManagementMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }
    }
}
