using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikkTakk2013.Forms
{
    public partial class FrmSummary : Form
    {
        private Boolean _saveWindow;
        private string _sql;
        private DataTable _tblSummary;

        public FrmSummary()
        {
            InitializeComponent();
        }

        private void FrmSummary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_saveWindow)
            {
                Common.SetPositionSize(Name, "WindowX", Left.ToString());
                Common.SetPositionSize(Name, "WindowY", Top.ToString());
                Common.SetPositionSize(Name, "WindowHeight", Height.ToString());
                Common.SetPositionSize(Name, "WindowWidth", Width.ToString());
            }
            if (rbCustom.Checked)
            {
                frmMain.MySettings.SummaryStartDate = dtpStart.Value;
                frmMain.MySettings.SummaryEndDate = dtpEnd.Value;
                frmMain.MySettings.WriteSettings();
            }
        }

        private void FrmSummary_Move(object sender, EventArgs e)
        {
            _saveWindow = true;
        }

        private void FrmSummary_Load(object sender, EventArgs e)
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
            dtpStart.Value = frmMain.MySettings.SummaryStartDate;
            dtpEnd.Value = frmMain.MySettings.SummaryEndDate;
            _sql = "SELECT Akt.UserName, List.Date, convert(DATE, List.Date, 104) AS SortDate, Akt.Name, List.time " +
                         "from tblActivityList AS List Inner Join tblActivityName AS Akt on List.IdActivity = Akt.IdActivity " +
                         "WHERE Akt.UserName='" + Functions.WindowsUser() + "' ORDER BY Date DESC, List.Time DESC";
            _tblSummary = Functions.GetTable(_sql);
            dgvSummary.DataSource = _tblSummary;
            ConfigGrid();
            rbToday.Checked = true;
        }

        private void ConfigGrid()
        {
            dgvSummary.AutoGenerateColumns = true;
            if (dgvSummary.ColumnCount > 0)
            {
                dgvSummary.Columns[2].Visible = false;
                dgvSummary.Columns[0].HeaderText = "Bruker";
                dgvSummary.Columns[1].HeaderText = "Dato";
                dgvSummary.Columns[3].HeaderText = "Aktivitetsnavn";
                dgvSummary.Columns[3].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
                dgvSummary.Columns[4].HeaderText = "Tid";
                DataGridViewCellStyle cellStyle=new DataGridViewCellStyle();
                cellStyle.Format = "T";
                dgvSummary.Columns[4].DefaultCellStyle = cellStyle;
            }
        }


        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToday.Checked)
            {
                string rowFilter = "Date = #" + DateTime.Now.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "#";
                DataView dv = new DataView(_tblSummary);
                dv.RowFilter = rowFilter;
                dgvSummary.DataSource = dv;
            }
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeek.Checked)
            {
                int today = (int)DateTime.Now.DayOfWeek;
                DateTime dateStart = DateTime.Today.AddDays(-(today - 1));
                DateTime dateEnd = dateStart.AddDays(6);
                DataView dv = new DataView(_tblSummary);
                string rowFilter = "Date >= #" + dateStart.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "# AND Date <= #"+ dateEnd.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "#";
                dv.RowFilter = rowFilter;
                dgvSummary.DataSource = dv;
            }
        }

        private void rbLastWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLastWeek.Checked)
            {
                int today = (int)DateTime.Now.DayOfWeek;
                DateTime dateStart = DateTime.Today.AddDays(-(today - 1+7));
                DateTime dateEnd = dateStart.AddDays(6);
                DataView dv = new DataView(_tblSummary);
                string rowFilter = "Date >= #" + dateStart.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "# AND Date <= #" + dateEnd.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "#";
                dv.RowFilter = rowFilter;
                dgvSummary.DataSource = dv;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            dgvSummary.DataSource = _tblSummary;
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom.Enabled = rbCustom.Checked;
            lblTo.Enabled = rbCustom.Checked;
            dtpStart.Enabled = rbCustom.Checked;
            dtpEnd.Enabled = rbCustom.Checked;
            if (rbCustom.Checked)
            {
                AddCustomFilter();
            }
        }

        private void AddCustomFilter()
        {
            DateTime dateStart = dtpStart.Value;
            DateTime dateEnd = dtpEnd.Value;
            int test = DateTime.Compare(dateEnd, dateStart);
            if (DateTime.Compare(dateEnd, dateStart) < 0)
            {
                dateEnd = dateStart.AddDays(6);
                dtpEnd.Value = dateEnd;
            }
            DataView dv = new DataView(_tblSummary);
            string rowFilter = "Date >= #" + dateStart.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "# AND Date <= #" +
                               dateEnd.ToString("MM/dd/yyyy 00:00:00", System.Globalization.CultureInfo.InvariantCulture) + "#";
            dv.RowFilter = rowFilter;
            dgvSummary.DataSource = dv;
        }

        private void dtpStart_CloseUp(object sender, EventArgs e)
        {
            AddCustomFilter();
        }

        private void dtpEnd_CloseUp(object sender, EventArgs e)
        {
            AddCustomFilter();
        }
    }
}
