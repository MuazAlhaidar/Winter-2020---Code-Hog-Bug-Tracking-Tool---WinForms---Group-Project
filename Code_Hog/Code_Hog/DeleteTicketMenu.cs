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
    public partial class DeleteTicketMenu : Form
    {

        CodeHogEntities codeHogEntities;
        public DeleteTicketMenu(string ticketID)
        {
            InitializeComponent();
            codeHogEntities = new CodeHogEntities();
            ticketIDLabel.Text = ticketID;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteTicketButton_Click(object sender, EventArgs e)
        {
            int TicketId = Convert.ToInt32(ticketIDLabel.Text); 
            foreach (var ticket in codeHogEntities.Tickets)
            {
                if (ticket.TicketID == TicketId)
                {
                    codeHogEntities.Tickets.Remove(ticket);

                }

                foreach (var dependency in codeHogEntities.Dependencies.Where(s => s.TicketID == TicketId)) {

                    codeHogEntities.Dependencies.Remove(dependency);
                }
            }
            codeHogEntities.SaveChanges();
            Close();
        }
    }
}
