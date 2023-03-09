using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YAHTZEEEEEEEEEEEEEEEEEE
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://hu.wikipedia.org/wiki/Kockap%C3%B3ker");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            if (listBox1.Items.Count < 1)
            {
                groupBox1.Enabled = false;
            }
            button4.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                listBox1.Items.Add(textBox1.Text);
                groupBox1.Enabled = true;
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameFuctions.AddPlayers(listBox1.Items.Cast<string>().ToList());
            new Form1().Show();
        }
    }
}
