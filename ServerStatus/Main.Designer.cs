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
            statusToolStripMenuItem = new ToolStripMenuItem();
            allToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            criticalToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            modifyPasswordToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutServerStatusToolStripMenuItem = new ToolStripMenuItem();
            listViewShowStatus = new ListView();
            columnHeaderCPUstatus0 = new ColumnHeader();
            columnHeaderCPUstatus1 = new ColumnHeader();
            columnHeaderCPUstatus2 = new ColumnHeader();
            columnHeaderCPUstatus3 = new ColumnHeader();
            columnHeaderCPUstatus4 = new ColumnHeader();
            columnHeaderCPUstatus5 = new ColumnHeader();
            columnHeaderHDstatus = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(881, 24);
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
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open Status Data";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save Status Data";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { graphViewToolStripMenuItem, reloadTableToolStripMenuItem, statusToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // graphViewToolStripMenuItem
            // 
            graphViewToolStripMenuItem.Name = "graphViewToolStripMenuItem";
            graphViewToolStripMenuItem.Size = new Size(141, 22);
            graphViewToolStripMenuItem.Text = "Graph View";
            graphViewToolStripMenuItem.Click += graphViewToolStripMenuItem_Click;
            // 
            // reloadTableToolStripMenuItem
            // 
            reloadTableToolStripMenuItem.Name = "reloadTableToolStripMenuItem";
            reloadTableToolStripMenuItem.Size = new Size(141, 22);
            reloadTableToolStripMenuItem.Text = "Reload Table";
            reloadTableToolStripMenuItem.Click += reloadTableToolStripMenuItem_Click;
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allToolStripMenuItem, normalToolStripMenuItem, criticalToolStripMenuItem });
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new Size(141, 22);
            statusToolStripMenuItem.Text = "Status";
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(114, 22);
            allToolStripMenuItem.Text = "All";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(114, 22);
            normalToolStripMenuItem.Text = "Normal";
            // 
            // criticalToolStripMenuItem
            // 
            criticalToolStripMenuItem.Name = "criticalToolStripMenuItem";
            criticalToolStripMenuItem.Size = new Size(114, 22);
            criticalToolStripMenuItem.Text = "Critical";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyPasswordToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // modifyPasswordToolStripMenuItem
            // 
            modifyPasswordToolStripMenuItem.Name = "modifyPasswordToolStripMenuItem";
            modifyPasswordToolStripMenuItem.Size = new Size(162, 22);
            modifyPasswordToolStripMenuItem.Text = "ModifyPassword";
            modifyPasswordToolStripMenuItem.Click += modifyPasswordToolStripMenuItem_Click;
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
            listViewShowStatus.Columns.AddRange(new ColumnHeader[] { columnHeaderCPUstatus0, columnHeaderCPUstatus1, columnHeaderCPUstatus2, columnHeaderCPUstatus3, columnHeaderCPUstatus4, columnHeaderCPUstatus5, columnHeaderHDstatus, columnHeaderDate });
            listViewShowStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewShowStatus.Location = new Point(0, 27);
            listViewShowStatus.Name = "listViewShowStatus";
            listViewShowStatus.Size = new Size(881, 712);
            listViewShowStatus.TabIndex = 1;
            listViewShowStatus.UseCompatibleStateImageBehavior = false;
            listViewShowStatus.View = View.Details;
            // 
            // columnHeaderCPUstatus0
            // 
            columnHeaderCPUstatus0.Text = "CPU status 0";
            columnHeaderCPUstatus0.Width = 100;
            // 
            // columnHeaderCPUstatus1
            // 
            columnHeaderCPUstatus1.Text = "CPU status 1";
            columnHeaderCPUstatus1.Width = 100;
            // 
            // columnHeaderCPUstatus2
            // 
            columnHeaderCPUstatus2.Text = "CPU status 3";
            columnHeaderCPUstatus2.Width = 100;
            // 
            // columnHeaderCPUstatus3
            // 
            columnHeaderCPUstatus3.Text = "CPU status 3";
            columnHeaderCPUstatus3.Width = 100;
            // 
            // columnHeaderCPUstatus4
            // 
            columnHeaderCPUstatus4.Text = "CPU status 4";
            columnHeaderCPUstatus4.Width = 100;
            // 
            // columnHeaderCPUstatus5
            // 
            columnHeaderCPUstatus5.Text = "CPU status 5";
            columnHeaderCPUstatus5.Width = 100;
            // 
            // columnHeaderHDstatus
            // 
            columnHeaderHDstatus.Text = "HD status";
            columnHeaderHDstatus.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date";
            columnHeaderDate.Width = 150;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 740);
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
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem criticalToolStripMenuItem;
        private ListView listViewShowStatus;
        private ColumnHeader columnHeaderCPUstatus0;
        private ColumnHeader columnHeaderCPUstatus1;
        private ColumnHeader columnHeaderCPUstatus2;
        private ColumnHeader columnHeaderCPUstatus3;
        private ColumnHeader columnHeaderCPUstatus4;
        private ColumnHeader columnHeaderCPUstatus5;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderHDstatus;
        private ToolStripMenuItem reloadTableToolStripMenuItem;
    }
}
