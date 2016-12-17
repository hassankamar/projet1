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
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VM6PDB8;Initial Catalog=Projet;Integrated Security=True" );
        
        Form6 forme;
        public Form8( Form6 forme)
        {
           this.forme = forme;
            InitializeComponent();
        }

        private void Component_invisible()
        {
            lblcpas.Visible = false;
            lblDR.Visible = false;
            lblID.Visible = false;
            lblNOM.Visible = false;
            lblpass.Visible = false;
            lblPrenom.Visible = false;
            lbltele.Visible = false;
            lblusername.Visible = false;
            txtCpas.Visible = false;
            txtID.Visible = false;
            txtNom.Visible = false;
            txtPas.Visible = false;
            txtPrenom.Visible = false;
            txtTele.Visible = false;
            txtusername.Visible = false;
            cmbDR.Visible = false;
            dgInfoem.Visible = false;

           
        }

        private void Component_visible()
        {
            lblcpas.Visible = true;
            lblDR.Visible = true;
            lblID.Visible = true;
            lblNOM.Visible = true;
            lblpass.Visible = true;
            lblPrenom.Visible = true;
            lbltele.Visible = true;
            lblusername.Visible = true;
            txtCpas.Visible = true;
            txtID.Visible = true;
            txtNom.Visible = true;
            txtPas.Visible = true;
            txtPrenom.Visible = true;
            txtTele.Visible = true;
            txtusername.Visible = true;
            cmbDR.Visible = true;
        }

        private void check()
        {int nb;
            if (txtID.Text == "")
            {
                MessageBox.Show("Entre id de employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
            }
            else if (!Int32.TryParse(txtID.Text, out nb)) {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
            }
            else if (txtNom.Text == "")
            {
                MessageBox.Show("Entre Nom  de employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
            }
            else if (txtPrenom.Text == "")
            {
                MessageBox.Show("Entre Prenom  de employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrenom.Focus();
            }
            else if (txtTele.Text == "")
            {
                MessageBox.Show("Entre Telephon  de employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTele.Focus();
            }
            else if (!Int32.TryParse(txtTele.Text, out nb))
            {
                MessageBox.Show("Invalid Telephon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTele.Focus();

            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Entre Username  de employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
            }
            else if (txtPas.Text == "")
            {
                MessageBox.Show("Entre Password de employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPas.Focus();
            }
            else if (txtCpas.Text == "")
            {
                MessageBox.Show("Confirme Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpas.Focus();
            }
            else if (txtPas.Text != txtCpas.Text)
            {
                MessageBox.Show("Incorrect Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpas.Focus();
            }
            if (cmbDR.SelectedText.Count()==0)
            {
                MessageBox.Show("Select le caracter de employe D si Directeur E si Employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDR.Focus();
            }
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.forme.Close();
        }
        //  ad employe  button +
        private void btnadd_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false; 
            btnDelet.Visible = false;
            btnInfor.Visible = false;
            Component_visible();
            btnad.Visible = true;






        }
        // delete emlpoye button  x
        private void button1_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnad.Visible = false;
            btnInfor.Visible = false;
            Component_visible();
            btnDelet.Visible = true;
            
        }
        //    button add apres click button +
        private void btnad_Click(object sender, EventArgs e)
        {

          /*  check();

 
            try
            {
                conn.Open();
                string query = "insert into employe (ID_employe,Nom_employe,prenom,Tele) values ("+txtID.Text+",'"+ txtNom.Text+"','"+txtPrenom.Text+"',"+txtTele.Text+" ) ";
                string query1 = "insert into Admins (Type_a , Pass, Username,ID_em ) values ('"+cmbDR.SelectedItem.ToString()+"','"+ txtPas.Text+ "', '"+txtusername.Text+ "',"+txtID.Text+") ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();


            }
            catch ( Exception io)
            {
                MessageBox.Show(io.ToString());
            }
            finally
            {
                conn.Close();
            }
            */

            Component_invisible();
            btnad.Visible = false;

           
        }
        // button  uddate vraie and x
        private void button2_Click(object sender, EventArgs e)
        {
            Component_invisible();
            txtID.Visible = true;
            btnDelet.Visible = false;
            btnUpdate.Visible = false;
            btnInfor.Visible = true;
            lblID.Visible = true;
         
        }
        // button update apres click vraie and  x
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

               
                string query = " UPDATE employe set "+dgInfoem.SelectedCells.ToString()+ "";
        
                SqlCommand cmd = new SqlCommand(query, conn);
                
                cmd.ExecuteNonQuery();
              


            }
            catch (Exception io)
            {
                MessageBox.Show(io.ToString());
            }
            finally
            {
                conn.Close();
            }
            
            
            Component_invisible();
            btnUpdate.Visible = false;
            btnInfor.Visible = false;

        }
        // delet employe apres click button X
        private void btnDelet_Click(object sender, EventArgs e)
        {
            Component_invisible();
           btnDelet.Visible = false;
          
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            Component_visible();
            txtNom.Visible = false;
            txtPrenom.Visible = false;
            lblNomNotevalid.Text = "You can not change name";
            lblprenomNotvalid.Text = "You can not change prenom";
            btnUpdate.Visible = true;
          
            
             int nb;
            if (txtID.Text == "")
            {
                MessageBox.Show("Entre ID de Employe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtID.Focus();
            }
            else if (!Int32.TryParse(txtID.Text, out nb)) {
                MessageBox.Show("INVALID ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
            } 
            txtID.Visible = true;
            lblID.Visible = true;
          //  dgInfoem.Visible = true;

               SqlDataAdapter adapter = null;
                 DataSet ds = new DataSet( ) ;
            try
            {
                conn.Open();
                string query = "select * from Admins , employe "+ 
               " where   employe.ID_employe=" + txtID.Text + "AND Admins.ID_em=employe.ID_employe";
                 
                adapter = new SqlDataAdapter(query, conn) ;
               adapter.Fill(ds, "table_persone" ) ;
               dgInfoem.DataSource = ds.Tables["table_persone"];
              
                //SqlCommand cmd = new SqlCommand(query, conn);
               txtusername.Text = dgInfoem.Rows[0].Cells[2].Value.ToString();
               txtPas.Text = dgInfoem.Rows[0].Cells[1].Value.ToString();
               txtCpas.Text = dgInfoem.Rows[0].Cells[1].Value.ToString();
               txtTele.Text = dgInfoem.Rows[0].Cells[7].Value.ToString();
                 


            }
            catch (Exception io)
            {
                MessageBox.Show(io.ToString());
            }
            finally
            {
                conn.Close();
            }
             




        }

        
    }
}
