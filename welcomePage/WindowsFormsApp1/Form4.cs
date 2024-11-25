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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the 'view' form
            view viewForm = new view();

            // Hide the current form (Form4)
            this.Hide();

            // Show the 'view' form
            viewForm.ShowDialog();

            // Show Form4 again after 'view' form is closed
            this.Show();
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
        
            // Create an instance of the 'view' form
            upload uploadForm = new upload();

            // Hide the current form (Form4)
            this.Hide();

            // Show the 'view' form
            uploadForm.ShowDialog();

            // Show Form4 again after 'view' form is closed
            this.Show();
           
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the 'view' form
            remove removeForm = new remove();

            // Hide the current form (Form4)
            this.Hide();

            // Show the 'view' form
            removeForm.ShowDialog();

            // Show Form4 again after 'view' form is closed
            this.Show();

        }
    }
}
