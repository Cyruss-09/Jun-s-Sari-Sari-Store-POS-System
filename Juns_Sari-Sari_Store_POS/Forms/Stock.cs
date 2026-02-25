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
    }
}
