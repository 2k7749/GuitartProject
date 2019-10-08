using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ShopGuitar
{
    public partial class Muser : UserControl
    {
        EnCryp to = new EnCryp();
        int id = 0;
        
        public Muser()
        {
            InitializeComponent();
        }
        void GridFill(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Users WHERE CONCAT(staffid,username,staffphone) LIKE '%" + SearchValue + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsers.RowTemplate.Height = 50;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dgvUsers.Columns[8];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[10].Visible = false;
        }
        private void Muser_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill("");
            resultstaffid.Visible = false;
            resultusername.Visible = false;
            upPic.Enabled = true;
            sexCombo.SelectedIndex = 0;
            levelCombo.SelectedIndex = 0;
        }
        void Clear()
        {
            mid.Text = "Staff ID"; mUsername.Text = "Username"; mPassword.Text = "Password"; sexCombo.SelectedIndex = 0; mPhone.Text = "Staff Phone"; mAddress.Text = "Address"; levelCombo.SelectedIndex = 0;
            pictureBox1.Image = null;
            id = 0;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            upPic.Enabled = false;
        }

        private void DgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow.Index != -1)
            {
                Byte[] img = (Byte[])dgvUsers.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                mid.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                mUsername.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                mPassword.Text = to.DeCrypt(dgvUsers.CurrentRow.Cells[3].Value.ToString());
                if(dgvUsers.CurrentRow.Cells[4].Value.ToString() == "1")
                {
                    sexCombo.SelectedIndex = 1;
                }else
                {
                    sexCombo.SelectedIndex = 2;
                }
                mPhone.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
                mAddress.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
                if (dgvUsers.CurrentRow.Cells[7].Value.ToString() == "1")
                {
                    levelCombo.SelectedIndex = 1;
                }else if (dgvUsers.CurrentRow.Cells[7].Value.ToString() == "2")
                {
                    levelCombo.SelectedIndex = 2;
                }
                else if (dgvUsers.CurrentRow.Cells[7].Value.ToString() == "3")
                {
                    levelCombo.SelectedIndex = 3;
                }
                else if (dgvUsers.CurrentRow.Cells[7].Value.ToString() == "4")
                {
                    levelCombo.SelectedIndex = 4;
                }
                else
                {
                    levelCombo.SelectedIndex = 5;
                }
                mStaffname.Text = dgvUsers.CurrentRow.Cells[9].Value.ToString();
                id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                upPic.Enabled = true;
            }
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
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int tempstaffid = 0;
            int tempuername = 0;
            int levelnumber = 0;
            int sexnumber = 0;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("INSERT INTO Users (staffid, username, password, sex, staffphone, address, level, image, staffname) VALUES (@staffid, @username, @password, @sex, @staffphone, @address, @level, @image, @staffname)", conn);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = mid.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = mUsername.Text;
            string getdatabox = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = to.EnCrypt(mPassword.Text);
            Object sexcb = sexCombo.SelectedItem;
            if (sexcb.ToString() == "Sex" || sexcb.ToString() == "Nam")
            {
                sexnumber = 1;
            }else
            { sexnumber = 0; }
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = sexnumber;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = mPhone.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = mAddress.Text;
            Object selectedItem = levelCombo.SelectedItem;
            
            if (selectedItem.ToString() == "Level" || selectedItem.ToString() == "Customer")
            {
                levelnumber = 1;
            }
            else if (selectedItem.ToString() == "Staff")
            {
                levelnumber = 2;
            }
            else if (selectedItem.ToString() == "Collaborator")
            {
                levelnumber = 3;
            }
            else if (selectedItem.ToString() == "Warehouse Checker")
            {
                levelnumber = 4;
            }
            else
            {
                levelnumber = 5;
            }
            command.Parameters.Add("@level", MySqlDbType.Int32).Value = levelnumber;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@staffname", MySqlDbType.VarChar).Value = mStaffname.Text;
            using (var cmd = new MySqlCommand("Select staffid from Users WHERE staffid = '"+mid.Text+"'", conn))
            {
                  string reid = Convert.ToString(cmd.ExecuteScalar());
                    resultstaffid.Text = reid;
                    if(resultstaffid.Text.Length > 0)
                {
                    Alert.ThatShow("Staff ID already exists", Alert.AlertType.warning);
                }
                else
                {
                    tempstaffid = 1;
                }
            }
            using (var cmd1 = new MySqlCommand("Select username from Users WHERE username = '"+mUsername.Text+"'", conn))
            {
                string reuser = Convert.ToString(cmd1.ExecuteScalar());
                resultusername.Text = reuser;
                if (resultusername.Text.Length > 0)
                {
                    Alert.ThatShow("Username already exists", Alert.AlertType.warning);
                }
                else
                {
                    tempuername = 1;
                }
            }
            if (string.IsNullOrEmpty(mid.Text) || mid.Text == "Staff ID" || string.IsNullOrEmpty(mUsername.Text) || mUsername.Text == "Username" || string.IsNullOrEmpty(mPassword.Text) || mPassword.Text == "Password" || string.IsNullOrEmpty(mPhone.Text) || mPhone.Text == "Staff Phone" || string.IsNullOrEmpty(mAddress.Text) || mAddress.Text == "Address")
            {
                Alert.ThatShow("Don't leave blank", Alert.AlertType.error);
            }
            else if (pictureBox1.Image == null)
            {
                Alert.ThatShow("Please Import Image", Alert.AlertType.error);
            }
            else if (tempstaffid == 1 && tempuername == 1)
            {
                ExecMyQuery(command, "Insert Successfully");
            }
            
            conn.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UpPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Choose Image FROM UR PC(*.JPG,*.PNG,*.GIF)|*.jpg;*.png;*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand connafterrcmd = new MySqlCommand("UsersDeleteID", conn);
                connafterrcmd.CommandType = CommandType.StoredProcedure;
                connafterrcmd.Parameters.AddWithValue("_id", id);
                connafterrcmd.ExecuteNonQuery();
                Clear();
                GridFill("");
                conn.Close();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int levelnumber = 0;
            int sexnumber = 0;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE Users SET staffid = @staffid, username = @username, password = @password, sex = @sex, staffphone = @staffphone, address = @address, level = @level, image = @image, staffname = @staffname WHERE id = @id", conn);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = mid.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = mUsername.Text;
            string getdatabox = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = to.EnCrypt(mPassword.Text);
            Object sexcb = sexCombo.SelectedItem;
            if (sexcb.ToString() == "Sex" || sexcb.ToString() == "Nam")
            {
                sexnumber = 1;
            }
            else
            { sexnumber = 0; }
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = sexnumber;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = mPhone.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = mAddress.Text;
            Object selectedItem = levelCombo.SelectedItem;
            if (selectedItem.ToString() == "Level" || selectedItem.ToString() == "Customer")
            {
                levelnumber = 1;
            }
            else if (selectedItem.ToString() == "Staff")
            {
                levelnumber = 2;
            }
            else if (selectedItem.ToString() == "Collaborator")
            {
                levelnumber = 3;
            }
            else if (selectedItem.ToString() == "Warehouse Checker")
            {
                levelnumber = 4;
            }
            else
            {
                levelnumber = 5;
            }
            command.Parameters.Add("@level", MySqlDbType.Int32).Value = levelnumber;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@staffname", MySqlDbType.VarChar).Value = mStaffname.Text;
            if (string.IsNullOrEmpty(mid.Text) || mid.Text == "Staff ID" || string.IsNullOrEmpty(mUsername.Text) || mUsername.Text == "Username" || string.IsNullOrEmpty(mPassword.Text) || mPassword.Text == "Password" || string.IsNullOrEmpty(mPhone.Text) || mPhone.Text == "Staff Phone" || string.IsNullOrEmpty(mAddress.Text) || mAddress.Text == "Address")
            {
                Alert.ThatShow("Don't leave blank", Alert.AlertType.error);
            }else
            { ExecMyQuery(command, "Updated Successfully");  }
            conn.Close();
        }

        private void Mid_OnValueChanged(object sender, EventArgs e)
        {
            upPic.Enabled = true;
        }

        private void Mid_Enter(object sender, EventArgs e)
        {
            if (mid.Text == "Staff ID")
            {
                mid.Text = "";
            }
        }

        private void Mid_Leave(object sender, EventArgs e)
        {
            if (mid.Text == "")
            {
                mid.Text = "Staff ID";
            }
        }

        private void MUsername_Enter(object sender, EventArgs e)
        {
            if (mUsername.Text == "Username")
            {
                mUsername.Text = "";
            }
        }

        private void MUsername_Leave(object sender, EventArgs e)
        {
            if (mUsername.Text == "")
            {
                mUsername.Text = "Username";
            }
        }

        private void TxtSearch_OnValueChanged(object sender, EventArgs e)
        {
            GridFill(txtSearch.Text);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE staffid = @staffid", conn);
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = mid.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                Alert.ThatShow("Empty", Alert.AlertType.info);
                Clear();
            }
            else
            {
                mid.Text = table.Rows[0][1].ToString();
                mUsername.Text = table.Rows[0][2].ToString();
                mPassword.Text = to.EnCrypt(table.Rows[0][3].ToString());
                if (table.Rows[0][4].ToString() == "1")
                {
                    sexCombo.SelectedIndex = 1;
                }
                else
                {
                    sexCombo.SelectedIndex = 2;
                }
                mPhone.Text = table.Rows[0][5].ToString();
                mAddress.Text = table.Rows[0][6].ToString();
                if (table.Rows[0][7].ToString() == "1")
                {
                    levelCombo.SelectedIndex = 1;
                }
                else if (table.Rows[0][7].ToString() == "2")
                {
                    levelCombo.SelectedIndex = 2;
                }
                else if (table.Rows[0][7].ToString() == "3")
                {
                    levelCombo.SelectedIndex = 3;
                }
                else if (table.Rows[0][7].ToString() == "4")
                {
                    levelCombo.SelectedIndex = 4;
                }
                else
                {
                    levelCombo.SelectedIndex = 5;
                }
                byte[] img = (byte[])table.Rows[0][8];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                mStaffname.Text = table.Rows[0][9].ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                upPic.Enabled = true;
            }
        }

        private void MPassword_Enter(object sender, EventArgs e)
        {
            if (mPassword.Text == "Password")
            {
                mPassword.Text = "";
            }
        }

        private void MPassword_Leave(object sender, EventArgs e)
        {
            if (mPassword.Text == "")
            {
                mPassword.Text = "Password";
            }
        }

        private void MPhone_Enter(object sender, EventArgs e)
        {
            if (mPhone.Text == "Staff Phone")
            {
                mPhone.Text = "";
            }
        }

        private void MPhone_Leave(object sender, EventArgs e)
        {
            if (mPhone.Text == "")
            {
                mPhone.Text = "Staff Phone";
            }
        }

        private void MAddress_Enter(object sender, EventArgs e)
        {
            if (mAddress.Text == "Address")
            {
                mAddress.Text = "";
            }
        }

        private void MAddress_Leave(object sender, EventArgs e)
        {
            if (mAddress.Text == "")
            {
                mAddress.Text = "Address";
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.HintText == "Write your text here")
            {
                txtSearch.HintText = "";
                txtSearch.Text = "";
                txtSearch.HintForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.HintText == "")
            {
                txtSearch.Text = "";
                txtSearch.HintText = "Write your text here";
                txtSearch.HintForeColor = Color.Silver;
            }
        }

        private void MStaffname_Enter(object sender, EventArgs e)
        {
            if (mStaffname.Text == "Staff Name")
            {
                mStaffname.Text = "";
            }
        }

        private void MStaffname_Leave(object sender, EventArgs e)
        {
            if (mStaffname.Text == "")
            {
                mStaffname.Text = "Staff Name";
            }
        }

        private void MPhone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
