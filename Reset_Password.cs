using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Reset_Password : Form
    {
        [Obsolete]
        public Reset_Password()
        {
            InitializeComponent();
        }
        readonly DBConnection db = new DBConnection();

        [Obsolete]
        private void Btn_reset_Click(object sender, EventArgs e)
        {
            if (txt_newpass.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Your new Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_cnewpass.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Confirm Your new Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_newpass.Text == txt_cnewpass.Text)
            {
                db.cmd = new System.Data.SqlClient.SqlCommand("UPDATE Login SET password = '" + txt_cnewpass.Text + "'WHERE username ='" + txt_username.Text + "'", db.con);
                db.con.Open();
                int i = db.cmd.ExecuteNonQuery();
                db.con.Close();
                db.cmd.Dispose();
                if (i == 1)
                {
                    MessageBox.Show("Password Reset Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
            }
            else
            {
                MessageBox.Show("Password do not match eachother!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                txt_newpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_newpass.UseSystemPasswordChar = true;
            }
        }

        private void Guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked)
            {
                txt_cnewpass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_cnewpass.UseSystemPasswordChar = true;
            }
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            txt_newpass.UseSystemPasswordChar = true;
            txt_cnewpass.UseSystemPasswordChar = true;
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        [Obsolete]
        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
