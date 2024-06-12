using System.Data.SqlClient;
using System.Data;


namespace Inventory_System
{
    internal class DBConnection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public SqlDataReader dr;

        public DBConnection()
        {
            con = new SqlConnection("Data Source=SKYLINE-PRO\\SQLEXPRESS;Initial Catalog=INVENTORY;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataTable GetData(string a)
        {
            OpenConnection();
            da = new SqlDataAdapter(a, con);
            dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
