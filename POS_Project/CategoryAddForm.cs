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
    public partial class CategoryAddForm : Form
    {

        POSDBEntities modelContext;
        CategoryFormList categoryFormList;
        category cat;
        public CategoryAddForm(CategoryFormList categoryFormList)
        {
            InitializeComponent();
            this.categoryFormList = categoryFormList;
        }

        public CategoryAddForm(CategoryFormList categoryFormList, category cat)
        {
            InitializeComponent();
            this.categoryFormList = categoryFormList;
            this.cat = cat;
        }


        public CategoryAddForm()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Clear()
        {
            SaveButton.Enabled = true;
            CategoryNameBox.Clear();
            CategoryNameBox.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveButton.Text == "Save")
            {
                try
                {
                    modelContext = new POSDBEntities();
                    cat = new category();
                    //var last = modelContext.brands.
                    cat.Name = CategoryNameBox.Text;
                    cat.CategoryID = 1;
                    //MessageBox.Show(br.Name + " " + br.id + " " + br.BrandID);
                    Clear();
                    modelContext.categories.Add(cat);
                    modelContext.SaveChanges();
                    //modelContext.Dispose();
                    this.Close();
                    categoryFormList.LoadRecords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    modelContext = new POSDBEntities();
                    cat.Name = CategoryNameBox.Text;
                    MessageBox.Show(cat.Name + " " + CategoryNameBox.Text);
                    modelContext.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                    modelContext.SaveChanges();
                    categoryFormList.LoadRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
