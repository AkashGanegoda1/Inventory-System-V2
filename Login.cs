using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Login : Form
    {
        readonly DBConnection db = new DBConnection();

        [Obsolete]
        public Login()
        {
            InitializeComponent();
        }

        private int count = 1;
        private void Slider()
        {
            if (count == 5)
            {
                count = 1;
            }
            guna2PictureBox1.ImageLocation = string.Format(@"Img\{0}.jpg", count);
            count++;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void Guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Txt_userid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void Txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();
            }
        }

        [Obsolete]
        private void Btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_userid.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt_password.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the Correct Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string query = "Select * from Login where username = '" + txt_userid.Text + "' and password = '" + txt_password.Text + "'";
                db.da = new System.Data.SQLite.SQLiteDataAdapter(query, db.con);
                db.dt = new System.Data.DataTable();
                db.da.Fill(db.dt);
                if (db.dt.Rows.Count == 1)
                {
                    this.Hide();
                    Dashboard ds = new Dashboard();
                    ds.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Password for the user account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [Obsolete]
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Account_Recovery account_Recovery = new Account_Recovery();
            account_Recovery.Show();
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
