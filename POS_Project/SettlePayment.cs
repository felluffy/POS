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
    public partial class SettlePayment : Form
    {
        CashierForm cf;
        bool CashPayable = false;
        bool paymentDone = false;
        double TotalPayable = 0.0;
        public SettlePayment(double TotalPayable, CashierForm cf = null)
        {
            InitializeComponent();
            this.TotalPayable = TotalPayable;
            TotalPayableLabel.Text = TotalPayable.ToString();
            this.cf = cf;
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            CashPayable = true;
            PaidBox.Enabled = true;
        }

        private void SettlePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab && CashPayable)
            {
                if (double.Parse(PaidBox.Text) >= double.Parse(TotalPayableLabel.Text))
                {
                    ReturnAmountLabel.Text = (double.Parse(PaidBox.Text) - double.Parse(TotalPayableLabel.Text)).ToString();
                    MessageBox.Show("Return amount: " + ReturnAmountLabel.Text);
                    paymentDone = true;
                    UpdateCart();
                    this.Dispose();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BkashButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processed");
            paymentDone = true;
            UpdateCart();
            this.Dispose();
        }

        private void SSLCommerzButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processed");
            paymentDone = true;
            UpdateCart();
            this.Dispose();
        }
        

        private void UpdateCart()
        {
            if(paymentDone)
            {
                cf.NextPaymentAndUpdateProducts();
            }
        }
    }
}
 