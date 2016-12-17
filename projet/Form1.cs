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
    public partial class Form1 : Form
    {

        //SqlConnection commd = new SqlConnection(@"Data Source=DESKTOP-VM6PDB8;Initial Catalog=Projet;Integrated Security=True");
        SqlConnection commd = new SqlConnection("Data Source=DESKTOP-VM6PDB8;Initial Catalog=Projet;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }



        
      

        private void btnlogin_Click(object sender, EventArgs e)
        {
           string type="";
            bool u = false, p = false;
            SqlDataReader r = null;
            if (txtlog.Text == "")
            {
                MessageBox.Show("entre user name");
                txtlog.Focus();
                
            }
            else

                if (txtpas.Text == "")
                {
                    MessageBox.Show("entre le password");
                    txtpas.Focus();
                }

            try
            {  

                //  else
                //{
                commd.Open();
                string req = "select * From Admins";
                SqlCommand comm = new SqlCommand(req, commd);
                r = comm.ExecuteReader();

                while (r.Read())
                {
                    
                    if ((string)r[2] == txtlog.Text && (string)r[1] == txtpas.Text)
                    {
                       
                        u = true;
                        p = true;

                        type = ((string)r[0]).Trim();
                        break;
                    }
                    else if ((string)r[1] != txtlog.Text || (string)r[2] != txtpas.Text)
                    {
                        u = false; p = false;
                    }


                }
              
                if (u == true && p == true )
                {

                    if (type == "E") // form de Employe
                    {
                        Form4 Form4 = new Form4(this);
                        Form4.Show();
                        this.Hide();
                    }
                    else { //   From de Admin 
                        Form6 Form6 = new Form6(this);
                        Form6.Show();
                        this.Hide();


                    }

                  
                }
               

                if (u == false || p == false)
                    labeluser.Text = "Invalid Username OR Password  ";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (commd != null)
                    commd.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtlog.Focus();
        }
     
    }






}