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
    public partial class ChangePriority : Form
    {
        private int ticketNumber; //The Ticket ID # of the current ticket, given when the form is opened
        CodeHogEntities codeHogEntities; //used for DB queries
        private int chosenPriority; //New priority for ticket, as chosen by user

        public ChangePriority(int ticketNum, CodeHogEntities currentCodeHogEntities, UserLogin currentUser)
        {
            //setup
            InitializeComponent();
            codeHogEntities = currentCodeHogEntities;
            ticketNumber = ticketNum;

            //set menu components
            ticketNumPrintLabel.Text = ticketNum.ToString(); //ticket Number label
            usernamePrintLabel.Text = currentUser.Name; //username label

            //set default radial button to the ticket's current priority
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //Radio Button and default selection setup, based on existing priority within the ticket
                    switch (ticket.TicketPriority)
                    {
                        case 1:
                            radioButton1.Checked = true;
                            chosenPriority = 1;
                            break;
                        case 2:
                            radioButton2.Checked = true;
                            chosenPriority = 2;
                            break;
                        case 3:
                            radioButton3.Checked = true;
                            chosenPriority = 3;
                            break;
                        case 4:
                            radioButton4.Checked = true;
                            chosenPriority = 4;
                            break;
                        case 5:
                            radioButton5.Checked = true;
                            chosenPriority = 5;
                            break;

                    }

                }

            }

        }

        //save
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //update the ticket entry with the new priority
            foreach (var ticket in codeHogEntities.Tickets) //find the current ticket in the DB
            {

                if (ticket.TicketID == ticketNumber) //if the ticket in the DB is the ticket we are looking for
                {
                    //Update priority on the current ticket
                    ticket.TicketPriority = chosenPriority;

                }
            }

            //Save changes to DB
            codeHogEntities.SaveChanges(); //TODO FIX

            //close the form
            this.Close();

        }

        //radio button handling. If one is pressed, the others are not
        private void RadioButt1_Click(object sender, EventArgs e)
        {
            chosenPriority = 1;

        }

        private void RadioButt2_Click(object sender, EventArgs e)
        {
            chosenPriority = 2;

        }

        private void RadioButt3_CLick(object sender, EventArgs e)
        {
            chosenPriority = 3;

        }

        private void RadioButt4_Click(object sender, EventArgs e)
        {
            chosenPriority = 4;

        }

        private void RadioButt5_Click(object sender, EventArgs e)
        {
            chosenPriority = 5;

        }
    }

}
