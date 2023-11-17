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
    public partial class BrandAddForm : Form
    {
        POSDBEntities modelContext;
        BrandFormList brandFormList;
        brand br;
        public BrandAddForm(BrandFormList brandFormList)
        {
            InitializeComponent();
            this.brandFormList = brandFormList;
        }

        public BrandAddForm(BrandFormList brandFormList, brand br)
        {
            InitializeComponent();
            this.brandFormList = brandFormList;
            this.br = br;
        }


        public BrandAddForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveButton.Text == "Save")
            {
                try
                {
                    modelContext = new POSDBEntities();
                    br = new brand();
                    //var last = modelContext.brands.
                    br.Name = brandNameBox.Text;
                    br.BrandID = 53;
                    //MessageBox.Show(br.Name + " " + br.id + " " + br.BrandID);
                    Clear();
                    modelContext.brands.Add(br);
                    modelContext.SaveChanges();
                    //modelContext.Dispose();
                    this.Close();
                    brandFormList.LoadRecords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "IDIOT");
                }
            }
            else
            {
                try
                {
                    modelContext = new POSDBEntities();
                    br.Name = brandNameBox.Text;
                    MessageBox.Show(br.Name + " " + brandNameBox.Text);
                    modelContext.Entry(br).State = System.Data.Entity.EntityState.Modified;
                    modelContext.SaveChanges();
                    brandFormList.LoadRecords();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Clear()
        {
            SaveButton.Enabled = true;
            brandNameBox.Clear();
            brandNameBox.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
