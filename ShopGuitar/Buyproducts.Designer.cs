namespace ShopGuitar
{
    partial class Buyproducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buyproducts));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtRetail = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLeftqty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.addTocart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NamedProduct = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.selectedQty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.n7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.n1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.payNow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboType = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDel1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FastAddPID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntomoney = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.sumqty = new System.Windows.Forms.TextBox();
            this.preNameP = new System.Windows.Forms.TextBox();
            this.userSeed = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(633, 467);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "- STORE - Ace is the place with the helpful hardware man";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 39);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pname,
            this.Qty,
            this.Price,
            this.Total,
            this.Pid});
            this.dataGridView1.Location = new System.Drawing.Point(682, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 281);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
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
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(1246, 3);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(31, 22);
            this.txtpid.TabIndex = 3;
            // 
            // txtRetail
            // 
            this.txtRetail.Location = new System.Drawing.Point(1246, 61);
            this.txtRetail.Name = "txtRetail";
            this.txtRetail.Size = new System.Drawing.Size(31, 22);
            this.txtRetail.TabIndex = 4;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(1243, 33);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(34, 22);
            this.txtQty.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtLeftqty);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.addTocart);
            this.panel2.Controls.Add(this.NamedProduct);
            this.panel2.Controls.Add(this.selectedQty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.n7);
            this.panel2.Controls.Add(this.n6);
            this.panel2.Controls.Add(this.n8);
            this.panel2.Controls.Add(this.n5);
            this.panel2.Controls.Add(this.n9);
            this.panel2.Controls.Add(this.n4);
            this.panel2.Controls.Add(this.n3);
            this.panel2.Controls.Add(this.n2);
            this.panel2.Controls.Add(this.n1);
            this.panel2.Location = new System.Drawing.Point(682, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 192);
            this.panel2.TabIndex = 6;
            // 
            // txtLeftqty
            // 
            this.txtLeftqty.BorderColorFocused = System.Drawing.Color.Red;
            this.txtLeftqty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLeftqty.BorderColorMouseHover = System.Drawing.Color.Red;
            this.txtLeftqty.BorderThickness = 3;
            this.txtLeftqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLeftqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtLeftqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLeftqty.isPassword = false;
            this.txtLeftqty.Location = new System.Drawing.Point(343, 47);
            this.txtLeftqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeftqty.Name = "txtLeftqty";
            this.txtLeftqty.Size = new System.Drawing.Size(55, 44);
            this.txtLeftqty.TabIndex = 13;
            this.txtLeftqty.Text = "Left";
            this.txtLeftqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(343, 141);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(55, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(343, 92);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 45);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // addTocart
            // 
            this.addTocart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addTocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addTocart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTocart.BorderRadius = 0;
            this.addTocart.ButtonText = "Add To Cart";
            this.addTocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTocart.DisabledColor = System.Drawing.Color.Gray;
            this.addTocart.Iconcolor = System.Drawing.Color.Transparent;
            this.addTocart.Iconimage = ((System.Drawing.Image)(resources.GetObject("addTocart.Iconimage")));
            this.addTocart.Iconimage_right = null;
            this.addTocart.Iconimage_right_Selected = null;
            this.addTocart.Iconimage_Selected = null;
            this.addTocart.IconMarginLeft = 0;
            this.addTocart.IconMarginRight = 0;
            this.addTocart.IconRightVisible = true;
            this.addTocart.IconRightZoom = 0D;
            this.addTocart.IconVisible = true;
            this.addTocart.IconZoom = 85D;
            this.addTocart.IsTab = false;
            this.addTocart.Location = new System.Drawing.Point(205, 151);
            this.addTocart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTocart.Name = "addTocart";
            this.addTocart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addTocart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addTocart.OnHoverTextColor = System.Drawing.Color.White;
            this.addTocart.selected = false;
            this.addTocart.Size = new System.Drawing.Size(134, 35);
            this.addTocart.TabIndex = 10;
            this.addTocart.Text = "Add To Cart";
            this.addTocart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTocart.Textcolor = System.Drawing.Color.White;
            this.addTocart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTocart.Click += new System.EventHandler(this.AddTocart_Click);
            // 
            // NamedProduct
            // 
            this.NamedProduct.BorderColorFocused = System.Drawing.Color.Yellow;
            this.NamedProduct.BorderColorIdle = System.Drawing.Color.SpringGreen;
            this.NamedProduct.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.NamedProduct.BorderThickness = 3;
            this.NamedProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NamedProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamedProduct.isPassword = false;
            this.NamedProduct.Location = new System.Drawing.Point(202, 47);
            this.NamedProduct.Margin = new System.Windows.Forms.Padding(4);
            this.NamedProduct.Name = "NamedProduct";
            this.NamedProduct.Size = new System.Drawing.Size(134, 44);
            this.NamedProduct.TabIndex = 9;
            this.NamedProduct.Text = "Name Product";
            this.NamedProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // selectedQty
            // 
            this.selectedQty.BorderColorFocused = System.Drawing.Color.Magenta;
            this.selectedQty.BorderColorIdle = System.Drawing.Color.Aqua;
            this.selectedQty.BorderColorMouseHover = System.Drawing.Color.Magenta;
            this.selectedQty.BorderThickness = 3;
            this.selectedQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectedQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.selectedQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectedQty.isPassword = false;
            this.selectedQty.Location = new System.Drawing.Point(202, 99);
            this.selectedQty.Margin = new System.Windows.Forms.Padding(4);
            this.selectedQty.Name = "selectedQty";
            this.selectedQty.Size = new System.Drawing.Size(134, 44);
            this.selectedQty.TabIndex = 8;
            this.selectedQty.Text = "Qty.";
            this.selectedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.selectedQty.Enter += new System.EventHandler(this.SelectedQty_Enter);
            this.selectedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedQty_KeyPress);
            this.selectedQty.Leave += new System.EventHandler(this.SelectedQty_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(242, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Qty.";
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.MediumBlue;
            this.n7.color = System.Drawing.Color.MediumBlue;
            this.n7.colorActive = System.Drawing.Color.RoyalBlue;
            this.n7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n7.ForeColor = System.Drawing.Color.White;
            this.n7.Image = null;
            this.n7.ImagePosition = 20;
            this.n7.ImageZoom = 50;
            this.n7.LabelPosition = 41;
            this.n7.LabelText = "7";
            this.n7.Location = new System.Drawing.Point(6, 133);
            this.n7.Margin = new System.Windows.Forms.Padding(6);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(56, 53);
            this.n7.TabIndex = 6;
            this.n7.Click += new System.EventHandler(this.N7_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n6.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n6.colorActive = System.Drawing.Color.Yellow;
            this.n6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n6.ForeColor = System.Drawing.Color.White;
            this.n6.Image = null;
            this.n6.ImagePosition = 20;
            this.n6.ImageZoom = 50;
            this.n6.LabelPosition = 41;
            this.n6.LabelText = "6";
            this.n6.Location = new System.Drawing.Point(142, 71);
            this.n6.Margin = new System.Windows.Forms.Padding(6);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(56, 53);
            this.n6.TabIndex = 5;
            this.n6.Click += new System.EventHandler(this.N6_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.Pink;
            this.n8.color = System.Drawing.Color.Pink;
            this.n8.colorActive = System.Drawing.Color.PaleVioletRed;
            this.n8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n8.ForeColor = System.Drawing.Color.White;
            this.n8.Image = ((System.Drawing.Image)(resources.GetObject("n8.Image")));
            this.n8.ImagePosition = 20;
            this.n8.ImageZoom = 50;
            this.n8.LabelPosition = 41;
            this.n8.LabelText = "8";
            this.n8.Location = new System.Drawing.Point(74, 133);
            this.n8.Margin = new System.Windows.Forms.Padding(6);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(56, 53);
            this.n8.TabIndex = 4;
            this.n8.Click += new System.EventHandler(this.N8_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.Aqua;
            this.n5.color = System.Drawing.Color.Aqua;
            this.n5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.n5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n5.ForeColor = System.Drawing.Color.White;
            this.n5.Image = null;
            this.n5.ImagePosition = 20;
            this.n5.ImageZoom = 50;
            this.n5.LabelPosition = 41;
            this.n5.LabelText = "5";
            this.n5.Location = new System.Drawing.Point(74, 71);
            this.n5.Margin = new System.Windows.Forms.Padding(6);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(56, 53);
            this.n5.TabIndex = 4;
            this.n5.Click += new System.EventHandler(this.N5_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.n9.color = System.Drawing.Color.DarkGoldenrod;
            this.n9.colorActive = System.Drawing.Color.Goldenrod;
            this.n9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n9.ForeColor = System.Drawing.Color.White;
            this.n9.Image = ((System.Drawing.Image)(resources.GetObject("n9.Image")));
            this.n9.ImagePosition = 20;
            this.n9.ImageZoom = 50;
            this.n9.LabelPosition = 41;
            this.n9.LabelText = "9";
            this.n9.Location = new System.Drawing.Point(142, 133);
            this.n9.Margin = new System.Windows.Forms.Padding(6);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(56, 53);
            this.n9.TabIndex = 4;
            this.n9.Click += new System.EventHandler(this.N9_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n4.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.n4.colorActive = System.Drawing.Color.GreenYellow;
            this.n4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n4.ForeColor = System.Drawing.Color.White;
            this.n4.Image = null;
            this.n4.ImagePosition = 20;
            this.n4.ImageZoom = 50;
            this.n4.LabelPosition = 41;
            this.n4.LabelText = "4";
            this.n4.Location = new System.Drawing.Point(6, 71);
            this.n4.Margin = new System.Windows.Forms.Padding(6);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(56, 53);
            this.n4.TabIndex = 3;
            this.n4.Click += new System.EventHandler(this.N4_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.n3.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.n3.colorActive = System.Drawing.Color.Magenta;
            this.n3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n3.ForeColor = System.Drawing.Color.White;
            this.n3.Image = null;
            this.n3.ImagePosition = 20;
            this.n3.ImageZoom = 50;
            this.n3.LabelPosition = 41;
            this.n3.LabelText = "3";
            this.n3.Location = new System.Drawing.Point(142, 6);
            this.n3.Margin = new System.Windows.Forms.Padding(6);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(56, 53);
            this.n3.TabIndex = 2;
            this.n3.Click += new System.EventHandler(this.N3_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.n2.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.n2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.n2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n2.ForeColor = System.Drawing.Color.White;
            this.n2.Image = null;
            this.n2.ImagePosition = 20;
            this.n2.ImageZoom = 50;
            this.n2.LabelPosition = 41;
            this.n2.LabelText = "2";
            this.n2.Location = new System.Drawing.Point(74, 6);
            this.n2.Margin = new System.Windows.Forms.Padding(6);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(56, 53);
            this.n2.TabIndex = 1;
            this.n2.Click += new System.EventHandler(this.N2_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.Brown;
            this.n1.color = System.Drawing.Color.Brown;
            this.n1.colorActive = System.Drawing.Color.Red;
            this.n1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.n1.ForeColor = System.Drawing.Color.White;
            this.n1.Image = null;
            this.n1.ImagePosition = 20;
            this.n1.ImageZoom = 50;
            this.n1.LabelPosition = 41;
            this.n1.LabelText = "1";
            this.n1.Location = new System.Drawing.Point(6, 6);
            this.n1.Margin = new System.Windows.Forms.Padding(6);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(56, 53);
            this.n1.TabIndex = 0;
            this.n1.Click += new System.EventHandler(this.N1_Click_1);
            // 
            // payNow
            // 
            this.payNow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.payNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.payNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payNow.BorderRadius = 0;
            this.payNow.ButtonText = "Pay Now";
            this.payNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payNow.DisabledColor = System.Drawing.Color.Gray;
            this.payNow.Iconcolor = System.Drawing.Color.Transparent;
            this.payNow.Iconimage = ((System.Drawing.Image)(resources.GetObject("payNow.Iconimage")));
            this.payNow.Iconimage_right = null;
            this.payNow.Iconimage_right_Selected = null;
            this.payNow.Iconimage_Selected = null;
            this.payNow.IconMarginLeft = 0;
            this.payNow.IconMarginRight = 0;
            this.payNow.IconRightVisible = true;
            this.payNow.IconRightZoom = 0D;
            this.payNow.IconVisible = true;
            this.payNow.IconZoom = 90D;
            this.payNow.IsTab = false;
            this.payNow.Location = new System.Drawing.Point(1088, 362);
            this.payNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payNow.Name = "payNow";
            this.payNow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.payNow.OnHovercolor = System.Drawing.Color.Red;
            this.payNow.OnHoverTextColor = System.Drawing.Color.White;
            this.payNow.selected = false;
            this.payNow.Size = new System.Drawing.Size(152, 59);
            this.payNow.TabIndex = 7;
            this.payNow.Text = "Pay Now";
            this.payNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payNow.Textcolor = System.Drawing.Color.White;
            this.payNow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payNow.Click += new System.EventHandler(this.PayNow_Click);
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.Transparent;
            this.comboType.BaseColor = System.Drawing.Color.White;
            this.comboType.BorderColor = System.Drawing.Color.Black;
            this.comboType.BorderSize = 3;
            this.comboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FocusedColor = System.Drawing.Color.Empty;
            this.comboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboType.ForeColor = System.Drawing.Color.Black;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Select Category"});
            this.comboType.Location = new System.Drawing.Point(43, 50);
            this.comboType.Name = "comboType";
            this.comboType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboType.Size = new System.Drawing.Size(231, 31);
            this.comboType.TabIndex = 8;
            this.comboType.TextChanged += new System.EventHandler(this.ComboType_TextChanged);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Remove All Items";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1087, 495);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(153, 59);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "Remove All Items";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel1.BorderRadius = 0;
            this.btnDel1.ButtonText = "Remove 1 Item";
            this.btnDel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel1.DisabledColor = System.Drawing.Color.Gray;
            this.btnDel1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDel1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDel1.Iconimage")));
            this.btnDel1.Iconimage_right = null;
            this.btnDel1.Iconimage_right_Selected = null;
            this.btnDel1.Iconimage_Selected = null;
            this.btnDel1.IconMarginLeft = 0;
            this.btnDel1.IconMarginRight = 0;
            this.btnDel1.IconRightVisible = true;
            this.btnDel1.IconRightZoom = 0D;
            this.btnDel1.IconVisible = true;
            this.btnDel1.IconZoom = 90D;
            this.btnDel1.IsTab = false;
            this.btnDel1.Location = new System.Drawing.Point(1088, 433);
            this.btnDel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDel1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDel1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDel1.selected = false;
            this.btnDel1.Size = new System.Drawing.Size(152, 59);
            this.btnDel1.TabIndex = 11;
            this.btnDel1.Text = "Remove 1 Item";
            this.btnDel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel1.Textcolor = System.Drawing.Color.White;
            this.btnDel1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel1.Click += new System.EventHandler(this.BtnDel1_Click);
            // 
            // FastAddPID
            // 
            this.FastAddPID.BorderColorFocused = System.Drawing.Color.DarkSlateBlue;
            this.FastAddPID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FastAddPID.BorderColorMouseHover = System.Drawing.Color.DarkSlateBlue;
            this.FastAddPID.BorderThickness = 3;
            this.FastAddPID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastAddPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FastAddPID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FastAddPID.isPassword = false;
            this.FastAddPID.Location = new System.Drawing.Point(517, 47);
            this.FastAddPID.Margin = new System.Windows.Forms.Padding(4);
            this.FastAddPID.Name = "FastAddPID";
            this.FastAddPID.Size = new System.Drawing.Size(130, 33);
            this.FastAddPID.TabIndex = 12;
            this.FastAddPID.Text = "Product ID";
            this.FastAddPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FastAddPID.Enter += new System.EventHandler(this.FastAddPID_Enter);
            this.FastAddPID.Leave += new System.EventHandler(this.FastAddPID_Leave);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.BlueViolet;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(641, 45);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(35, 37);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 13;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1000, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Into Money: ";
            // 
            // txtIntomoney
            // 
            this.txtIntomoney.BackColor = System.Drawing.Color.White;
            this.txtIntomoney.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIntomoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntomoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntomoney.Location = new System.Drawing.Point(1119, 334);
            this.txtIntomoney.Name = "txtIntomoney";
            this.txtIntomoney.Size = new System.Drawing.Size(119, 23);
            this.txtIntomoney.TabIndex = 14;
            // 
            // sumqty
            // 
            this.sumqty.Location = new System.Drawing.Point(683, 334);
            this.sumqty.Name = "sumqty";
            this.sumqty.Size = new System.Drawing.Size(100, 22);
            this.sumqty.TabIndex = 16;
            // 
            // preNameP
            // 
            this.preNameP.Location = new System.Drawing.Point(789, 334);
            this.preNameP.Name = "preNameP";
            this.preNameP.Size = new System.Drawing.Size(100, 22);
            this.preNameP.TabIndex = 17;
            this.preNameP.TextChanged += new System.EventHandler(this.PreNameP_TextChanged);
            // 
            // userSeed
            // 
            this.userSeed.Location = new System.Drawing.Point(1246, 89);
            this.userSeed.Name = "userSeed";
            this.userSeed.Size = new System.Drawing.Size(34, 22);
            this.userSeed.TabIndex = 18;
            // 
            // Buyproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.userSeed);
            this.Controls.Add(this.preNameP);
            this.Controls.Add(this.sumqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIntomoney);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.FastAddPID);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.payNow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtRetail);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Buyproducts";
            this.Size = new System.Drawing.Size(1280, 566);
            this.Load += new System.EventHandler(this.Buyproducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtRetail;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton n7;
        private Bunifu.Framework.UI.BunifuTileButton n6;
        private Bunifu.Framework.UI.BunifuTileButton n8;
        private Bunifu.Framework.UI.BunifuTileButton n5;
        private Bunifu.Framework.UI.BunifuTileButton n9;
        private Bunifu.Framework.UI.BunifuTileButton n4;
        private Bunifu.Framework.UI.BunifuTileButton n3;
        private Bunifu.Framework.UI.BunifuTileButton n2;
        private Bunifu.Framework.UI.BunifuTileButton n1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox NamedProduct;
        private Bunifu.Framework.UI.BunifuMetroTextbox selectedQty;
        private Bunifu.Framework.UI.BunifuFlatButton addTocart;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton payNow;
        private Guna.UI.WinForms.GunaComboBox comboType;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox FastAddPID;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIntomoney;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLeftqty;
        private System.Windows.Forms.TextBox sumqty;
        private System.Windows.Forms.TextBox preNameP;
        private System.Windows.Forms.TextBox userSeed;
    }
}
