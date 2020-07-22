using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog {

    // Press Ctrl + M , Ctrl + O to collapse the functions (if in visual studio)

    public struct UserLogin {

        public int Id;
        public string Name;
        public int RoleID;
    };

    public partial class MainMenu : Form, IDataGridRefresh {

        CodeHogEntities codeHogEntities;

        int currentTicket;

        private UserLogin CurrentUser;

        //------------------------------ Constructor ------------------------------//

        public MainMenu() {

            InitializeComponent();

            codeHogEntities = new CodeHogEntities();

            ApplyFilterToDataGrid();
        }


        //------------------------------ Miscellaneos -----------------------------//

        private void MainMenu_Load(object sender, EventArgs e) {

            // TODO: This line of code loads data into the 'codeHogDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.codeHogDataSet.Tickets);
        }

        private void TicketDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

            int TicketId = Convert.ToInt32(ticketDataGridView.Rows[e.RowIndex].Cells[0].Value);
            PrintTicketToLabelsAndTextBoxes(TicketId);
            DeleteTicketButton.Enabled = true; //enable button once ticket is selected
            EditDependenciesButton.Enabled = true; //enable button once ticket is selected

            DeleteTicketButton.Enabled = CurrentUser.RoleID >= 2;
        }

        private void PrintTicketToLabelsAndTextBoxes(int TicketId) {

            foreach (var ticket in codeHogEntities.Tickets) {

                if (ticket.TicketID == TicketId) {

                    // The appropriate ticket is found in the database and its 
                    // componenets are pasted into the ticket feilds
                    ticketIDLabel.Text = ticket.TicketID.ToString();
                    currentTicket = TicketId;
                    priorityLabel.Text = ticket.TicketPriority.ToString();
                    statusLabel.Text = ticket.TicketStatus.ToString();

                    foreach (var user in codeHogEntities.Users) {

                        if (user.UserID == ticket.TicketReporter) {

                            // The user whose ID matches the ticket reporter ID is
                            // found, and their name is places in the text slot
                            reporterNameLabel.Text = user.Username;
                            break;
                        }
                    }

                    nameTextBox.Text = ticket.TicketName;
                    descriptionTextBox.Text = ticket.TicketDescription;
                    noteTextBox.Text = "";

                    // This loop parses throught the notes table and prints out the notes
                    // that are associated with this ticket
                    foreach (var note in codeHogEntities.Notes) {

                        if (note.TicketID == TicketId) {

                            noteTextBox.Text += $"-({note.User.Username}): {note.Note1}{Environment.NewLine}";
                        }
                    }
                }

                dependenciesLabel.Text = "";

                // This loop parses throught the dependency table and prints out the dependencies
                // that are associated with this ticket
                foreach (var dependency in codeHogEntities.Dependencies.Where(aDependency => aDependency.TicketID == TicketId)) {

                    dependenciesLabel.Text += $"{dependency.DependentTicketID}  ";
                }
            }
        }

        private void FilterDataGridChange(object sender, EventArgs e) {

            ApplyFilterToDataGrid();
        }

        private void ApplyFilterToDataGrid() {

            if (archiveCheckBox.Checked && (activeCheckBox.Checked == false)) {

                ticketDataGridView.DataSource = codeHogEntities.Tickets.Where(x => x.TicketArchiveStatus).ToList();
            }
            else if (activeCheckBox.Checked && archiveCheckBox.Checked == false) {

                ticketDataGridView.DataSource = codeHogEntities.Tickets.Where(x => x.TicketArchiveStatus == false).ToList();
            }
            else {
                ticketDataGridView.DataSource = codeHogEntities.Tickets.Where(x => (x.TicketArchiveStatus == false || x.TicketArchiveStatus == true)).ToList();
            }
        }

        private void Logout() {

            this.Hide();
            Login temp = new Login();
            temp.Show();
        }

        public void UpdateDataGrid() {

            ticketDataGridView.DataSource = codeHogEntities.Tickets.ToList();
            ticketDataGridView.Refresh();
            ApplyFilterToDataGrid();
            PrintTicketToLabelsAndTextBoxes(currentTicket);
        }

        public void SetUser(int Id, string Name, int RoleId) {

            CurrentUser.Id = Id;
            CurrentUser.Name = Name;
            CurrentUser.RoleID = RoleId;

            userManagementButton.Enabled = CurrentUser.RoleID == 3;
        }


        //------------------------ Open Seperate Form -----------------------------//

        private void OpenChangePriorityForm() {

            Form changePriorityForm = new ChangePriority(currentTicket, codeHogEntities, CurrentUser);
            changePriorityForm.FormClosed += ChangeStatusOrPriorityForm_FormClosed;
            changePriorityForm.ShowDialog();
        }

        private void OpenChangeStatusForm() {

            Form changeStatusForm = new ChangeStatus(currentTicket, codeHogEntities, CurrentUser);
            changeStatusForm.FormClosed += ChangeStatusOrPriorityForm_FormClosed;
            changeStatusForm.ShowDialog();
        }


        //----------------------------- Button Clicks -----------------------------//

        private void ButtonLogout_Click(object sender, EventArgs e) {

            Logout();
        }

        private void CreateNewTicketButton_Click(object sender, EventArgs e) {

            this.Hide();
            CreateTicketMenu createTicketMenu = new CreateTicketMenu(CurrentUser);
            //Possiple bug from the SetUser functionality.
            createTicketMenu.SetUser(CurrentUser.Id, CurrentUser.Name, CurrentUser.RoleID);
            createTicketMenu.Show();
        }

        private void AddNoteButton_Click(object sender, EventArgs e) {

            //if a ticket is selected, open the add note menu
            if (ticketIDLabel.Text != "..") {

                Form m = new AddNote(currentTicket, CurrentUser.Name, codeHogEntities);
                m.FormClosed += AddNote_FormClosed;
                m.ShowDialog();
            }
            else {

                MessageBox.Show("Please select a Ticket before attempting to add a note");
            }
        }

        private void DeleteTicketButton_Click(object sender, EventArgs e) {

            DeleteTicketMenu deleteTicket = new DeleteTicketMenu(ticketIDLabel.Text);
            deleteTicket.FormClosing += DeleteTicketMenu_FormClosed;
            deleteTicket.ShowDialog();
        }

        private void ChangePriorityButton_Click(object sender, EventArgs e) {

            //if a ticket is selected, open the change priority menu
            if (ticketIDLabel.Text != "..") {

                OpenChangePriorityForm();
            }
            else {

                MessageBox.Show("Please select a Ticket before attempting to change the priority");
            }
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e) {

            //if a ticket is selected, open the change status menu
            if (ticketIDLabel.Text != "..") {

                OpenChangeStatusForm();
            }
            else {

                MessageBox.Show("Please select a Ticket before attempting to change the priority");
            }
        }

        private void EditDependenciesButton_Click(object sender, EventArgs e) {

            DependenciesMenu dependencyTicket = new DependenciesMenu(ticketIDLabel.Text, codeHogEntities);
            dependencyTicket.FormClosing += DependenciesMenu_FormClosed;
            dependencyTicket.ShowDialog();
        }

        private void UserManagementButton(object sender, EventArgs e) {

            this.Hide();
            UserManagementMenu userManagmentMenu = new UserManagementMenu(CurrentUser);
            userManagmentMenu.Show();
        }


        //--------------------------- Form Closed Events ----------------------------//

        private void UserManagementMenu_FormClosed(object sender, FormClosedEventArgs e) {

            this.Show();
        }

        private void AddNote_FormClosed(object sender, FormClosedEventArgs e) {

            UpdateDataGrid();
        }

        private void DeleteTicketMenu_FormClosed(object sender, FormClosingEventArgs e) {

            foreach (var ticket in codeHogEntities.Tickets)
            {
                if (ticket.TicketID == currentTicket)
                {
                    break;
                }
                else
                {
                    // set all of the labels in the main menu to ".."
                    ticketIDLabel.Text = "..";
                    priorityLabel.Text = "..";
                    statusLabel.Text = "..";
                    reporterNameLabel.Text = "..";
                    nameTextBox.Text = "..";
                    descriptionTextBox.Text = "";
                    noteTextBox.Text = "";
                    //disable button once delete is confirmed
                    DeleteTicketButton.Enabled = false; 
                }
            }
            UpdateDataGrid();
        }

        private void ChangeStatusOrPriorityForm_FormClosed(object sender, FormClosedEventArgs e) {

            UpdateDataGrid();
        }

        private void DependenciesMenu_FormClosed(object sender, FormClosingEventArgs e) {

            if (ticketIDLabel.Text == null)
                EditDependenciesButton.Enabled = false; //disable button once delete is confirmed

            UpdateDataGrid();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Logout();
        }

    }
}
