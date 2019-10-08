namespace ShopGuitar
{
    partial class ConfirmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmOrder));
            this.buyorderlist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadressship = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntomoney = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Paynow = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.getUserSeed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.buyorderlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paynow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // buyorderlist
            // 
            this.buyorderlist.BackgroundColor = System.Drawing.Color.White;
            this.buyorderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyorderlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pname,
            this.Qty,
            this.Price,
            this.Total,
            this.Pid});
            this.buyorderlist.Location = new System.Drawing.Point(12, 55);
            this.buyorderlist.Name = "buyorderlist";
            this.buyorderlist.RowHeadersWidth = 51;
            this.buyorderlist.RowTemplate.Height = 24;
            this.buyorderlist.Size = new System.Drawing.Size(528, 422);
            this.buyorderlist.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "No.";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // pname
            // 
            this.pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pname.HeaderText = "Name";
            this.pname.MinimumWidth = 6;
            this.pname.Name = "pname";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 60;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 90;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 110;
            // 
            // Pid
            // 
            this.Pid.HeaderText = "pid";
            this.Pid.MinimumWidth = 6;
            this.Pid.Name = "Pid";
            this.Pid.Visible = false;
            this.Pid.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "- Payment Confirmation -";
            // 
            // txtadressship
            // 
            this.txtadressship.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtadressship.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtadressship.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtadressship.BorderThickness = 3;
            this.txtadressship.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadressship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtadressship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtadressship.isPassword = false;
            this.txtadressship.Location = new System.Drawing.Point(12, 542);
            this.txtadressship.Margin = new System.Windows.Forms.Padding(4);
            this.txtadressship.Name = "txtadressship";
            this.txtadressship.Size = new System.Drawing.Size(329, 46);
            this.txtadressship.TabIndex = 5;
            this.txtadressship.Text = "Press your Address";
            this.txtadressship.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtadressship.Enter += new System.EventHandler(this.Txtadressship_Enter);
            this.txtadressship.Leave += new System.EventHandler(this.Txtadressship_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Into Money: ";
            // 
            // txtIntomoney
            // 
            this.txtIntomoney.BorderColorFocused = System.Drawing.Color.Red;
            this.txtIntomoney.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtIntomoney.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtIntomoney.BorderThickness = 3;
            this.txtIntomoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIntomoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIntomoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIntomoney.isPassword = false;
            this.txtIntomoney.Location = new System.Drawing.Point(416, 480);
            this.txtIntomoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntomoney.Name = "txtIntomoney";
            this.txtIntomoney.Size = new System.Drawing.Size(123, 36);
            this.txtIntomoney.TabIndex = 12;
            this.txtIntomoney.Text = "Totals";
            this.txtIntomoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIntomoney.OnValueChanged += new System.EventHandler(this.TxtIntomoney_OnValueChanged);
            // 
            // Paynow
            // 
            this.Paynow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Paynow.Image = ((System.Drawing.Image)(resources.GetObject("Paynow.Image")));
            this.Paynow.ImageActive = null;
            this.Paynow.Location = new System.Drawing.Point(357, 533);
            this.Paynow.Name = "Paynow";
            this.Paynow.Size = new System.Drawing.Size(88, 63);
            this.Paynow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Paynow.TabIndex = 13;
            this.Paynow.TabStop = false;
            this.Paynow.Zoom = 10;
            this.Paynow.Click += new System.EventHandler(this.Paynow_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Gray;
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.ImageActive = null;
            this.Cancel.Location = new System.Drawing.Point(451, 533);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 63);
            this.Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cancel.TabIndex = 14;
            this.Cancel.TabStop = false;
            this.Cancel.Zoom = 10;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // getUserSeed
            // 
            this.getUserSeed.Location = new System.Drawing.Point(13, 9);
            this.getUserSeed.Name = "getUserSeed";
            this.getUserSeed.Size = new System.Drawing.Size(13, 22);
            this.getUserSeed.TabIndex = 15;
            // 
            // ConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 601);
            this.Controls.Add(this.getUserSeed);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Paynow);
            this.Controls.Add(this.txtIntomoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadressship);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyorderlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmOrder";
            this.Load += new System.EventHandler(this.ConfirmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyorderlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paynow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView buyorderlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtadressship;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIntomoney;
        private Bunifu.Framework.UI.BunifuImageButton Paynow;
        private Bunifu.Framework.UI.BunifuImageButton Cancel;
        private System.Windows.Forms.TextBox getUserSeed;
    }
}