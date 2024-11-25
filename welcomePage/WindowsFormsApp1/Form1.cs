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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            Form3 signUpForm = new Form3();
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                Form2 adminLoginForm = new Form2();
                this.Hide();
                adminLoginForm.ShowDialog();
                this.Show();

            }
            else
            {

            }
        }
    }
}
