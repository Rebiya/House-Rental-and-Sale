using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class viewRental : Form
    {
        public viewRental()
        {
            InitializeComponent();
        }

        private void rentalBtn1_Click(object sender, EventArgs e)
        {

            // Sample scheduled date and time (you can replace these with your actual variables)
            DateTime scheduledDate = new DateTime(2024, 11, 26, 14, 30, 0); // November 26, 2024, at 2:30 PM

            string message = $"The time is scheduled on the client side at {scheduledDate.ToShortTimeString()} " +
                             $"and the date is scheduled for {scheduledDate.ToShortDateString()}.";

            MessageBox.Show(message, "Scheduled Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rentalBtn2_Click(object sender, EventArgs e)
        {

            // Sample scheduled date and time (you can replace these with your actual variables)
            DateTime scheduledDate = new DateTime(2024, 11, 26, 14, 30, 0); // November 26, 2024, at 2:30 PM

            string message = $"The time is scheduled on the client side at {scheduledDate.ToShortTimeString()} " +
                             $"and the date is scheduled for {scheduledDate.ToShortDateString()}.";

            MessageBox.Show(message, "Scheduled Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rentalBtn3_Click(object sender, EventArgs e)
        {

            // Sample scheduled date and time (you can replace these with your actual variables)
            DateTime scheduledDate = new DateTime(2024, 11, 26, 14, 30, 0); // November 26, 2024, at 2:30 PM

            string message = $"The time is scheduled on the client side at {scheduledDate.ToShortTimeString()} " +
                             $"and the date is scheduled for {scheduledDate.ToShortDateString()}.";

            MessageBox.Show(message, "Scheduled Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rentalBtn4_Click(object sender, EventArgs e)
        {

            // Sample scheduled date and time (you can replace these with your actual variables)
            DateTime scheduledDate = new DateTime(2024, 11, 26, 14, 30, 0); // November 26, 2024, at 2:30 PM

            string message = $"The time is scheduled on the client side at {scheduledDate.ToShortTimeString()} " +
                             $"and the date is scheduled for {scheduledDate.ToShortDateString()}.";

            MessageBox.Show(message, "Scheduled Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rentalBtn5_Click(object sender, EventArgs e)
        {

            // Sample scheduled date and time (you can replace these with your actual variables)
            DateTime scheduledDate = new DateTime(2024, 11, 26, 14, 30, 0); // November 26, 2024, at 2:30 PM

            string message = $"The time is scheduled on the client side at {scheduledDate.ToShortTimeString()} " +
                             $"and the date is scheduled for {scheduledDate.ToShortDateString()}.";

            MessageBox.Show(message, "Scheduled Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rentalBtn6_Click(object sender, EventArgs e)
        {

            // Sample scheduled date and time (you can replace these with your actual variables)
            DateTime scheduledDate = new DateTime(2024, 11, 26, 14, 30, 0); // November 26, 2024, at 2:30 PM

            string message = $"The time is scheduled on the client side at {scheduledDate.ToShortTimeString()} " +
                             $"and the date is scheduled for {scheduledDate.ToShortDateString()}.";

            MessageBox.Show(message, "Scheduled Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
