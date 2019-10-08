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
    public partial class Mproducts : UserControl
    {
        public Mproducts()
        {
            InitializeComponent();
        }

        private void Mproducts_Load(object sender, EventArgs e)
        {
            Clear();
            FillGridProducts("");
            comboType.SelectedIndex = 0;
            comboBrand.SelectedIndex = 0;
            QueryTypeandBran();
            txtDateadd.Enabled = false;
            bunifuDatepicker1.Enabled = false;
            btnUpdate.Enabled = false;
            resultpid.Visible = false;
            resultpname.Visible = false;


        }
        public void QueryTypeandBran()
        {
           
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            using (var cmd = new MySqlCommand("select typename From Config_types", conn))
            {
                MySqlDataReader Reader;
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        comboType.Items.Add(Reader.GetString(i));
                    }
                }
            }
            using (var cmd1 = new MySqlCommand("select brandname From Config_brands", conn))
            {
                MySqlDataReader ReaderBrand;
                ReaderBrand = cmd1.ExecuteReader();
                while (ReaderBrand.Read())
                {
                    for (int i = 0; i < ReaderBrand.FieldCount; i++)
                    {
                        comboBrand.Items.Add(ReaderBrand.GetString(i));
                    }
                }
            }
            conn.Close();
        }
       
        public void FillGridProducts(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Products WHERE CONCAT(pid,pname,typename,brandname) LIKE '%" + SearchValue + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[0].Visible = false;
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
            conn.Close(); FillGridProducts("");

        }
        void Clear()
        {
            txtProductid.Text = "Product ID"; txtProductname.Text = "Product Name";  comboType.SelectedIndex = 0; comboBrand.SelectedIndex = 0; txtWholeprice.Text = "Wholesale Price"; txtRetailprice.Text = "Retail Price"; txtQty.Text = "Qty."; txtDateadd.Text = "Date Add";
            pictureBox1.Image = null;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            bunifuImageButton1.Enabled = false;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Choose Image FROM UR PC(*.JPG,*.PNG,*.GIF)|*.jpg;*.png;*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int tempstaffid = 0;
            int tempname = 0;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("INSERT INTO Products (pid, pname, typename, brandname, wholeprice, retailprice, qty, image, dateadd) VALUES (@pid, @pname, @typename, @brandname, @wholeprice, @retailprice, @qty, @image, @dateadd)", conn);
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = txtProductid.Text;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = txtProductname.Text;
            Object typecb = comboType.SelectedItem;
            command.Parameters.Add("@typename", MySqlDbType.VarChar).Value = typecb.ToString();
            Object brandcb = comboBrand.SelectedItem;
            command.Parameters.Add("@brandname", MySqlDbType.VarChar).Value = brandcb.ToString();
            command.Parameters.Add("@wholeprice", MySqlDbType.Int32).Value = txtWholeprice.Text;
            command.Parameters.Add("@retailprice", MySqlDbType.Int32).Value = txtRetailprice.Text;
            command.Parameters.Add("@qty", MySqlDbType.Int32).Value = txtQty.Text;
            command.Parameters.Add("@dateadd", MySqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            using (var cmd = new MySqlCommand("Select pid from Products WHERE pid = '" + txtProductid.Text + "'", conn))
            {
                string reid = Convert.ToString(cmd.ExecuteScalar());
                resultpname.Text = reid;
                if (resultpname.Text.Length > 0)
                {
                    Alert.ThatShow("Products ID already exists", Alert.AlertType.warning);
                }
                else
                {
                    tempstaffid = 1;
                }
            }
            using (var cmd1 = new MySqlCommand("Select pname from Products WHERE pid = '" + txtProductname.Text + "'", conn))
            {
                string repname = Convert.ToString(cmd1.ExecuteScalar());
                resultpid.Text = repname;
                if (resultpid.Text.Length > 0)
                {
                    Alert.ThatShow("Product Name already exists", Alert.AlertType.warning);
                }
                else
                {
                    tempname = 1;
                }
            }
            if (string.IsNullOrEmpty(txtProductid.Text) || txtProductid.Text == "Product ID" || string.IsNullOrEmpty(txtProductname.Text) || txtProductname.Text == "Product Name" || comboType.SelectedIndex == 0 || comboBrand.SelectedIndex ==0 || string.IsNullOrEmpty(txtWholeprice.Text) || txtWholeprice.Text == "Wholesale Price" || string.IsNullOrEmpty(txtRetailprice.Text) || txtRetailprice.Text == "Retail Price" || string.IsNullOrEmpty(txtQty.Text) || txtQty.Text == "Qty.")
            {
                Alert.ThatShow("Don't leave blank", Alert.AlertType.error);
            }
            else if(tempstaffid == 1 && tempname == 1)
            {
                ExecMyQuery(command, "Inserted Successfuly");
            }
            
            conn.Close();
        }

        private void TxtProductid_OnValueChanged(object sender, EventArgs e)
        {
            bunifuImageButton1.Enabled = true;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[8].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            txtProductid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtProductname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboType.SelectedIndex = comboType.Items.IndexOf(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            comboBrand.SelectedIndex = comboBrand.Items.IndexOf(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtWholeprice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRetailprice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtDateadd.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            bunifuDatepicker1.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE Products SET pid=@pid, pname=@pname, typename=@typename, brandname=@brandname, wholeprice=@wholeprice, retailprice = @retailprice, qty = @qty, dateadd = @dateadd, image=@image WHERE id=@id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = txtProductid.Text;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = txtProductname.Text;
            Object typecb = comboType.SelectedItem;
            command.Parameters.Add("@typename", MySqlDbType.VarChar).Value =  typecb.ToString();
            Object brandcb = comboBrand.SelectedItem;
            command.Parameters.Add("@brandname", MySqlDbType.VarChar).Value = brandcb.ToString();
            command.Parameters.Add("@wholeprice", MySqlDbType.Int32).Value = txtWholeprice.Text;
            command.Parameters.Add("@retailprice", MySqlDbType.Int32).Value = txtRetailprice.Text;
            command.Parameters.Add("@qty", MySqlDbType.Int32).Value = txtQty.Text;
            command.Parameters.Add("@dateadd", MySqlDbType.DateTime).Value = bunifuDatepicker1.Value;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            if (string.IsNullOrEmpty(txtProductid.Text) || txtProductid.Text == "Product ID" || string.IsNullOrEmpty(txtProductname.Text) || txtProductname.Text == "Product Name" || comboType.SelectedIndex == 0 || comboBrand.SelectedIndex == 0 || string.IsNullOrEmpty(txtWholeprice.Text) || txtWholeprice.Text == "Wholesale Price" || string.IsNullOrEmpty(txtRetailprice.Text) || txtRetailprice.Text == "Retail Price" || string.IsNullOrEmpty(txtQty.Text) || txtQty.Text == "Qty.")
            {
                Alert.ThatShow("Don't leave blank", Alert.AlertType.error);
            }
            else
            {
                ExecMyQuery(command, "Updated Successfuly");
            }
            
            conn.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM Products WHERE id = @id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ExecMyQuery(command, "Deleted");
            Clear();
            conn.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Products WHERE pid = @pid", conn);
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = txtProductid.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Empty");
                Clear();
            }
            else
            {
                txtProductid.Text = table.Rows[0][1].ToString();
                txtProductname.Text = table.Rows[0][2].ToString();
                comboType.SelectedIndex = comboType.Items.IndexOf(table.Rows[0][3].ToString());
                comboBrand.SelectedIndex = comboBrand.Items.IndexOf(table.Rows[0][4].ToString());
                txtWholeprice.Text = table.Rows[0][5].ToString();
                txtRetailprice.Text = table.Rows[0][6].ToString();
                txtQty.Text = table.Rows[0][7].ToString();
                txtDateadd.Text = table.Rows[0][9].ToString();
                byte[] img = (byte[])table.Rows[0][8];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                bunifuDatepicker1.Enabled = true;

            }
            conn.Close();
        }

        private void TxtProductid_Enter(object sender, EventArgs e)
        {
            if (txtProductid.Text == "Product ID")
            {
                txtProductid.Text = "";
            }
        }

        private void TxtProductid_Leave(object sender, EventArgs e)
        {
            if (txtProductid.Text == "")
            {
                txtProductid.Text = "Product ID";
            }
        }

        private void TxtProductname_Enter(object sender, EventArgs e)
        {
            if (txtProductname.Text == "Product Name")
            {
                txtProductname.Text = "";
            }
        }

        private void TxtProductname_Leave(object sender, EventArgs e)
        {
            if (txtProductname.Text == "")
            {
                txtProductname.Text = "Product Name";
            }
        }
        private void TxtWholeprice_Enter(object sender, EventArgs e)
        {
            if (txtWholeprice.Text == "Wholesale Price")
            {
                txtWholeprice.Text = "";
            }
        }

        private void TxtWholeprice_Leave(object sender, EventArgs e)
        {
            if (txtWholeprice.Text == "")
            {
                txtWholeprice.Text = "Wholesale Price";
            }
        }

        private void TxtRetailprice_Enter(object sender, EventArgs e)
        {
            if (txtRetailprice.Text == "Retail Price")
            {
                txtRetailprice.Text = "";
            }
        }

        private void TxtRetailprice_Leave(object sender, EventArgs e)
        {
            if (txtRetailprice.Text == "")
            {
                txtRetailprice.Text = "Retail Price";
            }
        }

        private void TxtQty_Enter(object sender, EventArgs e)
        {
            if (txtQty.Text == "Qty.")
            {
                txtQty.Text = "";
            }
        }

        private void TxtQty_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                txtQty.Text = "Qty.";
            }
        }
        private void TxtSeaching_Enter(object sender, EventArgs e)
        {
            if (txtSeaching.HintText == "Type your key")
            {
                txtSeaching.Text = "";
                txtSeaching.HintText = "";
                txtSeaching.HintForeColor = Color.Black;
            }
        }

        private void TxtSeaching_Leave(object sender, EventArgs e)
        {
            if (txtSeaching.HintText == "")
            {
                txtSeaching.Text = "";
                txtSeaching.HintText = "Type your key";
                txtSeaching.HintForeColor = Color.Silver;
            }
        }

        private void TxtSeaching_OnValueChanged(object sender, EventArgs e)
        {
            FillGridProducts(txtSeaching.Text);
        }


        private void TxtWholeprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtRetailprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
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
