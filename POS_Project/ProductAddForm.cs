using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace POS_Project
{
    public partial class ProductAddForm : Form
    {
        POSDBEntities modelContext;
        ProductFormList productFormList;
        product prod_In;
        List<long> brandIDs = new List<long>();
        List<long> categoryIDs = new List<long>();
        public ProductAddForm()
        {
            InitializeComponent();
            LoadBrands();
            LoadCategories();
        }

        public ProductAddForm(ProductFormList productFormList) : this()
        {
            this.productFormList = productFormList;
        }

        public ProductAddForm(ProductFormList productFormList, product prod_In) : this(productFormList)
        {
            this.prod_In = prod_In; //= new product(prod_In);
            MessageBox.Show(prod_In.id.ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clear()
        {
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }


        private void LoadCategories()
        {
            CategoryBox.Items.Clear();
            modelContext = new POSDBEntities();
            var categories = modelContext.categories;
            var message = "";
            foreach (var category in categories)
            {
                //message = message + brand; ;
                //brandsSaved.Add(brand);
                categoryIDs.Add(category.id);
                CategoryBox.Items.Add(category.Name.ToString());
            }
        }

        private void LoadBrands()
        {
            BrandBox.Items.Clear();
            modelContext = new POSDBEntities();
            var brands = modelContext.brands;
            var message = "";
            foreach (var brand in brands)
            {
                //message = message + brand; ;
                //brandsSaved.Add(brand);
                brandIDs.Add(brand.id);
                BrandBox.Items.Add(brand.Name.ToString());
            }
        }

        private void BrandBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            long brandID, categoryID;
            if (SaveButton.Text == "Save")
            {
                try
                {
                    product prod = new product();
                    modelContext = new POSDBEntities();
                    prod.brandID = brandIDs[BrandBox.SelectedIndex];
                    prod.categoryID = categoryIDs[CategoryBox.SelectedIndex];
                    prod.ProductCode = ProductCodeBox.Text.ToString();
                    prod.Price = double.Parse(PriceBox.Text.ToString());
                    prod.Weight = double.Parse(WeightBox.Text.ToString());
                    prod.Quantity = long.Parse(QuantityBox.Text.ToString());
                    prod.Description = DescriptionBox.Text.ToString();
                    prod.Barcode = BarcodeBox.Text.ToString();
                    prod.Name = NameBox.Text.ToString();



                    modelContext.products.Add(prod);
                    modelContext.SaveChanges();
                    modelContext.Dispose();

                    MessageBox.Show("saved"); 
                    clear();

                }
                catch (Exception except)
                {
                    MessageBox.Show(except.ToString());
                }
            }

            else if (SaveButton.Text == "Update")
            {
                try
                {
                    //var cdContext = new POSDBEntities();
                    prod_In.brandID = brandIDs[BrandBox.SelectedIndex];
                    prod_In.categoryID = categoryIDs[CategoryBox.SelectedIndex];
                    prod_In.ProductCode = ProductCodeBox.Text.ToString();
                    prod_In.Price = float.Parse(PriceBox.Text.ToString());
                    prod_In.Weight = float.Parse(WeightBox.Text.ToString());
                    prod_In.Quantity = long.Parse(QuantityBox.Text.ToString());
                    prod_In.Description = DescriptionBox.Text.ToString();
                    prod_In.Name = NameBox.Text.ToString();
                    prod_In.Barcode = BarcodeBox.Text.ToString();


                    product prod = new product();
                    modelContext = new POSDBEntities();
                    prod.brandID = prod_In.brandID;
                    prod.categoryID = prod_In.categoryID;
                    prod.ProductCode = prod_In.ProductCode;
                    prod.Price = prod_In.Price;
                    prod.Weight = prod_In.Weight;
                    prod.Quantity = prod_In.Quantity;
                    prod.Description = prod_In.Description;
                    prod.Name = prod_In.Name;
                    prod.Barcode = prod_In.Barcode;
                    prod.id = prod_In.id;

                    

                    modelContext.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                    modelContext.SaveChanges();
                    if (productFormList != null)
                        productFormList.LoadRecords();
                    MessageBox.Show("Updated succ");
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.ToString());
                }
            }

            if (productFormList != null)
                productFormList.LoadRecords();
            this.Dispose();
        }
    }
}
