using Google.Protobuf;
using System;
using System.Globalization;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Materials_IN : Form
    {
        [Obsolete]
        public Materials_IN()
        {
            InitializeComponent();
        }
        readonly DBConnection db = new DBConnection();
        private void Materials_IN_Load(object sender, EventArgs e)
        {
            Pro_Load();
            guna2DateTimePicker1.Text = DateTime.Today.ToString();

            try
            {
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand("SELECT DISTINCT Material FROM Materials", db.con);
                db.dr = db.cmd.ExecuteReader();
                while (db.dr.Read())
                {
                    cmb_material.Items.Add(db.dr["Material"]);

                }
                db.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_material.SelectedItem == null)
            {
                MessageBox.Show("Please Select Material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmb_mcategory.SelectedItem == null)
            {
                MessageBox.Show("Please Select Material Category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmb_unit.SelectedItem == null)
            {
                MessageBox.Show("Please Select Unit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand("Insert into Materials_IN values('" + guna2DateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + cmb_material.Text + "','" + cmb_mcategory.Text + "','" + cmb_unit.Text + "','" + txt_quantity.Text + "')", db.con);
                int i = db.cmd.ExecuteNonQuery();
                db.con.Close();
                if (i == 1)
                {
                    MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pro_Load();

                }
                else
                {
                    MessageBox.Show("Save Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            db.con.Open();
            db.cmd = new System.Data.SQLite.SQLiteCommand("select * from Stock where Material_Category='" + cmb_mcategory.Text + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                db.dr.Close();
                db.cmd = new System.Data.SQLite.SQLiteCommand("update Stock set Avilable_Quantity=Avilable_Quantity+'" + txt_quantity.Text + "' where Material_Category='" + cmb_mcategory.Text + "'", db.con);
                db.cmd.ExecuteNonQuery();
            }
            else
            {
                try
                {
                    db.dr.Close();
                    db.cmd = new System.Data.SQLite.SQLiteCommand("insert into Stock(Material,Material_Category,Unit,Avilable_Quantity) values ('" + cmb_material.Text + "','" + cmb_mcategory.Text + "','" + cmb_unit.Text + "','" + txt_quantity.Text + "')", db.con);
                    db.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
            db.con.Close();
        }
        public void Pro_Load()
        {
            bunifuDataGridView2.DataSource = db.GetData("Select Date,Material,Material_Category,Unit,Quantity from Materials_IN");
        }

        private void Txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("This Field Cannot Contain Letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantity.Focus();

                return;

            }
        }

        private void Cmb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.cmd = new System.Data.SQLite.SQLiteCommand("SELECT Material_Category FROM Materials WHERE Material ='" + cmb_material.Text + "'", db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            cmb_mcategory.Items.Clear();
            while (db.dr.Read())
            {
                cmb_mcategory.Items.Add(db.dr["Material_Category"]);
            }
            db.con.Close();
        }

        private void Guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bs = new BindingSource
            {
                DataSource = bunifuDataGridView2.DataSource,
                Filter = "Material like '%" + guna2TextBox1.Text + "%'"
            };
            bunifuDataGridView2.DataSource = bs.DataSource;
        }

        private void BunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Assuming "Date" is the name of the column containing dates
                if (bunifuDataGridView2.Columns[e.ColumnIndex].Name == "Date")
                {
                    var cellValue = bunifuDataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (cellValue != null)
                    {
                        // Define the expected date format here
                        string dateFormat = "MM/dd/yyyy"; // Adjust this format based on your date string

                        if (DateTime.TryParseExact(cellValue.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime selectedDate))
                        {
                            guna2DateTimePicker1.Value = selectedDate;
                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        
                    }
                }
            }


            UpdateOtherControls();
        }

        private void UpdateOtherControls()
        {
            cmb_material.Text = bunifuDataGridView2.CurrentRow.Cells["Material"].Value.ToString();
            cmb_mcategory.Text = bunifuDataGridView2.CurrentRow.Cells["Material_Category"].Value.ToString();
            cmb_unit.Text = bunifuDataGridView2.CurrentRow.Cells["Unit"].Value.ToString();
            txt_quantity.Text = bunifuDataGridView2.CurrentRow.Cells["Quantity"].Value.ToString();
        }
    }
}

        
    
    

