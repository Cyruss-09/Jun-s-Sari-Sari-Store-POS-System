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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;

namespace Juns_Sari_Sari_Store_POS
{
    public partial class Loginpage : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Juns POS System1.accdb");

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

        public Loginpage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "SELECT Username FROM UserDetails WHERE Username = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("?", textBoxUsername.Text);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Success", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open Work_Station form
                            Work_Station workStation = new Work_Station();
                            workStation.StartPosition = FormStartPosition.CenterScreen;
                            workStation.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void Loginpage_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 30, 30));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}