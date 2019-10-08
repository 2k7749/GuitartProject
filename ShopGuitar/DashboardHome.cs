using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ShopGuitar
{
    public partial class DashboardHome : UserControl
    {
        public DashboardHome()
        {
            InitializeComponent();
        }

        private void DashboardHome_Load(object sender, EventArgs e)
        {
            homeUser.ForeColor = Color.Crimson;
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("Select c.name from Users u, Config_levels c WHERE u.level = c.level AND username = '" + homeUser.Text + "' GROUP BY c.name ", conn))
                {

                    string hlevel = Convert.ToString(cmd.ExecuteScalar());
                    homeLevels.Text = hlevel;
                }
                using (var cmd1 = new MySqlCommand("Select staffid from Users WHERE username = '" + homeUser.Text + "'", conn))
                {
                    string hid = Convert.ToString(cmd1.ExecuteScalar());
                    homeStaffID.Text = hid;
                }
                using (var cmd2 = new MySqlCommand("Select staffphone from Users WHERE username = '" + homeUser.Text + "'", conn))
                {
                    string hphone = Convert.ToString(cmd2.ExecuteScalar());
                    homePhone.Text = hphone;
                }
                using (var cmd3 = new MySqlCommand("Select sex from Users WHERE username = '" + homeUser.Text + "'", conn))
                {
                    string hsex = Convert.ToString(cmd3.ExecuteScalar());
                    if (hsex == "0")
                    {
                        homeSex.Text = "Nữ";
                    }
                    else
                    {
                        homeSex.Text = "Nam";
                    }

                }
                using (var cmd4 = new MySqlCommand("Select staffname from Users WHERE username = '" + homeUser.Text + "'", conn))
                {
                    string sname = Convert.ToString(cmd4.ExecuteScalar());
                    staffName.Text = sname;
                }
                using (var cmd5 = new MySqlCommand("Select points from Users WHERE username = '" + homeUser.Text + "'", conn))
                {
                    string spoints = Convert.ToString(cmd5.ExecuteScalar());
                    infoPoints.Text = spoints;
                }
                using (var cmd5 = new MySqlCommand("Select image from Users WHERE username = '" + homeUser.Text + "'", conn))
                {
                    Byte[] img = (Byte[])cmd5.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox3.Image = Image.FromStream(ms);
                }
                
                conn.Close();
            }
        }
        public string USeeding
        {
            set { homeUser.Text = value; }
        }
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ((DashBoard)this.TopLevelControl).Close();
            Form1 sistema = new Form1();
            sistema.ShowDialog();
        }
        public void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DashBoard form = Application.OpenForms.OfType<DashBoard>().FirstOrDefault();
            if (form != null)
            {
                form.ChangePwdfunction();
            }
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DashBoard form = Application.OpenForms.OfType<DashBoard>().FirstOrDefault();
            if (form != null)
            {
                form.ChangePwdfunction();
            }
        }
    }
}
