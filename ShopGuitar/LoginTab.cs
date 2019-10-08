using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGuitar
{
    public partial class LoginTab : UserControl
    {
        EnCryp to = new EnCryp();
        public LoginTab()
        {
            InitializeComponent();
            LoadChecked();
            //MessageBox.Show(to.EnCrypt("tdnlkd"));
        }

        private void LoginTab_Load(object sender, EventArgs e)
        {
            Date.Enabled = false;
            Times.Enabled = false;
            Date.Text = DateTime.Now.ToShortDateString();
            Times.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Times.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = to.EnCrypt(txtpwd.Text);
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter query = new MySqlDataAdapter("SELECT count(*) FROM Users WHERE username = '" + user + "' and password = '" + pass + "'", conn);
            DataTable filldata = new DataTable();
            LoadingToDB ldb = new LoadingToDB(txtuser.Text); // txtuser
            query.Fill(filldata);
            if (filldata.Rows[0][0].ToString() == "1")
            {
                Alert.ThatShow("Please wait A moment", Alert.AlertType.success);
                RememberChecked();
                ((Form1)this.TopLevelControl).Hide();
                ldb.Show();
            }
            else
            {
                Alert.ThatShow("Wrong UserName or Password....", Alert.AlertType.warning);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        void RememberChecked()
        {
            if(bunifuCheckbox1.Checked == true)
            {
                Properties.Settings.Default.Username = txtuser.Text;
                Properties.Settings.Default.Password = txtpwd.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
        void LoadChecked()
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                txtuser.Text = Properties.Settings.Default.Username;
                txtpwd.Text = Properties.Settings.Default.Password;
                bunifuCheckbox1.Checked = true;
            }
        }

        private void Txtpwd_Enter(object sender, EventArgs e)
        {
            if(txtpwd.Text == "Type ur Password")
            {
                txtpwd.Text = "";
                txtpwd.isPassword = true;
            }
        }

        private void Txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "Type ur Password";
                txtpwd.isPassword = false;
            }
        }

        private void Txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void Txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtuser.Focus();
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void Txtpwd_OnValueChanged(object sender, EventArgs e)
        {
            txtpwd.isPassword = true;
        }
    }
}
