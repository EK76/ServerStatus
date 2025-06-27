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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            showGaphicToolStripMenuItem = new ToolStripMenuItem();
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
            markerSizeToolStripMenuItem = new ToolStripMenuItem();
            smallToolStripMenuItem = new ToolStripMenuItem();
            medumToolStripMenuItem = new ToolStripMenuItem();
            largeToolStripMenuItem = new ToolStripMenuItem();
            noneMarkerSizeToolStripMenuItem = new ToolStripMenuItem();
            markerTypeToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            starToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartShowStatus).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1, viewToolStripMenuItem });
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
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, showGaphicToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // showGaphicToolStripMenuItem
            // 
            showGaphicToolStripMenuItem.CheckOnClick = true;
            showGaphicToolStripMenuItem.Name = "showGaphicToolStripMenuItem";
            showGaphicToolStripMenuItem.Size = new Size(180, 22);
            showGaphicToolStripMenuItem.Text = "3D Graphic";
            showGaphicToolStripMenuItem.CheckedChanged += showGaphicToolStripMenuItem_CheckedChanged;
            showGaphicToolStripMenuItem.Click += showGaphicToolStripMenuItem_Click;
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
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Date";
            chartArea2.AxisX.TitleFont = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea2.AxisY.Title = "Temperature (°C)";
            chartArea2.AxisY.TitleFont = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea2.Name = "ChartArea1";
            chartShowStatus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartShowStatus.Legends.Add(legend2);
            chartShowStatus.Location = new Point(0, 27);
            chartShowStatus.Name = "chartShowStatus";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.MarkerSize = 14;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "CPU status 0";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.MarkerSize = 14;
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "CPU status 1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.MarkerSize = 14;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "CPU status 2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.MarkerSize = 14;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "CPU status 3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.MarkerSize = 14;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series12.Name = "CPU status 4";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.MarkerSize = 14;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "CPU status 5";
            series13.YValuesPerPoint = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.MarkerSize = 14;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series14.Name = "HD status";
            chartShowStatus.Series.Add(series8);
            chartShowStatus.Series.Add(series9);
            chartShowStatus.Series.Add(series10);
            chartShowStatus.Series.Add(series11);
            chartShowStatus.Series.Add(series12);
            chartShowStatus.Series.Add(series13);
            chartShowStatus.Series.Add(series14);
            chartShowStatus.Size = new Size(2272, 1140);
            chartShowStatus.TabIndex = 2;
            chartShowStatus.Text = "chartStatus";
            chartShowStatus.GetToolTipText += chartShowStatus_GetToolTipText;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 1148);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2489, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // markerSizeToolStripMenuItem
            // 
            markerSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, medumToolStripMenuItem, largeToolStripMenuItem });
            markerSizeToolStripMenuItem.Name = "markerSizeToolStripMenuItem";
            markerSizeToolStripMenuItem.Size = new Size(180, 22);
            markerSizeToolStripMenuItem.Text = "Marker Size";
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(116, 22);
            smallToolStripMenuItem.Text = "Small";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // medumToolStripMenuItem
            // 
            medumToolStripMenuItem.Checked = true;
            medumToolStripMenuItem.CheckState = CheckState.Checked;
            medumToolStripMenuItem.Name = "medumToolStripMenuItem";
            medumToolStripMenuItem.Size = new Size(116, 22);
            medumToolStripMenuItem.Text = "Medum";
            medumToolStripMenuItem.Click += medumToolStripMenuItem_Click;
            // 
            // largeToolStripMenuItem
            // 
            largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            largeToolStripMenuItem.Size = new Size(116, 22);
            largeToolStripMenuItem.Text = "Large";
            largeToolStripMenuItem.Click += largeToolStripMenuItem_Click;
            // 
            // noneMarkerSizeToolStripMenuItem
            // 
            noneMarkerSizeToolStripMenuItem.Name = "noneMarkerSizeToolStripMenuItem";
            noneMarkerSizeToolStripMenuItem.Size = new Size(180, 22);
            noneMarkerSizeToolStripMenuItem.Text = "None Marker Size";
            noneMarkerSizeToolStripMenuItem.Click += noneMarkerSizeToolStripMenuItem_Click;
            // 
            // markerTypeToolStripMenuItem
            // 
            markerTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circleToolStripMenuItem, triangleToolStripMenuItem, squareToolStripMenuItem, starToolStripMenuItem });
            markerTypeToolStripMenuItem.Name = "markerTypeToolStripMenuItem";
            markerTypeToolStripMenuItem.Size = new Size(180, 22);
            markerTypeToolStripMenuItem.Text = "Marker Type";
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Checked = true;
            circleToolStripMenuItem.CheckState = CheckState.Checked;
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(116, 22);
            circleToolStripMenuItem.Text = "Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(116, 22);
            triangleToolStripMenuItem.Text = "Triangle";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(116, 22);
            squareToolStripMenuItem.Text = "Square";
            squareToolStripMenuItem.Click += squareToolStripMenuItem_Click;
            // 
            // starToolStripMenuItem
            // 
            starToolStripMenuItem.Name = "starToolStripMenuItem";
            starToolStripMenuItem.Size = new Size(116, 22);
            starToolStripMenuItem.Text = "Star";
            starToolStripMenuItem.Click += starToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { markerSizeToolStripMenuItem, noneMarkerSizeToolStripMenuItem, markerTypeToolStripMenuItem, toolStripMenuItem3, defaultToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "Format";
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(180, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
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
        private ToolStripMenuItem showGaphicToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem markerSizeToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem medumToolStripMenuItem;
        private ToolStripMenuItem largeToolStripMenuItem;
        private ToolStripMenuItem noneMarkerSizeToolStripMenuItem;
        private ToolStripMenuItem markerTypeToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem starToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem defaultToolStripMenuItem;
    }
}