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
using System.Net;
using System.Net.Mail;

namespace ShopGuitar
{
    public partial class SendMail : Form
    {
        EnCryp to = new EnCryp();
        public SendMail(string phone,string address,string namec, string mailc)
        {
            InitializeComponent();
            tname.Text = namec;
            tphone.Text = phone;
            taddress.Text = address;
            cMail.Text = mailc;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
           
            MySqlCommand command = new MySqlCommand("INSERT INTO Users (staffid, username, password, sex, staffphone, address, level, staffname, points, money) VALUES (@staffid,@username,@password,@sex,@staffphone,@address,@level,@staffname,@points,@money)", conn);
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = bidtext.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userrandom.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = to.EnCrypt("123456");
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = 1;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = tphone.Text;
            command.Parameters.Add("@address", MySqlDbType.Int32).Value = taddress.Text;
            command.Parameters.Add("@level", MySqlDbType.Int32).Value = 2;
            command.Parameters.Add("@staffname", MySqlDbType.VarChar).Value = tname.Text;
            command.Parameters.Add("@points", MySqlDbType.Int32).Value = 0;
            command.Parameters.Add("@money", MySqlDbType.Int32).Value = 0;
            ExecMyQuery(command, "Confirmed SEND");
            conn.Close();
    }
        public void ExecMyQuery(MySqlCommand mcomd, string msg)
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        conn.Open();
        if (mcomd.ExecuteNonQuery() == 1)
        {
                MailMessage msgg = new MailMessage("tuitit677@gmail.com", cMail.Text, "Account Infomation - Guitar Shop", "Here Your UserName: " + userrandom.Text + " |  Password: 123456 (Default Password, Ur Can Change)");
                msgg.IsBodyHtml = true;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("tuitit677@gmail.com", "0919449012");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msgg);
                Alert.ThatShow(msg, Alert.AlertType.success);
                this.Close();
        }
        else
        {
            Alert.ThatShow("Error in making Your request!!", Alert.AlertType.error);
        }
        conn.Close();
    }
        public void ExecMyQuery1(MySqlCommand mcomd, string msg)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                
                Alert.ThatShow(msg, Alert.AlertType.success);
                this.Close();
            }
            else
            {
                Alert.ThatShow("Error in making Your request!!", Alert.AlertType.error);
            }
            conn.Close();
        }
        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO Users (staffid, username, password, sex, staffphone, address, level, staffname, points, money) VALUES (@staffid,@username,@password,@sex,@staffphone,@address,@level,@staffname,@points,@money)", conn);
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = bidtext.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userrandom.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = to.EnCrypt("123456");
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = 1;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = tphone.Text;
            command.Parameters.Add("@address", MySqlDbType.Int32).Value = taddress.Text;
            command.Parameters.Add("@level", MySqlDbType.Int32).Value = 2;
            command.Parameters.Add("@staffname", MySqlDbType.VarChar).Value = tname.Text;
            command.Parameters.Add("@points", MySqlDbType.Int32).Value = 0;
            command.Parameters.Add("@money", MySqlDbType.Int32).Value = 0;
            ExecMyQuery1(command, "Inserted");
            conn.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void SendMail_Load(object sender, EventArgs e)
        {
            tname.Visible = false;
            tphone.Visible = false;
            taddress.Visible = false;
            cMail.Visible = false;
            bidtext.Visible = false;
            userrandom.Visible = false;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            bidtext.Text = finalString;
            var stringuser = new char[8];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringuser[i] = chars[random.Next(chars.Length)];
            }
            var finalUser = new String(stringuser);
            userrandom.Text = finalUser;
        }
    }
}
