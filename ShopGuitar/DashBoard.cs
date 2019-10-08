using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGuitar
{
    public partial class DashBoard : Form
    {
        public DashBoard(string sessionuser)
        {
            InitializeComponent();
            dashboardHome1.BringToFront();
            SeedingUser.Text = sessionuser;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            SeedingUser.Visible = false;
            Date.Enabled = false;
            Times.Enabled = false;
            btnchangePwd.Visible = false;
            Date.Text = DateTime.Now.ToShortDateString();
            Times.Text = DateTime.Now.ToLongTimeString();
            }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Times.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMuser_Click(object sender, EventArgs e)
        {
            sslider.Width = btnMuser.Width;
            sslider.Left = btnMuser.Left;
            muser1.BringToFront();
        }

        private void BtnMcustomers_Click(object sender, EventArgs e)
        {
            sslider.Width = btnMcustomers.Width;
            sslider.Left = btnMcustomers.Left;
            mcustomers1.BringToFront();
        }
        public string USeeding
        {
            get { return SeedingUser.Text; }
        }
        private void SeedingUser_TextChanged(object sender, EventArgs e)
        {
           dashboardHome1.USeeding = USeeding;
            changepwdtab1.USeeding = USeeding;
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            sslider.Width = btnHome.Width;
            sslider.Left = btnHome.Left;
            dashboardHome1.BringToFront();
        }

        private void BunifuTileButton5_Click(object sender, EventArgs e)
        {
            sslider.Width = btnStock.Width;
            sslider.Left = btnStock.Left;
            mproducts1.BringToFront();
        }

        private void Mproducts1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            sslider.Width = btnStore.Width;
            sslider.Left = btnStore.Left;
            buyproducts1.BringToFront();
        }
        public void ChangePwdfunction()
        {
            BtnchangePwd_Click(new object(), new EventArgs());
        }

        private void BtnchangePwd_Click(object sender, EventArgs e)
        {
            changepwdtab1.Refresh();
            changepwdtab1.BringToFront();
        }
    }
}
