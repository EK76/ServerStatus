namespace WinFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            graphViewToolStripMenuItem = new ToolStripMenuItem();
            reloadTableToolStripMenuItem = new ToolStripMenuItem();
            markToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            daytoolStripComboBox = new ToolStripComboBox();
            setDateToolStripMenuItem = new ToolStripMenuItem();
            showServerRebootTimeToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            modifyPasswordToolStripMenuItem = new ToolStripMenuItem();
            emptyTableToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutServerStatusToolStripMenuItem = new ToolStripMenuItem();
            listViewShowStatus = new ListView();
            columnHeaderCPUstatus = new ColumnHeader();
            columnHeaderHDstatus = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelRows = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(444, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(165, 22);
            openToolStripMenuItem.Text = "Open Status Data";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(165, 22);
            saveToolStripMenuItem.Text = "Save Status Data";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { graphViewToolStripMenuItem, reloadTableToolStripMenuItem, markToolStripMenuItem, showToolStripMenuItem, setDateToolStripMenuItem, showServerRebootTimeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // graphViewToolStripMenuItem
            // 
            graphViewToolStripMenuItem.Enabled = false;
            graphViewToolStripMenuItem.Name = "graphViewToolStripMenuItem";
            graphViewToolStripMenuItem.Size = new Size(209, 22);
            graphViewToolStripMenuItem.Text = "Graph View";
            graphViewToolStripMenuItem.Click += graphViewToolStripMenuItem_Click;
            // 
            // reloadTableToolStripMenuItem
            // 
            reloadTableToolStripMenuItem.Name = "reloadTableToolStripMenuItem";
            reloadTableToolStripMenuItem.Size = new Size(209, 22);
            reloadTableToolStripMenuItem.Text = "Reload Table";
            reloadTableToolStripMenuItem.Click += reloadTableToolStripMenuItem_Click;
            // 
            // markToolStripMenuItem
            // 
            markToolStripMenuItem.Enabled = false;
            markToolStripMenuItem.Name = "markToolStripMenuItem";
            markToolStripMenuItem.Size = new Size(209, 22);
            markToolStripMenuItem.Text = "Mark Critical";
            markToolStripMenuItem.Click += markToolStripMenuItem_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daytoolStripComboBox });
            showToolStripMenuItem.Enabled = false;
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(209, 22);
            showToolStripMenuItem.Text = "Show Selected Day Status";
            // 
            // daytoolStripComboBox
            // 
            daytoolStripComboBox.Name = "daytoolStripComboBox";
            daytoolStripComboBox.Size = new Size(121, 23);
            daytoolStripComboBox.Text = "Select Day";
            daytoolStripComboBox.SelectedIndexChanged += daytoolStripComboBox_SelectedIndexChanged;
            daytoolStripComboBox.Click += daytoolStripComboBox_Click;
            // 
            // setDateToolStripMenuItem
            // 
            setDateToolStripMenuItem.Enabled = false;
            setDateToolStripMenuItem.Name = "setDateToolStripMenuItem";
            setDateToolStripMenuItem.Size = new Size(209, 22);
            setDateToolStripMenuItem.Text = "Set Date Interval";
            setDateToolStripMenuItem.Click += setDateToolStripMenuItem_Click;
            // 
            // showServerRebootTimeToolStripMenuItem
            // 
            showServerRebootTimeToolStripMenuItem.Name = "showServerRebootTimeToolStripMenuItem";
            showServerRebootTimeToolStripMenuItem.Size = new Size(209, 22);
            showServerRebootTimeToolStripMenuItem.Text = "Show Server Startup Time";
            showServerRebootTimeToolStripMenuItem.Click += showServerRebootTimeToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyPasswordToolStripMenuItem, emptyTableToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // modifyPasswordToolStripMenuItem
            // 
            modifyPasswordToolStripMenuItem.Name = "modifyPasswordToolStripMenuItem";
            modifyPasswordToolStripMenuItem.Size = new Size(180, 22);
            modifyPasswordToolStripMenuItem.Text = "Change Password";
            modifyPasswordToolStripMenuItem.Click += modifyPasswordToolStripMenuItem_Click;
            // 
            // emptyTableToolStripMenuItem
            // 
            emptyTableToolStripMenuItem.Name = "emptyTableToolStripMenuItem";
            emptyTableToolStripMenuItem.Size = new Size(180, 22);
            emptyTableToolStripMenuItem.Text = "Empty The Table";
            emptyTableToolStripMenuItem.Click += emptyTableToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutServerStatusToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutServerStatusToolStripMenuItem
            // 
            aboutServerStatusToolStripMenuItem.Name = "aboutServerStatusToolStripMenuItem";
            aboutServerStatusToolStripMenuItem.Size = new Size(177, 22);
            aboutServerStatusToolStripMenuItem.Text = "About Server Status";
            aboutServerStatusToolStripMenuItem.Click += aboutServerStatusToolStripMenuItem_Click;
            // 
            // listViewShowStatus
            // 
            listViewShowStatus.Columns.AddRange(new ColumnHeader[] { columnHeaderCPUstatus, columnHeaderHDstatus, columnHeaderDate });
            listViewShowStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewShowStatus.FullRowSelect = true;
            listViewShowStatus.Location = new Point(12, 25);
            listViewShowStatus.Name = "listViewShowStatus";
            listViewShowStatus.Size = new Size(421, 893);
            listViewShowStatus.TabIndex = 1;
            listViewShowStatus.UseCompatibleStateImageBehavior = false;
            listViewShowStatus.View = View.Details;
            listViewShowStatus.SelectedIndexChanged += listViewShowStatus_SelectedIndexChanged;
            listViewShowStatus.DoubleClick += listViewShowStatus_DoubleClick;
            // 
            // columnHeaderCPUstatus
            // 
            columnHeaderCPUstatus.Text = "CPU status";
            columnHeaderCPUstatus.Width = 100;
            // 
            // columnHeaderHDstatus
            // 
            columnHeaderHDstatus.Text = "HD status";
            columnHeaderHDstatus.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.Width = 200;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelRows });
            statusStrip1.Location = new Point(0, 921);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(444, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRows
            // 
            toolStripStatusLabelRows.Name = "toolStripStatusLabelRows";
            toolStripStatusLabelRows.Size = new Size(140, 17);
            toolStripStatusLabelRows.Text = "toolStripStatusLabelRows";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 943);
            Controls.Add(statusStrip1);
            Controls.Add(listViewShowStatus);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            Text = "Server Status";
            Activated += FormMain_Activated;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem modifyPasswordToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem graphViewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutServerStatusToolStripMenuItem;
        private ListView listViewShowStatus;
        private ColumnHeader columnHeaderCPUstatus;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderHDstatus;
        private ToolStripMenuItem reloadTableToolStripMenuItem;
        private ToolStripMenuItem markToolStripMenuItem;
        private ToolStripMenuItem emptyTableToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripComboBox daytoolStripComboBox;
        private ToolStripMenuItem showServerRebootTimeToolStripMenuItem;
        private ToolStripMenuItem setDateToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelRows;
    }
}
