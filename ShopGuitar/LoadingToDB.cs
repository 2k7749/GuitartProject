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
    public partial class LoadingToDB : Form
    {
        public LoadingToDB(string gettinguser)
        {
            InitializeComponent();
            userflogin.Text = gettinguser;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if (rectangleShape2.Width >= 475)
            {
                timer1.Stop();
                DashBoard db = new DashBoard(userflogin.Text);
                db.Show();
                this.Hide();
            }
        }

        private void LoadingToDB_Load(object sender, EventArgs e)
        {
            userflogin.Visible = false;
        }
    }
}
