using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet
{
    public partial class Form4 : Form
    {
        Form1 forme;
        public Form4( Form1 forme)
        {
            this.forme = forme;
            InitializeComponent();
        }

        public Form4()
        {
            // TODO: Complete member initialization
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bt_Per.Checked)
            {
                Form3 Form3 = new Form3();
                Form3.Show();
            }
            else
            {
                Form7 Form7 = new Form7();
                Form7.Show();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.forme.Close();
        }
    }
}
