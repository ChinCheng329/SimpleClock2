using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;           
using System.IO;
using System.Diagnostics;             

namespace SimpleClock2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboboxInitialzation();

            timerClock.Start();
        }
        List<string> hours = new List<string>();
        List<string> minutes = new List<string>();

        string strSelectTime = "";

        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;

        List<string> StopWatchLog = new List<string>();         
        Stopwatch sw = new Stopwatch();

        bool isCountDownReset = true;                           
        TimeSpan ts;

        private void comboboxInitialzation()
        {
            
            for (int i = 0; i <= 23; i++)
            {
                cmbHour.Items.Add(string.Format("{0:00}", i));
                cmbCountHour.Items.Add(string.Format("{0:00}", i));
                cmbHour.SelectedIndex = 0;
            }

            
            for (int i = 0; i <= 59; i++)
            {
                cmbMin.Items.Add(string.Format("{0:00}", i));
                cmbCountMin.Items.Add(string.Format("{0:00}", i));
                cmbCountSecond.Items.Add(string.Format("{0:00}", i));
                cmbMin.SelectedIndex = 0;
            }
            cmbHour.SelectedIndex = 0;
            cmbMin.SelectedIndex = 0;
            cmbCountHour.SelectedIndex = 0;
            cmbCountMin.SelectedIndex = 0;
            cmbCountSecond.SelectedIndex = 0;
        }


        private void timerAlert_tick(object sender, EventArgs e)
        {

            if (strSelectTime == DateTime.Now.ToString("HH:mm"))
            {
                playBeep(timerAlert);
            }
        }

        private void stopWaveOut()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void timerClock_tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtWeekDay.Text = DateTime.Now.ToString("dddd");
        }

        private void btnSetAlert_Click(object sender, EventArgs e)
        {
            timerAlert.Start(); 
            btnSetAlert.Enabled = false;
            btnCancelAlert.Enabled = true;
            strSelectTime = cmbHour.SelectedItem.ToString() + ":" + cmbMin.SelectedItem.ToString(); 
        }

        private void btnCancelAlert_Click(object sender, EventArgs e)
        {
            stopWaveOut();     
            timerAlert.Stop(); 
            btnSetAlert.Enabled = true;
            btnCancelAlert.Enabled = false;
        }

        private void timerStopWatch_tick(object sender, EventArgs e)
        {
            txtStopWatch.Text = sw.Elapsed.ToString("hh':'mm':'ss':'fff");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();
            timerStopWatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sw.Reset();
            timerStopWatch.Stop();
            txtStopWatch.Text = "00:00:00:000";
            listStopWatchLog.Items.Clear();
            StopWatchLog.Clear();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sw.Stop();
            timerStopWatch.Stop();
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            logRecord();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (sw.IsRunning)
            {
                logRecord();
                sw.Restart();
            }
            else
            {
                sw.Reset();
                txtStopWatch.Text = "00:00:00:000";
            }
        }
        private void logRecord()
        {
            listStopWatchLog.Items.Clear(); 
            StopWatchLog.Add(txtStopWatch.Text); 

            
            int i = StopWatchLog.Count;
            while (i > 0)
            {
                listStopWatchLog.Items.Add(String.Format("第 {0} 筆紀錄：{1}", i.ToString(), StopWatchLog[i - 1] + "\n"));
                i--;
            }
        }

        private void txtCountDown_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCountStart_Click(object sender, EventArgs e)
        {
            if (isCountDownReset == true)
            {
                int Hour = int.Parse(cmbCountHour.SelectedItem.ToString());
                int Min = int.Parse(cmbCountMin.SelectedItem.ToString());
                int Sec = int.Parse(cmbCountSecond.SelectedItem.ToString());
                ts = new TimeSpan(Hour, Min, Sec); // 設定倒數時間
            }
            isCountDownReset = false;
            timerCountDown.Start();
        }

        private void btnCountPause_Click(object sender, EventArgs e)
        {
            timerCountDown.Stop();
        }

        private void btnCountStop_Click(object sender, EventArgs e)
        {
            stopWaveOut(); 
            isCountDownReset = true;
            timerCountDown.Stop();
            txtCountDown.Text = "00:00:00";
            cmbCountHour.SelectedIndex = 0;
            cmbCountMin.SelectedIndex = 0;
            cmbCountSecond.SelectedIndex = 0;
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            txtCountDown.Text = ts.ToString("hh':'mm':'ss");    
            ts = ts.Subtract(TimeSpan.FromSeconds(1));          

            if (txtCountDown.Text == "00:00:00")
                playBeep(timerCountDown);
        }
        private void playBeep(System.Windows.Forms.Timer timer)
        {
            try
            {
                stopWaveOut();

                string audioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "alert.wav");

                // 使用 AudioFileReader 來讀取聲音檔
                audioFileReader = new AudioFileReader(audioFilePath);

                // 初始化 WaveOutEvent
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);

                // 播放聲音檔
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法播放聲音檔，錯誤資訊: " + ex.Message);
            }
            finally
            {
                timer.Stop(); // 停止鬧鐘計時器
            }
        }
    }
}
