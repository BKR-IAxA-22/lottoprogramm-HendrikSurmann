using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    i--;
                else
                    lottonumbers[i] = randomNum;
            }

            label1.Text = lottonumbers[0].ToString();
            label2.Text = lottonumbers[1].ToString();
            label3.Text = lottonumbers[2].ToString();
            label4.Text = lottonumbers[3].ToString();
            label5.Text = lottonumbers[4].ToString();
            label6.Text = lottonumbers[5].ToString();
            label7.Text = lottonumbers[6].ToString();

            if (int.TryParse(textBox1.Text, out _) && lottonumbers.Contains(int.Parse(textBox1.Text)))
                textBox1.BackColor= Color.Green;
            else
                textBox1.BackColor = Color.White;

            if (int.TryParse(textBox2.Text, out _) && lottonumbers.Contains(int.Parse(textBox2.Text)))
                textBox2.BackColor = Color.Green;
            else
                textBox2.BackColor = Color.White;

            if (int.TryParse(textBox3.Text, out _) && lottonumbers.Contains(int.Parse(textBox3.Text)))
                textBox3.BackColor = Color.Green;
            else
                textBox3.BackColor = Color.White;

            if (int.TryParse(textBox4.Text, out _) && lottonumbers.Contains(int.Parse(textBox4.Text)))
                textBox4.BackColor = Color.Green;
            else
                textBox4.BackColor = Color.White;

            if (int.TryParse(textBox5.Text, out _) && lottonumbers.Contains(int.Parse(textBox5.Text)))
                textBox5.BackColor = Color.Green;
            else
                textBox5.BackColor = Color.White;
        
            if (int.TryParse(textBox6.Text, out _) && lottonumbers.Contains(int.Parse(textBox6.Text)))
                textBox6.BackColor = Color.Green;
            else
                textBox6.BackColor = Color.White;

            if (int.TryParse(textBox7.Text, out _) && lottonumbers.Contains(int.Parse(textBox7.Text)))
                textBox7.BackColor = Color.Green;
            else
                textBox7.BackColor = Color.White;

        }
    }
}
