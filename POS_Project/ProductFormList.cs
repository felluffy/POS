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
    public partial class ProductFormList : Form
    {
        POSDBEntities modelContext;
        public ProductFormList()
        {
            InitializeComponent();
            LoadRecords();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductAddForm AddNewProduct = new ProductAddForm();
            AddNewProduct.SaveButton.Text = "Save";
            AddNewProduct.ShowDialog();
        }

        public void LoadRecords()
        {
            //var blyat = new POSDBEntities();
            modelContext = new POSDBEntities();
            dataGridView1.Rows.Clear();
            var products = modelContext.products.ToList();
            foreach (var product in products)
            {
                var br = modelContext.brands.FirstOrDefault(bra => bra.id == product.brandID);//modelContext.brands.Find(product.brandID);
                var cat = modelContext.categories.FirstOrDefault(cate => cate.id == product.categoryID);
                dataGridView1.Rows.Add(product.id, product.ProductCode, product.Name, product.Description, br.Name, cat.Name, product.Price, product.Quantity, product.Weight, product.Barcode);
            }
            modelContext.Dispose();

        }

        private void LoadCategories()
        {
            
        }
        private void LoatBrands()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            try
            {
                var prodId = (long)dataGridView1[0, e.RowIndex].Value;
                var prod = modelContext.products.FirstOrDefault(pr => pr.id == prodId);
                if (columnName == "Edit")
                {
                    
                    MessageBox.Show(((long)dataGridView1[0, e.RowIndex].Value).ToString());
                    ProductAddForm paf = new ProductAddForm(this, prod);
                    var br = modelContext.brands.FirstOrDefault(bra => bra.id == prod.brandID);
                    var cat = modelContext.categories.FirstOrDefault(cate => cate.id == prod.categoryID);
                    paf.NameBox.Text = prod.Name;
                    paf.ProductCodeBox.Text = prod.ProductCode;
                    paf.PriceBox.Text = prod.Price.ToString();
                    paf.WeightBox.Text = prod.Weight.ToString();
                    paf.DescriptionBox.Text = prod.Description;
                    paf.QuantityBox.Text = prod.Quantity.ToString();
                    paf.BrandBox.SelectedIndex = paf.BrandBox.FindStringExact(br.Name);
                    paf.CategoryBox.SelectedIndex = paf.CategoryBox.FindStringExact(cat.Name);
                    paf.BarcodeBox.Text = prod.Barcode;
                    paf.SaveButton.Text = "Update";
                    paf.ShowDialog();
                }
                else if (columnName == "Delete")
                {
                    modelContext.Entry(prod).State = System.Data.Entity.EntityState.Deleted;
                    modelContext.SaveChanges();
                    MessageBox.Show(prod.Name + "Deleted Successfully");
                    LoadRecords();
                }
            }
            catch (Exception Except)
            {
                MessageBox.Show(Except.ToString());
            }
        }
    }
}
