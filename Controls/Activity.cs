using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikkTakk2013.Controls
{
    public partial class Activity : UserControl
    {
        private DateTime _value;
        private Stopwatch timeElapsed;

        #region Constructor
        public Activity()
        {
            InitializeComponent();
            timeElapsed = new Stopwatch();
            //txt.Text = timeElapsed.Elapsed.ToString();
        }
        #endregion

        #region Events
        public event EventHandler StartEvent;
        public event EventHandler StopEvent;
        public event EventHandler SavedEvent;
        public event EventHandler FailedEvent;

        protected virtual void Start(EventArgs e)
        {
            EventHandler handler = StartEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void Stop(EventArgs e)
        {
            EventHandler handler = StopEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void Saved(EventArgs e)
        {
            EventHandler handler = SavedEvent;
            if (handler != null)
                handler(this, e);
        }

        protected virtual void Failed(EventArgs e)
        {
            EventHandler handler = FailedEvent;
            if (handler != null)
                handler(this, e);
        }
        #endregion

        #region Properties
        public int ActivityId { get; set; }
        public int ListId { get; set; }
        public string ActivityName
        {
            get { return btn.Text; }
            set
            {
                btn.Text = value;
                Name = value;
            }
        }

        public bool IsRunning { get; set; }

        public DateTime Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Public Methods
        public void Init()
        {
            _value = new DateTime(2000, 1, 1);
            ReadData();
            time.Value = _value;
        }

        public void Save()
        {
            SaveData();
        }

        public void Start()
        {
            timeElapsed.Start();
            tmr.Enabled = true;
            btn.BackColor = Color.LawnGreen;
            IsRunning = true;
            Start(EventArgs.Empty);
        }

        public void Stop()
        {
            timeElapsed.Stop();
            tmr.Enabled = false;
            SetBackgroundColor();
            SaveData();
            IsRunning = false;
            Stop(EventArgs.Empty);
        }
        #endregion

        #region Private Methods
        private void SetBackgroundColor()
        {
            if (Value.ToLongTimeString() != new DateTime().ToLongTimeString())
                btn.BackColor = Color.Aquamarine;
            else
                btn.BackColor = SystemColors.ButtonFace;
            if (timeElapsed.IsRunning)
                btn.BackColor = Color.LawnGreen;
        }

        private void ReadData()
        {
            string sql = "SELECT IdActivityList, Time FROM tblActivityList WHERE IdActivity = @ActivityId AND Date = @Date";
            SqlCommand cmd = new SqlCommand(sql, Common.Conn);
            cmd.Parameters.AddWithValue("@ActivityId", ActivityId);
            cmd.Parameters.AddWithValue("@Date", DateTime.Today);
            if (Common.Conn.State != ConnectionState.Open)
                Common.Conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ListId = reader.GetInt32(0);
                if (!reader.IsDBNull(1)) 
                    _value = reader.GetDateTime(1);
            }
            reader.Close();
            Common.Conn.Close();
            SetBackgroundColor();
        }

        private void SaveData()
        {
            bool succes = false;
            if (Value.ToLongTimeString() == new DateTime().ToLongTimeString())
            {
                if (ListId > 0)
                {
                    string sql = "DELETE FROM tblActivityList WHERE ActivityId = @IdActivityList";
                    SqlCommand cmd = new SqlCommand(sql, Common.Conn);
                    cmd.Parameters.AddWithValue("@IdActivityList", ListId);
                    succes = Functions.RunCmd(cmd);
                }
            }
            else
            {
                if (ListId > 0)
                {
                    string sql = "UPDATE tblActivityList SET IdActivity = @IdActivity, UserName = @UserName, time = @time, Date = @date WHERE IdActivityList = @IdActivityList";
                    SqlCommand cmd = new SqlCommand(sql, Common.Conn);
                    cmd.Parameters.AddWithValue("@IdActivity", ActivityId);
                    cmd.Parameters.AddWithValue("@UserName", Environment.UserName);
                    cmd.Parameters.AddWithValue("@time", Value);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                    cmd.Parameters.AddWithValue("@IdActivityList", ListId);
                    succes = Functions.RunCmd(cmd);
                }
                else
                {
                    string sql = "INSERT INTO tblActivityList (IdActivity, UserName, time, Date) VALUES (@IdActivity, @UserName, @time, @Date)";
                    SqlCommand cmd = new SqlCommand(sql, Common.Conn);
                    cmd.Parameters.AddWithValue("@IdActivity", ActivityId);
                    cmd.Parameters.AddWithValue("@UserName", Environment.UserName);
                    cmd.Parameters.AddWithValue("@time", Value);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                    succes = Functions.RunCmd(cmd);
                }
            }

            if (succes)
            {
                ReadData();
                Saved(EventArgs.Empty);
            }
            else
            {
                Failed(EventArgs.Empty);
            }
        }

        #endregion

        private void tmr_Tick(object sender, EventArgs e)
        {
            Value = time.Value.AddMilliseconds(timeElapsed.ElapsedMilliseconds);
            time.Value = time.Value.AddMilliseconds(timeElapsed.ElapsedMilliseconds);
            timeElapsed.Restart();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (timeElapsed.IsRunning)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }

        private void time_ValueChanged(object sender, EventArgs e)
        {
            Value = time.Value;
        }

    }
}
