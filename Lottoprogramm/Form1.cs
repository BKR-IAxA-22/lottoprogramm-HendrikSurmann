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

        private int[] lottonumbers = new int[7];

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lottonumbers = new int[7];

            for (int i = 0; i < lottonumbers.Length; i++)
            {
                int randomNum = rand.Next(1, 49);
                if (lottonumbers.Contains(randomNum))
                {
                    i--;
                    continue;
                }
                else
                    lottonumbers[i] = randomNum;

                Controls.OfType<Label>().FirstOrDefault(c => c.Name == "label"+(i+1)).Text = lottonumbers[i].ToString();

                TextBox textBox = Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "textBox" + (i + 1));
                if (int.TryParse(textBox.Text, out int convertedInteger) && lottonumbers.Contains(convertedInteger))
                    textBox.BackColor = Color.Green;
                else
                    textBox.BackColor = Color.Black;
            }

        }
    }
}