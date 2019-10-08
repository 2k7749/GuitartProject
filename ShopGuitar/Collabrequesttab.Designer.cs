namespace ShopGuitar
{
    partial class Collabrequesttab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collabrequesttab));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCollab = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cIntro = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.cMail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollab)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Collaborators - Request";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 39);
            this.panel1.TabIndex = 2;
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
            // dgvCollab
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCollab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCollab.BackgroundColor = System.Drawing.Color.White;
            this.dgvCollab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCollab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCollab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCollab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollab.DoubleBuffered = true;
            this.dgvCollab.EnableHeadersVisualStyles = false;
            this.dgvCollab.HeaderBgColor = System.Drawing.Color.PaleVioletRed;
            this.dgvCollab.HeaderForeColor = System.Drawing.Color.PaleVioletRed;
            this.dgvCollab.Location = new System.Drawing.Point(614, 102);
            this.dgvCollab.Name = "dgvCollab";
            this.dgvCollab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCollab.RowHeadersWidth = 51;
            this.dgvCollab.RowTemplate.Height = 24;
            this.dgvCollab.Size = new System.Drawing.Size(626, 461);
            this.dgvCollab.TabIndex = 3;
            this.dgvCollab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCollab_CellContentClick);
            this.dgvCollab.DoubleClick += new System.EventHandler(this.DgvCollab_DoubleClick);
            // 
            // cName
            // 
            this.cName.BorderColorFocused = System.Drawing.Color.DarkViolet;
            this.cName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cName.BorderColorMouseHover = System.Drawing.Color.DarkViolet;
            this.cName.BorderThickness = 3;
            this.cName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cName.Enabled = false;
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cName.isPassword = false;
            this.cName.Location = new System.Drawing.Point(43, 55);
            this.cName.Margin = new System.Windows.Forms.Padding(4);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(257, 44);
            this.cName.TabIndex = 4;
            this.cName.Text = "Collab Name";
            this.cName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cPhone
            // 
            this.cPhone.BorderColorFocused = System.Drawing.Color.DarkViolet;
            this.cPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPhone.BorderColorMouseHover = System.Drawing.Color.DarkViolet;
            this.cPhone.BorderThickness = 3;
            this.cPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cPhone.Enabled = false;
            this.cPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cPhone.isPassword = false;
            this.cPhone.Location = new System.Drawing.Point(43, 107);
            this.cPhone.Margin = new System.Windows.Forms.Padding(4);
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(183, 44);
            this.cPhone.TabIndex = 5;
            this.cPhone.Text = "Collab Phone";
            this.cPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cAddress
            // 
            this.cAddress.BorderColorFocused = System.Drawing.Color.DarkViolet;
            this.cAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cAddress.BorderColorMouseHover = System.Drawing.Color.DarkViolet;
            this.cAddress.BorderThickness = 3;
            this.cAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cAddress.Enabled = false;
            this.cAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cAddress.isPassword = false;
            this.cAddress.Location = new System.Drawing.Point(43, 159);
            this.cAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(428, 44);
            this.cAddress.TabIndex = 6;
            this.cAddress.Text = "Collab Address";
            this.cAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cIntro
            // 
            this.cIntro.BorderColor = System.Drawing.Color.Black;
            this.cIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cIntro.Location = new System.Drawing.Point(43, 262);
            this.cIntro.Multiline = true;
            this.cIntro.Name = "cIntro";
            this.cIntro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cIntro.Size = new System.Drawing.Size(549, 120);
            this.cIntro.TabIndex = 9;
            // 
            // cMail
            // 
            this.cMail.BorderColorFocused = System.Drawing.Color.DarkViolet;
            this.cMail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cMail.BorderColorMouseHover = System.Drawing.Color.DarkViolet;
            this.cMail.BorderThickness = 3;
            this.cMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cMail.Enabled = false;
            this.cMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cMail.isPassword = false;
            this.cMail.Location = new System.Drawing.Point(43, 211);
            this.cMail.Margin = new System.Windows.Forms.Padding(4);
            this.cMail.Name = "cMail";
            this.cMail.Size = new System.Drawing.Size(229, 44);
            this.cMail.TabIndex = 10;
            this.cMail.Text = "Collab Gmail";
            this.cMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.color = System.Drawing.Color.Black;
            this.btnDelete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = 20;
            this.btnDelete.ImageZoom = 45;
            this.btnDelete.LabelPosition = 41;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(472, 391);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 112);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.color = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.colorActive = System.Drawing.Color.Crimson;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImagePosition = 20;
            this.btnConfirm.ImageZoom = 45;
            this.btnConfirm.LabelPosition = 41;
            this.btnConfirm.LabelText = "Confirm";
            this.btnConfirm.Location = new System.Drawing.Point(335, 391);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 112);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(614, 51);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(264, 44);
            this.bunifuTextbox1.TabIndex = 15;
            this.bunifuTextbox1.text = "Search";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.BunifuTextbox1_OnTextChange);
            this.bunifuTextbox1.Enter += new System.EventHandler(this.BunifuTextbox1_Enter);
            this.bunifuTextbox1.Leave += new System.EventHandler(this.BunifuTextbox1_Leave);
            // 
            // Collabrequesttab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cMail);
            this.Controls.Add(this.cIntro);
            this.Controls.Add(this.cAddress);
            this.Controls.Add(this.cPhone);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.dgvCollab);
            this.Controls.Add(this.panel1);
            this.Name = "Collabrequesttab";
            this.Size = new System.Drawing.Size(1280, 566);
            this.Load += new System.EventHandler(this.Collabrequesttab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCollab;
        private Bunifu.Framework.UI.BunifuMetroTextbox cName;
        private Bunifu.Framework.UI.BunifuMetroTextbox cPhone;
        private Bunifu.Framework.UI.BunifuMetroTextbox cAddress;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox cIntro;
        private Bunifu.Framework.UI.BunifuMetroTextbox cMail;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuTileButton btnConfirm;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
