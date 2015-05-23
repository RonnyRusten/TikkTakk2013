using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TikkTakk2013
{
    public class Common
    {
        public static String str_ProductName = "TikkTakk 2015";
        public static String str_Company = "RuSoft";
        public static String StrDbPath;
        public static string StrConnetion;
        public static SqlConnection Conn;

        public static bool DbConnect()
        {
            //String connString;
            //if (Common.Conn == null)
            //{
            //    connString = "Data Source=" + Common.StrDbPath;
            //    Common.Conn = new System.Data.SqlServerCe.SqlCeConnection(connString);
            //}
            string dbServer = "rru-w8";
            StrConnetion = "Server=" + dbServer + "; Database=TikkTakk; User Id=sa; Password=Doelle01;";
            Conn = new SqlConnection(StrConnetion);
            try
            {
                Conn.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection failed!" + ex.Message);
                return false;
            }
        }

        public static Int32 GetPositionSize(String frmName, String KeyName)
        {
            Microsoft.Win32.RegistryKey MainKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey ParentKey = MainKey.CreateSubKey(str_Company);
            Microsoft.Win32.RegistryKey AppKey = ParentKey.CreateSubKey(str_ProductName);
            Microsoft.Win32.RegistryKey frmKey = AppKey.CreateSubKey(frmName);
            return Convert.ToInt32(frmKey.GetValue(KeyName, 0));
        }

        public static void SetPositionSize(String frmName, String keyName, String keyValue)
        {
            Microsoft.Win32.RegistryKey mainKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey parentKey = mainKey.CreateSubKey(str_Company);
            Microsoft.Win32.RegistryKey appKey = parentKey.CreateSubKey(str_ProductName);
            Microsoft.Win32.RegistryKey frmKey = appKey.CreateSubKey(frmName);
            frmKey.SetValue(keyName, keyValue);
        }

        public static String GetRegistryKey(string keyName, string defaultValue = "")
        {
            Microsoft.Win32.RegistryKey MainKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey ParentKey = MainKey.CreateSubKey(str_Company);
            Microsoft.Win32.RegistryKey AppKey = ParentKey.CreateSubKey(str_ProductName);
            String retVal = (String)AppKey.GetValue(keyName, "");
            //return Convert.ToInt16(AppKey.GetValue(keyName, -1));
            if (retVal == "")
            {
                return defaultValue;
            }
            return retVal;
        }

        public static void SetRegistryKey(string keyName, string keyValue)
        {
            Microsoft.Win32.RegistryKey mainKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey parentKey = mainKey.CreateSubKey(str_Company);
            Microsoft.Win32.RegistryKey appKey = parentKey.CreateSubKey(str_ProductName);
            appKey.SetValue(keyName, keyValue);
        }

        public static Boolean WindowSizePos(string formName, ref int Left, ref int Top, ref int Width, ref int Height)
        {
            int tmpLeft, tmpTop, tmpWidth, tmpHeight;
            Boolean Offscreen = false;

            tmpLeft = GetPositionSize(formName, "WindowX");
            tmpTop = GetPositionSize(formName, "WindowY");
            tmpWidth = GetPositionSize(formName, "WindowWidth");
            tmpHeight = GetPositionSize(formName, "WindowHeight");

            System.Drawing.Rectangle screenSize = new System.Drawing.Rectangle();

            if (tmpWidth == 0)
                tmpWidth = 230;
            if (tmpHeight == 0)
                tmpHeight = 190;

            try
            {
                foreach (System.Windows.Forms.Screen Disp in System.Windows.Forms.Screen.AllScreens)
                {
                    screenSize.Width += Disp.Bounds.Width;
                    screenSize.Height += Disp.Bounds.Height;
                }

                if (tmpLeft >= screenSize.Width - tmpWidth) {
                    tmpLeft = screenSize.Width - tmpWidth;
                    Offscreen = true;
                }
                if (tmpLeft < 0 ) {
                    tmpLeft = 0;
                    Offscreen = true;
                }
                if (tmpTop >= screenSize.Height ) {
                    tmpTop = screenSize.Height - tmpHeight;
                    Offscreen = true;
                }
                if (tmpTop < 0 ) {
                    tmpTop = 0;
                    Offscreen = true;
                }
                if (tmpWidth > screenSize.Width ) {
                    tmpWidth = screenSize.Width;
                    tmpLeft = 0;
                }
                if (tmpHeight > screenSize.Height)
                {
                    tmpHeight = screenSize.Height;
                    tmpTop = 0;
                }
            }
            catch (Exception e)
            {
            }

            Left = tmpLeft;
            Top = tmpTop;
            Width = tmpWidth;
            Height = tmpHeight;
            return Offscreen;
        }
    }
}
