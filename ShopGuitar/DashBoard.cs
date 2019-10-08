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
        int mov;
        int movX;
        int movY;
        public DashBoard(string sessionuser)
        {
            InitializeComponent();
            dashboardHome1.BringToFront();
            SeedingUser.Text = sessionuser;
            checkaccess(sessionuser);
            querylevel.Visible = false;
            if (querylevel.Text == "1") // User
            {
                btnMuser.Enabled = false;
                btnMcustomers.Enabled = false;
                collabRq.Enabled = false;
                btnStock.Enabled = false;
                btnPOS.Enabled = false;
                btnAnaly.Enabled = false;
            }
            else if (querylevel.Text == "2") // Collaborators
            {
                btnMuser.Enabled = false;
                btnMcustomers.Enabled = false;
                collabRq.Enabled = false;
                btnStock.Enabled = false;
                btnPOS.Enabled = false;
                btnAnaly.Enabled = false;
            }
            else if (querylevel.Text == "3") //Staff
            {
                btnMuser.Enabled = false;
                btnMcustomers.Enabled = false;
                btnStock.Enabled = false;
            }
            else if (querylevel.Text == "4") // Warechecker
            {

                btnMuser.Enabled = false;
                btnMcustomers.Enabled = false;
                collabRq.Enabled = false;
                bunifuTileButton6.Enabled = false;
                btnStore.Enabled = false;
                btnPOS.Enabled = false;
            }
            else if (querylevel.Text == "5") // Admin
            {

            }
        }
        void checkaccess(string userhere)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select level from Users WHERE username = '" + userhere + "'";
            int userdone = Convert.ToInt32(cmd.ExecuteScalar());
            querylevel.Text = userdone.ToString();
            conn.Close();
        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
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
            buyproducts1.USeeding = USeeding;
            historybuytab1.USeeding = USeeding;
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
        public void GoToStore()
        {
            GotoStoreNow_Click(new object(), new EventArgs());
        }

        private void BtnchangePwd_Click(object sender, EventArgs e)
        {
            changepwdtab1.Refresh();
            changepwdtab1.BringToFront();
        }

        private void BunifuTileButton6_Click(object sender, EventArgs e)
        {
            sslider.Width = bunifuTileButton6.Width;
            sslider.Left = bunifuTileButton6.Left;
            historybuytab1.BringToFront();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void CollabRq_Click(object sender, EventArgs e)
        {
            sslider.Width = collabRq.Width;
            sslider.Left = collabRq.Left;
            collabrequesttab1.BringToFront();
        }

        private void BtnPOS_Click(object sender, EventArgs e)
        {
            sslider.Width = btnPOS.Width;
            sslider.Left = btnPOS.Left;
            pos1.BringToFront();
        }

        private void BtnAnaly_Click(object sender, EventArgs e)
        {
            sslider.Width = btnAnaly.Width;
            sslider.Left = btnAnaly.Left;
            analyticstab1.BringToFront();

        }

        private void GotoStoreNow_Click(object sender, EventArgs e)
        {
            sslider.Width = btnStore.Width;
            sslider.Left = btnStore.Left;
            buyproducts1.Refresh();
            buyproducts1.BringToFront();
        }
    }
}
