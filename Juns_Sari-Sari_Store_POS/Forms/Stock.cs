using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juns_Sari_Sari_Store_POS.Forms
{
    public partial class Stockpage : Form
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);
        public Stockpage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            btnAddItem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAddItem.Width, btnAddItem.Height, 30, 30));
            btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30));
        }

        private void btnPurchasingSummary_Click(object sender, EventArgs e)
        {
            Purchasing_Summary purchasing_Summary = new Purchasing_Summary();
            purchasing_Summary.StartPosition = FormStartPosition.CenterScreen;
            purchasing_Summary.Show();
            this.Hide();
        }

        private void fullScreenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_View stock_View = new Stock_View();
            stock_View.Show();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lowStockValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Low_Stock_Reminder low_Stock_Reminder = new Low_Stock_Reminder();
            low_Stock_Reminder.Show();
        }

        private void textBoxPurchasingQuantity_TextChanged(object sender, EventArgs e)
        {   
            // this code will allow textbox to accept numbers only
            if(string.IsNullOrEmpty(textBoxPurchasingQuantity.Text))
            {
                textBoxPurchasingQuantity.Text = "";
                textBoxPurchasingPrice.Text = "";
            }
            else
            {
                float qty;
                if(float.TryParse(textBoxPurchasingQuantity.Text,out qty))
                {

                }else
                {
                    textBoxPurchasingQuantity.Text = "";
                    textBoxPurchasingPrice.Text = "";
                }
            }
        }

        private void textBoxPurchasingPrice_TextChanged(object sender, EventArgs e)
        {   
            
            if (string.IsNullOrEmpty(textBoxPurchasingPrice.Text))
            {
                textBoxPurchasingPrice.Text = "";
                textBoxPurchaseValue.Text = "";

            }
            else
            {
                float PurchasingPrice;
                if (float.TryParse(textBoxPurchasingPrice.Text, out PurchasingPrice))
                {
                    double Purchasing_Value = Convert.ToDouble(textBoxPurchasingQuantity.Text) * Convert.ToDouble(textBoxPurchasingPrice.Text);


                    textBoxPurchaseValue.Text = Convert.ToString(Purchasing_Value);
                }
                else
                {
                    textBoxPurchasingPrice.Text = "";
                    textBoxPurchaseValue.Text = "";
                }
            }
        }

        private void textBoxSellingPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSellingPrice.Text))
            {
                textBoxSellingPrice.Text = "";
            }
            else
            {
                float qty;
                if (float.TryParse(textBoxSellingPrice.Text, out qty))
                {

                }
                else
                {
                    textBoxSellingPrice.Text = "";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Work_Station work_Station = new Work_Station();
            work_Station.Show();
            this.Show();
            this.Hide();
        }

        private void textBoxPurchaseValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPurchaseValue.Text))
            {
                textBoxPurchaseValue.Text = "";
            }
            else
            {
                float PurchaseValue;
                if (float.TryParse(textBoxPurchaseValue.Text, out PurchaseValue))
                {

                }
                else
                {
                    textBoxPurchaseValue.Text = "";
                }
            }
        }
    }
}
