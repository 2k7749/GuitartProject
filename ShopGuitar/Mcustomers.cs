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
    public partial class Mcustomers : UserControl
    {
        public Mcustomers()
        {
            InitializeComponent();
        }

        private void Mcustomers_Load(object sender, EventArgs e)
        {
            GridFill("");
            boxSex.SelectedIndex = 0;
        }
        void GridFill(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Users WHERE level = 1 AND CONCAT(staffid, staffname) LIKE '%" + SearchValue + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCus.RowTemplate.Height = 30;
            dgvCus.AllowUserToAddRows = false;
            dgvCus.DataSource = table;
            dgvCus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCus.AllowUserToResizeRows = false;
            dgvCus.Columns[0].Visible = false;
            dgvCus.Columns[2].Visible = false;
            dgvCus.Columns[3].Visible = false;
            dgvCus.Columns[8].Visible = false;
        }

        private void DgvCus_DoubleClick(object sender, EventArgs e)
        {
            txtcid.Text = dgvCus.CurrentRow.Cells[1].Value.ToString();
            if (dgvCus.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                boxSex.SelectedIndex = 1;
            }
            else
            {
                boxSex.SelectedIndex = 2;
            }
            txtCphone.Text = dgvCus.CurrentRow.Cells[5].Value.ToString();
            txtCaddress.Text = dgvCus.CurrentRow.Cells[6].Value.ToString();
            txtCname.Text = dgvCus.CurrentRow.Cells[9].Value.ToString();
            txtPoints.Text = dgvCus.CurrentRow.Cells[10].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
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
            GridFill("");

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int sexnumber = 0;
            int tempstaffid = 0;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("UPDATE Users SET staffid = @cid,sex = @sex, staffphone = @cphone, address = @caddress, points = @points, staffname = @staffname WHERE id=@id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvCus.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = txtcid.Text;
            using (var cmd = new MySqlCommand("Select staffid from Users WHERE staffid = '" + txtcid.Text + "'", conn))
            {
                string reid = Convert.ToString(cmd.ExecuteScalar());
                resultstaffid.Text = reid;
                if (resultstaffid.Text.Length > 0)
                {
                    Alert.ThatShow("Customer ID already exists", Alert.AlertType.warning);
                }
                else
                {
                    tempstaffid = 1;
                }
            }
            Object sexcb = boxSex.SelectedItem;
            if (sexcb.ToString() == "Sex" || sexcb.ToString() == "Nam")
            {
                sexnumber = 1;
            }
            else
            { sexnumber = 0; }
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sexnumber;
            command.Parameters.Add("@cphone", MySqlDbType.VarChar).Value = txtCphone.Text;
            command.Parameters.Add("@caddress", MySqlDbType.VarChar).Value = txtCaddress.Text;
            command.Parameters.Add("@staffname", MySqlDbType.VarChar).Value = txtCname.Text;
            command.Parameters.Add("@points", MySqlDbType.Int32).Value = txtPoints.Text;
            if(string.IsNullOrEmpty(txtcid.Text) || txtcid.Text == "Customer ID" || string.IsNullOrEmpty(txtCname.Text) || txtCname.Text == "Customer Name" || string.IsNullOrEmpty(txtCphone.Text) || txtCphone.Text == "Customer Phone" || string.IsNullOrEmpty(txtCaddress.Text) || txtCaddress.Text == "Customer Address" || string.IsNullOrEmpty(txtPoints.Text) || txtPoints.Text == "Points")
            {
                Alert.ThatShow("Don't leave blank", Alert.AlertType.warning);
            }
            else if(tempstaffid == 1){ 
            ExecMyQuery(command, "Updated Successfully");
            }
            conn.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM Users WHERE id = @id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvCus.CurrentRow.Cells[0].Value.ToString();
            ExecMyQuery(command, "Deleted Successfully");
            Clearman();
            conn.Close();
        }
        public void Clearman()
        {
            txtcid.Text = "";
            txtCaddress.Text = "";
            txtCphone.Text = "";
            txtPoints.Text = "";
            txtCname.Text = "";
            boxSex.SelectedIndex = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clearman();
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            GridFill(txtSearchVal.Text);
        }

        private void Txtcid_Enter(object sender, EventArgs e)
        {
            if (txtcid.Text == "Customer ID")
            {
                txtcid.Text = "";
            }
        }

        private void Txtcid_Leave(object sender, EventArgs e)
        {
            if (txtcid.Text == "")
            {
                txtcid.Text = "Customer ID";
            }
        }

        private void TxtCname_Enter(object sender, EventArgs e)
        {
            if (txtCname.Text == "Customer Name")
            {
                txtCname.Text = "";
            }
        }

        private void TxtCname_Leave(object sender, EventArgs e)
        {
            if (txtCname.Text == "")
            {
                txtCname.Text = "Customer Name";
            }
        }

        private void TxtCphone_Enter(object sender, EventArgs e)
        {
            if (txtCphone.Text == "Customer Phone")
            {
                txtCphone.Text = "";
            }
        }

        private void TxtCphone_Leave(object sender, EventArgs e)
        {
            if (txtCphone.Text == "")
            {
                txtCphone.Text = "Customer Phone";
            }
        }

        private void TxtCaddress_Enter(object sender, EventArgs e)
        {
            if (txtCaddress.Text == "Customer Address")
            {
                txtCaddress.Text = "";
            }
        }

        private void TxtCaddress_Leave(object sender, EventArgs e)
        {
            if (txtCaddress.Text == "")
            {
                txtCaddress.Text = "Customer Address";
            }
        }

        private void TxtPoints_Enter(object sender, EventArgs e)
        {
            if (txtPoints.Text == "Points")
            {
                txtPoints.Text = "";
            }
        }

        private void TxtPoints_Leave(object sender, EventArgs e)
        {
            if (txtPoints.Text == "")
            {
                txtPoints.Text = "Points";
            }
        }

        private void TxtSearchVal_Enter(object sender, EventArgs e)
        {
            if(txtSearchVal.HintText == "Write your text here...")
            {
                txtSearchVal.HintText = "";
                txtSearchVal.Text = "";
                txtSearchVal.HintForeColor = Color.Crimson;
            }
        }

        private void TxtSearchVal_Leave(object sender, EventArgs e)
        {
            if (txtSearchVal.HintText == "")
            {
                txtSearchVal.Text = "";
                txtSearchVal.HintText = "Write your text here...";
                txtSearchVal.HintForeColor = Color.DarkGray;
            }
        }
    }
}
