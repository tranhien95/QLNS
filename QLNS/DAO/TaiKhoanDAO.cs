using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNS.DAO
{
    class TaiKhoanDAO :BaseDAO
    {
        public bool InsertAccount(TaiKhoanInfo AccInfo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Insert Into TAIKHOAN values(@ID, @PassWord, @Loai)";
                cmd.Parameters.Add("@ID", SqlDbType.Char, 20);
                cmd.Parameters.Add("@PassWord", SqlDbType.Char, 32);
                cmd.Parameters.Add("@Loai", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = AccInfo.ID;
                cmd.Parameters["@PassWord"].Value = AccInfo.Pass;
                cmd.Parameters["@Loai"].Value = AccInfo.LoaiTK;
                return Insert(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool DeleteAccount(TaiKhoanInfo AccInfo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Delete From TAIKHOAN Where ID = @ID";
                cmd.Parameters.Add("@ID", SqlDbType.Char, 20);
                cmd.Parameters["@ID"].Value = AccInfo.ID;
                return Delete(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From TAIKHOAN";
                return GetTable(cmd,"TAIKHOAN");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable GetSingle(String ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Select * From TAIKHOAN Where ID = @ID";
                cmd.Parameters.Add("@ID", SqlDbType.Char, 20);
                cmd.Parameters["@ID"].Value = ID;
                return GetTable(cmd, "TAIKHOAN");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public bool UpdateID(String OldId, String NewId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update TAIKHOAN Set ID = @IDNew Where ID = @IDOld";
                cmd.Parameters.Add("@IDNew", SqlDbType.Char, 20);
                cmd.Parameters.Add("@IDOld", SqlDbType.Char, 20);
                cmd.Parameters["@IDOld"].Value = OldId;
                cmd.Parameters["@IDNew"].Value = NewId;
                return Update(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool UpdatePassWord(String ID, String NewPass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"Update TAIKHOAN Set Pass = @NewPass Where ID = @ID";
                cmd.Parameters.Add("@ID", SqlDbType.Char, 20);
                cmd.Parameters.Add("@NewPass", SqlDbType.Char, 32);
                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters["@NewPass"].Value = NewPass;
                return Update(cmd);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
