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
    public partial class Collabrequesttab : UserControl
    {
        EnCryp to = new EnCryp();
        public Collabrequesttab()
        {
            InitializeComponent();
        }
        void GridFill(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Collaborator WHERE CONCAT(collabname) LIKE '%" + SearchValue + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCollab.RowTemplate.Height = 50;
            dgvCollab.AllowUserToAddRows = false;
            dgvCollab.DataSource = table;
            dgvCollab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCollab.Columns[0].Visible = false;
            dgvCollab.AllowUserToResizeRows = false;
        }
        private void Collabrequesttab_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnConfirm.Enabled = false;
            GridFill("");
        }

        private void BunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void DgvCollab_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCollab.CurrentRow.Index != -1)
            {
                cName.Text = dgvCollab.CurrentRow.Cells[1].Value.ToString();
                cPhone.Text = dgvCollab.CurrentRow.Cells[2].Value.ToString();
                cAddress.Text = dgvCollab.CurrentRow.Cells[3].Value.ToString();
                cIntro.Text = dgvCollab.CurrentRow.Cells[4].Value.ToString();
                cMail.Text = dgvCollab.CurrentRow.Cells[5].Value.ToString();
                btnDelete.Enabled = true;
                btnConfirm.Enabled = true;
            }
        }

        private void DgvCollab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BunifuTextbox1_Enter(object sender, EventArgs e)
        {
            if(bunifuTextbox1.text == "Search")
            {
                bunifuTextbox1.text = "";
                bunifuTextbox1.ForeColor = Color.White;
            }
        }

        private void BunifuTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text == "")
            {
                bunifuTextbox1.text = "Search";
                bunifuTextbox1.ForeColor = Color.Black;
            }
        }

        private void BunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            GridFill(bunifuTextbox1.text);
        }
        void Clear()
        {
            cName.Text = cAddress.Text = cPhone.Text = cIntro.Text = cMail.Text  = "";
            btnDelete.Enabled = false;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SendMail openSend = new SendMail(cPhone.Text, cAddress.Text, cName.Text, cMail.Text);
            openSend.ShowDialog();
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
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM Collaborator WHERE id = @id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvCollab.CurrentRow.Cells[0].Value.ToString();
            ExecMyQuery(command, "Deleted");
            Clear();
            conn.Close();
        }
    }
}
