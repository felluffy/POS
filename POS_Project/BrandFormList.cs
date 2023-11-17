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
    public partial class BrandFormList : Form
    {
        POSDBEntities modelContext;
        public BrandFormList()
        {
            InitializeComponent();
            LoadRecords();
            //modelContext = new DBModelEntities();

            //var vvv = modelContext.brands.Find()

            //MessageBox.Show(vvv.Name + " " + vvv.ID);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BrandAddForm baf = new BrandAddForm(this);
            baf.SaveButton.Text = "Save";
            baf.ShowDialog();
        }

        public void LoadRecords()
        {
            modelContext = new POSDBEntities();
            dataGridView1.Rows.Clear();
            var brands = modelContext.brands;           
            foreach(var brand in brands)
            {
                dataGridView1.Rows.Add(brand.id, brand.BrandID,  brand.Name);
            }
            modelContext.Dispose();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            try
            {
                brand br = new brand();
                br.Name = dataGridView1[2, e.RowIndex].Value.ToString();
                br.id = (long)dataGridView1[0, e.RowIndex].Value;
                br.BrandID = (long)dataGridView1[1, e.RowIndex].Value;
                MessageBox.Show(br.id + " " + br.Name);
                //br.id = (UInt64)dataGridView1[0, e.RowIndex].Value;
                
                //MessageBox.Show(columnName);
                if (columnName == "Edit")
                {
                    BrandAddForm brandForm = new BrandAddForm(this, br);
                    brandForm.brandNameBox.Text = br.Name;
                    brandForm.SaveButton.Text = "Update";
                    brandForm.ShowDialog();
                }
                else if (columnName == "Delete")
                {
                    modelContext.Entry(br).State = System.Data.Entity.EntityState.Deleted;
                    modelContext.SaveChanges();
                    MessageBox.Show(br.Name + "Deleted Successfully");
                    LoadRecords();
                }
            }
            catch(Exception Except)
            {
                MessageBox.Show(Except.ToString());
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
