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
    public partial class Changepwdtab : UserControl
    {
        EnCryp to = new EnCryp();
        public Changepwdtab()
        {
            InitializeComponent();
        }

        private void Changepwdtab_Load(object sender, EventArgs e)
        {
            gunaComboBox1.SelectedIndex = 0;
            textBox1.Visible = false;
             currentPass.Visible = false;
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand("Select * FROM Users WHERE username = '" + textBox1.Text + "'", conn))
                {
                    MySqlDataReader Reader;
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        string sname = (string)Reader["staffname"];
                        staffName.Text = sname;
                        int phone = (int)Reader["staffphone"];
                        staffPhone.Text = phone.ToString();
                        string address = (string)Reader["address"];
                        staffAddress.Text = address;
                        string curent = (string)Reader["password"];
                        currentPass.Text = curent;
                        int sexget = (int)Reader["sex"];
                        if (sexget == 1)
                        {
                            gunaComboBox1.SelectedIndex = 0;
                        }else
                        {
                            gunaComboBox1.SelectedIndex = 1;
                        }
                    }
                }
                conn.Close();
            }
        }
        public string USeeding
        {
            set { textBox1.Text = value; }
        }
        public void ExecMyQuery(MySqlCommand mcomd, string msg)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                Alert.ThatShow(msg, Alert.AlertType.success);
            }
            else
            {
                Alert.ThatShow("Error in making Your request!!", Alert.AlertType.error);
            }
            conn.Close();

        }
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("UPDATE Users SET password = @newpwd WHERE username= '"+textBox1.Text+"'", conn);
            command.Parameters.Add("@newpwd", MySqlDbType.VarChar).Value = to.EnCrypt(bunifuMetroTextbox3.Text);
            if(bunifuMetroTextbox1.Text != to.DeCrypt(currentPass.Text))
            {
                Alert.ThatShow("The current PWD is incorrect", Alert.AlertType.warning);
            }else if(bunifuMetroTextbox2.Text != bunifuMetroTextbox3.Text)
            {
                Alert.ThatShow("New password doesn't match", Alert.AlertType.warning);
            }
            else {
            ExecMyQuery(command, "Updated Ur Password");
            }
            conn.Close();
        }

        private void BunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMetroTextbox1.Text == "Current Password")
            {
                bunifuMetroTextbox1.Text = "";
                bunifuMetroTextbox1.isPassword = true;
            }
        }

        private void BunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "")
            {
                bunifuMetroTextbox1.Text = "Current Password";
            }
        }

        private void BunifuMetroTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox2.Text == "New Password")
            {
                bunifuMetroTextbox2.Text = "";
                bunifuMetroTextbox2.isPassword = true;
            }
        }

        private void BunifuMetroTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox2.Text == "")
            {
                bunifuMetroTextbox2.Text = "New Password";
            }
        }

        private void BunifuMetroTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox3.Text == "Confirm New Password")
            {
                bunifuMetroTextbox3.Text = "";
                bunifuMetroTextbox3.isPassword = true;
            }
        }

        private void BunifuMetroTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox3.Text == "")
            {
                bunifuMetroTextbox3.Text = "Confirm New Password";
            }
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int sexnumber = 0;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("UPDATE Users SET sex = @sex, staffphone = @staffphone, address = @address, staffname = @staffname WHERE username= '" + textBox1.Text + "'", conn);
            Object sexcb = gunaComboBox1.SelectedItem;
            if (sexcb.ToString() == "Nam")
            {
                sexnumber = 1;
            }
            else
            { sexnumber = 0; }
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = sexnumber;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = staffPhone.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = staffAddress.Text;
            command.Parameters.Add("@staffname", MySqlDbType.VarChar).Value = staffName.Text;
            if (string.IsNullOrEmpty(staffPhone.Text) || staffPhone.Text == "Your Phone" || string.IsNullOrEmpty(staffAddress.Text) || staffAddress.Text == "Your Address" || string.IsNullOrEmpty(staffName.Text) || staffName.Text == "Your Name")
            {
                Alert.ThatShow("PLS Don't Leave Blank", Alert.AlertType.warning);
            }else if(staffPhone.Text.Length > 11)
            {
                Alert.ThatShow("Phone < 11 Nums", Alert.AlertType.warning);
            }
            else
            {
                ExecMyQuery(command, "Updated Info Successfuly");
            }
            conn.Close();
        }

        private void StaffPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void StaffName_Enter(object sender, EventArgs e)
        {
            if(staffName.Text == "Your Name")
            {
                staffName.Text = "";
            }
        }

        private void StaffName_Leave(object sender, EventArgs e)
        {
            if (staffName.Text == "")
            {
                staffName.Text = "Your Name";
            }
        }

        private void StaffPhone_Enter(object sender, EventArgs e)
        {
            if (staffPhone.Text == "Your Phone")
            {
                staffPhone.Text = "";
            }
        }

        private void StaffPhone_Leave(object sender, EventArgs e)
        {
            if (staffPhone.Text == "")
            {
                staffPhone.Text = "Your Phone";
            }
        }

        private void StaffAddress_Enter(object sender, EventArgs e)
        {
            if (staffAddress.Text == "Your Address")
            {
                staffAddress.Text = "";
            }
        }

        private void StaffAddress_Leave(object sender, EventArgs e)
        {
            if (staffAddress.Text == "")
            {
                staffAddress.Text = "Your Address";
            }
        }
    }
}
