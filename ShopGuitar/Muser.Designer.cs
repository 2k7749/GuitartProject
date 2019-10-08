namespace ShopGuitar
{
    partial class Muser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.mid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.mUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.mPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.mPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.mAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.upPic = new Bunifu.Framework.UI.BunifuImageButton();
            this.resultstaffid = new System.Windows.Forms.TextBox();
            this.resultusername = new System.Windows.Forms.TextBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.levelCombo = new Guna.UI.WinForms.GunaComboBox();
            this.sexCombo = new Guna.UI.WinForms.GunaComboBox();
            this.mStaffname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 39);
            this.panel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "- User Management - Complete information before executing command";
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.DoubleBuffered = true;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.HeaderBgColor = System.Drawing.Color.Crimson;
            this.dgvUsers.HeaderForeColor = System.Drawing.Color.Crimson;
            this.dgvUsers.Location = new System.Drawing.Point(43, 254);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1197, 305);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.DoubleClick += new System.EventHandler(this.DgvUsers_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Location = new System.Drawing.Point(867, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 197);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "-Function Box-";
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(7, 155);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.Black;
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(98, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(7, 111);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Black;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(98, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(7, 48);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.Black;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.Fuchsia;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.Black;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "Insert";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsert.Iconimage = null;
            this.btnInsert.Iconimage_right = null;
            this.btnInsert.Iconimage_right_Selected = null;
            this.btnInsert.Iconimage_Selected = null;
            this.btnInsert.IconMarginLeft = 0;
            this.btnInsert.IconMarginRight = 0;
            this.btnInsert.IconRightVisible = true;
            this.btnInsert.IconRightZoom = 0D;
            this.btnInsert.IconVisible = true;
            this.btnInsert.IconZoom = 90D;
            this.btnInsert.IsTab = false;
            this.btnInsert.Location = new System.Drawing.Point(7, 4);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.Black;
            this.btnInsert.OnHovercolor = System.Drawing.Color.Lime;
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(98, 38);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(305, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(471, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 162);
            this.panel8.TabIndex = 26;
            // 
            // mid
            // 
            this.mid.BorderColorFocused = System.Drawing.Color.Crimson;
            this.mid.BorderColorIdle = System.Drawing.Color.Black;
            this.mid.BorderColorMouseHover = System.Drawing.Color.Crimson;
            this.mid.BorderThickness = 3;
            this.mid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mid.isPassword = false;
            this.mid.Location = new System.Drawing.Point(485, 51);
            this.mid.Margin = new System.Windows.Forms.Padding(4);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(177, 44);
            this.mid.TabIndex = 28;
            this.mid.Text = "Staff ID";
            this.mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mid.OnValueChanged += new System.EventHandler(this.Mid_OnValueChanged);
            this.mid.Enter += new System.EventHandler(this.Mid_Enter);
            this.mid.Leave += new System.EventHandler(this.Mid_Leave);
            // 
            // mUsername
            // 
            this.mUsername.BorderColorFocused = System.Drawing.Color.Crimson;
            this.mUsername.BorderColorIdle = System.Drawing.Color.Black;
            this.mUsername.BorderColorMouseHover = System.Drawing.Color.Crimson;
            this.mUsername.BorderThickness = 3;
            this.mUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mUsername.isPassword = false;
            this.mUsername.Location = new System.Drawing.Point(485, 101);
            this.mUsername.Margin = new System.Windows.Forms.Padding(4);
            this.mUsername.Name = "mUsername";
            this.mUsername.Size = new System.Drawing.Size(177, 44);
            this.mUsername.TabIndex = 29;
            this.mUsername.Text = "Username";
            this.mUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mUsername.Enter += new System.EventHandler(this.MUsername_Enter);
            this.mUsername.Leave += new System.EventHandler(this.MUsername_Leave);
            // 
            // mPassword
            // 
            this.mPassword.BorderColorFocused = System.Drawing.Color.Crimson;
            this.mPassword.BorderColorIdle = System.Drawing.Color.Black;
            this.mPassword.BorderColorMouseHover = System.Drawing.Color.Crimson;
            this.mPassword.BorderThickness = 3;
            this.mPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mPassword.isPassword = false;
            this.mPassword.Location = new System.Drawing.Point(485, 153);
            this.mPassword.Margin = new System.Windows.Forms.Padding(4);
            this.mPassword.Name = "mPassword";
            this.mPassword.Size = new System.Drawing.Size(177, 44);
            this.mPassword.TabIndex = 30;
            this.mPassword.Text = "Password";
            this.mPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mPassword.Enter += new System.EventHandler(this.MPassword_Enter);
            this.mPassword.Leave += new System.EventHandler(this.MPassword_Leave);
            // 
            // mPhone
            // 
            this.mPhone.BorderColorFocused = System.Drawing.Color.Crimson;
            this.mPhone.BorderColorIdle = System.Drawing.Color.Black;
            this.mPhone.BorderColorMouseHover = System.Drawing.Color.Crimson;
            this.mPhone.BorderThickness = 3;
            this.mPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mPhone.isPassword = false;
            this.mPhone.Location = new System.Drawing.Point(672, 101);
            this.mPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mPhone.Name = "mPhone";
            this.mPhone.Size = new System.Drawing.Size(177, 44);
            this.mPhone.TabIndex = 31;
            this.mPhone.Text = "Staff Phone";
            this.mPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mPhone.Enter += new System.EventHandler(this.MPhone_Enter);
            this.mPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MPhone_KeyPress);
            this.mPhone.Leave += new System.EventHandler(this.MPhone_Leave);
            // 
            // mAddress
            // 
            this.mAddress.BorderColorFocused = System.Drawing.Color.Crimson;
            this.mAddress.BorderColorIdle = System.Drawing.Color.Black;
            this.mAddress.BorderColorMouseHover = System.Drawing.Color.Crimson;
            this.mAddress.BorderThickness = 3;
            this.mAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mAddress.isPassword = false;
            this.mAddress.Location = new System.Drawing.Point(672, 153);
            this.mAddress.Margin = new System.Windows.Forms.Padding(4);
            this.mAddress.Name = "mAddress";
            this.mAddress.Size = new System.Drawing.Size(177, 44);
            this.mAddress.TabIndex = 31;
            this.mAddress.Text = "Address";
            this.mAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mAddress.Enter += new System.EventHandler(this.MAddress_Enter);
            this.mAddress.Leave += new System.EventHandler(this.MAddress_Leave);
            // 
            // upPic
            // 
            this.upPic.BackColor = System.Drawing.Color.Transparent;
            this.upPic.Image = ((System.Drawing.Image)(resources.GetObject("upPic.Image")));
            this.upPic.ImageActive = null;
            this.upPic.Location = new System.Drawing.Point(406, 194);
            this.upPic.Name = "upPic";
            this.upPic.Size = new System.Drawing.Size(55, 45);
            this.upPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upPic.TabIndex = 32;
            this.upPic.TabStop = false;
            this.upPic.Zoom = 10;
            this.upPic.Click += new System.EventHandler(this.UpPic_Click);
            // 
            // resultstaffid
            // 
            this.resultstaffid.Location = new System.Drawing.Point(0, 3);
            this.resultstaffid.Name = "resultstaffid";
            this.resultstaffid.Size = new System.Drawing.Size(10, 22);
            this.resultstaffid.TabIndex = 33;
            // 
            // resultusername
            // 
            this.resultusername.Location = new System.Drawing.Point(16, 3);
            this.resultusername.Name = "resultusername";
            this.resultusername.Size = new System.Drawing.Size(10, 22);
            this.resultusername.TabIndex = 34;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Silver;
            this.txtSearch.HintText = "Write your text here";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.MediumSpringGreen;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Black;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.MediumSpringGreen;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(1003, 207);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 41);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.TxtSearch_OnValueChanged);
            this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Red;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(612, 45);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(45, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 36;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // levelCombo
            // 
            this.levelCombo.BackColor = System.Drawing.Color.Transparent;
            this.levelCombo.BaseColor = System.Drawing.Color.White;
            this.levelCombo.BorderColor = System.Drawing.Color.Black;
            this.levelCombo.BorderSize = 3;
            this.levelCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.levelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelCombo.FocusedColor = System.Drawing.Color.Empty;
            this.levelCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelCombo.ForeColor = System.Drawing.Color.Black;
            this.levelCombo.FormattingEnabled = true;
            this.levelCombo.Items.AddRange(new object[] {
            "Level",
            "Customer",
            "Staff",
            "Collaborator",
            "Warehouse Checker",
            "Admin"});
            this.levelCombo.Location = new System.Drawing.Point(672, 207);
            this.levelCombo.Name = "levelCombo";
            this.levelCombo.OnHoverItemBaseColor = System.Drawing.Color.Blue;
            this.levelCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.levelCombo.Size = new System.Drawing.Size(177, 35);
            this.levelCombo.TabIndex = 37;
            // 
            // sexCombo
            // 
            this.sexCombo.BackColor = System.Drawing.Color.Transparent;
            this.sexCombo.BaseColor = System.Drawing.Color.White;
            this.sexCombo.BorderColor = System.Drawing.Color.Black;
            this.sexCombo.BorderSize = 3;
            this.sexCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sexCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCombo.FocusedColor = System.Drawing.Color.Empty;
            this.sexCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexCombo.ForeColor = System.Drawing.Color.Black;
            this.sexCombo.FormattingEnabled = true;
            this.sexCombo.Items.AddRange(new object[] {
            "Sex",
            "Nam",
            "Nữ"});
            this.sexCombo.Location = new System.Drawing.Point(672, 59);
            this.sexCombo.Name = "sexCombo";
            this.sexCombo.OnHoverItemBaseColor = System.Drawing.Color.Blue;
            this.sexCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sexCombo.Size = new System.Drawing.Size(177, 35);
            this.sexCombo.TabIndex = 39;
            // 
            // mStaffname
            // 
            this.mStaffname.BorderColorFocused = System.Drawing.Color.Crimson;
            this.mStaffname.BorderColorIdle = System.Drawing.Color.Black;
            this.mStaffname.BorderColorMouseHover = System.Drawing.Color.Crimson;
            this.mStaffname.BorderThickness = 3;
            this.mStaffname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mStaffname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mStaffname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mStaffname.isPassword = false;
            this.mStaffname.Location = new System.Drawing.Point(485, 205);
            this.mStaffname.Margin = new System.Windows.Forms.Padding(4);
            this.mStaffname.Name = "mStaffname";
            this.mStaffname.Size = new System.Drawing.Size(177, 44);
            this.mStaffname.TabIndex = 40;
            this.mStaffname.Text = "Staff Name";
            this.mStaffname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mStaffname.Enter += new System.EventHandler(this.MStaffname_Enter);
            this.mStaffname.Leave += new System.EventHandler(this.MStaffname_Leave);
            // 
            // Muser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mStaffname);
            this.Controls.Add(this.sexCombo);
            this.Controls.Add(this.levelCombo);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.resultusername);
            this.Controls.Add(this.resultstaffid);
            this.Controls.Add(this.upPic);
            this.Controls.Add(this.mAddress);
            this.Controls.Add(this.mPhone);
            this.Controls.Add(this.mPassword);
            this.Controls.Add(this.mUsername);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel1);
            this.Name = "Muser";
            this.Size = new System.Drawing.Size(1280, 566);
            this.Load += new System.EventHandler(this.Muser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuMetroTextbox mid;
        private Bunifu.Framework.UI.BunifuMetroTextbox mUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox mPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox mPhone;
        private Bunifu.Framework.UI.BunifuMetroTextbox mAddress;
        private Bunifu.Framework.UI.BunifuImageButton upPic;
        private System.Windows.Forms.TextBox resultstaffid;
        private System.Windows.Forms.TextBox resultusername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Guna.UI.WinForms.GunaComboBox levelCombo;
        private Guna.UI.WinForms.GunaComboBox sexCombo;
        private Bunifu.Framework.UI.BunifuMetroTextbox mStaffname;
    }
}
