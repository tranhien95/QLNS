using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLNS.Utilities
{
    class ConfigReader
    {
        #region Get
        public string GetServerName()
        {
            string severName = ConfigurationManager.AppSettings["Server"];
            return severName;
        }
        public string GetPassWord()
        {
            string passWord = ConfigurationManager.AppSettings["PassWord"];
            return passWord;
        }
        public string GetDatabaseName()
        {
            string DatabaseName = ConfigurationManager.AppSettings["Database"];
            return DatabaseName;
        }
        public string GetUserName()
        {
            string User = ConfigurationManager.AppSettings["User"];
            return User;
        }

        public int GetOption()
        {
            int Option = int.Parse(ConfigurationManager.AppSettings["Option"]);
            return Option;
        }
        #endregion

        #region Edit
        public void SetServerName(String ServerName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Server"].Value = ServerName;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void SetPassWord(String PassWord)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["PassWord"].Value = PassWord;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void SetDatabaseName(String DatabaseName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Database"].Value = DatabaseName;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void SetUsereName(String User)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["User"].Value = User;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void SetOption(String Option)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Option"].Value = Option;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        #endregion
    }
}
