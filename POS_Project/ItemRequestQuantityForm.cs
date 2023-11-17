using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Project
{
    public partial class ItemRequestQuantityForm : Form
    {
        product prod;
        string Transcation_no;
        LookUpProduct lup;
        POSDBEntities modelContext;
        public ItemRequestQuantityForm(product prod, string Transcation_no, LookUpProduct lup = null)
        {
            InitializeComponent();
            this.Transcation_no = Transcation_no;
            this.prod = prod;
            BarcodeLabel.Text = prod.Barcode;
            NameLabel.Text = prod.Name;
            DescriptionLabel.Text = prod.Description;
            this.lup = lup;

        }

        private void ItemRequestQuantityForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Dispose();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //    this.Dispose();
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    //try
                    //{
                        modelContext = new POSDBEntities();
                        cart crt = new cart();
                        crt.TransactionNo = Transcation_no;
                        crt.productID = prod.id;
                        crt.Quantity = long.Parse(QunatityTextBox.Text);
                        crt.Date = DateTime.Now;
                        crt.Price = double.Parse(PriceBox.Text);
                        crt.Status = "KURVA";

                        MessageBox.Show(crt.TransactionNo + " " + crt.productID + " " + crt.Quantity + " " + crt.Date.ToString() + " " + crt.Price + " " + crt.Status);

                        modelContext.carts.Add(crt);

                        modelContext.SaveChanges();
                        modelContext.Dispose();
                        this.Dispose();
                    //} catch(Exception ex)
                    //{
                     //   MessageBox.Show(ex.ToString());
                    //}
                    break;
                case Keys.Oemplus:
                    AddItem();
                    break;
                case Keys.OemMinus:
                    DecreaseItem();
                    break;
                case Keys.Escape:
                    this.Dispose();
                    break;
                default:
                    break;
            }
        }
        private void AddItem()
        {
            int numberOfItmes = int.Parse(QunatityTextBox.Text);
            if (prod.Quantity > numberOfItmes)
                numberOfItmes++;
            PriceBox.Text = (numberOfItmes * prod.Price).ToString();
            QunatityTextBox.Text = numberOfItmes.ToString();
        }
        private void DecreaseItem()
        {
            int numberOfItmes = int.Parse(QunatityTextBox.Text);
            if (numberOfItmes > 0)
            {
                numberOfItmes--;
            }
            PriceBox.Text = (numberOfItmes * prod.Price).ToString();
            QunatityTextBox.Text = numberOfItmes.ToString();
            
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DecreaseItem();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void QunatityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int numberOfItmes = int.Parse(QunatityTextBox.Text);
                if (numberOfItmes >= 0 && numberOfItmes <= prod.Quantity)
                    PriceBox.Text = (numberOfItmes * prod.Price).ToString();
                else
                    PriceBox.Text = 0.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Only enter numbers");
            }
        }
    }
}
