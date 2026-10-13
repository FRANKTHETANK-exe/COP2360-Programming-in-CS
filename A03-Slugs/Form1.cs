using System;
using System.Windows.Forms;

namespace slugs1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddSlugs_Click(object sender, EventArgs e)
        {
            try
            {
                // Read values from textboxes and convert to integers
                int slugs1 = int.Parse(txtLocation1.Text);
                int slugs2 = int.Parse(txtLocation2.Text);
                int slugs3 = int.Parse(txtLocation3.Text);
                int slugs4 = int.Parse(txtLocation4.Text);
                int slugs5 = int.Parse(txtLocation5.Text);

                // Calculate total
                int totalSlugs = slugs1 + slugs2 + slugs3 + slugs4 + slugs5;

                // Display result
                lblTotal.Text = "Total Slugs: " + totalSlugs;
            }
            catch (FormatException)
            {
                // Show error if input is invalid
                MessageBox.Show("Please enter only numbers in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler for Label1 click (if needed)
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Event handler for Label4 click (if needed)
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Event handler for Label5 click (if needed)
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Event handler for Label6 click (if needed)
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Event handler for TextBox3 text change (if needed)
        }
    }
}
