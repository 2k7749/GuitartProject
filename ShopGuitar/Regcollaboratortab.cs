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
    public partial class Regcollaboratortab : UserControl
    {
        public Regcollaboratortab()
        {
            InitializeComponent();
        }

        private void Regcollaboratortab_Load(object sender, EventArgs e)
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

        private void CollabName_Enter(object sender, EventArgs e)
        {
            if (collabName.Text == "Your Name")
            {
                collabName.Text = "";
                collabName.ForeColor = Color.Crimson;
            }
        }

        private void CollabName_Leave(object sender, EventArgs e)
        {
            if (collabName.Text == "")
            {
                collabName.Text = "Your Name";
                collabName.ForeColor = Color.Gray;
            }
        }

        private void CollabPhone_Enter(object sender, EventArgs e)
        {
            if (collabPhone.Text == "Your Phone")
            {
                collabPhone.Text = "";
                collabPhone.ForeColor = Color.Crimson;
            }
        }

        private void CollabPhone_Leave(object sender, EventArgs e)
        {
            if (collabPhone.Text == "")
            {
                collabPhone.Text = "Your Phone";
                collabPhone.ForeColor = Color.Gray;
            }
        }

        private void CollabAddress_Enter(object sender, EventArgs e)
        {
            if (collabAddress.Text == "Your Address")
            {
                collabAddress.Text = "";
                collabAddress.ForeColor = Color.Crimson;
            }
        }

        private void CollabAddress_Leave(object sender, EventArgs e)
        {
            if (collabPhone.Text == "")
            {
                collabPhone.Text = "Your Address";
                collabAddress.ForeColor = Color.Gray;
            }
        }

        private void TxtIntro_Enter(object sender, EventArgs e)
        {
            if (txtIntro.Text == "Introduce Yourself")
            {
                txtIntro.Text = "";
                txtIntro.ForeColor = Color.Orange;
            }
        }

        private void TxtIntro_Leave(object sender, EventArgs e)
        {
            if (txtIntro.Text == "")
            {
                txtIntro.Text = "Introduce Yourself";
                txtIntro.ForeColor = Color.Gray;
            }
        }

        private void RegCollab_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO Collaborator (collabname, collabphone, collabaddress, intro,gmail) VALUES (@Collabname,@Collabphone,@Collabaddress,@Intro,@gmail)", conn);
            command.Parameters.Add("@Collabname", MySqlDbType.VarChar).Value = collabName.Text;
            command.Parameters.Add("@Collabphone", MySqlDbType.VarChar).Value = collabPhone.Text;
            command.Parameters.Add("@Collabaddress", MySqlDbType.VarChar).Value = collabAddress.Text;
            command.Parameters.Add("@Gmail", MySqlDbType.VarChar).Value = txtMail.Text;
            command.Parameters.Add("@Intro", MySqlDbType.VarChar).Value = txtIntro.Text;
            string email = txtMail.Text;
            if (string.IsNullOrEmpty(collabName.Text) || collabName.Text == "Your Name")
            {
                Alert.ThatShow("Please enter Name to continue", Alert.AlertType.warning);
            }
            else if(string.IsNullOrEmpty(collabPhone.Text) || collabPhone.Text == "Your Phone" || collabPhone.Text.Length >11)
            {
                Alert.ThatShow("Please enter Phone to continue", Alert.AlertType.warning);
            }
            else if (string.IsNullOrEmpty(collabAddress.Text) || collabAddress.Text == "Your Address")
            {
                Alert.ThatShow("Please enter Address to continue", Alert.AlertType.warning);
            }
            else if (string.IsNullOrEmpty(txtMail.Text) || txtMail.Text == "Your G-Mail")
            {
                Alert.ThatShow("Please enter GMAIL to continue", Alert.AlertType.warning);
            }
            else if(email.LastIndexOf("@") < 1)
            {
                Alert.ThatShow("Wrong email format, Check back ", Alert.AlertType.warning);
            }
            else if (string.IsNullOrEmpty(txtIntro.Text) || txtIntro.Text == "Introduce Yourself")
            {
                Alert.ThatShow("Please enter Intro to continue", Alert.AlertType.warning);
            }
            else { 
            ExecMyQuery(command);
            }
            conn.Close();
        }
        public void ExecMyQuery(MySqlCommand mcomd)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                Alert.ThatShow("Submitted successfully", Alert.AlertType.success);
            }
            else
            {
                Alert.ThatShow("Unable to fulfil your request", Alert.AlertType.error);
            }
            conn.Close();
        }

        private void CollabPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int h = 58; h <= 127; h++)
            {
                if (e.KeyChar == h)            
                {
                    e.Handled = true;
                }
            }
            for (int k = 32; k <= 47; k++)
            {
                if (e.KeyChar == k)              
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Your G-Mail")
            {
                txtMail.Text = "";
                txtIntro.ForeColor = Color.Crimson;
            }
        }

        private void TxtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Your G-Mail";
                txtMail.ForeColor = Color.Crimson;
            }
        }
    }
}
