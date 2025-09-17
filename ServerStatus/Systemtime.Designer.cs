namespace ServerStatus.ServerStatus
{
    partial class FormSystemTime
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
            listBoxSystemTime = new ListBox();
            labelText = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(204, 468);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Close";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // listBoxSystemTime
            // 
            listBoxSystemTime.Font = new Font("Segoe UI", 12F);
            listBoxSystemTime.FormattingEnabled = true;
            listBoxSystemTime.Location = new Point(12, 46);
            listBoxSystemTime.Name = "listBoxSystemTime";
            listBoxSystemTime.Size = new Size(267, 403);
            listBoxSystemTime.TabIndex = 1;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelText.Location = new Point(12, 18);
            labelText.Name = "labelText";
            labelText.Size = new Size(267, 21);
            labelText.TabIndex = 2;
            labelText.Text = "List over reboot times for the system.";
            // 
            // FormSystemTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 503);
            Controls.Add(labelText);
            Controls.Add(listBoxSystemTime);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSystemTime";
            ShowIcon = false;
            Text = "Server Status";
            Load += ForSystemTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private ListBox listBoxSystemTime;
        private Label labelText;
    }
}