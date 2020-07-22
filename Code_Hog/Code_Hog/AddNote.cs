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
    public partial class AddNote : Form
    {
        private string newNote; //Stores the contents of the new note, to be added to the ticket
        private int ticketNumber; //the ticket ID number, given when the form is opened
        private string userN; //stores the username of the current user, given when the form is opened
        CodeHogEntities codeHogEntities; //used for DB queries
        private int userIDNum; //the ID number of the current user

        public AddNote(int tickNum, string userName, CodeHogEntities currentCodeHogEntities)
        {
            //setup
            InitializeComponent();
            codeHogEntities = currentCodeHogEntities;
            ticketNumber = tickNum;
            userN = userName;

            //set the title component labels to the correct text
            //set menu components
            ticketNumPrintLabel.Text = ticketNumber.ToString(); //ticket Number label
            usernamePrintLabel.Text = userN; //username label

        }

        //Adds note
        private void Button1_Click(object sender, EventArgs e)
        {
            newNote = noteTextBox.Text; //grabs the input text from the text box, and prepares it for storage in the DB

            //get user ID #
            foreach (var ticket in codeHogEntities.Users) //find the current user in the DB
            {

                if (ticket.Username == userN) //get the user's #
                {
                    userIDNum = ticket.UserID;

                }

            }

            //update the ticket entry with the new note text and username
            Note newNoteEntry = new Note();

            newNoteEntry.TicketID = ticketNumber;
            newNoteEntry.UserID = userIDNum;
            newNoteEntry.Note1 = newNote;

            codeHogEntities.Notes.Add(newNoteEntry);
            codeHogEntities.SaveChanges();

            //close the form
            this.Close();
        }
    }
}
