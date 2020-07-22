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
    public partial class ChangeStatus : Form
    {
        private int ticketNumber; //The ticket ID number, given when the form is opened
        CodeHogEntities codeHogEntities; //used for DB queries
        private int choice; //stores the new status value, as chosen by the user

        public ChangeStatus(int TicketNum, CodeHogEntities currentCodeHogEntities, UserLogin currentUser)
        {
            //setup
            InitializeComponent();
            codeHogEntities = currentCodeHogEntities;
            ticketNumber = TicketNum;

            //set menu components
            ticketNumPrintLabel.Text = TicketNum.ToString(); //ticket Number label
            usernamePrintLabel.Text = currentUser.Name; //username label

            //Get current ticket status
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //set status label
                    switch (ticket.TicketStatus)
                    {
                        case 1:
                            PrintStatusLabel.Text = "Unresolved";
                            break;
                        case 2:
                            PrintStatusLabel.Text = "Under Review";
                            break;
                        case 3:
                            PrintStatusLabel.Text = "Archived";
                            break;

                    }

                    //set default choice
                    choice = ticket.TicketStatus;

                }

            }

        }

        //Option Buttons
        private void Button1_Click(object sender, EventArgs e)
        {
            PrintStatusLabel.Text = "Unresolved";
            choice = 1;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PrintStatusLabel.Text = "Under Review";
            choice = 2;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PrintStatusLabel.Text = "Archived";
            choice = 3;

        }

        //Update Ticket with new status
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //Set new ticket status
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //set status to choice
                    ticket.TicketStatus = choice;

                    //set archive status
                    if (choice < 3)
                    {
                        ticket.TicketArchiveStatus = false;

                    }
                    else
                    {
                        ticket.TicketArchiveStatus = true;

                    }

                }

            }

            //Save changes to DB
            codeHogEntities.SaveChanges();

            //close the form
            this.Close();

        }

    }

}
