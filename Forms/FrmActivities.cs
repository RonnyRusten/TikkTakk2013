using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikkTakk2013.Forms
{
    public partial class FrmActivities : Form
    {
        private Boolean _saveWindow;
        private SqlDataAdapter _activitiesAdapter;
        private DataSet _dsActivities;
        private DataSet _dsChanges;
        private DataTable _tblActivities;

        public FrmActivities()
        {
            InitializeComponent();
        }

        private void FrmActivities_Load(object sender, EventArgs e)
        {
            int formLeft = 0;
            int formTop = 0;
            int formWidth = 0;
            int formHeight = 0;
            _saveWindow = Common.WindowSizePos(Name, ref formLeft, ref formTop, ref formWidth, ref formHeight);
            Left = formLeft;
            Top = formTop;
            Width = formWidth;
            Height = formHeight;
            Opacity = Functions.Opacity();
            GetActivities();
            DefaultActivity();
        }

        private void FrmActivities_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (_saveWindow)
            {
                Common.SetPositionSize(Name, "WindowX", Left.ToString());
                Common.SetPositionSize(Name, "WindowY", Top.ToString());
                Common.SetPositionSize(Name, "WindowHeight", Height.ToString());
                Common.SetPositionSize(Name, "WindowWidth", Width.ToString());
            }
        }

        private void FrmActivities_Move(object sender, EventArgs e)
        {
            _saveWindow = true;
        }

        private void FrmActivities_Resize(object sender, EventArgs e)
        {
            _saveWindow = true;
        }

        private void dgvActivities_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow row = dgv.SelectedRows[0];
            row.Cells["UserName"].Value = Environment.UserName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            frmMain.MySettings.DefaultActivity = (cbDefaultActivity.SelectedValue == null) ? -1 : (int) cbDefaultActivity.SelectedValue;
            frmMain.MySettings.WriteSettings();
            //Common.SetRegistryKey("DefaultActivityId", (cbDefaultActivity.SelectedIndex > 0) ? cbDefaultActivity.SelectedValue.ToString() : "");
            Cleanup();
            //chkActive.Focus();
            dgvActivities.NotifyCurrentCellDirty(true);
            dgvActivities.EndEdit();
            if (dgvActivities.IsCurrentRowDirty | dgvActivities.IsCurrentCellDirty)
                dgvActivities.CommitEdit(DataGridViewDataErrorContexts.Commit);
            int n = _activitiesAdapter.Update(_tblActivities);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cleanup()
        {
            if (dgvActivities.Rows[0].Cells[1].Value == DBNull.Value || dgvActivities.Rows[0].Cells[1].Value.ToString() == "")
            {
                _tblActivities.Rows[0].Delete();
            }
        }

        private void GetActivities()
        {
            _tblActivities = new DataTable();
            _activitiesAdapter = ActivitiesAdapter();
            _activitiesAdapter.Fill(_tblActivities);
            dgvActivities.DataSource = _tblActivities;
            dgvActivities.Columns[1].HeaderText = "Aktivitetsnavn";
            dgvActivities.Columns[2].HeaderText = "I bruk";
            dgvActivities.Columns[0].Visible = false;
            dgvActivities.Columns[3].Visible = false;
            dgvActivities.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvActivities.Columns[2].Width = 50;
            DataRow newRow = _tblActivities.NewRow();
            _tblActivities.Rows.InsertAt(newRow, 0);
        }

        private SqlDataAdapter ActivitiesAdapter()
        {
            string sql = "SELECT * FROM tblActivityName WHERE UserName='" + Environment.UserName;
            if (chkActive.Checked)
                sql += "' AND InUse=1";
            else
                sql += "'";
            sql += " ORDER BY Name";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Common.Conn);

            SqlCommand cmdInsert = new SqlCommand("INSERT INTO tblActivityName ( Name, InUse, UserName) VALUES (@Name, @InUse, @UserName)", Common.Conn);
            cmdInsert.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            cmdInsert.Parameters.Add("@InUse", SqlDbType.Bit, 1, "InUse");
            cmdInsert.Parameters.Add("@UserName", SqlDbType.NVarChar, 100, "UserName");
            adapter.InsertCommand = cmdInsert;

            SqlCommand cmdUpdate = new SqlCommand("UPDATE tblActivityName SET Name = @Name, InUse = @InUse WHERE IdActivity = @IdActivity", Common.Conn);
            cmdUpdate.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            cmdUpdate.Parameters.Add("@InUse", SqlDbType.Bit, 1, "InUse");
            cmdUpdate.Parameters.Add("@IdActivity", SqlDbType.Int, 4, "IdActivity");
            adapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdDelete = new SqlCommand("DELETE FROM tblActivities WHERE IdActivity = @IdActivity", Common.Conn);
            cmdDelete.Parameters.Add("@IdActivity", SqlDbType.Int, 4, "IdActivity");
            adapter.DeleteCommand = cmdDelete;

            return adapter;
        }

        private void DefaultActivity()
        {
            string sql = "SELECT IdActivity, Name FROM tblActivityName WHERE InUse = 1 AND UserName='" + Functions.WindowsUser() + "' UNION SELECT null, null ORDER BY Name";
            DataTable tbl = Functions.GetTable(sql);
            cbDefaultActivity.DisplayMember = "Name";
            cbDefaultActivity.ValueMember = "IdActivity";
            cbDefaultActivity.DataSource = tbl;

            int defaultId = frmMain.MySettings.DefaultActivity;
            cbDefaultActivity.SelectedValue = defaultId;
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            GetActivities();
        }


    }
}
