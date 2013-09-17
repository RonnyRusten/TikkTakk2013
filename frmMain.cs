using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikkTakk2013
{
    public partial class frmMain : Form
    {
        TikkTakk2013.clsCommon.clsPublic commonFunctions;
        Boolean _SaveWindow;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int Left = 0;
            int Top = 0;
            int Width = 0;
            int Height = 0;
            commonFunctions = new TikkTakk2013.clsCommon.clsPublic();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            _SaveWindow = commonFunctions.WindowSizePos(this.Name, ref Left, ref Top, ref Width, ref Height);
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
