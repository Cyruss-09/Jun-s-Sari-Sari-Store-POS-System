using Juns_Sari_Sari_Store_POS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juns_Sari_Sari_Store_POS
{
    public partial class Work_Station : Form
    {
        public Work_Station()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
           Stockpage stockpage = new Stockpage();
           stockpage.StartPosition = FormStartPosition.CenterScreen;
           stockpage.Show();
           this.Show();
           this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}