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
    public partial class StockInForm : Form
    {
        List<stockin> stocks = new List<stockin>();
        POSDBEntities modelContext;
        int lastIndex = 0;
        int index = 0;
        public StockInForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            modelContext = new POSDBEntities();
            dataGridView1.Rows.Clear();
            var products = modelContext.products.ToList();
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.id, product.ProductCode, product.Name, product.Description, product.Quantity);
            }
            modelContext.Dispose();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            //MessageBox.Show("Delete selected");

            string columnName = dataGridView2.Columns[e.ColumnIndex].Name;
            if(columnName == "Delete")
            {
                MessageBox.Show("Delete selected");
                
                // var item = stocks.Find()
                //var item = modelContext.stockins.FirstOrDefault(it => it.id == (long)dataGridView2[e.RowIndex, 0].Value);
                //modelContext.stockins.Remove(item);
                //modelContext.SaveChanges();
                //LoadStockIn();

                var stck = new stockin();
                stck.id = int.Parse(dataGridView2[0, e.RowIndex].Value.ToString());//stocks.Find((long)dataGridView2[0, e.RowIndex].Value)) // change to long
                var item = stocks.Find(st => st.id == stck.id);
                stocks.Remove(item);
                for (int i = stck.id; i != stocks.Count; i++)
                {
                    stocks[i].id = i;
                }
                LoadStockIn(dataGridView2);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            //if()
            if(columnName == "Select")
            {
                //@TODO: change to list, add to 2nd grid, on save, add it to database later
                if (MessageBox.Show("Add this item?", "Confirm" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var refno = ReferenceTextBox.Text;
                    var stockBy = StockInByTextBox.Text;
                    var dt = StockInDateTime.Value;

                    stockin stck = new stockin();
                    stck.id = index++;
                    stck.InDate = dt;
                    stck.ReferenceNo = refno;
                    stck.StockInBy = stockBy;
                    stck.productId = (long)dataGridView1[0, e.RowIndex].Value;
                    stck.ProductDescription = dataGridView1[3, e.RowIndex].Value.ToString();
                    //if(!stocks.Contains(stck))
                        stocks.Add(stck);
                    MessageBox.Show(stck.id.ToString());
                    //modelContext.stockins.Add(stck);
                    //modelContext.SaveChanges();
                    LoadStockIn(dataGridView2);
                   
                }

            }
        }

        public void LoadStockIn(DataGridView grid)
        {
            grid.Rows.Clear();
            modelContext = new POSDBEntities();
            //var stcks = modelContext.stockins.ToList();
            foreach(var stck in stocks)
            {
                var prod = modelContext.products.FirstOrDefault(pr => pr.id == stck.productId);
                grid.Rows.Add(stck.id, stck.productId, prod.ProductCode, stck.ReferenceNo, stck.ProductDescription, stck.InDate, stck.StockInBy, stck.Quantity);
            }
            //modelContext.Dispose();
        }

        public void LoadStockIn()
        {
            dataGridView3.Rows.Clear();
            modelContext = new POSDBEntities();
            var stcks = modelContext.stockins.ToList();
            foreach (var stck in stcks)
            {
                var prod = modelContext.products.FirstOrDefault(pr => pr.id == stck.productId);
                dataGridView3.Rows.Add(stck.id, stck.productId, prod.ProductCode, stck.ReferenceNo, stck.ProductDescription, stck.InDate, stck.StockInBy, stck.Quantity);
            }
            modelContext.Dispose();
        }

        public void LoadStockIn(long id)
        {
            dataGridView2.Rows.Clear();
            modelContext = new POSDBEntities();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
                LoadProducts(); 
            modelContext = new POSDBEntities();
            dataGridView1.Rows.Clear();
            var products = modelContext.products.Where(br => br.Name.Contains(SearchBox.Text) || br.Description.Contains(SearchBox.Text)) ;
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.id, product.ProductCode, product.Name, product.Description, product.Quantity);
            }
            modelContext.Dispose();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            modelContext = new POSDBEntities();
            try
            {
                int i = 0;
                foreach(var stck in stocks)
                {
                    stck.Quantity = long.Parse(dataGridView2[7, i++].Value.ToString());
                    var prod = modelContext.products.FirstOrDefault(pro => pro.id == stck.productId);
                    modelContext.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                    //modelContext.products
                    //modelContext.SaveChanges();
                    modelContext.Entry<product>(prod).State = System.Data.Entity.EntityState.Modified;//CurrentValues.SetValues(prod);
                    modelContext.stockins.Add(stck);
                    //modelContext.Entry<stockin>(stck).State = System.Data.Entity.EntityState.Modified;
                    //modelContext.Entry(stck).CurrentValues.SetValues(stck);
                    //modelContext.SaveChanges();
                }

                modelContext.SaveChanges();
                modelContext.Dispose();
                dataGridView2.Rows.Clear();
                LoadProducts();
                stocks.Clear();
                LoadStockIn();
                MessageBox.Show("Saved successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            MessageBox.Show("BLYAT");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            modelContext = new POSDBEntities();
            var stcks = modelContext.stockins.Where(stk => DateTime1.Value < stk.InDate && stk.InDate < DateTime2.Value).ToList();
            foreach(var stck in stcks)
            {
                var prod = modelContext.products.FirstOrDefault(pr => pr.id == stck.productId);
                dataGridView3.Rows.Add(stck.id, stck.productId, prod.ProductCode, stck.ReferenceNo, stck.ProductDescription, stck.InDate, stck.StockInBy, stck.Quantity);
            }
        }
    }
}
