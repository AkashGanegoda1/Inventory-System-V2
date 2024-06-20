using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Reflection;



namespace Inventory_System
{
    internal class DBConnection
    {
        public SQLiteConnection con;
        public SQLiteCommand cmd;
        public SQLiteDataAdapter da;
        public DataTable dt;
        public SQLiteDataReader dr;

        public DBConnection()
        {
            string dbFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "inventory.db");
            con = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");


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
            da = new SQLiteDataAdapter(a, con);
            dt = new DataTable();
            da.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
