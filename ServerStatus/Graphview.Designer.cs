namespace ServerStatus.ServerStatus
{
    partial class FormGraphView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            panelStatus = new Panel();
            checkBoxHDstatus = new CheckBox();
            checkBoxCPUstatus2 = new CheckBox();
            checkBoxCPUstatus5 = new CheckBox();
            checkBoxCPUstatus4 = new CheckBox();
            checkBoxCPUstatus3 = new CheckBox();
            checkBoxCPUstatus1 = new CheckBox();
            checkBoxCPUstatus0 = new CheckBox();
            dat = new System.ComponentModel.BackgroundWorker();
            chartShowStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartShowStatus).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2489, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // panelStatus
            // 
            panelStatus.Controls.Add(checkBoxHDstatus);
            panelStatus.Controls.Add(checkBoxCPUstatus2);
            panelStatus.Controls.Add(checkBoxCPUstatus5);
            panelStatus.Controls.Add(checkBoxCPUstatus4);
            panelStatus.Controls.Add(checkBoxCPUstatus3);
            panelStatus.Controls.Add(checkBoxCPUstatus1);
            panelStatus.Controls.Add(checkBoxCPUstatus0);
            panelStatus.Location = new Point(2278, 27);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(211, 809);
            panelStatus.TabIndex = 1;
            panelStatus.Visible = false;
            // 
            // checkBoxHDstatus
            // 
            checkBoxHDstatus.AutoSize = true;
            checkBoxHDstatus.Checked = true;
            checkBoxHDstatus.CheckState = CheckState.Checked;
            checkBoxHDstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxHDstatus.Location = new Point(14, 265);
            checkBoxHDstatus.Name = "checkBoxHDstatus";
            checkBoxHDstatus.Size = new Size(102, 25);
            checkBoxHDstatus.TabIndex = 7;
            checkBoxHDstatus.Text = "HD status";
            checkBoxHDstatus.UseVisualStyleBackColor = true;
            checkBoxHDstatus.CheckStateChanged += checkBoxHDstatus_CheckStateChanged;
            // 
            // checkBoxCPUstatus2
            // 
            checkBoxCPUstatus2.AutoSize = true;
            checkBoxCPUstatus2.Checked = true;
            checkBoxCPUstatus2.CheckState = CheckState.Checked;
            checkBoxCPUstatus2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxCPUstatus2.Location = new Point(14, 114);
            checkBoxCPUstatus2.Name = "checkBoxCPUstatus2";
            checkBoxCPUstatus2.Size = new Size(123, 25);
            checkBoxCPUstatus2.TabIndex = 6;
            checkBoxCPUstatus2.Text = "CPU status 2";
            checkBoxCPUstatus2.UseVisualStyleBackColor = true;
            checkBoxCPUstatus2.CheckStateChanged += checkBoxCPUstatus2_CheckStateChanged;
            // 
            // checkBoxCPUstatus5
            // 
            checkBoxCPUstatus5.AutoSize = true;
            checkBoxCPUstatus5.Checked = true;
            checkBoxCPUstatus5.CheckState = CheckState.Checked;
            checkBoxCPUstatus5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxCPUstatus5.Location = new Point(14, 226);
            checkBoxCPUstatus5.Name = "checkBoxCPUstatus5";
            checkBoxCPUstatus5.Size = new Size(123, 25);
            checkBoxCPUstatus5.TabIndex = 5;
            checkBoxCPUstatus5.Text = "CPU status 5";
            checkBoxCPUstatus5.UseVisualStyleBackColor = true;
            checkBoxCPUstatus5.CheckStateChanged += checkBoxCPUstatus5_CheckStateChanged;
            // 
            // checkBoxCPUstatus4
            // 
            checkBoxCPUstatus4.AutoSize = true;
            checkBoxCPUstatus4.Checked = true;
            checkBoxCPUstatus4.CheckState = CheckState.Checked;
            checkBoxCPUstatus4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxCPUstatus4.Location = new Point(14, 186);
            checkBoxCPUstatus4.Name = "checkBoxCPUstatus4";
            checkBoxCPUstatus4.Size = new Size(123, 25);
            checkBoxCPUstatus4.TabIndex = 4;
            checkBoxCPUstatus4.Text = "CPU status 4";
            checkBoxCPUstatus4.UseVisualStyleBackColor = true;
            checkBoxCPUstatus4.CheckStateChanged += checkBoxCPUstatus4_CheckStateChanged;
            // 
            // checkBoxCPUstatus3
            // 
            checkBoxCPUstatus3.AutoSize = true;
            checkBoxCPUstatus3.Checked = true;
            checkBoxCPUstatus3.CheckState = CheckState.Checked;
            checkBoxCPUstatus3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxCPUstatus3.Location = new Point(14, 151);
            checkBoxCPUstatus3.Name = "checkBoxCPUstatus3";
            checkBoxCPUstatus3.Size = new Size(123, 25);
            checkBoxCPUstatus3.TabIndex = 3;
            checkBoxCPUstatus3.Text = "CPU status 3";
            checkBoxCPUstatus3.UseVisualStyleBackColor = true;
            checkBoxCPUstatus3.CheckStateChanged += checkBoxCPUstatus3_CheckStateChanged;
            // 
            // checkBoxCPUstatus1
            // 
            checkBoxCPUstatus1.AutoSize = true;
            checkBoxCPUstatus1.Checked = true;
            checkBoxCPUstatus1.CheckState = CheckState.Checked;
            checkBoxCPUstatus1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxCPUstatus1.Location = new Point(14, 76);
            checkBoxCPUstatus1.Name = "checkBoxCPUstatus1";
            checkBoxCPUstatus1.Size = new Size(123, 25);
            checkBoxCPUstatus1.TabIndex = 1;
            checkBoxCPUstatus1.Text = "CPU status 1";
            checkBoxCPUstatus1.UseVisualStyleBackColor = true;
            checkBoxCPUstatus1.CheckStateChanged += checkBoxCPUstatus1_CheckStateChanged;
            // 
            // checkBoxCPUstatus0
            // 
            checkBoxCPUstatus0.AutoSize = true;
            checkBoxCPUstatus0.Checked = true;
            checkBoxCPUstatus0.CheckState = CheckState.Checked;
            checkBoxCPUstatus0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxCPUstatus0.Location = new Point(14, 37);
            checkBoxCPUstatus0.Name = "checkBoxCPUstatus0";
            checkBoxCPUstatus0.Size = new Size(123, 25);
            checkBoxCPUstatus0.TabIndex = 0;
            checkBoxCPUstatus0.Text = "CPU status 0";
            checkBoxCPUstatus0.UseVisualStyleBackColor = true;
            checkBoxCPUstatus0.CheckStateChanged += checkBoxCPUstatus0_CheckStateChanged;
            // 
            // chartShowStatus
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisX.TitleFont = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisY.Title = "Temperature (°C)";
            chartArea1.AxisY.TitleFont = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.Name = "ChartArea1";
            chartShowStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartShowStatus.Legends.Add(legend1);
            chartShowStatus.Location = new Point(0, 27);
            chartShowStatus.Name = "chartShowStatus";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "CPU status 0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "CPU status 1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "CPU status 2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "CPU status 3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerSize = 8;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "CPU status 4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.MarkerSize = 8;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "CPU status 5";
            series6.YValuesPerPoint = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerSize = 8;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "HD status";
            chartShowStatus.Series.Add(series1);
            chartShowStatus.Series.Add(series2);
            chartShowStatus.Series.Add(series3);
            chartShowStatus.Series.Add(series4);
            chartShowStatus.Series.Add(series5);
            chartShowStatus.Series.Add(series6);
            chartShowStatus.Series.Add(series7);
            chartShowStatus.Size = new Size(2272, 1140);
            chartShowStatus.TabIndex = 2;
            chartShowStatus.Text = "chartStatus";
            chartShowStatus.GetToolTipText += chartShowStatus_GetToolTipText;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 1142);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2489, 28);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(174, 23);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // FormGraphView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2489, 1170);
            Controls.Add(statusStrip1);
            Controls.Add(chartShowStatus);
            Controls.Add(panelStatus);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGraphView";
            ShowIcon = false;
            Text = "Sever Status";
            Load += FormGraphView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartShowStatus).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Panel panelStatus;
        private CheckBox checkBoxCPUstatus2;
        private CheckBox checkBoxCPUstatus5;
        private CheckBox checkBoxCPUstatus4;
        private CheckBox checkBoxCPUstatus3;
        private CheckBox checkBoxCPUstatus1;
        private CheckBox checkBoxCPUstatus0;
        private CheckBox checkBoxHDstatus;
        private System.ComponentModel.BackgroundWorker dat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShowStatus;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}