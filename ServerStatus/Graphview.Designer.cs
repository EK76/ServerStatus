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
            toolStripMenuItem1 = new ToolStripMenuItem();
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
            defaultToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            showGaphicToolStripMenuItem = new ToolStripMenuItem();
            panelStatus = new Panel();
            buttonSelectAll = new Button();
            dat = new System.ComponentModel.BackgroundWorker();
            chartShowStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            checkBoxCPUStatus0 = new CheckBox();
            checkBoxCPUStatus1 = new CheckBox();
            checkBoxCPUStatus2 = new CheckBox();
            checkBoxCPUStatus3 = new CheckBox();
            checkBoxCPUStatus4 = new CheckBox();
            checkBoxCPUStatus5 = new CheckBox();
            checkBoxHDStatus = new CheckBox();
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
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { markerSizeToolStripMenuItem, noneMarkerSizeToolStripMenuItem, markerTypeToolStripMenuItem, toolStripMenuItem3, defaultToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "Format";
            // 
            // markerSizeToolStripMenuItem
            // 
            markerSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, medumToolStripMenuItem, largeToolStripMenuItem });
            markerSizeToolStripMenuItem.Name = "markerSizeToolStripMenuItem";
            markerSizeToolStripMenuItem.Size = new Size(166, 22);
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
            noneMarkerSizeToolStripMenuItem.Size = new Size(166, 22);
            noneMarkerSizeToolStripMenuItem.Text = "None Marker Size";
            noneMarkerSizeToolStripMenuItem.Click += noneMarkerSizeToolStripMenuItem_Click;
            // 
            // markerTypeToolStripMenuItem
            // 
            markerTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circleToolStripMenuItem, triangleToolStripMenuItem, squareToolStripMenuItem, starToolStripMenuItem });
            markerTypeToolStripMenuItem.Name = "markerTypeToolStripMenuItem";
            markerTypeToolStripMenuItem.Size = new Size(166, 22);
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
            toolStripMenuItem3.Size = new Size(163, 6);
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Enabled = false;
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(166, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
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
            settingsToolStripMenuItem.Size = new Size(132, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // showGaphicToolStripMenuItem
            // 
            showGaphicToolStripMenuItem.CheckOnClick = true;
            showGaphicToolStripMenuItem.Name = "showGaphicToolStripMenuItem";
            showGaphicToolStripMenuItem.Size = new Size(132, 22);
            showGaphicToolStripMenuItem.Text = "3D Graphic";
            showGaphicToolStripMenuItem.CheckedChanged += showGaphicToolStripMenuItem_CheckedChanged;
            showGaphicToolStripMenuItem.CheckedChanged += showGaphicToolStripMenuItem_CheckedChanged;
            // 
            // panelStatus
            // 
            panelStatus.Controls.Add(checkBoxHDStatus);
            panelStatus.Controls.Add(buttonSelectAll);
            panelStatus.Controls.Add(checkBoxCPUStatus5);
            panelStatus.Controls.Add(checkBoxCPUStatus0);
            panelStatus.Controls.Add(checkBoxCPUStatus4);
            panelStatus.Controls.Add(checkBoxCPUStatus1);
            panelStatus.Controls.Add(checkBoxCPUStatus3);
            panelStatus.Controls.Add(checkBoxCPUStatus2);
            panelStatus.Location = new Point(2278, 27);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(211, 462);
            panelStatus.TabIndex = 1;
            panelStatus.Visible = false;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Enabled = false;
            buttonSelectAll.Location = new Point(31, 378);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(84, 33);
            buttonSelectAll.TabIndex = 6;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
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
            series1.MarkerSize = 14;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "CPU status 0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 14;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "CPU status 1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 14;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "CPU status 2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 14;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "CPU status 3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerSize = 14;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "CPU status 4";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.MarkerSize = 14;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "CPU status 5";
            series6.YValuesPerPoint = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerSize = 14;
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
            // checkBoxCPUStatus0
            // 
            checkBoxCPUStatus0.AutoSize = true;
            checkBoxCPUStatus0.Checked = true;
            checkBoxCPUStatus0.CheckState = CheckState.Checked;
            checkBoxCPUStatus0.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus0.Location = new Point(31, 26);
            checkBoxCPUStatus0.Name = "checkBoxCPUStatus0";
            checkBoxCPUStatus0.Size = new Size(137, 29);
            checkBoxCPUStatus0.TabIndex = 4;
            checkBoxCPUStatus0.Text = "CPU Status 0";
            checkBoxCPUStatus0.UseVisualStyleBackColor = true;
            checkBoxCPUStatus0.CheckStateChanged += checkBoxCPUStatus0_CheckStateChanged;
            // 
            // checkBoxCPUStatus1
            // 
            checkBoxCPUStatus1.AutoSize = true;
            checkBoxCPUStatus1.Checked = true;
            checkBoxCPUStatus1.CheckState = CheckState.Checked;
            checkBoxCPUStatus1.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus1.Location = new Point(31, 73);
            checkBoxCPUStatus1.Name = "checkBoxCPUStatus1";
            checkBoxCPUStatus1.Size = new Size(137, 29);
            checkBoxCPUStatus1.TabIndex = 5;
            checkBoxCPUStatus1.Text = "CPU Status 1";
            checkBoxCPUStatus1.UseVisualStyleBackColor = true;
            checkBoxCPUStatus1.CheckStateChanged += checkBoxCPUStatus1_CheckStateChanged;
            // 
            // checkBoxCPUStatus2
            // 
            checkBoxCPUStatus2.AutoSize = true;
            checkBoxCPUStatus2.Checked = true;
            checkBoxCPUStatus2.CheckState = CheckState.Checked;
            checkBoxCPUStatus2.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus2.Location = new Point(31, 118);
            checkBoxCPUStatus2.Name = "checkBoxCPUStatus2";
            checkBoxCPUStatus2.Size = new Size(137, 29);
            checkBoxCPUStatus2.TabIndex = 6;
            checkBoxCPUStatus2.Text = "CPU Status 2";
            checkBoxCPUStatus2.UseVisualStyleBackColor = true;
            checkBoxCPUStatus2.CheckStateChanged += checkBoxCPUStatus2_CheckStateChanged;
            // 
            // checkBoxCPUStatus3
            // 
            checkBoxCPUStatus3.AutoSize = true;
            checkBoxCPUStatus3.Checked = true;
            checkBoxCPUStatus3.CheckState = CheckState.Checked;
            checkBoxCPUStatus3.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus3.Location = new Point(31, 162);
            checkBoxCPUStatus3.Name = "checkBoxCPUStatus3";
            checkBoxCPUStatus3.Size = new Size(137, 29);
            checkBoxCPUStatus3.TabIndex = 7;
            checkBoxCPUStatus3.Text = "CPU Status 3";
            checkBoxCPUStatus3.UseVisualStyleBackColor = true;
            checkBoxCPUStatus3.CheckStateChanged += checkBoxCPUStatus3_CheckStateChanged;
            // 
            // checkBoxCPUStatus4
            // 
            checkBoxCPUStatus4.AutoSize = true;
            checkBoxCPUStatus4.Checked = true;
            checkBoxCPUStatus4.CheckState = CheckState.Checked;
            checkBoxCPUStatus4.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus4.Location = new Point(31, 211);
            checkBoxCPUStatus4.Name = "checkBoxCPUStatus4";
            checkBoxCPUStatus4.Size = new Size(137, 29);
            checkBoxCPUStatus4.TabIndex = 8;
            checkBoxCPUStatus4.Text = "CPU Status 4";
            checkBoxCPUStatus4.UseVisualStyleBackColor = true;
            checkBoxCPUStatus4.CheckStateChanged += checkBoxCPUStatus4_CheckStateChanged;
            // 
            // checkBoxCPUStatus5
            // 
            checkBoxCPUStatus5.AutoSize = true;
            checkBoxCPUStatus5.Checked = true;
            checkBoxCPUStatus5.CheckState = CheckState.Checked;
            checkBoxCPUStatus5.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus5.Location = new Point(31, 259);
            checkBoxCPUStatus5.Name = "checkBoxCPUStatus5";
            checkBoxCPUStatus5.Size = new Size(137, 29);
            checkBoxCPUStatus5.TabIndex = 9;
            checkBoxCPUStatus5.Text = "CPU Status 5";
            checkBoxCPUStatus5.UseVisualStyleBackColor = true;
            checkBoxCPUStatus5.CheckStateChanged += checkBoxCPUStatus5_CheckStateChanged;
            // 
            // checkBoxHDStatus
            // 
            checkBoxHDStatus.AutoSize = true;
            checkBoxHDStatus.Checked = true;
            checkBoxHDStatus.CheckState = CheckState.Checked;
            checkBoxHDStatus.Font = new Font("Segoe UI", 14.25F);
            checkBoxHDStatus.Location = new Point(31, 309);
            checkBoxHDStatus.Name = "checkBoxHDStatus";
            checkBoxHDStatus.Size = new Size(112, 29);
            checkBoxHDStatus.TabIndex = 10;
            checkBoxHDStatus.Text = "HD Status";
            checkBoxHDStatus.UseVisualStyleBackColor = true;
            checkBoxHDStatus.CheckStateChanged += checkBoxHDStatus_CheckStateChanged;
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
        private CheckBox checkBoxCPUStatus0;
        private CheckBox checkBoxCPUStatus1;
        private CheckBox checkBoxCPUStatus2;
        private CheckBox checkBoxCPUStatus3;
        private CheckBox checkBoxCPUStatus4;
        private CheckBox checkBoxCPUStatus5;
        private CheckBox checkBoxHDStatus;
        private Button buttonSelectAll;
    }
}