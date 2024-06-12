using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddMaterials : Form
    {
        [System.Obsolete]
        public AddMaterials()
        {
            InitializeComponent();
        }
        readonly DBConnection db = new DBConnection();
        private void AddMaterials_Load(object sender, System.EventArgs e)
        {
            Pro_Load();

            var col = new DataGridViewMergedTextBoxColumn();

            const string field = "Material";

            col.HeaderText = field;
            col.Name = field;
            col.DataPropertyName = field;

            int colidx = bunifuDataGridView2.Columns[field].Index;
            bunifuDataGridView2.Columns.Remove(field);
            bunifuDataGridView2.Columns.Insert(colidx, col);

            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        public void Pro_Load()
        {
            bunifuDataGridView2.DataSource = db.GetData("Select Material,Material_Category AS [Material Category] from Materials");
        }

        private void Btn_save_Click(object sender, System.EventArgs e)
        {
            if (txt_material.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_material_category.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Material Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.cmd = new System.Data.SqlClient.SqlCommand("Insert into Materials values('" + txt_material.Text + "','" + txt_material_category.Text + "')", db.con);
            db.con.Open();
            int i = db.cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pro_Load();
            }
            else
            {
                MessageBox.Show("Save Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.con.Close();
        }

        private void Btn_clear_Click(object sender, System.EventArgs e)
        {
            txt_material.Clear();
            txt_material_category.Clear();
        }

        private void Btn_update_Click(object sender, System.EventArgs e)
        {
            if (txt_material.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_material_category.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Material Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.con.Open();
                db.cmd = new System.Data.SqlClient.SqlCommand("Update Materials set Material_Category= '" + txt_material_category.Text + "' where Material='" + txt_material.Text + "'", db.con);
                int i = db.cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Data Updated Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pro_Load();
                }
                else
                {
                    MessageBox.Show("Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check data again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_material.Text = bunifuDataGridView2.CurrentRow.Cells["Material"].Value.ToString();
            txt_material_category.Text = bunifuDataGridView2.CurrentRow.Cells["Material Category"].Value.ToString();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_material.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_material_category.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Material Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            db.con.Open();
            db.cmd = new System.Data.SqlClient.SqlCommand("delete from Materials where Material= '" + txt_material.Text + "'", db.con);
            int i = db.cmd.ExecuteNonQuery();
            db.con.Close();
            db.cmd.Dispose();
            if (i == 1)
            {
                MessageBox.Show("Data Seleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pro_Load();
            }
            else
            {
                MessageBox.Show("Data Cannot be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
