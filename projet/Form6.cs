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
    public partial class Form6 : Form
    {
         Form1 forme;
        public Form6( Form1 forme)
          {
              this.forme = forme;
            InitializeComponent();
        }
 

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.forme.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 forme = new Form8(this);
            forme.Show();
            this.Hide();
        }

        
        
    }
}
