using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog
{
    public partial class DependenciesMenu : Form, IDataGridRefresh
    {
        CodeHogEntities codeHogEntities;
        int tempID;

        public DependenciesMenu(string ticketID, CodeHogEntities currentCodeHogEntities)
        {
            InitializeComponent();
            codeHogEntities = currentCodeHogEntities;
            ticketIDLabel.Text = ticketID;
            tempID = Convert.ToInt32(ticketIDLabel.Text); //this is only used to compare. See line below(if there is a better way please change it)
            dependencyDataGridView.DataSource = codeHogEntities.Dependencies.Where(x => (x.TicketID == tempID)).ToList(); //display related ticketID
        }

        private void DependenciesMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeHogDataSet2.Dependencies' table. You can move, or remove it, as needed.
            this.dependenciesTableAdapter.Fill(this.codeHogDataSet2.Dependencies);
            // TODO: This line of code loads data into the 'codeHogDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.codeHogDataSet.Tickets);

        }

        //delete dependent ticket (does not save)
        private void DeleteDependcyButton(object sender, EventArgs e)
        {
            int dependentTicketID = Convert.ToInt32(deleteDTicketIDLabel.Text);
            foreach (var ticket in codeHogEntities.Dependencies)
            {
                if (ticket.DependentTicketID == dependentTicketID)
                {
                    codeHogEntities.Dependencies.Remove(ticket);
                }
            }

            UpdateDataGrid();
            deleteDependencyButton.Enabled = false;
            confirmChangesButton.Enabled = true;
        }

        // add dependent ticket (does not save)
        private void AddDepnedncyButton(object sender, EventArgs e)
        {
            int ticketID = Convert.ToInt32(ticketIDLabel.Text);
            int dependentTicketID = Convert.ToInt32(dependentTicketIDLabel.Text);

            var newDependency = new Dependency()
            {
                TicketID = ticketID,
                DependentTicketID = dependentTicketID
            };
            
            codeHogEntities.Dependencies.Add(newDependency);
            UpdateDataGrid();
            addDependencyButton.Enabled = false;
            confirmChangesButton.Enabled = true;
        }

        //close form without saving
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //saves all changes
        private void ConfirmChangesButton_Click(object sender, EventArgs e)
        {
            codeHogEntities.SaveChanges();
            UpdateDataGrid();
            MessageBox.Show("Your changes have been save!");
            confirmChangesButton.Enabled = false;
        }

        //set dependentTicketIDLabel after selecting an available ticket row header and enable add dependency button
        private void TicketDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dependentTicketIDLabel.Text = Convert.ToString(ticketDataGridView.Rows[e.RowIndex].Cells[0].Value);
            addDependencyButton.Enabled = true;
        }

        //enable delete button after after selecting an available dependeny ticket row header
        private void DependencyDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteDTicketIDLabel.Text = Convert.ToString(dependencyDataGridView.Rows[e.RowIndex].Cells[1].Value);
            deleteDependencyButton.Enabled = true;
        }

        public void UpdateDataGrid() {

            dependencyDataGridView.DataSource = codeHogEntities.Dependencies.Where(x => (x.TicketID == tempID)).ToList();
            dependencyDataGridView.Refresh();
        }
    }
}
