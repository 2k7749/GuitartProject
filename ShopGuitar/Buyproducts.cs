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
    public partial class Buyproducts : UserControl
    {
        public Buyproducts()
        {
            InitializeComponent();
        }
        private void Buyproducts_Load(object sender, EventArgs e)
        {
            Showitems("");
            QueryTypeandBran();
            flowLayoutPanel1.Controls.Clear();
            comboType.SelectedIndex = 0;
            NamedProduct.Enabled = false;
            txtLeftqty.Enabled = false;
            panel2.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            txtpid.Visible = false;
            txtQty.Visible = false;
            txtRetail.Visible = false;
            sumqty.Visible = false;
            preNameP.Visible = false;
            userSeed.Visible = false;
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
            conn.Close();
        }
        public void Showitems(string gettype)
        {

            int horizotal = 3;
            int verical = 3;
            int mod = 0;

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from Products WHERE IF('"+gettype+ "' = 'Select Category',typename LIKE '%%',typename = '" + gettype + "')", conn);
            MySqlDataReader Reader;
            Reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Reader);
            int numRows = dt.Rows.Count;
            int i = 0;
            Button[] btn_item = new Button[numRows];
            foreach(DataRow row in dt.Rows)
            {
                Byte[] img = (Byte[])row[8];
                MemoryStream ms = new MemoryStream(img);
                btn_item[i] = new Button();
                btn_item[i].BackColor = System.Drawing.Color.Crimson;
                btn_item[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_item[i].ForeColor = System.Drawing.Color.White;
                btn_item[i].Size = new System.Drawing.Size(120, 120);
                btn_item[i].TabIndex = 0;
                btn_item[i].TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn_item[i].UseVisualStyleBackColor = false;
                btn_item[i].Cursor = System.Windows.Forms.Cursors.Hand;
                btn_item[i].Location = new Point(horizotal, verical);
                btn_item[i].Text = row[2].ToString();
                btn_item[i].BackgroundImage = Image.FromStream(ms);
                btn_item[i].BackgroundImageLayout = ImageLayout.Stretch;
                btn_item[i].Click += new EventHandler(btn_Click);
                btn_item[i].Click += new EventHandler(btn_Click);
                mod = i % 4;
                if(mod == 0)
                {
                    verical = 0;
                    horizotal = horizotal + 135;
                }else
                {
                    verical = verical + 122;
                    flowLayoutPanel1.Controls.Add(btn_item[i]);
                }
                i++;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn_item = sender as Button;
            NamedProduct.Text = btn_item.Text.ToString();
            preNameP.Text = NamedProduct.Text + "xxx";
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand("Select pid,pname,retailprice,qty FROM Products WHERE pname = '"+ btn_item.Text.ToString() + "'", conn))
                {
                    MySqlDataReader Reader;
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        string pidd = (string)Reader["pid"];
                        txtpid.Text = pidd;
                        int retailprice = (int)Reader["retailprice"];
                        txtRetail.Text = retailprice.ToString();
                        int qty = (int)Reader["qty"];
                        txtQty.Text = qty.ToString();
                        txtLeftqty.Text = qty.ToString();
                    }
                    if (sumqty.Text != "")
                    {
                        int stock = int.Parse(txtQty.Text) - int.Parse(sumqty.Text);
                        txtLeftqty.Text = stock.ToString();
                        if(txtLeftqty.Text == "0")
                        {
                            panel2.Visible = false;
                            Alert.ThatShow("OutStock", Alert.AlertType.warning);
                        }
                    }
                    else if (txtQty.Text == "0")
                    {
                        panel2.Visible = false;
                        Alert.ThatShow("OutStock", Alert.AlertType.warning);
                    }
                    else
                    {
                        panel2.Visible = true;
                    }
                    if (preNameP.Text != btn_item.Text.ToString())
                    {
                        sumqty.Text = "";
                    }
                    int sum = 0;
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1[1, j].Value.ToString() == btn_item.Text.ToString())
                        {
                          sum = sum + Convert.ToInt32(dataGridView1[2, j].Value);
                            sumqty.Text = sum.ToString(); 
                        } 
                    }
                    
                    // int count = Convert.ToInt32(cmd.ExecuteScalar());
                    // totalusers.Text = count.ToString();
                }
                conn.Close();
            }
        }

        private void N1_Click_1(object sender, EventArgs e)
        {
            selectedQty.Text = n1.LabelText;
        }

        private void N2_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n2.LabelText;
        }

        private void N3_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n3.LabelText;
        }

        private void N4_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n4.LabelText;
        }

        private void N5_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n5.LabelText;
        }

        private void N6_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n6.LabelText;
        }

        private void N7_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n7.LabelText;
        }

        private void N8_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n8.LabelText;
        }

        private void N9_Click(object sender, EventArgs e)
        {
            selectedQty.Text = n9.LabelText;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            selectedQty.Text = "Qty.";
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            txtpid.Text = "";
            txtQty.Text = "";
            txtRetail.Text = "";
            sumqty.Text = "";
            NamedProduct.Text = "Name Product";
            selectedQty.Text = "Qty.";
            panel2.Visible = false;
        }
        static int ID_ = 0;
        public static int Id
        {
            get { return ++ID_; }
        }
        private void AddTocart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedQty.Text) || selectedQty.Text == "Qty.")
                          {
                        
                             Alert.ThatShow("Please fill Qty.", Alert.AlertType.warning);
                         }
            else if (int.Parse(txtLeftqty.Text) < int.Parse(selectedQty.Text))
            {
                Alert.ThatShow("Not enough product Qty. instock", Alert.AlertType.warning);

            }
            else
                    {
                        int rowId = dataGridView1.Rows.Add();
                        DataGridViewRow row = dataGridView1.Rows[rowId];
                        row.Cells["id"].Value = Id.ToString();
                        row.Cells["pname"].Value = NamedProduct.Text;
                        row.Cells["Qty"].Value = selectedQty.Text;
                        row.Cells["Price"].Value = txtRetail.Text;
                        int totals = int.Parse(selectedQty.Text) * int.Parse(txtRetail.Text); 
                        row.Cells["Total"].Value = totals;
                        row.Cells["pid"].Value = txtpid.Text;
                sumqty.Text = "";
                panel2.Visible = false;
            }
        }

        private void ComboType_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Object typecb = comboType.SelectedItem;
            Showitems(typecb.ToString());
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sumqty.Text = "";
            panel2.Visible = false;
        }

        private void BtnDel1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected) { 
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    sumqty.Text = "";
                    panel2.Visible = false;
                }
            }
        }

        private void SelectedQty_Enter(object sender, EventArgs e)
        {
            if(selectedQty.Text == "Qty.")
            {
                selectedQty.Text = "";
                selectedQty.ForeColor = Color.Crimson;
            }
        }

        private void SelectedQty_Leave(object sender, EventArgs e)
        {
            if (selectedQty.Text == "")
            {
                selectedQty.Text = "Qty.";
                selectedQty.ForeColor = Color.Black;
            }
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            txtpid.Text = FastAddPID.Text;
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand("Select pid,pname,retailprice,qty FROM Products WHERE pid = '" + FastAddPID.Text + "'", conn))
                {
                    MySqlDataReader Reader;
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        string pname = (string)Reader["pname"];
                        NamedProduct.Text = pname;
                        int retailprice = (int)Reader["retailprice"];
                        txtRetail.Text = retailprice.ToString();
                        int qty = (int)Reader["qty"];
                        txtQty.Text = qty.ToString();
                    }
                    // int count = Convert.ToInt32(cmd.ExecuteScalar());
                    // totalusers.Text = count.ToString();
                }
                conn.Close();
            }
        }

        private void FastAddPID_Enter(object sender, EventArgs e)
        {
            if (FastAddPID.Text == "Product ID")
            {
                FastAddPID.Text = "";
                FastAddPID.ForeColor = Color.DarkSlateBlue;
            }
        }

        private void FastAddPID_Leave(object sender, EventArgs e)
        {
            if (FastAddPID.Text == "")
            {
                FastAddPID.Text = "Product ID";
                FastAddPID.ForeColor = Color.Black;
            }
        }

        private void PayNow_Click(object sender, EventArgs e)
        {
            ConfirmOrder confirms = new ConfirmOrder(userSeed.Text);
            confirms.buyorderlist.Rows.Clear();
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        confirms.buyorderlist.Rows.Add();
                        confirms.buyorderlist.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        confirms.buyorderlist.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        confirms.buyorderlist.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        confirms.buyorderlist.Rows[i].Cells[3].Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        confirms.buyorderlist.Rows[i].Cells[4].Value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        confirms.buyorderlist.Rows[i].Cells[5].Value = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    }
                }
                confirms.ShowDialog();
            }
            else
            {
                Alert.ThatShow("There re no Items to Pay", Alert.AlertType.info);
            }
            
        }

        private void SelectedQty_KeyPress(object sender, KeyPressEventArgs e)
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


        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            txtIntomoney.Text = sum.ToString();


        }
        public string USeeding
        {
            set { userSeed.Text = value; }
        }
        private void PreNameP_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
