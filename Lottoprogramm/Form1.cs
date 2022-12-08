using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lottoprogramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] lottonumbers;

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Random obj
            Random rand = new Random();
            // Create new integer array so that all numbers are 0
            lottonumbers = new int[7];

            // Loop through all numbers
            for (int i = 0; i < lottonumbers.Length; i++)
            {
                // Generate a random number 
                int randomNum = rand.Next(1, 49);
                // check if random numbers already exists in the array
                if (lottonumbers.Contains(randomNum))
                {
                    // if it already exists go back one step to repeat the random number generation
                    i--;
                    continue; // go to the end of the for loop
                }
                else
                    lottonumbers[i] = randomNum; // if the number is not in the array put it in the array

                // Search for the label and put the random number in the Text
                Controls.OfType<Label>().FirstOrDefault(c => c.Name == "label"+(i+1)).Text = lottonumbers[i].ToString();

                // Search for the TextBox and save it to use it in the if statement
                TextBox textBox = Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "textBox" + (i + 1));
                if (int.TryParse(textBox.Text, out int convertedInteger) && lottonumbers.Contains(convertedInteger)) // check if the number in the Textbox is in the array
                    textBox.BackColor = Color.Green; // if yes => turn background green
                else
                    textBox.BackColor = Color.Black; // if no => turn background white
            }

        }
    }
}