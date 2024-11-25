//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WindowsFormsApp1
//{
//    public partial class upload : Form
//    {
//        public upload()
//        {
//            InitializeComponent();
//        }

//        private void panel2_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void labelDisplay_Click(object sender, EventArgs e)
//        {

//        }

//        private void pictureBox1_Click(object sender, EventArgs e)
//        {

//        }

//        private void uploadBtn_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class upload : Form
    {
        public upload()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            // Open file dialog to browse for an image file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Load the image into the PictureBox
                    Image uploadedImage = Image.FromFile(selectedFilePath);
                    pictureBox1.Image = uploadedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Simulate inserting the file path into a database
                    // (Replace with actual database logic if necessary)

                    // Show confirmation message
                    MessageBox.Show("Image successfully inserted into the database.", "Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle any errors during the upload process
                    MessageBox.Show($"An error occurred while uploading the image: {ex.Message}", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Update the label with the text from the TextBox
            labelDisplay.Text = textBox1.Text;
        }
    }
}
