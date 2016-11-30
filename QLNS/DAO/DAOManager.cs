using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace QLNS.DAO
{
    class DAOManager
    {
        public ConfigReader config { get; private set; }
        public String ConnectionString { get; private set; }
        public SqlConnection conn { get; private set; }

        public DAOManager()
        {
            config = new ConfigReader();
            conn = new SqlConnection();
            SetConnection();
        }
        
        public void SetConnectionStringWinAuth()
        {
            String Server = config.GetServerName();
            String DatabaseName = config.GetDatabaseName();
            ConnectionString = @"Server=" + Server + "; Database=" + DatabaseName + "; Trusted_Connection=Yes;";
            conn.ConnectionString = ConnectionString;
        }
        public void SetConnectionStringSQLAuth()
        {
            String Server = config.GetServerName();
            String DatabaseName = config.GetDatabaseName();
            String PassWord = config.GetPassWord();
            String UserId = config.GetUserName();
            ConnectionString = @"Server=" + Server + "; Database=" + DatabaseName + "; User Id=" + UserId + "; Password=" + PassWord;
            conn.ConnectionString = ConnectionString;
        }

        public void SetConnection()
        {
            if (config.GetOption() == 0)
            {
                SetConnectionStringWinAuth();
            }
            else
            {
                SetConnectionStringSQLAuth();
            }
        }

        public void OpenConn()
        {
            if(conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
