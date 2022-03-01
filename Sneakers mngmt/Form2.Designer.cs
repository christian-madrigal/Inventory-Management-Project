namespace Sneakers_mngmt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.invenGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lbliSize = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbliSku = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtShoeName = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSubNew = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdSel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.invenGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // invenGrid
            // 
            this.invenGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invenGrid.Location = new System.Drawing.Point(169, 0);
            this.invenGrid.Name = "invenGrid";
            this.invenGrid.Size = new System.Drawing.Size(704, 161);
            this.invenGrid.TabIndex = 0;
            this.invenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invenGrid_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(902, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // grpInventory
            // 
            this.grpInventory.BackColor = System.Drawing.Color.Transparent;
            this.grpInventory.Controls.Add(this.picBox);
            this.grpInventory.Controls.Add(this.cmbSize);
            this.grpInventory.Controls.Add(this.txtSku);
            this.grpInventory.Controls.Add(this.txtPrice);
            this.grpInventory.Controls.Add(this.txtQty);
            this.grpInventory.Controls.Add(this.txtColor);
            this.grpInventory.Controls.Add(this.txtShoeName);
            this.grpInventory.Controls.Add(this.txtID);
            this.grpInventory.Controls.Add(this.lbliSku);
            this.grpInventory.Controls.Add(this.lblPrice);
            this.grpInventory.Controls.Add(this.lblQty);
            this.grpInventory.Controls.Add(this.lbliSize);
            this.grpInventory.Controls.Add(this.lblColor);
            this.grpInventory.Controls.Add(this.lblName);
            this.grpInventory.Controls.Add(this.lblPic);
            this.grpInventory.Controls.Add(this.lblItemId);
            this.grpInventory.Location = new System.Drawing.Point(12, 218);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(494, 417);
            this.grpInventory.TabIndex = 4;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(41, 47);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(41, 13);
            this.lblItemId.TabIndex = 0;
            this.lblItemId.Text = "Item ID";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(41, 319);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(68, 13);
            this.lblPic.TabIndex = 1;
            this.lblPic.Text = "Shoe Picture";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Shoe Name";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(41, 119);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lbliSize
            // 
            this.lbliSize.AutoSize = true;
            this.lbliSize.Location = new System.Drawing.Point(41, 155);
            this.lbliSize.Name = "lbliSize";
            this.lbliSize.Size = new System.Drawing.Size(27, 13);
            this.lbliSize.TabIndex = 4;
            this.lbliSize.Text = "Size";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(41, 188);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(41, 226);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lbliSku
            // 
            this.lbliSku.AutoSize = true;
            this.lbliSku.Location = new System.Drawing.Point(41, 262);
            this.lbliSku.Name = "lbliSku";
            this.lbliSku.Size = new System.Drawing.Size(26, 13);
            this.lbliSku.TabIndex = 7;
            this.lbliSku.Text = "Sku";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(170, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtShoeName
            // 
            this.txtShoeName.Location = new System.Drawing.Point(170, 80);
            this.txtShoeName.Name = "txtShoeName";
            this.txtShoeName.Size = new System.Drawing.Size(100, 20);
            this.txtShoeName.TabIndex = 10;
            this.txtShoeName.TextChanged += new System.EventHandler(this.txtShoeName_TextChanged);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(170, 116);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 11;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(170, 185);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 13;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(170, 223);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(170, 259);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(100, 20);
            this.txtSku.TabIndex = 15;
            this.txtSku.TextChanged += new System.EventHandler(this.txtSku_TextChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(170, 152);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 12;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(158, 167);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 45);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSubNew
            // 
            this.btnSubNew.Location = new System.Drawing.Point(239, 167);
            this.btnSubNew.Name = "btnSubNew";
            this.btnSubNew.Size = new System.Drawing.Size(75, 45);
            this.btnSubNew.TabIndex = 6;
            this.btnSubNew.Text = "Submit New";
            this.btnSubNew.UseVisualStyleBackColor = true;
            this.btnSubNew.Click += new System.EventHandler(this.btnSubNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(320, 167);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 45);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select Shoe";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdSel
            // 
            this.btnUpdSel.Location = new System.Drawing.Point(401, 167);
            this.btnUpdSel.Name = "btnUpdSel";
            this.btnUpdSel.Size = new System.Drawing.Size(75, 45);
            this.btnUpdSel.TabIndex = 8;
            this.btnUpdSel.Text = "Update Selected";
            this.btnUpdSel.UseVisualStyleBackColor = true;
            this.btnUpdSel.Click += new System.EventHandler(this.btnUpdSel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(482, 167);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 45);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(644, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBox.Location = new System.Drawing.Point(170, 309);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 62);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 16;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 647);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdSel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSubNew);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.invenGrid);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invenGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView invenGrid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtShoeName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbliSku;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lbliSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSubNew;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdSel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBox;
    }
}