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
    public partial class LookUpProduct : Form
    {
        POSDBEntities modelContext;
        CashierForm parent = null;
        string Transcation_no;
        public LookUpProduct(CashierForm parent, string Transaction_no = "")
        {
            InitializeComponent();
            this.parent = parent;
            this.Transcation_no = Transaction_no;
        }

        public void LoadRecords(String search ="")
        {
            //var blyat = new POSDBEntities();
            modelContext = new POSDBEntities();
            dataGridView1.Rows.Clear();
            var products = modelContext.products.Where(pr => pr.Quantity > 0 && (pr.Name.Contains(search) || pr.Barcode.Contains(search))).ToList();
            foreach (var product in products)
            {
                var br = modelContext.brands.FirstOrDefault(bra => bra.id == product.brandID);//modelContext.brands.Find(product.brandID);
                var cat = modelContext.categories.FirstOrDefault(cate => cate.id == product.categoryID);
                dataGridView1.Rows.Add(product.id, product.ProductCode, product.Name, product.Description, br.Name, cat.Name, product.Price, product.Barcode);
            }
            modelContext.Dispose();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadRecords(SearchBox.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            modelContext = new POSDBEntities();
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(columnName == "Select")
            {
                var index = dataGridView1[0, e.RowIndex].Value.ToString();
                var ind = long.Parse(index);
                product prod = modelContext.products.FirstOrDefault(pr => pr.id == ind);
                ItemRequestQuantityForm iqf = new ItemRequestQuantityForm(prod, Transcation_no, this);
                iqf.ShowDialog();
            }
        }
    }
}
