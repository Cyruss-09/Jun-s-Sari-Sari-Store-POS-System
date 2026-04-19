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
using System.Data.SqlClient;
using System.Diagnostics;

namespace Juns_Sari_Sari_Store_POS.Forms
{
    
    public partial class Stockpage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Juns.db.mdf;Integrated Security=True;Connect Timeout=30");

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
            Stockopen();

            btnAddItem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAddItem.Width, btnAddItem.Height, 30, 30));
            btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30));
        }

        private void Stockopen()
        {
            con.Open();
            SqlCommand CountItem = new SqlCommand("Select Count(ItemCode) from Stock", con);
            string ItemCount = CountItem.ExecuteScalar().ToString();
            con.Close();

            lblStockcount.Text = ItemCount;
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

        // Helper to clear all input controls after successful insert
        private void ClearInputFields()
        {
            textBoxItem.Clear();
            textBoxDescription.Clear();
            textBoxPurchasingQuantity.Clear();
            textBoxPurchasingPrice.Clear();
            textBoxPurchaseValue.Clear();
            textBoxSellingPrice.Clear();
            textBoxPurchasingOrder.Clear();
            comboBoxSupplier.SelectedIndex = -1; // clears selection but preserves items
            textBoxItem.Focus();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {   
             
            if(string.IsNullOrEmpty(textBoxItem.Text))
            {
                MessageBox.Show("Item Code can't be null", "Error", MessageBoxButtons. OK, MessageBoxIcon.Error);
                textBoxItem.Focus();
                this.ActiveControl = textBoxItem;
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxDescription.Text))
                {
                    MessageBox.Show("Description can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxDescription.Focus();
                    this.ActiveControl = textBoxDescription;
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxPurchasingQuantity.Text))
                    {
                        MessageBox.Show("Purchasing Quantity can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPurchasingQuantity.Focus();
                        this.ActiveControl = textBoxPurchasingQuantity;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBoxPurchasingPrice.Text))
                        {
                            MessageBox.Show("Purchasing Price can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxPurchasingPrice.Focus();
                            this.ActiveControl = textBoxPurchasingPrice;
                        }else
                        {
                            if (string.IsNullOrEmpty(textBoxSellingPrice.Text))
                            {
                                MessageBox.Show("Purchasing Selling Price can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxSellingPrice.Focus();
                                this.ActiveControl = textBoxSellingPrice;
                            }else
                            {
                                if (string.IsNullOrEmpty(textBoxPurchasingOrder.Text))
                                {
                                    MessageBox.Show("Purchasing Order can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBoxPurchasingOrder.Focus();
                                    this.ActiveControl = textBoxPurchasingOrder;
                                }else
                                {
                                    if (string.IsNullOrEmpty(comboBoxSupplier.Text))
                                    {
                                        MessageBox.Show("Supplier can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        comboBoxSupplier.Focus();
                                        this.ActiveControl = comboBoxSupplier;
                                    }else
                                    {
                                        textBoxItem.Clear();
                                        textBoxDescription.Clear();
                                        textBoxPurchasingQuantity.Clear();
                                        textBoxPurchasingPrice.Clear();
                                        textBoxPurchaseValue.Clear();
                                        textBoxSellingPrice.Clear();
                                        textBoxPurchasingOrder.Clear();
                                        comboBoxSupplier.SelectedIndex = -1;
                                        textBoxItem.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            const string sql = @"INSERT INTO dbo.Stock([ItemCode],[Description],[Prch_Qty],[Prch_Price],[Prch_Value],[MRP],[Supplier])
                     VALUES (@code,@desc,@qty,@price,@value,@mrp,@supplier)";

            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@code", textBoxItem.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", textBoxDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", double.TryParse(textBoxPurchasingQuantity.Text, out var qty) ? qty : 0.0);
                cmd.Parameters.AddWithValue("@price", double.TryParse(textBoxPurchasingPrice.Text, out var price) ? price : 0.0);
                cmd.Parameters.AddWithValue("@value", double.TryParse(textBoxPurchaseValue.Text, out var value) ? value : 0.0);
                cmd.Parameters.AddWithValue("@mrp", double.TryParse(textBoxSellingPrice.Text, out var mrp) ? mrp : 0.0);
                cmd.Parameters.AddWithValue("@supplier", comboBoxSupplier.Text.Trim());

                try
                {
                    if (con.State != ConnectionState.Open) con.Open();

                    using (var check = new SqlCommand("SELECT DB_NAME(), USER_NAME(), OBJECT_ID('dbo.Stock')", con))
                    {
                        using (var rdr = check.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                Debug.WriteLine($"DB={rdr.GetValue(0)}, USER={rdr.GetValue(1)}, OBJECT_ID(dbo.Stock)={rdr.GetValue(2)}");
                            }
                        }
                    }

                    int rows = cmd.ExecuteNonQuery();
                    
                    if (rows > 0)
                    {
                        ClearInputFields();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Insert failed: {ex.Message}");
                    MessageBox.Show("Failed to add item. See debug output for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand ViewAllItems = new SqlCommand("select * from [Stock]", con);
            ViewAllItems.ExecuteNonQuery();
            SqlDataAdapter ItemAdapter = new SqlDataAdapter(ViewAllItems);
            DataTable StockTable = new DataTable();
            ItemAdapter.Fill(StockTable);
            dataGridView1.DataSource = StockTable;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
