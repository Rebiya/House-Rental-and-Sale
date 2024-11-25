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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rentalView_Click(object sender, EventArgs e)
        {
            // Create an instance of the 'view' form
            viewRental viewRental = new viewRental();

            // Hide the current form (Form4)
            this.Hide();

            // Show the 'view' form
            viewRental.ShowDialog();

            // Show Form4 again after 'view' form is closed
            this.Show();
        }

        private void purchaseView_Click(object sender, EventArgs e)
        {
            // Create an instance of the 'view' form
            viewPurchase viewPurchase = new viewPurchase();

            // Hide the current form (Form4)
            this.Hide();

            // Show the 'view' form
            viewPurchase.ShowDialog();

            // Show Form4 again after 'view' form is closed
            this.Show();
        }
    }
}
