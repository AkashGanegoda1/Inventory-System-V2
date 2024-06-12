using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Account_Recovery : Form
    {
        string randomCode;
        public static string to;

        [Obsolete]
        public Account_Recovery()
        {
            InitializeComponent();
        }
        
        private void Account_Recovery_Load(object sender, EventArgs e)
        {
            bunifuPanel2.Enabled = false;
            txt_email.Text = "hhcohelmet.inquiries@gmail.com";
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
        private void Btn_emailsent_Click(object sender, EventArgs e)
        {
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                try
                {
                    MailMessage msg = new MailMessage
                    {
                        From = new MailAddress("hhcohelmet.inquiries@gmail.com")
                    };
                    msg.To.Add(txt_email.Text);
                    msg.Subject = "Password Reset (Inventory System)";
                    msg.Body = "Your One-Time Password (OTP) is " + randomCode;

                    SmtpClient smt = new SmtpClient
                    {
                        Host = "smtp.gmail.com"
                    };
                    NetworkCredential ntcd = new NetworkCredential
                    {
                        UserName = "hhcohelmet.inquiries@gmail.com",
                        Password = "nwjdjpvsxdkollus"
                    };
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);
                    if (msg == null)
                    {
                        MessageBox.Show("Mail sent Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mail sent Successfully, Please Check Your Mail!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txt_email.Clear();
                    bunifuPanel2.Enabled = true;
                    bunifuPanel1.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Unsuccessfull Attempt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        [Obsolete]
        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        [Obsolete]
        private void Btn_otpverify_Click(object sender, EventArgs e)
        {
            if (txt_otp.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter the OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (randomCode == (txt_otp.Text).ToString())
            {
                to = txt_email.Text;
                Reset_Password obj = new Reset_Password();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct Verification Code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
