namespace ShopGuitar
{
    partial class Mcustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCus = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSearchVal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCphone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCaddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPoints = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.boxSex = new Guna.UI.WinForms.GunaComboBox();
            this.resultstaffid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Customer Management - Close customers";
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
            // dgvCus
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCus.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCus.DoubleBuffered = true;
            this.dgvCus.EnableHeadersVisualStyles = false;
            this.dgvCus.HeaderBgColor = System.Drawing.Color.Yellow;
            this.dgvCus.HeaderForeColor = System.Drawing.Color.Yellow;
            this.dgvCus.Location = new System.Drawing.Point(43, 49);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCus.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCus.RowHeadersWidth = 51;
            this.dgvCus.RowTemplate.Height = 24;
            this.dgvCus.Size = new System.Drawing.Size(824, 513);
            this.dgvCus.TabIndex = 2;
            this.dgvCus.DoubleClick += new System.EventHandler(this.DgvCus_DoubleClick);
            // 
            // txtSearchVal
            // 
            this.txtSearchVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearchVal.ForeColor = System.Drawing.Color.Black;
            this.txtSearchVal.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchVal.HintText = "Write your text here...";
            this.txtSearchVal.isPassword = false;
            this.txtSearchVal.LineFocusedColor = System.Drawing.Color.Magenta;
            this.txtSearchVal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchVal.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtSearchVal.LineThickness = 3;
            this.txtSearchVal.Location = new System.Drawing.Point(874, 51);
            this.txtSearchVal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchVal.Name = "txtSearchVal";
            this.txtSearchVal.Size = new System.Drawing.Size(366, 46);
            this.txtSearchVal.TabIndex = 3;
            this.txtSearchVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchVal.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox1_OnValueChanged);
            this.txtSearchVal.Enter += new System.EventHandler(this.TxtSearchVal_Enter);
            this.txtSearchVal.Leave += new System.EventHandler(this.TxtSearchVal_Leave);
            // 
            // txtcid
            // 
            this.txtcid.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtcid.BorderThickness = 3;
            this.txtcid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtcid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcid.isPassword = false;
            this.txtcid.Location = new System.Drawing.Point(874, 136);
            this.txtcid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(366, 44);
            this.txtcid.TabIndex = 4;
            this.txtcid.Text = "Cusomer ID";
            this.txtcid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcid.Enter += new System.EventHandler(this.Txtcid_Enter);
            this.txtcid.Leave += new System.EventHandler(this.Txtcid_Leave);
            // 
            // txtCname
            // 
            this.txtCname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCname.BorderThickness = 3;
            this.txtCname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCname.isPassword = false;
            this.txtCname.Location = new System.Drawing.Point(874, 188);
            this.txtCname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(366, 44);
            this.txtCname.TabIndex = 5;
            this.txtCname.Text = "Customer Name";
            this.txtCname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCname.Enter += new System.EventHandler(this.TxtCname_Enter);
            this.txtCname.Leave += new System.EventHandler(this.TxtCname_Leave);
            // 
            // txtCphone
            // 
            this.txtCphone.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCphone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCphone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCphone.BorderThickness = 3;
            this.txtCphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCphone.isPassword = false;
            this.txtCphone.Location = new System.Drawing.Point(874, 293);
            this.txtCphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCphone.Name = "txtCphone";
            this.txtCphone.Size = new System.Drawing.Size(366, 44);
            this.txtCphone.TabIndex = 6;
            this.txtCphone.Text = "Customer Phone";
            this.txtCphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCphone.Enter += new System.EventHandler(this.TxtCphone_Enter);
            this.txtCphone.Leave += new System.EventHandler(this.TxtCphone_Leave);
            // 
            // txtCaddress
            // 
            this.txtCaddress.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCaddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaddress.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCaddress.BorderThickness = 3;
            this.txtCaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaddress.isPassword = false;
            this.txtCaddress.Location = new System.Drawing.Point(874, 345);
            this.txtCaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaddress.Name = "txtCaddress";
            this.txtCaddress.Size = new System.Drawing.Size(366, 44);
            this.txtCaddress.TabIndex = 7;
            this.txtCaddress.Text = "Customer Address";
            this.txtCaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCaddress.Enter += new System.EventHandler(this.TxtCaddress_Enter);
            this.txtCaddress.Leave += new System.EventHandler(this.TxtCaddress_Leave);
            // 
            // txtPoints
            // 
            this.txtPoints.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPoints.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPoints.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPoints.BorderThickness = 3;
            this.txtPoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPoints.isPassword = false;
            this.txtPoints.Location = new System.Drawing.Point(874, 397);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(366, 44);
            this.txtPoints.TabIndex = 8;
            this.txtPoints.Text = "Points";
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoints.Enter += new System.EventHandler(this.TxtPoints_Enter);
            this.txtPoints.Leave += new System.EventHandler(this.TxtPoints_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(874, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 100);
            this.panel2.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClear.BackColor = System.Drawing.Color.Gray;
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
            this.btnClear.Location = new System.Drawing.Point(247, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.Gray;
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(116, 92);
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
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.btnDelete.Location = new System.Drawing.Point(126, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.Aqua;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(116, 92);
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
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
            this.btnUpdate.Location = new System.Drawing.Point(5, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(116, 92);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // boxSex
            // 
            this.boxSex.BackColor = System.Drawing.Color.Transparent;
            this.boxSex.BaseColor = System.Drawing.Color.White;
            this.boxSex.BorderColor = System.Drawing.Color.Black;
            this.boxSex.BorderSize = 3;
            this.boxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSex.FocusedColor = System.Drawing.Color.Empty;
            this.boxSex.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSex.ForeColor = System.Drawing.Color.Black;
            this.boxSex.FormattingEnabled = true;
            this.boxSex.Items.AddRange(new object[] {
            "Sex",
            "Nam",
            "Nữ"});
            this.boxSex.Location = new System.Drawing.Point(874, 244);
            this.boxSex.Name = "boxSex";
            this.boxSex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.boxSex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.boxSex.Size = new System.Drawing.Size(366, 39);
            this.boxSex.TabIndex = 11;
            // 
            // resultstaffid
            // 
            this.resultstaffid.Location = new System.Drawing.Point(0, 3);
            this.resultstaffid.Name = "resultstaffid";
            this.resultstaffid.Size = new System.Drawing.Size(10, 22);
            this.resultstaffid.TabIndex = 12;
            // 
            // Mcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultstaffid);
            this.Controls.Add(this.boxSex);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtCaddress);
            this.Controls.Add(this.txtCphone);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.txtSearchVal);
            this.Controls.Add(this.dgvCus);
            this.Controls.Add(this.panel1);
            this.Name = "Mcustomers";
            this.Size = new System.Drawing.Size(1280, 566);
            this.Load += new System.EventHandler(this.Mcustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchVal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcid;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCphone;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCaddress;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPoints;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Guna.UI.WinForms.GunaComboBox boxSex;
        private System.Windows.Forms.TextBox resultstaffid;
    }
}
