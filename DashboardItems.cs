using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using Bunifu.UI.WinForms;

namespace Inventory_System
{
    public partial class DashboardItems : Form
    {
        [Obsolete]
        public DashboardItems()
        {
            InitializeComponent();
        }
        readonly DBConnection db = new DBConnection();
        private void DashboardItems_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = db.GetData("Select Material,Material_Category ,Unit,Avilable_Quantity from Stock");

            var col = new DataGridViewMergedTextBoxColumn();

            const string field = "Material";

            col.HeaderText = field;
            col.Name = field;
            col.DataPropertyName = field;

            int colidx = bunifuDataGridView1.Columns[field].Index;
            bunifuDataGridView1.Columns.Remove(field);
            bunifuDataGridView1.Columns.Insert(colidx, col);

            try
            {
                string query1 = "SELECT COUNT(Material) FROM Materials";
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand(query1, db.con);
                Int32 rowscount = Convert.ToInt32(db.cmd.ExecuteScalar());
                db.cmd.Dispose();
                db.con.Close();

                label3.Text = rowscount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query11 = "SELECT COUNT(*) FROM Materials_IN";
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand(query11, db.con);
                Int32 rowscount = Convert.ToInt32(db.cmd.ExecuteScalar());
                db.cmd.Dispose();
                db.con.Close();
                label9.Text = rowscount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query11 = "SELECT COUNT(*) FROM Materials_OUT";
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand(query11, db.con);
                Int32 rowscount = Convert.ToInt32(db.cmd.ExecuteScalar());
                db.cmd.Dispose();
                db.con.Close();
                label5.Text = rowscount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string query11 = "SELECT COUNT(Material) FROM Stock";
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand(query11, db.con);
                Int32 rowscount = Convert.ToInt32(db.cmd.ExecuteScalar());
                db.cmd.Dispose();
                db.con.Close();
                label2.Text = rowscount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lbltime.Text = DateTime.Today.ToLongDateString();
            label11.Text = DateTime.Today.ToLongDateString();
            label13.Text = DateTime.Today.ToLongDateString();
            label8.Text = DateTime.Today.ToLongDateString();
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void Btn_email_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"))
                {
                    MessageBox.Show("Please Enter the Gmail in Correct Way!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt_subject.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the Subject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt_body.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the Content!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MailMessage msg = new MailMessage
                {
                    From = new MailAddress("ak2.industries.pvt.ltd@gmail.com")
                };
                msg.To.Add(txt_email.Text);
                msg.Subject = txt_subject.Text;
                msg.Body = txt_body.Text;
                SmtpClient smt = new SmtpClient
                {
                    Host = "smtp.gmail.com"
                };
                System.Net.NetworkCredential ntcd = new NetworkCredential
                {
                    UserName = "ak2.industries.pvt.ltd@gmail.com",
                    Password = "kjukzicspqdnmmqn"
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
                    MessageBox.Show("Mail sent Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Data Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_email.Clear();
            txt_subject.Clear();
            txt_body.Clear();
        }
    }
}
