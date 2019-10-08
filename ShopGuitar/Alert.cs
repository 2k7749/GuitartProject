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
    public partial class Alert : Form
    {
        public Alert(string _alertmessage, AlertType type)
        {
            InitializeComponent();
            alertmessage.Text = _alertmessage;
            switch(type){
                case AlertType.success:
                    this.BackColor = Color.MediumSeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warning:
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[2];
                    break;
                case AlertType.error:
                    this.BackColor = Color.Orange;
                    icon.Image = imageList1.Images[3];
                    break;
            }
        }
        public static void ThatShow(string alertmessage, AlertType type)
        {
            new ShopGuitar.Alert(alertmessage, type).Show();
        }
        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = -1* (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 20;
            show.Start();
        }
        public enum AlertType
        {
            success, info, warning, error
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        private void Timeout_Tick(object sender, EventArgs e)
        {
            closealert.Start();
        }
        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
        //transit
        int interval = 400;
        private void Show_Tick(object sender, EventArgs e)
        {
            if(this.Top<500)
            {
                this.Top += interval;//drop
                interval += 2;//speed
                Shake(this);
            }
            else
            {
                show.Stop();
            }
        }

        private void Closealert_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }
    }
}
