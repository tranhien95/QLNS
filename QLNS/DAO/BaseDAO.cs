using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLNS.DAO
{
    class BaseDAO
    {
        private DAOManager daoManager;
        private SqlCommand command;

        private void SetCommandConn()
        {
            command.Connection = daoManager.conn;
        }
       
        public BaseDAO()
        {
            daoManager    = new DAOManager();
            command       = new SqlCommand();
            SetCommandConn();
        }

        public bool Excute(SqlCommand cmd)
        {
            try
            {
                command = cmd;
                SetCommandConn();
                daoManager.OpenConn();
                command.ExecuteNonQuery();
                daoManager.CloseConn();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                daoManager.CloseConn();
                return false;
            }
        }

        public bool Insert(SqlCommand cmd)
        {
            return Excute(cmd);
        }
        public bool Update(SqlCommand cmd)
        {
            return Excute(cmd);
        }
        public bool Delete(SqlCommand cmd)
        {
            return Excute(cmd);
        }

        public DataTable GetTable(SqlCommand cmd, String TableName)
        {
            try
            {
                command = cmd;
                SetCommandConn();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, TableName);
                DataTable dt = ds.Tables[TableName];
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                daoManager.CloseConn();
                return null;
            }
        }

        public string GetMax(SqlCommand cmd, String ColumnName)
        {
            string str = "0";
            try
            {
                command = cmd;
                SetCommandConn();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count != 0)    
                    str = dt.Rows[0][ColumnName].ToString();
                return str;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                daoManager.CloseConn();
                return null;
            }

        }

        public DataTable GetNoName(SqlCommand cmd)
        {
            try
            {
                command = cmd;
                SetCommandConn();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                daoManager.CloseConn();
                return null;
            }
        }
    }
}
