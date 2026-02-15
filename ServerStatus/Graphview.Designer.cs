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
            radioButtonHd = new RadioButton();
            radioButtonCpuStatus = new RadioButton();
            labelAvgTemp = new Label();
            labelMinTemp = new Label();
            labelMaxTemp = new Label();
            labelDate = new Label();
            labelTemp = new Label();
            checkBoxHDStatus = new CheckBox();
            checkBoxCPUStatus = new CheckBox();
            chartShowStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            labelLastDate = new Label();
            labelFirstDate = new Label();
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
            menuStrip1.Size = new Size(2519, 24);
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
            noneMarkerSizeToolStripMenuItem.CheckStateChanged += noneMarkerSizeToolStripMenuItem_CheckStateChanged;
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
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Enabled = false;
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(180, 22);
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
            // 
            // panelStatus
            // 
            panelStatus.Controls.Add(radioButtonHd);
            panelStatus.Controls.Add(radioButtonCpuStatus);
            panelStatus.Controls.Add(labelAvgTemp);
            panelStatus.Controls.Add(labelMinTemp);
            panelStatus.Controls.Add(labelMaxTemp);
            panelStatus.Controls.Add(labelDate);
            panelStatus.Controls.Add(labelTemp);
            panelStatus.Controls.Add(checkBoxHDStatus);
            panelStatus.Controls.Add(checkBoxCPUStatus);
            panelStatus.Location = new Point(2278, 27);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(229, 372);
            panelStatus.TabIndex = 1;
            panelStatus.Visible = false;
            // 
            // radioButtonHd
            // 
            radioButtonHd.AutoSize = true;
            radioButtonHd.Font = new Font("Segoe UI", 14.25F);
            radioButtonHd.Location = new Point(105, 118);
            radioButtonHd.Name = "radioButtonHd";
            radioButtonHd.Size = new Size(56, 29);
            radioButtonHd.TabIndex = 17;
            radioButtonHd.Text = "HD";
            radioButtonHd.UseVisualStyleBackColor = true;
            radioButtonHd.Click += radioButtonHd_Click;
            // 
            // radioButtonCpuStatus
            // 
            radioButtonCpuStatus.AutoSize = true;
            radioButtonCpuStatus.Checked = true;
            radioButtonCpuStatus.Font = new Font("Segoe UI", 14.25F);
            radioButtonCpuStatus.Location = new Point(12, 118);
            radioButtonCpuStatus.Name = "radioButtonCpuStatus";
            radioButtonCpuStatus.Size = new Size(66, 29);
            radioButtonCpuStatus.TabIndex = 16;
            radioButtonCpuStatus.TabStop = true;
            radioButtonCpuStatus.Text = "CPU";
            radioButtonCpuStatus.UseVisualStyleBackColor = true;
            radioButtonCpuStatus.Click += radioButtonCpuStatus_Click;
            // 
            // labelAvgTemp
            // 
            labelAvgTemp.AutoSize = true;
            labelAvgTemp.Font = new Font("Segoe UI", 14.25F);
            labelAvgTemp.Location = new Point(3, 229);
            labelAvgTemp.Name = "labelAvgTemp";
            labelAvgTemp.Size = new Size(157, 25);
            labelAvgTemp.TabIndex = 15;
            labelAvgTemp.Text = "Avg temperature:";
            // 
            // labelMinTemp
            // 
            labelMinTemp.AutoSize = true;
            labelMinTemp.Font = new Font("Segoe UI", 14.25F);
            labelMinTemp.Location = new Point(3, 190);
            labelMinTemp.Name = "labelMinTemp";
            labelMinTemp.Size = new Size(158, 25);
            labelMinTemp.TabIndex = 14;
            labelMinTemp.Text = "Min temperature:";
            // 
            // labelMaxTemp
            // 
            labelMaxTemp.AutoSize = true;
            labelMaxTemp.Font = new Font("Segoe UI", 14.25F);
            labelMaxTemp.Location = new Point(3, 150);
            labelMaxTemp.Name = "labelMaxTemp";
            labelMaxTemp.Size = new Size(161, 25);
            labelMaxTemp.TabIndex = 13;
            labelMaxTemp.Text = "Max temperature:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 14.25F);
            labelDate.Location = new Point(3, 318);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(55, 25);
            labelDate.TabIndex = 12;
            labelDate.Text = "Date:";
            labelDate.Visible = false;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Segoe UI", 14.25F);
            labelTemp.Location = new Point(3, 282);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(122, 25);
            labelTemp.TabIndex = 11;
            labelTemp.Text = "Temperature:";
            labelTemp.Visible = false;
            // 
            // checkBoxHDStatus
            // 
            checkBoxHDStatus.AutoSize = true;
            checkBoxHDStatus.Checked = true;
            checkBoxHDStatus.CheckState = CheckState.Checked;
            checkBoxHDStatus.Font = new Font("Segoe UI", 14.25F);
            checkBoxHDStatus.Location = new Point(12, 59);
            checkBoxHDStatus.Name = "checkBoxHDStatus";
            checkBoxHDStatus.Size = new Size(112, 29);
            checkBoxHDStatus.TabIndex = 10;
            checkBoxHDStatus.Text = "HD Status";
            checkBoxHDStatus.UseVisualStyleBackColor = true;
            checkBoxHDStatus.CheckStateChanged += checkBoxHDStatus_CheckStateChanged;
            checkBoxHDStatus.Click += checkBoxHDStatus_Click;
            // 
            // checkBoxCPUStatus
            // 
            checkBoxCPUStatus.AutoSize = true;
            checkBoxCPUStatus.Checked = true;
            checkBoxCPUStatus.CheckState = CheckState.Checked;
            checkBoxCPUStatus.Font = new Font("Segoe UI", 14.25F);
            checkBoxCPUStatus.Location = new Point(12, 24);
            checkBoxCPUStatus.Name = "checkBoxCPUStatus";
            checkBoxCPUStatus.Size = new Size(122, 29);
            checkBoxCPUStatus.TabIndex = 4;
            checkBoxCPUStatus.Text = "CPU Status";
            checkBoxCPUStatus.UseVisualStyleBackColor = true;
            checkBoxCPUStatus.CheckStateChanged += checkBoxCPUStatus_CheckStateChanged;
            checkBoxCPUStatus.Click += checkBoxCPUStatus_Click;
            // 
            // chartShowStatus
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.Minimum = 1D;
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
            series1.Name = "CPU status";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerSize = 14;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "HD status";
            chartShowStatus.Series.Add(series1);
            chartShowStatus.Series.Add(series2);
            chartShowStatus.Size = new Size(2272, 1140);
            chartShowStatus.TabIndex = 2;
            chartShowStatus.Text = "ls";
            chartShowStatus.GetToolTipText += chartShowStatus_GetToolTipText;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 1148);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2519, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // labelLastDate
            // 
            labelLastDate.AutoSize = true;
            labelLastDate.BackColor = Color.White;
            labelLastDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastDate.Location = new Point(2123, 1095);
            labelLastDate.Name = "labelLastDate";
            labelLastDate.Size = new Size(42, 20);
            labelLastDate.TabIndex = 4;
            labelLastDate.Text = "label";
            // 
            // labelFirstDate
            // 
            labelFirstDate.AutoSize = true;
            labelFirstDate.BackColor = Color.White;
            labelFirstDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstDate.Location = new Point(176, 1099);
            labelFirstDate.Name = "labelFirstDate";
            labelFirstDate.Size = new Size(42, 20);
            labelFirstDate.TabIndex = 5;
            labelFirstDate.Text = "label";
            // 
            // FormGraphView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2519, 1170);
            Controls.Add(labelFirstDate);
            Controls.Add(labelLastDate);
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
        private CheckBox checkBoxCPUStatus;
        private CheckBox checkBoxHDStatus;
        private Label labelLastDate;
        private Label labelFirstDate;
        private Label labelTemp;
        private Label labelDate;
        private Label labelAvgTemp;
        private Label labelMinTemp;
        private Label labelMaxTemp;
        private RadioButton radioButtonHd;
        private RadioButton radioButtonCpuStatus;
    }
}