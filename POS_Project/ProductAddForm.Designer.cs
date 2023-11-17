namespace POS_Project
{
    partial class ProductAddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.RichTextBox();
            this.BrandName = new MaterialSkin.Controls.MaterialLabel();
            this.ProductCodeBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PriceBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.QuantityBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.WeightBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.BarcodeBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 38);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add a Product";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.Location = new System.Drawing.Point(744, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 38);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(1178, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(1224, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(123, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(640, 28);
            this.NameBox.TabIndex = 9;
            this.NameBox.Text = "";
            // 
            // BrandName
            // 
            this.BrandName.AutoSize = true;
            this.BrandName.Depth = 0;
            this.BrandName.Font = new System.Drawing.Font("Roboto", 11F);
            this.BrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BrandName.Location = new System.Drawing.Point(12, 54);
            this.BrandName.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(105, 19);
            this.BrandName.TabIndex = 8;
            this.BrandName.Text = "Product Name";
            // 
            // ProductCodeBox
            // 
            this.ProductCodeBox.Location = new System.Drawing.Point(123, 102);
            this.ProductCodeBox.Name = "ProductCodeBox";
            this.ProductCodeBox.Size = new System.Drawing.Size(255, 28);
            this.ProductCodeBox.TabIndex = 11;
            this.ProductCodeBox.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Product Code";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(464, 103);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(299, 28);
            this.PriceBox.TabIndex = 13;
            this.PriceBox.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(415, 101);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Price";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(123, 148);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(255, 28);
            this.QuantityBox.TabIndex = 15;
            this.QuantityBox.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 148);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Quantity";
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(464, 147);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(299, 28);
            this.WeightBox.TabIndex = 17;
            this.WeightBox.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(403, 146);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Weight";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(123, 189);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(640, 126);
            this.DescriptionBox.TabIndex = 19;
            this.DescriptionBox.Text = "";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 189);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Description";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 343);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Brand";
            // 
            // BrandBox
            // 
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Location = new System.Drawing.Point(123, 343);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(255, 21);
            this.BrandBox.TabIndex = 21;
            this.BrandBox.SelectedIndexChanged += new System.EventHandler(this.BrandBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(689, 438);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 28);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(608, 438);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 28);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(464, 341);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(300, 21);
            this.CategoryBox.TabIndex = 25;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(389, 343);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(69, 19);
            this.materialLabel7.TabIndex = 24;
            this.materialLabel7.Text = "Category";
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Location = new System.Drawing.Point(123, 381);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(640, 28);
            this.BarcodeBox.TabIndex = 27;
            this.BarcodeBox.Text = "";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 381);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 19);
            this.materialLabel8.TabIndex = 26;
            this.materialLabel8.Text = "Barcode";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.ControlBox = false;
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ProductCodeBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.BrandName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductAddForm";
            this.Text = "ProductAddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox NameBox;
        private MaterialSkin.Controls.MaterialLabel BrandName;
        public System.Windows.Forms.RichTextBox ProductCodeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public System.Windows.Forms.RichTextBox PriceBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.RichTextBox QuantityBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public System.Windows.Forms.RichTextBox WeightBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        public System.Windows.Forms.RichTextBox DescriptionBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button SaveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        public System.Windows.Forms.ComboBox BrandBox;
        public System.Windows.Forms.ComboBox CategoryBox;
        public System.Windows.Forms.RichTextBox BarcodeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
    }
}