using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Projekt_Fight_Game
{
    public sealed class SingletonDB
    {
        private static SingletonDB dbInstance = null;
        private static readonly object padlock = new object();
        private string conString = (@"Data Source=LAPTOP-EQLFMT99\SQLEXPRESS;Initial Catalog=DBFightGame;Integrated Security=True");

        private SingletonDB()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Conn = new SqlConnection(conString))
            {
                Conn.Open();
                if (Conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("connected");

                }

                string sql = "SELECT * FROM tblUser";

                using (SqlCommand cmd = new SqlCommand(sql, Conn))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);


                }
            }

        }

        public static SingletonDB Instance
        {
            get
            {
                if (dbInstance == null)
                {
                    lock (padlock)
                    {
                        if (dbInstance == null)
                        {
                            dbInstance = new SingletonDB();
                        }
                    }
                }
                return dbInstance;
            }
        }

    }
}
