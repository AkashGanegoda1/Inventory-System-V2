using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Materials_OUT : Form
    {
        [Obsolete]
        public Materials_OUT()
        {
            InitializeComponent();
        }
        readonly DBConnection db = new DBConnection();

        public void Pro_Load()
        {
            bunifuDataGridView2.DataSource = db.GetData("Select Date,Material,Material_Category AS [Material Category],Unit,Available_Quantity AS [Available Quantity],Quantity_Out AS [Quantity Out] from Materials_OUT");
        }

        private void Materials_OUT_Load(object sender, System.EventArgs e)
        {
            Pro_Load();
            guna2DateTimePicker1.Text = DateTime.Today.ToString();

            try
            {
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand("SELECT DISTINCT Material FROM Stock", db.con);
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

        private void Txt_quantityout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("This Field Cannot Contain Letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantityout.Focus();

                return;

            }
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
            else if (txt_quantityout.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter Quantity Out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                db.con.Open();
                db.cmd = new System.Data.SQLite.SQLiteCommand("Insert into Materials_OUT values ('" + guna2DateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm tt") + "','" + cmb_material.Text + "','" + cmb_mcategory.Text + "','" + cmb_unit.Text + "','" + txt_availableQuantity.Text + "','" + txt_quantityout.Text + "')", db.con);
                int a = db.cmd.ExecuteNonQuery();
                db.con.Close();
                Pro_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                // Open the connection if it's closed
                if (db.con.State == ConnectionState.Closed)
                {
                    db.con.Open();
                }

                // Execute the first query to read Available_Quantity
                db.cmd = new System.Data.SQLite.SQLiteCommand("SELECT Avilable_Quantity FROM Stock WHERE Material_Category = @Material_Category", db.con);
                db.cmd.Parameters.Add("@Material_Category", DbType.String, 40).Value = cmb_mcategory.Text;

                db.dr = db.cmd.ExecuteReader();

                int currentQuantity = 0;

                if (db.dr.Read())
                {
                    // Read the current Available_Quantity
                    currentQuantity = Convert.ToInt32(db.dr["Avilable_Quantity"]);
                }

                db.dr.Close(); // Close the data reader

                // Prepare and execute the update query
                db.cmd = new System.Data.SQLite.SQLiteCommand("UPDATE Stock SET Avilable_Quantity = Avilable_Quantity - @Quantity_Out WHERE Material_Category = @Material_Category", db.con);
                db.cmd.Parameters.Add("@Material_Category", DbType.String, 40).Value = cmb_mcategory.Text;
                db.cmd.Parameters.Add("@Quantity_Out", DbType.Int32).Value = int.Parse(txt_quantityout.Text);

                db.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (db.con.State == ConnectionState.Open)
                {
                    db.con.Close();
                }
            }


        }

        private void Cmb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.cmd = new System.Data.SQLite.SQLiteCommand("SELECT Material_Category FROM Stock WHERE Material ='" + cmb_material.Text + "'", db.con);
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

        private void Cmb_mcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.cmd = new System.Data.SQLite.SQLiteCommand("Select * from Stock where Material_Category='" + cmb_mcategory.Text + "'", db.con);
            db.con.Open();
            db.cmd.ExecuteNonQuery();
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                string unit = (string)db.dr["Unit"].ToString();
                cmb_unit.Text = unit;

                string quantity = (string)db.dr["Avilable_Quantity"].ToString();
                txt_availableQuantity.Text = quantity;

            }
            db.con.Close();
        }
    }
}
