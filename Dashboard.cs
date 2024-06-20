using System;
using System.Windows.Forms;


namespace Inventory_System
{
    public partial class Dashboard : Form
    {
        [System.Obsolete]
        public Dashboard()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        private void OpenChildForm(Form ChildForm)
        {
            activeform?.Close();
            activeform = ChildForm;
            ChildForm.TopLevel = false;
            guna2Panel2.Controls.Add(ChildForm);
            guna2Panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        [Obsolete]
        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(new DashboardItems());
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        [Obsolete]
        private void Btn_addmaterials_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new AddMaterials());
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        [Obsolete]
        private void Btn_materialsIN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Materials_IN());
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        [Obsolete]
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        [Obsolete]
        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardItems());
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        [Obsolete]
        private void Btn_materialsOUT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Materials_OUT());
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        [Obsolete]
        private void Btn_finalstock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stock());
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
