using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            picShowPassword.MouseDown += picShowPassword_MouseDown;
            picShowPassword.MouseUp += picShowPassword_MouseUp;
            picShowPassword2.MouseDown += picShowPassword2_MouseDown;
            picShowPassword2.MouseUp += picShowPassword2_MouseUp;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = USERNAME.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;

            if (password != repeatPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the user credentials (can be saved to a database or a local file)
            MessageBox.Show("Sign-Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Return to Welcome Page
        
    }

        private void picShowPassword2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void picShowPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void picShowPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; // Reveal the password
        }

        private void picShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtRepeatPassword.UseSystemPasswordChar = false; // Reveal the password
        }

        private void picShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtRepeatPassword.UseSystemPasswordChar = true;
        }
    }
}
