namespace ServerStatus.ServerStatus
{
    partial class FormDetails
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
            labelDate = new Label();
            labelCPUstatus = new Label();
            labelHDstatus = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Calibri", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(22, 24);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(143, 59);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            // 
            // labelCPUstatus
            // 
            labelCPUstatus.AutoSize = true;
            labelCPUstatus.Font = new Font("Calibri", 26.25F);
            labelCPUstatus.Location = new Point(22, 94);
            labelCPUstatus.Name = "labelCPUstatus";
            labelCPUstatus.Size = new Size(104, 42);
            labelCPUstatus.TabIndex = 1;
            labelCPUstatus.Text = "label2";
            // 
            // labelHDstatus
            // 
            labelHDstatus.AutoSize = true;
            labelHDstatus.Font = new Font("Calibri", 26.25F);
            labelHDstatus.Location = new Point(22, 154);
            labelHDstatus.Name = "labelHDstatus";
            labelHDstatus.Size = new Size(104, 42);
            labelHDstatus.TabIndex = 7;
            labelHDstatus.Text = "label1";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(374, 248);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 283);
            Controls.Add(buttonClose);
            Controls.Add(labelHDstatus);
            Controls.Add(labelCPUstatus);
            Controls.Add(labelDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDetails";
            ShowIcon = false;
            Text = "Server Status.";
            Load += FormDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelCPUstatus;
        private Label labelHDstatus;
        private Button buttonClose;
    }
}