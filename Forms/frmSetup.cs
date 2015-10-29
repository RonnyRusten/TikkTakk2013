using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TikkTakk2013.Classes;

namespace TikkTakk2013
{
    public partial class frmSetup : Form
    {
        private Settings settings;
        public frmSetup()
        {
            InitializeComponent();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            settings = frmMain.MySettings;
            //txtServer.Text = Common.GetRegistryKey("DbServer");
            //txtUserName.Text = Common.GetRegistryKey("DbUserName");
            //txtPassword.Text = Common.GetRegistryKey("DbPassword");
            txtServer.Text = settings.DatabaseServer;
            txtDatabaseName.Text = settings.DatabaseName;
            txtUserName.Text = settings.DatabaseUserName;
            txtPassword.Text = settings.DatabasePassword;
            chkTopmost.Checked = settings.AlwaysOnTop;
            TopMost = chkTopmost.Checked;
            tbOpacity.Value = settings.Opacity;
            lblOpacity.Text = "Opacity: " + tbOpacity.Value +" %";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            settings.DatabaseServer = txtServer.Text;
            settings.DatabaseName = txtDatabaseName.Text;
            settings.DatabaseUserName = txtUserName.Text;
            settings.DatabasePassword = txtPassword.Text;
            settings.AlwaysOnTop = chkTopmost.Checked;
            settings.Opacity = tbOpacity.Value;
            frmMain.MySettings = settings;
            frmMain.MySettings.WriteSettings();

            //Common.SetRegistryKey("DbServer",txtServer.Text);
            //Common.SetRegistryKey("DbUserName", txtUserName.Text);
            //Common.SetRegistryKey("DbPassword", txtPassword.Text);
            //if (settings != null)
            //{
            //    settings.AlwaysOnTop = chkTopmost.Checked;
            //    settings.Opacity = tbOpacity.Value;
            //    if (Common.Conn.State != ConnectionState.Open)
            //    {
            //        Common.Conn.Open();
                    
            //    }
            //    string sql = "UPDATE tblSettings SET BooleanValue = @OnTop WHERE Name = 'AlwaysOnTop'";
            //    SqlCommand cmd = new SqlCommand(sql, Common.Conn);
            //    cmd.Parameters.AddWithValue("@OnTop", chkTopmost.Checked);
            //    cmd.ExecuteNonQuery();
            //    sql= "UPDATE tblSettings SET NumericValue = @Opacity WHERE Name = 'Opacity'";
            //    cmd = new SqlCommand(sql, Common.Conn);
            //    cmd.Parameters.AddWithValue("@Opacity", tbOpacity.Value);
            //    cmd.ExecuteNonQuery();
            //    Common.Conn.Close();
            //    frmMain.MySettings = settings;
            //}
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbOpacity_Scroll(object sender, EventArgs e)
        {
            lblOpacity.Text = "Opacity: " + tbOpacity.Value + " %";
        }
    }
}
