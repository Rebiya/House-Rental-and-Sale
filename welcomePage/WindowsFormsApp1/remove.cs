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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            // Logic for removing a second picture and its description
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this picture and its description?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear the image and description

                MessageBox.Show("The picture and its description have been removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Logic for returning a second item to the client-side page
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return this item to the client-side page?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The item has been successfully returned to the client-side page for sale or rental.", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void rmvBtn1_Click(object sender, EventArgs e)
        {


            // Logic for removing a second picture and its description
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this picture and its description?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) { 
                // Clear the image and description

                MessageBox.Show("The picture and its description have been removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void rtnBtn1_Click(object sender, EventArgs e)
        {
            // Logic for returning a second item to the client-side page
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return this item to the client-side page?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The item has been successfully returned to the client-side page for sale or rental.", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void rmvBtn2_Click(object sender, EventArgs e)
        {

            // Logic for removing a second picture and its description
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this picture and its description?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear the image and description

                MessageBox.Show("The picture and its description have been removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void rtnBtn2_Click(object sender, EventArgs e)
        {
            // Logic for returning a second item to the client-side page
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return this item to the client-side page?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The item has been successfully returned to the client-side page for sale or rental.", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void rmvBtn3_Click(object sender, EventArgs e)
        {

            // Logic for removing a second picture and its description
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this picture and its description?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear the image and description

                MessageBox.Show("The picture and its description have been removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }

        private void rtnBtn4_Click(object sender, EventArgs e)
        {
            // Logic for returning a second item to the client-side page
            DialogResult result = MessageBox.Show(
                "Are you sure you want to return this item to the client-side page?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The item has been successfully returned to the client-side page for sale or rental.", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The item stay in pending stage");
            }
        }
    }
}

