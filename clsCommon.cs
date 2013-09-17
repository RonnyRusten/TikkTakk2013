using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikkTakk2013
{
    public class clsCommon
    {
        public class clsPublic
        {
            private String str_ProductName;
            private String str_Company;

            public clsPublic()
            {
            str_ProductName = "TikkTakk 2011";
            str_Company = "RuSoft";
            }

            public Int16 getPositionSize(String frmName, String KeyName)
            {
                Microsoft.Win32.RegistryKey MainKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true);
                Microsoft.Win32.RegistryKey ParentKey = MainKey.CreateSubKey(str_Company);
                Microsoft.Win32.RegistryKey AppKey = ParentKey.CreateSubKey(str_ProductName);
                Microsoft.Win32.RegistryKey frmKey = AppKey.CreateSubKey(frmName);
                return Convert.ToInt16(frmKey.GetValue(KeyName, -1));
            }

            public Boolean WindowSizePos(string formName, ref int Left, ref int Top, ref int Width, ref int Height)
            {
                int tmpLeft, tmpTop, tmpWidth, tmpHeight;
                Boolean Offscreen = false;

                tmpLeft = getPositionSize(formName, "WindowX");
                tmpTop = getPositionSize(formName, "WindowY");
                tmpWidth = getPositionSize(formName, "WindowWidth");
                tmpHeight = getPositionSize(formName, "WindowHeight");

                System.Drawing.Rectangle ScreenSize = new System.Drawing.Rectangle();

                if (tmpWidth == 0)
                {
                    tmpWidth = 230;
                }
                try
                {
                    foreach (System.Windows.Forms.Screen Disp in System.Windows.Forms.Screen.AllScreens)
                    {
                        ScreenSize.Width += Disp.Bounds.Width;
                        ScreenSize.Height += Disp.Bounds.Height;
                    }

                    if (tmpLeft >= ScreenSize.Width - tmpWidth) {
                        tmpLeft = ScreenSize.Width - tmpWidth;
                        Offscreen = true;
                    }
                    if (tmpLeft < 0 ) {
                        tmpLeft = 0;
                        Offscreen = true;
                    }
                    if (tmpTop >= ScreenSize.Height ) {
                        tmpTop = ScreenSize.Height - tmpHeight;
                        Offscreen = true;
                    }
                    if (tmpTop < 0 ) {
                        tmpTop = 0;
                        Offscreen = true;
                    }
                    if (tmpWidth > ScreenSize.Width ) {
                        tmpWidth = ScreenSize.Width;
                        tmpLeft = 0;
                    }
                    if (tmpHeight > ScreenSize.Height)
                    {
                        tmpHeight = ScreenSize.Height;
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
}
