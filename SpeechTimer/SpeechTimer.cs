using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechTimer
{
    public enum FormLocation
    {
        LEFT_TOP=1,
        RIGHT_TOP=2,
        LEFT_BOTTOM=3,
        RIGHT_BOTTOM=4,
        CENTER=5,
        DEFAULT= RIGHT_BOTTOM
    }
    public partial class SpeechTimer : Form
    {
        public SpeechTimer()
        {
            InitializeComponent();
        }

        #region Enable Drag Move
        //private const int WM_NCHITTEST = 0x84;
        //private const int HT_CLIENT = 0x1;
        //private const int HT_CAPTION = 0x2;
        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg == WM_NCHITTEST)
        //    {
        //        m.Result = (IntPtr)(HT_CAPTION);
        //    }
        //}
        // This adds the event handler for the control
        private void AddDrag(Control Control) { Control.MouseDown += new MouseEventHandler(this.SpeechTimer_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void SpeechTimer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
        #endregion

        private void SpeechTimer_Load(object sender, EventArgs e)
        {
            Height = 215;
            lbMinLeft.ForeColor = lbDot.ForeColor = lbSecLeft.ForeColor = Color.DarkBlue;
            AddDrag(this);
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            InitTimer();
            MaximizeBox = false;
            MinimizeBox = false;
            var locationV = Properties.Settings.Default.WindowLocation;
            var location = (FormLocation)locationV;
            switch (location)
            {
                case FormLocation.LEFT_TOP:
                    rbLT.Checked = true;
                    break;
                case FormLocation.RIGHT_TOP:
                    rbRT.Checked = true;
                    break;
                case FormLocation.LEFT_BOTTOM:
                    rbLB.Checked = true;
                    break;
                case FormLocation.RIGHT_BOTTOM:
                    rbRB.Checked = true;
                    break;
                case FormLocation.CENTER:
                    rbCEN.Checked = true;
                    break;
                default:
                    location = FormLocation.RIGHT_BOTTOM;
                    rbRB.Checked = true;
                    break;
            }
            ReLocation(location);
            var topV = Properties.Settings.Default.TopMost;
            cbTopMost.Checked = topV;

            alarmSec = Properties.Settings.Default.AlarmSec;
            if (alarmSec<= 0){
                alarmSec = 60;
            }
            txtAlarmSec.Text = $"{alarmSec}";
        }
        private System.Timers.Timer timer = new System.Timers.Timer();
        private int totalSecend;
        private void InitTimer()
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        private int alarmSec = 60;
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            totalSecend--;
            int leftMin = totalSecend / 60;
            int leftSec=totalSecend% 60;
            this.BeginInvoke((Action)delegate{ 
                if (totalSecend <= alarmSec)
                {
                    lbMinLeft.ForeColor=lbDot.ForeColor = lbSecLeft.ForeColor= Color.Red;
                }
                lbMinLeft.Text= $"{leftMin}".PadLeft(2, '0');
                lbSecLeft.Text= $"{leftSec}".PadLeft(2, '0');
                if (totalSecend == 0)
                {
                    btnStop.Enabled = false;
                    btnStart.Enabled = true;
                }
            });
            if (totalSecend == 0)
            {
                timer.Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbMinLeft.ForeColor = lbDot.ForeColor = lbSecLeft.ForeColor = Color.DarkBlue;
            int time = GetTimeSetted();
            if (time <= 0){
                MessageBox.Show("选择或请输入时间", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            totalSecend = time * 60;
            timer.Start();
            lbMinLeft.Text = $"{time}".PadLeft(2,'0');
            lbSecLeft.Text = "00";
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            ShowHideOptions(false);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            totalSecend = 0;
            timer.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }
        private int GetTimeSetted()
        {
            if (!string.IsNullOrWhiteSpace(txtTimeInput.Text))
            {
                if (int.TryParse(txtTimeInput.Text, out int time))
                {
                    return time;
                }
            }else
            {
                if (rb5Min.Checked)
                {
                    return 5;
                }
                if (rb10Min.Checked)
                {
                    return 10;
                }
                if (rb15Min.Checked)
                {
                    return 15;
                }
                if (rb20Min.Checked)
                {
                    return 20;
                }
            }
            return 0;
        }

        private void txtTimeInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTimeInput.Text))
            {
                rb5Min.Checked = rb10Min.Checked = rb15Min.Checked = rb20Min.Checked = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ReLocation(FormLocation location)
        {
            switch (location)
            {
                case FormLocation.LEFT_TOP:
                    Top = 0;
                    Left = 0;
                    break;
                case FormLocation.RIGHT_TOP:
                    Top = 0;
                    Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
                    break;
                case FormLocation.LEFT_BOTTOM:
                    Top = Screen.PrimaryScreen.WorkingArea.Height - Height;
                    Left = 0;
                    break;
                case FormLocation.RIGHT_BOTTOM:
                    Top = Screen.PrimaryScreen.WorkingArea.Height - Height;
                    Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
                    break;
                case FormLocation.CENTER:
                    Top = (Screen.PrimaryScreen.WorkingArea.Height - Height)/2;
                    Left = (Screen.PrimaryScreen.WorkingArea.Width - Width)/2;
                    break;
            }
            Properties.Settings.Default.WindowLocation = (int)location;
            Properties.Settings.Default.Save();
            currentLocation = location;
        }
        private FormLocation currentLocation;
        private void rbLocation_CheckedChanged(object sender, EventArgs e)
        {
            var btn = sender as RadioButton;
            if (btn == null){ return; }
            FormLocation loc=0;
            if (btn == rbLT)
            {
                loc = FormLocation.LEFT_TOP;
            }
            else if (btn == rbRT)
            {
                loc = FormLocation.RIGHT_TOP;
            }
            else if (btn == rbLB)
            {
                loc = FormLocation.LEFT_BOTTOM;
            }
            else if (btn == rbRB)
            {
                loc = FormLocation.RIGHT_BOTTOM;
            }
            else if (btn == rbCEN)
            {
                loc = FormLocation.CENTER;
            }
            ReLocation(loc);
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            bool top = cbTopMost.Checked;
            IntPtr hDeskTop = Win32Support.FindWindow(null, "SpeechTimer");
            if (hDeskTop == null || hDeskTop == IntPtr.Zero)
            {
                return;
            }
            if (top)
            {
                Win32Support.SetWindowPos(hDeskTop, Win32Support.HWND_TOPMOST, 1, 1, 1, 1, Win32Support.SWP_NOMOVE | Win32Support.SWP_NOSIZE);
            }
            else
            {
                Win32Support.SetWindowPos(hDeskTop, Win32Support.HWND_NOTOPMOST, 1, 1, 1, 1, Win32Support.SWP_NOMOVE | Win32Support.SWP_NOSIZE);
            }
            Properties.Settings.Default.TopMost = top;
            Properties.Settings.Default.Save();
        }

        private void txtAlarmSec_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAlarmSec.Text))
            {
                if (!int.TryParse(txtAlarmSec.Text,out int alarmSet))
                {
                    MessageBox.Show("预警时间格式不正确,请输入数字", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                alarmSec = alarmSet;
                Properties.Settings.Default.AlarmSec = alarmSec;
                Properties.Settings.Default.Save();
            }
        }
        private bool optionsVisible = false;
        private void lbOptions_Click(object sender, EventArgs e)
        {
            ShowHideOptions(!optionsVisible);
        }
        private void ShowHideOptions(bool show)
        {
            optionsVisible = show;
            if (show)
            {
                Height = 300;
            }
            else
            {
                Height = 215;
            }
            ReLocation(currentLocation);
        }
    }
}
