using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class distanceCalculator : Form
    {
        public distanceCalculator()
        {
            InitializeComponent();
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the main window
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Clearing previous text from the textbox
            outputBox.Text = "";

            // Parsing textboxes for user input
            int speed = int.Parse(mphTextbox.Text);
            int time = int.Parse(hoursTextbox.Text);

            // Initializing counter for while loop
            int counter = 1;

            // Seperate variable for the distance calculation
            int distance = speed * time;

            while (counter <= time)
            {
                /* Formatting a text string variable to display the result to the user, the output for distance is
                 * multiplied by how large the counter is */
                string output = $"After hour {counter} the distance is {distance * counter} \n";

                // Adding on as many lines as needed to the output box
                outputBox.Text += output;

                // Incrementing the counter up so the loop is not infinite
                counter++;

            }
        }
    }
}
