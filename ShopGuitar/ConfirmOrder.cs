using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGuitar
{
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder()
        {
            InitializeComponent();

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
    }
}
