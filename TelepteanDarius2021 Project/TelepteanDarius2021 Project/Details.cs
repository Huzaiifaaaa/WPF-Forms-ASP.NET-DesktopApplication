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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
        }
        MemoryStream ms;
        byte[] photo_aray;

        void update()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TelepteanDarius2021 Project;Integrated Security=True");
            con.Open();
            double value = Convert.ToDouble(txtVal.Text);

           
                if (pcimage.Image!=null)
                {
                string str = " Update Employees set LastName='" + txtLastName.Text + "',FirstName='" + txtFirstName.Text + "',Title='" + txtTitle.Text + "',City='" + txtCity.Text + "',Country='" + txtCountry.Text + "',PhoneNumber='" + txtphone.Text + "' ,Photo= @photo,SalesValue='" + value + "',Notes='" + txtNote.Text + "' where EmployeeID ='" + txtEmpId.Text + "'";

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
                    string str = " Update Employees set LastName='" + txtLastName.Text + "',FirstName='" + txtFirstName + "',Title='" + txtTitle.Text + "',City='" + txtCity.Text + "',Country='" + txtCountry.Text + "',PhoneNumber='" + txtphone.Text + "' ,SalesValue='" + value + "',Notes='" + txtNote.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                }
               
              
           
            con.Close();
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcimage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnOkClose_Click(object sender, EventArgs e)
        {
            update();
            this.Close();
        }
    }
}
