using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PopGeorge2021_Project_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        public int d1, d2;
        public void load() 
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelepteanDarius2021 Project;Integrated Security=True");

            //string str2 = "SELECT  EmployeeID,FirstName,LastName,Title,City,Country,PhoneNumber,SalesValue FROM Employees";
            string str2 = "SELECT * FROM Employees";

            SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtLaod.DataSource = new BindingSource(dt, null);
            
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (dtLaod.Rows.Count>0)
            {
                DialogResult result = MessageBox.Show("You are sure", "operatoin Save", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Connected with database");    
            }
        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtLaod.Rows.Count > 0)
            {
                
                d1 = 1;
                Add frmadd = new Add();
                frmadd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Connected with database");
            }
           
        }
        void dgvsalvisible()
        {


            dtLaod.Columns[4].Visible = false;
            dtLaod.Columns[5].Visible = false;
            dtLaod.Columns[6].Visible = false;
            dtLaod.Columns[8].Visible = false;
            dtLaod.Columns[11].Visible = false;
            dtLaod.Columns[12].Visible = false;


        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dtLaod.Rows.Count > 0)
            {
                Details frm = new Details();

                try
                {
                    frm.txtEmpId.Text = dtLaod.CurrentRow.Cells[0].Value.ToString();
                    frm.txtLastName.Text = dtLaod.CurrentRow.Cells[1].Value.ToString();
                    frm.txtFirstName.Text = dtLaod.CurrentRow.Cells[2].Value.ToString();
                    frm.txtTitle.Text = dtLaod.CurrentRow.Cells[3].Value.ToString();
                    frm.txtCity.Text = dtLaod.CurrentRow.Cells[7].Value.ToString();
                    frm.txtCountry.Text = dtLaod.CurrentRow.Cells[9].Value.ToString();
                    frm.txtphone.Text = dtLaod.CurrentRow.Cells[10].Value.ToString();
                    frm.pcimage.Image = dtLaod.CurrentRow.Cells[10].Value as Image;
                    frm.txtNote.Text = dtLaod.CurrentRow.Cells[12].Value.ToString();
                    frm.txtVal.Text = dtLaod.CurrentRow.Cells[13].Value.ToString();

                    byte[] bytes = (byte[])dtLaod.CurrentRow.Cells[11].Value;
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    frm.pcimage.Image = img;
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Connected with database");
            }

        }
        void CHART()
        {

            Chart frm = new Chart();
            string x ; 
            double y = 0;
            for (int i = 0; i < dtLaod.Rows.Count - 1; i++)
            {
                x = dtLaod.Rows[i].Cells[1].Value.ToString() +" "+ dtLaod.Rows[i].Cells[2].Value.ToString();
                y = double.Parse(dtLaod.Rows[i].Cells[13].Value.ToString());
                frm.chart1.Series[0].Points.AddXY(x, y);
            }
            frm.ShowDialog();
        }
        private void dtLaod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (dtLaod.Rows.Count > 0)
            {
                CHART();
            }
            else
            {
                MessageBox.Show("Connected with database");
            }
         
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dtLaod.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("You are sure", "operatoin delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelepteanDarius2021 Project;Integrated Security=True");
                    con.Open();
                    try
                    {
                        int id = Convert.ToInt32(dtLaod.CurrentRow.Cells[0].Value);

                        string str = "DELETE FROM Employees WHERE EmployeeID = '" + id + "'";

                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("  Delete Successfully");
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load();
                }
                else
                {
                    MessageBox.Show("fielde delete", "operatoin delete");

                }
            }
            else
            {
                MessageBox.Show("Connected with database");
            }
          

        }

        private void txtSR_KeyDown(object sender, KeyEventArgs e)
        {
            if (dtLaod.Rows.Count > 0)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelepteanDarius2021 Project;Integrated Security=True");
                con1.Open();
                string str2 = "SELECT * FROM Employees where Country='" + txtSR.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtLaod.DataSource = new BindingSource(dt, null);
            }
            else
            {
                MessageBox.Show("Connected with database");

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                load();
                dgvsalvisible();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);

            }

        }
    }
}
