namespace POS_Project
{
    partial class SettlePayment
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.SSLCommerzButton = new MetroFramework.Controls.MetroButton();
            this.BkashButton = new MetroFramework.Controls.MetroButton();
            this.CashButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TotalPayableLabel = new MetroFramework.Controls.MetroLabel();
            this.ReturnAmountLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddItemPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelPictureBox = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PaidBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.CashButton);
            this.metroPanel1.Controls.Add(this.BkashButton);
            this.metroPanel1.Controls.Add(this.SSLCommerzButton);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 450);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.White;
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.PaidBox);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.ReturnAmountLabel);
            this.metroPanel2.Controls.Add(this.TotalPayableLabel);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 294);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(800, 156);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // SSLCommerzButton
            // 
            this.SSLCommerzButton.Location = new System.Drawing.Point(249, 61);
            this.SSLCommerzButton.Name = "SSLCommerzButton";
            this.SSLCommerzButton.Size = new System.Drawing.Size(287, 40);
            this.SSLCommerzButton.TabIndex = 3;
            this.SSLCommerzButton.Text = "Payment by SSLCommerz";
            this.SSLCommerzButton.UseSelectable = true;
            this.SSLCommerzButton.Click += new System.EventHandler(this.SSLCommerzButton_Click);
            // 
            // BkashButton
            // 
            this.BkashButton.Location = new System.Drawing.Point(249, 123);
            this.BkashButton.Name = "BkashButton";
            this.BkashButton.Size = new System.Drawing.Size(287, 40);
            this.BkashButton.TabIndex = 4;
            this.BkashButton.Text = "Payment by BKASH";
            this.BkashButton.UseSelectable = true;
            this.BkashButton.Click += new System.EventHandler(this.BkashButton_Click);
            // 
            // CashButton
            // 
            this.CashButton.Location = new System.Drawing.Point(249, 187);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(287, 40);
            this.CashButton.TabIndex = 5;
            this.CashButton.Text = "Cash";
            this.CashButton.UseSelectable = true;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Total Payable:";
            // 
            // TotalPayableLabel
            // 
            this.TotalPayableLabel.Location = new System.Drawing.Point(700, 61);
            this.TotalPayableLabel.Name = "TotalPayableLabel";
            this.TotalPayableLabel.Size = new System.Drawing.Size(88, 19);
            this.TotalPayableLabel.TabIndex = 3;
            this.TotalPayableLabel.Text = "\"\"";
            this.TotalPayableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReturnAmountLabel
            // 
            this.ReturnAmountLabel.Location = new System.Drawing.Point(700, 118);
            this.ReturnAmountLabel.Name = "ReturnAmountLabel";
            this.ReturnAmountLabel.Size = new System.Drawing.Size(88, 19);
            this.ReturnAmountLabel.TabIndex = 4;
            this.ReturnAmountLabel.Text = "\"\"";
            this.ReturnAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(633, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Return: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AddItemPictureBox);
            this.panel1.Controls.Add(this.CancelPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
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
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SettlePayment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(747, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddItemPictureBox
            // 
            this.AddItemPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.AddItemPictureBox.Location = new System.Drawing.Point(1178, 0);
            this.AddItemPictureBox.Name = "AddItemPictureBox";
            this.AddItemPictureBox.Size = new System.Drawing.Size(40, 38);
            this.AddItemPictureBox.TabIndex = 1;
            this.AddItemPictureBox.TabStop = false;
            // 
            // CancelPictureBox
            // 
            this.CancelPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelPictureBox.Location = new System.Drawing.Point(1224, 0);
            this.CancelPictureBox.Name = "CancelPictureBox";
            this.CancelPictureBox.Size = new System.Drawing.Size(40, 38);
            this.CancelPictureBox.TabIndex = 0;
            this.CancelPictureBox.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Paid:";
            // 
            // PaidBox
            // 
            // 
            // 
            // 
            this.PaidBox.CustomButton.Image = null;
            this.PaidBox.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.PaidBox.CustomButton.Name = "";
            this.PaidBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PaidBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PaidBox.CustomButton.TabIndex = 1;
            this.PaidBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PaidBox.CustomButton.UseSelectable = true;
            this.PaidBox.CustomButton.Visible = false;
            this.PaidBox.Enabled = false;
            this.PaidBox.Lines = new string[] {
        "0.0"};
            this.PaidBox.Location = new System.Drawing.Point(701, 89);
            this.PaidBox.MaxLength = 32767;
            this.PaidBox.Name = "PaidBox";
            this.PaidBox.PasswordChar = '\0';
            this.PaidBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PaidBox.SelectedText = "";
            this.PaidBox.SelectionLength = 0;
            this.PaidBox.SelectionStart = 0;
            this.PaidBox.ShortcutsEnabled = true;
            this.PaidBox.Size = new System.Drawing.Size(87, 23);
            this.PaidBox.TabIndex = 8;
            this.PaidBox.Text = "0.0";
            this.PaidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PaidBox.UseSelectable = true;
            this.PaidBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaidBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(13, 128);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(225, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Press Tab to calculate reutrn amount ";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // SettlePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettlePayment";
            this.Text = "SettlePayment";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettlePayment_KeyDown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton SSLCommerzButton;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton CashButton;
        private MetroFramework.Controls.MetroButton BkashButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel ReturnAmountLabel;
        private MetroFramework.Controls.MetroLabel TotalPayableLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AddItemPictureBox;
        private System.Windows.Forms.PictureBox CancelPictureBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox PaidBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}