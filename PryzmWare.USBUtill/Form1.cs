using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryzmWare.USBUtill
{
    public partial class Form1 : Form
    {
        private int totalMin = 0;
        private int totalHour = 0;
        private List<string> Files = new List<string>();
        const int WM_DEVICECHANGE = 0x0219; 
        const int DBT_DEVICEARRIVAL = 0x8000;
        const int DBT_DEVICEREMOVALCOMPLETE = 0x8004;
        const int DBT_DEVTYPVOLUME = 0x00000002;
        private int total = 0;
        private bool initSet = false;
        Timer timerMin = new Timer();
        Timer TimerHour = new Timer();
        public Form1()
        {
            InitializeComponent();
            timerMin.Tick += TimerMinMinOnTick;
            timerMin.Interval = 60000;
            TimerHour.Tick += TimerHourOnTick;
            TimerHour.Interval = 60000 * 60;
        }

        private void TimerHourOnTick(object sender, EventArgs e)
        {
            txtHour.Invoke((MethodInvoker)delegate {
                txtHour.Text = "USB's Per Hour: " + totalHour;
            });
            totalHour = 0;
        }

        private void TimerMinMinOnTick(object sender, EventArgs e)
        {
            txtMin.Invoke((MethodInvoker)delegate {
                txtMin.Text = "USB's Per Minute: " + totalMin;
            });
            totalMin = 0;
            if (!initSet)
            {
                txtHour.Invoke((MethodInvoker) delegate { txtHour.Text = "USB's Per Hour: " + totalHour; });
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        public void SetVolumeLabel(string newLabel)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady && d.DriveType == DriveType.Removable)
                {
                    d.VolumeLabel = newLabel;
                }
            }
        }

        public string VolumeLabel { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Drag the files you wish to be copied into main window.", "PryzmWare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
   

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                filesList.Nodes.Add(file.Substring(file.LastIndexOf("\\")));
            }
            Files = files.ToList();
            
        }

        private void btnMapPorts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One by one insert and remove a USB stick into each port (Recommend doing in order and using a usb hub) then click 'Finish Mapping'", "PryzmWare", MessageBoxButtons.OK);
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    DEV_BROADCAST_VOLUME vol = (DEV_BROADCAST_VOLUME) Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                    if ((m.WParam.ToInt32() == DBT_DEVICEARRIVAL) && (vol.dbcv_devicetype == DBT_DEVTYPVOLUME))
                    {
                        if (chkSetDeviceLabl.Checked)
                        {
                            SetVolumeLabel(txtDeviceLabel.Text.Trim());
                        }
                        var usbControl = new USBControl(DriveMaskToLetter(vol.dbcv_unitmask).ToString(), Files);
                        usbControl.CopyFinished += UsbControlOnCopyFinished;
                        flwStatus.Controls.Add(usbControl);
                    }

                    if ((m.WParam.ToInt32() == DBT_DEVICEREMOVALCOMPLETE) && (vol.dbcv_devicetype == DBT_DEVTYPVOLUME))
                    {

                    }
                }

                base.WndProc(ref m);
            }
            catch (Exception e)
            {
                //throw (e);
            }
        }

        private object mutex = new object();

        private void UsbControlOnCopyFinished(object sender, USBControl e)
        {
            lock (mutex)
            {
            flwStatus.Invoke((MethodInvoker)delegate {
                flwStatus.Controls.Remove(e);
                ++total;
                ++totalMin;
                ++totalHour;
                label1.Text = "USB's Processed: " + total;
                if (!timerMin.Enabled)
                {
                    timerMin.Start();
                    TimerHour.Start();
                }
            });
            }
        }


        [StructLayout(LayoutKind.Sequential)] //Same layout in mem
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }

        private static char DriveMaskToLetter(int mask)
        {
            char letter;
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C
            int cnt = 0;
            int pom = mask / 2;
            while (pom != 0)    // while there is any bit set in the mask shift it right        
            {
                pom = pom / 2;
                cnt++;
            }
            if (cnt < drives.Length)
                letter = drives[cnt];
            else
                letter = '?';
            return letter;
        }

        private void txtHour_Click(object sender, EventArgs e)
        {

        }
    }
}
