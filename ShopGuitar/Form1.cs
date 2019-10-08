using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGuitar
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        public Form1()
        {
            InitializeComponent();
            btnAlogin.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.Location = Screen.AllScreens[1].WorkingArea.Location;
            loginTab1.BringToFront();
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
        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            regcollaboratortab1.BringToFront();
            btnAlogin.Visible = true;
            btnAlogin.Location = new Point(0, 0);
            bunifuFlatButton1.Visible = false;
        }

        private void BtnAlogin_Click(object sender, EventArgs e)
        {
            loginTab1.BringToFront();
            btnAlogin.Visible = false;
            bunifuFlatButton1.Visible = true;
        }
    }
}
