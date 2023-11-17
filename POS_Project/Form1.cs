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
    public partial class Form1 : Form
    {
        private Form currentForm;
        //private Form oldForm;
        //POSDBEntities modelEntities;
        public Form1()
        {
            InitializeComponent();
        }

        private void BrandsButton_Click(object sender, EventArgs e)
        {
            BrandFormList brandsFormList = new BrandFormList();
            Open(brandsFormList);
            //brandsForm.TopLevel = false;
            //panel3.Controls.Add(brandsForm);
            //brandsForm.BringToFront();
            //brandsForm.Show();

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            
            InventoryFormList inventoryFormList = new InventoryFormList();
            Open(inventoryFormList);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductFormList productFormList = new ProductFormList();
            Open(productFormList);
            //productFormList.TopLevel = true;
        }


        private void Open(Form form)
        {
            if(currentForm != null)
                currentForm.Dispose();


            currentForm = form;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.BringToFront();
            form.Show(); 
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            CategoryFormList categoryFormList = new CategoryFormList();
            Open(categoryFormList);
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            StockInForm stockIn = new StockInForm();
            Open(stockIn);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            CashierForm cf = new CashierForm();
            cf.TopLevel = true;
            cf.ShowDialog();
        }
    }
}
