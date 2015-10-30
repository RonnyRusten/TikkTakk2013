using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikkTakk2013.Classes
{
    public class Settings
    {
        private DataTable _tblSettings;
        private string _settingsPath;
        private string _settingsFile;

        public int DefaultActivity { get; set; }
        public DateTime SummaryStartDate { get; set; }
        public DateTime SummaryEndDate { get; set; }
        public int Opacity { get; set; }
        public bool AlwaysOnTop { get; set; }
        public string DatabaseServer { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUserName { get; set; }
        public string DatabasePassword { get; set; }

        public Settings ()
        {
            //string sql = "SELECT * FROM tblSettings";
            //SqlDataAdapter adapter = new SqlDataAdapter(sql, Common.Conn);
            //DataTable tblSettings = new DataTable();
            //adapter.Fill(tblSettings);
            //DataRow[] setting = tblSettings.Select("Name='DefaultActivity'");
            //DefaultActivity = (Convert.IsDBNull(setting[0]["NumericValue"])) ? -1 : Convert.ToInt32(setting[0]["NumericValue"]);

            //setting = tblSettings.Select("Name='Opacity'");
            //Opacity= (Convert.IsDBNull(setting[0]["NumericValue"])) ? 85 : Convert.ToInt32(setting[0]["NumericValue"]);

            //setting = tblSettings.Select("Name='AlwaysOnTop'");
            //AlwaysOnTop = (!Convert.IsDBNull(setting[0]["BooleanValue"])) && (bool)(setting[0]["BooleanValue"]);

            ReadSettings();
            
        }

        public void ReadSettings()
        {
            _tblSettings = new DataTable();
            _tblSettings.TableName = "Settings";
            _tblSettings.Columns.Add("Name");
            _tblSettings.Columns.Add("Value");

            _settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\RuSoft\\TikkTakk";
            if (!Directory.Exists(_settingsPath))
            {
                Directory.CreateDirectory(_settingsPath);
            }

            _settingsFile = System.IO.Path.Combine(_settingsPath, "Settings.xml");
            if (!File.Exists(_settingsFile))
            {
                _tblSettings.WriteXml(_settingsFile);
            }
            else
            {
                _tblSettings.ReadXml(_settingsFile);
            }
            DefaultActivity = (GetSetting("DefaultActivity") == "") ? -1 : Convert.ToInt32(GetSetting("DefaultActivity"));
            Opacity = (GetSetting("Opacity") == "") ? 95 : Convert.ToInt32(GetSetting("Opacity"));
            AlwaysOnTop = (GetSetting("AlwaysOnTop") != "") && Convert.ToBoolean(GetSetting("AlwaysOnTop"));
            SummaryStartDate = (GetSetting("SummaryStartDate") == "") ? DateTime.Today : Convert.ToDateTime(GetSetting("SummaryStartDate").Substring(0, 10).Replace(".", "/"));
            SummaryEndDate = (GetSetting("SummaryEndDate") == "") ? DateTime.Today : Convert.ToDateTime(GetSetting("SummaryEndDate").Substring(0, 10).Replace(".", "/"));
            DatabaseServer = GetSetting("DatabaseServer");
            DatabaseName = GetSetting("DatabaseName");
            DatabaseUserName = GetSetting("DatabaseUserName");
            DatabasePassword = DecryptPassword(GetSetting("DatabasePassword"));
        }

        public void WriteSettings()
        {
            SetSetting("DefaultActivity",DefaultActivity.ToString());
            SetSetting("Opacity", Opacity.ToString());
            SetSetting("AlwaysOnTop", AlwaysOnTop.ToString());
            SetSetting("SummaryStartDate", SummaryStartDate.ToString());
            SetSetting("SummaryEndDate", SummaryEndDate.ToString());
            SetSetting("DatabaseServer", DatabaseServer);
            SetSetting("DatabaseName", DatabaseName);
            SetSetting("DatabaseUserName", DatabaseUserName);
            SetSetting("DatabasePassword", EncryptPassword(DatabasePassword));

            _tblSettings.WriteXml(_settingsFile);
        }

        private string GetSetting(string name)
        {
            DataRow[] rows = _tblSettings.Select("Name='" + name + "'");
            if (rows.Count() > 0)
                return rows[0]["Value"].ToString();
            return "";
        }

        private void SetSetting(string name, string value)
        {
            DataRow[] rows = _tblSettings.Select("Name='" + name + "'");
            if (rows.Count() > 0)
                rows[0]["Value"] = value;
            else
            {
                DataRow newRow = _tblSettings.NewRow();
                newRow[0] = name;
                newRow[1] = value;
                _tblSettings.Rows.Add(newRow);
            }
        }

        private string EncryptPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            string pw = Convert.ToBase64String(passwordBytes);
            return pw;
        }

        private string DecryptPassword(string encryptedPassword)
        {
            byte[] passwordBytes = Convert.FromBase64String(encryptedPassword);
            string password = Encoding.UTF8.GetString(passwordBytes);
            return password;
        }
    }
}
