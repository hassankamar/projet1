using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace projet
{
    public partial class Form2 : Form
    {
       // Form1 form1;/*************************************************************/
        string name;/***************/
        public Form2()//)Form1 form1,string name)
        {
            InitializeComponent();
           // this.form1 = form1;/////////////
           // this.name = name;///////////////////
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DBproject;Initial Catalog=Kontineur;Integrated Security=True");

        private void pERSONNEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void spect_kon_Click(object sender, EventArgs e)
        {
            if (txID_k.Text == "" || txP_k.Text == "" || txM_k.Text == "" /*|| cbAE_k.Text == ""  */||cbAR_k.Text == "" || txdate_a_k.Text == "" || txdate_e_k.Text == "")
                MessageBox.Show("Entre tous les donnes correctes");
            else
            {
                dgrid_k.Rows.Add(txID_k.Text,/* cbAE_k.Text*/ cbAR_k.Text, txdate_a_k.Text, txdate_e_k.Text, txM_k.Text, txP_k.Text);
                
               
            }
            txID_k.Clear();
           // cbAE_k.Text = "";
            cbAR_k.Text = "";
            txdate_a_k.Clear();
            txdate_e_k.Clear();
            txM_k.Clear();
            txP_k.Clear();
        }

      
    }
}
