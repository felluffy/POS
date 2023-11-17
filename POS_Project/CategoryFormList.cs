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
    public partial class CategoryFormList : Form
    {
        POSDBEntities modelContext;
        public CategoryFormList()
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
            CategoryAddForm caf = new CategoryAddForm(this);
            caf.SaveButton.Text = "Save";
            caf.ShowDialog();
        }

        public void LoadRecords()
        {
            modelContext = new POSDBEntities();
            dataGridView1.Rows.Clear();
            var categories = modelContext.categories;
            foreach (var category in categories)
            {
                dataGridView1.Rows.Add(category.id, category.CategoryID, category.Name);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            try
            {
                category cat = new category();
                cat.Name = dataGridView1[2, e.RowIndex].Value.ToString();
                cat.id = (long)dataGridView1[0, e.RowIndex].Value;
                cat.CategoryID = (long)dataGridView1[1, e.RowIndex].Value;
                //MessageBox.Show(cat.id + " " + cat.Name);
                if (columnName == "Edit")
                {
                    CategoryAddForm caf = new CategoryAddForm(this, cat);
                    caf.CategoryNameBox.Text = cat.Name;
                    caf.SaveButton.Text = "Update";
                    caf.ShowDialog();
                }
                else if (columnName == "Delete")
                {
                    modelContext.Entry(cat).State = System.Data.Entity.EntityState.Deleted;
                    modelContext.SaveChanges();
                    MessageBox.Show(cat.Name + "Deleted Successfully");
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
