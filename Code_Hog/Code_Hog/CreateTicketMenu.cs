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

    public partial class CreateTicketMenu : Form, IDataGridRefresh {

        //Setting up the database.
        CodeHogEntities Database = new CodeHogEntities();
        UserLogin user;

        public CreateTicketMenu(UserLogin currentUser) {

            InitializeComponent();

            user = currentUser;
        }

        private UserLogin CurrUser;

        public void  SetUser(int Id, string Name, int RoleId)
        {
            CurrUser.Id=Id;
            CurrUser.Name = Name;
            CurrUser.RoleID = RoleId;
        }

        private void CreateTicketMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeHogDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.codeHogDataSet.Tickets);

        }

        private void ButtonNewTicket_Click(object sender, EventArgs e)
        {
            //Prioerity Checking
            int Pri = -1;
            if (radioPri1.Checked)
                Pri = 1;
            else if (radioPri2.Checked)
                Pri = 2;
            else if (radioPri3.Checked)
                Pri = 3;
            else if (radioPri4.Checked)
                Pri = 4;
            else if (radioPri5.Checked)
                Pri = 5;

            int Status = -1;

            if (RadioStat1.Checked)
                Status = 1;
            else if (RadioStat2.Checked)
                Status = 2;
            else if (RadioStat3.Checked)
                Status = 3;

            //Checking if all the required fileds are tehere
            if (TextName.TextLength == 0 || TextDesc.TextLength == 0 || Pri == -1) {

                MessageBox.Show("One of the required fields is missing");
            }
            else
            {

                //Reporter should be the person who logs in UserId. Just putting a placeholder here for future referecne.
                int Reporter = CurrUser.Id;

                var NewTicket = new Ticket()
                {
                    TicketArchiveStatus = false,
                    TicketStatus = Status,
                    TicketReporter = Reporter ,

                    TicketDescription = TextDesc.Text,
                    TicketName = TextName.Text,
                    TicketPriority = Pri,
                    
                };
                Database.Tickets.Add(NewTicket);
                Database.SaveChanges();
                // Dependcies checking

                //Gettingt he piramary ticket ID
                var query = Database.Tickets.Where(s => s.TicketID == NewTicket.TicketID);
                Ticket Ticketp = query.FirstOrDefault<Ticket>();


                //Create a new dependecny, and add it to database
                foreach (DataGridViewRow temp in DataGridView1.SelectedRows)
                {

                    int ticketidrow = Int32.Parse(temp.Cells[0].Value.ToString());
                    query = Database.Tickets.Where(s => s.TicketID == ticketidrow );
                    Dependency dependency = new Dependency()
                    {
                        DependentTicketID = query.FirstOrDefault<Ticket>().TicketID,
                        TicketID=Ticketp.TicketID
                    };
                    Database.Dependencies.Add(dependency);
                    Database.SaveChanges();

                }
                //query = Database.Dependencies.Where(s => s.DependentTicketID == );
                //NewTicket.Dependencies=
                UpdateDataGrid();

                // This is the default values of a newly created ticket.
                //var wow=Database.Database.ExecuteSqlCommand("FROM * SELECT *");

            }
        }


        private void Return() {

            this.Hide();
            MainMenu menu = new MainMenu();
            menu.SetUser(user.Id, user.Name, user.RoleID);
            menu.Show();
        }

  
        private void CreateTicketMenu_FormClosed(object sender, FormClosedEventArgs e) {

            Return();
        }

        public void UpdateDataGrid() {

            DataGridView1.DataSource = Database.Tickets.ToList();
            DataGridView1.Refresh();
        }

        private void ButtonReturnMain_Click_1(object sender, EventArgs e)
        {
            Return();

        }
    }
}
