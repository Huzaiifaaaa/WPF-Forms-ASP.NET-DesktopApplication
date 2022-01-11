using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PopGeorge2021_Project_
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        Main frm2 = new Main();
        private void btnimage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcimage.Image = Image.FromFile(ofd.FileName);
            }
        }
        public void selectmacid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelepteanDarius2021 Project;Integrated Security=True");
            con.Open();
            string str1 = "select max(EmployeeID) from Employees;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtEmpId.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtEmpId.Text = a.ToString();
                }
            }
            con.Close();
        }
        private void Add_Load(object sender, EventArgs e)
        {
            selectmacid();
        }
        MemoryStream ms;
        byte[] photo_aray;
        private void btnOkClose_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelepteanDarius2021 Project;Integrated Security=True");
            con.Open();
            try
            {
                string MaritalStatus = string.Empty;
                double value = Convert.ToDouble(txtVal.Text);
                if (pcimage.Image != null)
                {
                   
                    string str = "INSERT INTO Employees(EmployeeID,LastName,FirstName,Title,City,Country,PhoneNumber,Photo,SalesValue,Notes) VALUES('" + Convert.ToInt32(txtEmpId.Text) + "','" + txtLastName.Text + "','" + txtFirstName.Text + "','" + txtTitle.Text + "','" + txtCity.Text + "','" + txtCountry.Text + "','" + txtphone.Text + "',@photo,'" + value + "','" + txtNote.Text + "'); ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    ms = new MemoryStream();
                    pcimage.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    cmd.Parameters.AddWithValue("@photo", photo_aray);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string str = "INSERT INTO Employees(EmployeeID,LastName,FirstName,Title,City,Country,PhoneNumber,SalesValue,Notes) VALUES('" + Convert.ToInt32(txtEmpId.Text) + "','" + txtLastName.Text + "','" + txtFirstName.Text + "','" + txtTitle.Text + "','" + txtCity.Text + "','" + txtCountry.Text + "','" + txtphone.Text + "','" + value + "','" + txtNote.Text + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                }


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
            frm2.load();
            this.Close();
        }
    }
}
