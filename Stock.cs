using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Stock : Form
    {
        [Obsolete]
        public Stock()
        {
            InitializeComponent();
        }
        readonly DBConnection db = new DBConnection();
        public void Pro_Load()
        {
            bunifuDataGridView2.DataSource = db.GetData("Select Material,Material_Category AS [Material Category],Unit,Avilable_Quantity AS [Available Quantity] from Stock");

            var col = new DataGridViewMergedTextBoxColumn();

            const string field = "Material";

            col.HeaderText = field;
            col.Name = field;
            col.DataPropertyName = field;

            int colidx = bunifuDataGridView2.Columns[field].Index;
            bunifuDataGridView2.Columns.Remove(field);
            bunifuDataGridView2.Columns.Insert(colidx, col);
        }
        
        private void Txt_availableQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindingSource bs = new BindingSource
            {
                DataSource = bunifuDataGridView2.DataSource,
                Filter = "Material like '%" + txt_search.Text + "%'"
            };
            bunifuDataGridView2.DataSource = bs.DataSource;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            Pro_Load();
        }
    }
}
