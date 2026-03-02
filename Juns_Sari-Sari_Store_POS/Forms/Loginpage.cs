using Juns_Sari_Sari_Store_POS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juns_Sari_Sari_Store_POS
{
    public partial class Loginpage : Form
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

        public Loginpage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text.Trim();
            string pass = textBoxPassword.Text;

            const string existsSql = "SELECT COUNT(1) FROM UserDetails WHERE Username = @user";
            const string authSql   = "SELECT COUNT(1) FROM UserDetails WHERE Username = @user AND Password = @pass";

            try
            {
                con.Open();

                using (var cmd = new SqlCommand(existsSql, con))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    bool userExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    if (!userExists)
                    {
                        MessageBox.Show("Username not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (var cmd = new SqlCommand(authSql, con))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    bool authenticated = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    if (authenticated)
                    {
                        var ws = new Work_Station { StartPosition = FormStartPosition.CenterScreen };
                        ws.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
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