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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(7, 246);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(140, 23);
            this.cmbHour.TabIndex = 3;
            // 
            // cmbMin
            // 
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(215, 246);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(150, 23);
            this.cmbMin.TabIndex = 4;
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
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_tick);
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
    }
}

