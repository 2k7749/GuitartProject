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
    public partial class Historybuytab : UserControl
    {
        public Historybuytab()
        {
            InitializeComponent();
        }

        private void Historybuytab_Load(object sender, EventArgs e)
        {
            txtGetName.Visible = false;
            txtsid.Visible = false;
            getdate.Visible = false;
            getdateto.Visible = false;
            bunifuDatepicker1.FormatCustom = "dd/MM/yyyy";
            bunifuDatepicker2.FormatCustom = "dd/MM/yyyy";
            gettingiduser(txtGetName.Text);
            FillGridLogs("");
        }
        public void FillGridLogs(string enterbillid)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string txtid = txtsid.Text;
            MySqlCommand gridfill = new MySqlCommand("Select * from SaleLog WHERE IF('" + enterbillid + "' = '',bid LIKE '%%',bid = '" + enterbillid + "')", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvHistory.RowTemplate.Height = 30;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.DataSource = table;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        public void gettingiduser(string staffidget)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select staffid FROM Users WHERE username = '" + staffidget + "'";
            string typeaccount = Convert.ToString(cmd1.ExecuteScalar());
            txtsid.Text = typeaccount;
            conn.Close();
        }
        public string USeeding
        {
            set { txtGetName.Text = value; }
        }

        private void BunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            getdate.Text = bunifuDatepicker1.Value.ToString("yyyy/MM/dd");
            getdateto.Text = bunifuDatepicker2.Value.ToString("yyyy/MM/dd");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string txtid = txtsid.Text;
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Salelog WHERE date(dofsale) BETWEEN '" + getdate.Text + "' and '" + getdateto.Text + "'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvHistory.RowTemplate.Height = 30;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.DataSource = table;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            FillGridLogs(bunifuMaterialTextbox1.Text);
        }

        private void BunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuMaterialTextbox1.HintText == "Search W Bill ID")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.HintText = "";
                bunifuMaterialTextbox1.HintForeColor = Color.Crimson;
            }
        }

        private void BunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.HintText == "")
            {
                bunifuMaterialTextbox1.HintText = "Search W Bill ID";
                bunifuMaterialTextbox1.HintForeColor = Color.Gray;
            }
        }
    }
}
