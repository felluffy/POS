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
    public partial class CashierForm : Form
    {
        POSDBEntities modelContext;
        string transactionNumber;
        double subtotal = 0.0f;
        public CashierForm()
        {
            InitializeComponent();
        }

        private void NewTransactionButton_Click(object sender, EventArgs e)
        {
            SetNewTransacation();
            dataGridView1.Rows.Clear();
            modelContext = new POSDBEntities();
            if(modelContext.carts.ToList().Count >= 0)
            {
                if (MessageBox.Show("Delete previous items?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    modelContext.carts.RemoveRange(modelContext.carts.ToList());
                    modelContext.SaveChanges();
                }
            }
        }

        //private void SearchBox_Click(object sender, EventArgs e)
        //{
        //    modelContext = new POSDBEntities();
        //    var prod = modelContext.products.Where(pr => pr.Barcode == SearchBox.Text.ToString());
        //    if(prod.Count() != 0)
        //    {
        //        ItemRequestQuantityForm irqf = new ItemRequestQuantityForm(prod.ElementAt(0));
        //        irqf.ShowDialog();
        //    }

        //    else
        //    {
        //        MessageBox.Show("Product not found");
        //    }
        //}

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modelContext = new POSDBEntities();
                //var prod = modelContext.products.Where(pr => pr.Barcode == SearchBox.Text.ToString());
                var prod = modelContext.products.FirstOrDefault(pr => pr.Barcode == SearchBox.Text.ToString());
                if (prod != null)
                {
                    ItemRequestQuantityForm irqf = new ItemRequestQuantityForm(prod, transactionNumber);
                    irqf.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Product not found");
                }
            }
        }

        private void LoadCart()
        {
            dataGridView1.Rows.Clear();
            modelContext = new POSDBEntities();
            var items = modelContext.carts.ToList();
            
            foreach(var item in items)
            {
                var prod = modelContext.products.FirstOrDefault(pr => pr.id == item.productID);
                dataGridView1.Rows.Add(item.id, 1, item.productID, prod.Name, prod.Description, item.Quantity, item.Price);
                subtotal += float.Parse(item.Price.ToString());
            }
            SubtotalLabel.Text = subtotal.ToString();
            TotalLabel.Text = subtotal.ToString();
            TaxLabel.Text = 0.0f.ToString();
            DiscountLabel.Text = "N/A";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "Delete")
            {
                var index = long.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
                var crt = modelContext.carts.FirstOrDefault(cr => cr.id == index);
                modelContext.Entry(crt).State = System.Data.Entity.EntityState.Deleted;
                modelContext.SaveChanges();
                MessageBox.Show(crt.id + "Deleted Successfully");
                LoadCart();
            }
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            LookUpProduct form = new LookUpProduct(this, transactionNumber);
            form.ShowDialog();
            LoadCart();
        }

        private void metroPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void NextPaymentAndUpdateProducts(bool ShouldUpdate = false)
        {
            SetNewTransacation();
            modelContext = new POSDBEntities();
            if (ShouldUpdate)
            {
                foreach (var item in modelContext.carts.ToList())
                {
                    product pr = modelContext.products.FirstOrDefault(prod => prod.id == item.productID);
                    pr.Quantity = pr.Quantity - item.Quantity;
                    modelContext.Entry<product>(pr).State = System.Data.Entity.EntityState.Modified;
                    modelContext.carts.Remove(item);
                };
                modelContext.SaveChanges();
            }
                
        }

        private void SetNewTransacation()
        {
            modelContext = new POSDBEntities();
            var date = DateTime.Today.ToString("yyyyMMdd");
            //MessageBox.Show(date);
            var last = modelContext.carts.Where(cr => cr.TransactionNo.Contains("date"));
            if (last.Count() > 0)
            {
                //transaction number
                transactionNumber = date + (int.Parse(last.Last().TransactionNo.Substring(last.Last().TransactionNo.Length - 5)) + 1).ToString();
            }
            else
            {
                transactionNumber = date + "10001";
            }
            TransactionNumberLabel.Text = transactionNumber;
            modelContext.Dispose();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            SettlePayment sp = new SettlePayment(subtotal, this);
            sp.ShowDialog();
        }
    }
}
