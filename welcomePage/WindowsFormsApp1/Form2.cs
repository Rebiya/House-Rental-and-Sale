//using System;
//using System.Drawing;
//using System.Text.RegularExpressions;
//using System.Windows.Forms;

//namespace WindowsFormsApp1
//{
//    public partial class Form2 : Form
//    {

//        public Form2()
//        {
//            InitializeComponent();
//            picShowPassword.MouseDown += picShowPassword_MouseDown;
//            picShowPassword.MouseUp += picShowPassword_MouseUp;
//        }

//        private void picShowPassword_Click(object sender, EventArgs e)
//        {

//        }

//        // Login button event handler
//        private void button1_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text;
//            string password = txtPassword.Text;

//            // Check hardcoded username and password
//            if (username == "Rebiya" && password == "rebu123")
//            {
//                // Navigate to the admin actions form if login is successful
//                Form4 adminActionsForm = new Form4();
//                this.Hide();
//                adminActionsForm.ShowDialog();
//                this.Show(); // Show the login form again after the admin form closes
//            }
//            else
//            {
//                // Display an error message for invalid login
//                MessageBox.Show("Invalid username or password,unauthorized to sign in as administrator", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void txtPassword_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void picShowPassword_MouseUp(object sender, MouseEventArgs e)
//        {
//            txtPassword.UseSystemPasswordChar = true; // Hide the password
//        }

//        private void picShowPassword_MouseDown(object sender, MouseEventArgs e)
//        {
//            txtPassword.UseSystemPasswordChar = false;
//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void txtEmail_TextChanged(object sender, EventArgs e)
//        {
//            string email = txtEmail.Text;

//            // Define a regular expression for validating an Email
//            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

//            if (Regex.IsMatch(email, emailPattern))
//            {
//                // Email is valid
//                lblValidationMessage.Text = "Valid Email"; // Update a label to show success
//                lblValidationMessage.ForeColor = Color.Green;
//            }
//            else
//            {
//                // Email is invalid
//                lblValidationMessage.Text = "Invalid Email"; // Update a label to show error
//                lblValidationMessage.ForeColor = Color.Red;
//            }
//        }
//    }
//}
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            picShowPassword.MouseDown += picShowPassword_MouseDown;
            picShowPassword.MouseUp += picShowPassword_MouseUp;
        }

        private void picShowPassword_Click(object sender, EventArgs e)
        {

        }

        // Login button event handler
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Hardcoded credentials
            string hardcodedEmail = "rebum.19@gmail.com";
            string hardcodedUsername = "Rebiya";
            string hardcodedPassword = "rebu123";

            // Validate email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format. Example: example@gmail.com", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (email != hardcodedEmail)
            {
                MessageBox.Show("Invalid email address. Please use the correct email!", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check username and password
            if (username == hardcodedUsername && password == hardcodedPassword)
            {
                // Navigate to the next form if login is successful
                Form4 adminActionsForm = new Form4();
                this.Hide();
                adminActionsForm.ShowDialog();
                this.Show(); // Show the login form again after the admin form closes
            }
            else
            {
                // Display an error message for invalid login
                MessageBox.Show("Invalid username or password. Unauthorized to sign in as administrator", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void picShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Hide the password
        }

        private void picShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            // Define a regular expression for validating an Email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(email, emailPattern))
            { // Email is valid MessageBox.Show("Valid Email", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information); } else { // Email is invalid MessageBox.Show("Invalid Email", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
