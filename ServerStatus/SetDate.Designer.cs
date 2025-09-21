namespace ServerStatus.ServerStatus
{
    partial class FormDateInterval
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
            buttonOk = new Button();
            buttonClose = new Button();
            comboBoxStartDate = new ComboBox();
            comboBoxEndDate = new ComboBox();
            labelText1 = new Label();
            labelText2 = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(131, 138);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(242, 138);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBoxStartDate
            // 
            comboBoxStartDate.FormattingEnabled = true;
            comboBoxStartDate.Location = new Point(12, 68);
            comboBoxStartDate.Name = "comboBoxStartDate";
            comboBoxStartDate.Size = new Size(121, 23);
            comboBoxStartDate.TabIndex = 2;
            comboBoxStartDate.SelectedIndexChanged += comboBoxStartDate_SelectedIndexChanged;
            // 
            // comboBoxEndDate
            // 
            comboBoxEndDate.Enabled = false;
            comboBoxEndDate.FormattingEnabled = true;
            comboBoxEndDate.Location = new Point(189, 68);
            comboBoxEndDate.Name = "comboBoxEndDate";
            comboBoxEndDate.Size = new Size(121, 23);
            comboBoxEndDate.TabIndex = 3;
            comboBoxEndDate.SelectedIndexChanged += comboBoxEndDate_SelectedIndexChanged;
            comboBoxEndDate.Click += comboBoxEndDate_Click;
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Location = new Point(15, 32);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(61, 15);
            labelText1.TabIndex = 4;
            labelText1.Text = "Start Date.";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Location = new Point(189, 32);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(57, 15);
            labelText2.TabIndex = 5;
            labelText2.Text = "End Date.";
            // 
            // FormDateInterval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 199);
            Controls.Add(labelText2);
            Controls.Add(labelText1);
            Controls.Add(comboBoxEndDate);
            Controls.Add(comboBoxStartDate);
            Controls.Add(buttonClose);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDateInterval";
            ShowIcon = false;
            Text = "Server Status";
            Load += FormDateInterval_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonClose;
        private ComboBox comboBoxStartDate;
        private ComboBox comboBoxEndDate;
        private Label labelText1;
        private Label labelText2;
    }
}