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
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder(string getuseedding)
        {
            InitializeComponent();
            txtIntomoney.Enabled = false;
            getUserSeed.Visible = false;
            getUserSeed.Text = getuseedding;
        }

        private void ConfirmOrder_Load(object sender, EventArgs e)
        {
            buyorderlist.RowHeadersVisible = false;
            buyorderlist.AllowUserToAddRows = false;
            int sum = 0;
            for (int i = 0; i < buyorderlist.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(buyorderlist.Rows[i].Cells[4].Value);
            }
            txtIntomoney.Text = sum.ToString();
        }
        private void TxtIntomoney_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Paynow_Click(object sender, EventArgs e)
        {
            int _min = 1111;
            int _max = 9999;
            Random _rdm = new Random();
            int billrandom = _rdm.Next(_min, _max);
            MySqlConnection conn = DBUtils.GetDBConnection();
            if (string.IsNullOrEmpty(txtadressship.Text) || txtadressship.Text == "Press your Address")
            {
                Alert.ThatShow("PLS enter your Address", Alert.AlertType.warning);
            }else
            {
                Alert.ThatShow("Pay Success", Alert.AlertType.success);
                for (int i = 0; i < buyorderlist.Rows.Count; i++)
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Salelog (bid, pname, pid, staffid, amount, dofsale, totals, address) VALUES (@bid,@pname,@pid,@staffid,@amount,@dofsale,@totals,@address)", conn);
                MySqlDataReader myReader;
                command.Parameters.Add("@bid", MySqlDbType.Int32).Value = billrandom; // bill random
                command.Parameters.AddWithValue("@pname", buyorderlist.Rows[i].Cells[1].Value);
                command.Parameters.AddWithValue("@pid", buyorderlist.Rows[i].Cells[5].Value);
                command.Parameters.AddWithValue("@staffid", getUserSeed.Text);
                command.Parameters.AddWithValue("@amount", buyorderlist.Rows[i].Cells[2].Value);
                command.Parameters.AddWithValue("@dofsale", DateTime.Now);
                command.Parameters.AddWithValue("@totals", buyorderlist.Rows[i].Cells[4].Value);
                command.Parameters.AddWithValue("@address", txtadressship.Text);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                }
                conn.Close();
            }
                this.Close();
            }
        }

        private void Txtadressship_Enter(object sender, EventArgs e)
        {
            if(txtadressship.Text == "Press your Address")
            {
                txtadressship.Text = "";
            }
        }

        private void Txtadressship_Leave(object sender, EventArgs e)
        {
            if(txtadressship.Text == "")

            {
                txtadressship.Text = "Press your Address";
            }
        }
    }
}
