namespace SimpleClock2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelAlert);
            this.tabPage1.Controls.Add(this.btnSetAlert);
            this.tabPage1.Controls.Add(this.cmbMin);
            this.tabPage1.Controls.Add(this.cmbHour);
            this.tabPage1.Controls.Add(this.txtWeekDay);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時鐘";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.Location = new System.Drawing.Point(653, 245);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAlert.TabIndex = 6;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = true;
            this.btnCancelAlert.Click += new System.EventHandler(this.btnCancelAlert_Click);
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Location = new System.Drawing.Point(517, 246);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(75, 23);
            this.btnSetAlert.TabIndex = 5;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            this.btnSetAlert.Click += new System.EventHandler(this.btnSetAlert_Click);
            // 
            // cmbMin
            // 
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(215, 246);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(150, 23);
            this.cmbMin.TabIndex = 4;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(7, 246);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(140, 23);
            this.cmbHour.TabIndex = 3;
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWeekDay.Location = new System.Drawing.Point(517, 156);
            this.txtWeekDay.Multiline = true;
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(211, 55);
            this.txtWeekDay.TabIndex = 2;
            this.txtWeekDay.Text = "星期二";
            this.txtWeekDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(7, 156);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(358, 55);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "2024-07-02";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(6, 6);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(759, 133);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "16:40:35";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.btnLog);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPause);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.listStopWatchLog);
            this.tabPage2.Controls.Add(this.txtStopWatch);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "碼表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "倒數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_tick);
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStopWatch.Location = new System.Drawing.Point(-4, 3);
            this.txtStopWatch.Multiline = true;
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.Size = new System.Drawing.Size(766, 144);
            this.txtStopWatch.TabIndex = 0;
            this.txtStopWatch.Text = "00:00:00:000";
            this.txtStopWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 15;
            this.listStopWatchLog.Location = new System.Drawing.Point(0, 153);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(170, 229);
            this.listStopWatchLog.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(176, 153);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(297, 153);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(115, 43);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(176, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 43);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(297, 220);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(115, 43);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "紀錄";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(176, 283);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(236, 43);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止並歸零";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "簡單時鐘";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Timer timerStopWatch;
    }
}

