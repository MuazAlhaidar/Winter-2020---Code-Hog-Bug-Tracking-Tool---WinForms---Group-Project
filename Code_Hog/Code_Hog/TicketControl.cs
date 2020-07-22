using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Hog
{
    class TicketControl
    {
        //used for holding ticket data in functions
        struct data
        {
            public int ticketNumber; //derived from DB on creation
            public int priority; // 1-5. 1 = High Priority, 5 = Low Priority
            public string name; //name of ticket, should only be X characters long
            public string initialRep; //Name of initial reporter
            public int status; //1 = Unresolved, 2 = Being Addressed/Fixed, 3 = Archived/Fixed/Ignored
            public string contributors; //List of all users who have contributed to the ticket
            public string description; //Description of issue
            public string dependancies; //Notes regarding related issues
            public string[] notes; //Notes regarding the issue and efforts to fix it
            
        }

        //Create new ticket in DB
        //Recieves the priority, name, initial reportor of, and the description of the new ticket
        public void CreateTicket(int inPriority, string inName, string repName, string inDesc)
        {
            data newTicket; //holder for information being placed in the new ticket

            //get next available ticket #
            //TODO

            //assign ticket number to next available ticket #
            //TODO

            //assign priority
            newTicket.priority = inPriority;

            //assign name
            newTicket.name = inName;

            //assign initial reporter name
            newTicket.initialRep = repName;

            //assign description of issue
            newTicket.description = inDesc;

            //push ticket to DB
            //TODO

        }

        //Edit existing Ticket in DB
        //Recieves ticket number, current contributor name, and changed info
        void UpdateTicketInfo(int number, int newPriority, int newStatus, string newContributor, string newDependancies, string newNote)
        {
            data updateTicket; //holder for information in the ticket that is being edited

            //get ticket information from DB based on input ticket number
            updateTicket = GetTicketInfo(number);

            //updatePriority
            updateTicket.priority = newPriority;

            //updateStatus
            updateTicket.status = newStatus;

            //check if the contributor is already on the list of past contribuotrs
            //add New Contributor to list if they are not on it already

            //update dependancies
            updateTicket.dependancies = newDependancies;

            //add new note to list of notes
            //TODO

            //update the ticket's entry in the DB with new data
            //TODO

        }

        //get specified ticket information from DB
        //takes ticket number as input
        //returns a data struct filled with information from the ticket's entry in the DB
        data GetTicketInfo(int number)
        {
            data returnVal;

            //get ticket data from DB, and assign to returnVal
            //TODO

            return returnVal;

        }

    }
}
