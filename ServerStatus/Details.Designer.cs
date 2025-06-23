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
            labelCPUstatus1 = new Label();
            labelCPUstatus2 = new Label();
            labelCPUstatus3 = new Label();
            labelCPUstatus4 = new Label();
            labelCPUstatus5 = new Label();
            labelHDstatus = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(22, 23);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(95, 39);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            // 
            // labelCPUstatus
            // 
            labelCPUstatus.AutoSize = true;
            labelCPUstatus.Font = new Font("Calibri", 18F);
            labelCPUstatus.Location = new Point(22, 70);
            labelCPUstatus.Name = "labelCPUstatus";
            labelCPUstatus.Size = new Size(74, 29);
            labelCPUstatus.TabIndex = 1;
            labelCPUstatus.Text = "label2";
            // 
            // labelCPUstatus1
            // 
            labelCPUstatus1.AutoSize = true;
            labelCPUstatus1.Font = new Font("Calibri", 18F);
            labelCPUstatus1.Location = new Point(22, 110);
            labelCPUstatus1.Name = "labelCPUstatus1";
            labelCPUstatus1.Size = new Size(74, 29);
            labelCPUstatus1.TabIndex = 2;
            labelCPUstatus1.Text = "label3";
            // 
            // labelCPUstatus2
            // 
            labelCPUstatus2.AutoSize = true;
            labelCPUstatus2.Font = new Font("Calibri", 18F);
            labelCPUstatus2.Location = new Point(22, 150);
            labelCPUstatus2.Name = "labelCPUstatus2";
            labelCPUstatus2.Size = new Size(74, 29);
            labelCPUstatus2.TabIndex = 3;
            labelCPUstatus2.Text = "label4";
            // 
            // labelCPUstatus3
            // 
            labelCPUstatus3.AutoSize = true;
            labelCPUstatus3.Font = new Font("Calibri", 18F);
            labelCPUstatus3.Location = new Point(22, 190);
            labelCPUstatus3.Name = "labelCPUstatus3";
            labelCPUstatus3.Size = new Size(74, 29);
            labelCPUstatus3.TabIndex = 4;
            labelCPUstatus3.Text = "label5";
            // 
            // labelCPUstatus4
            // 
            labelCPUstatus4.AutoSize = true;
            labelCPUstatus4.Font = new Font("Calibri", 18F);
            labelCPUstatus4.Location = new Point(22, 230);
            labelCPUstatus4.Name = "labelCPUstatus4";
            labelCPUstatus4.Size = new Size(74, 29);
            labelCPUstatus4.TabIndex = 5;
            labelCPUstatus4.Text = "label6";
            // 
            // labelCPUstatus5
            // 
            labelCPUstatus5.AutoSize = true;
            labelCPUstatus5.Font = new Font("Calibri", 18F);
            labelCPUstatus5.Location = new Point(22, 270);
            labelCPUstatus5.Name = "labelCPUstatus5";
            labelCPUstatus5.Size = new Size(74, 29);
            labelCPUstatus5.TabIndex = 6;
            labelCPUstatus5.Text = "label7";
            // 
            // labelHDstatus
            // 
            labelHDstatus.AutoSize = true;
            labelHDstatus.Font = new Font("Calibri", 18F);
            labelHDstatus.Location = new Point(22, 310);
            labelHDstatus.Name = "labelHDstatus";
            labelHDstatus.Size = new Size(74, 29);
            labelHDstatus.TabIndex = 7;
            labelHDstatus.Text = "label1";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(317, 345);
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
            ClientSize = new Size(401, 380);
            Controls.Add(buttonClose);
            Controls.Add(labelHDstatus);
            Controls.Add(labelCPUstatus5);
            Controls.Add(labelCPUstatus4);
            Controls.Add(labelCPUstatus3);
            Controls.Add(labelCPUstatus2);
            Controls.Add(labelCPUstatus1);
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
        private Label labelCPUstatus1;
        private Label labelCPUstatus2;
        private Label labelCPUstatus3;
        private Label labelCPUstatus4;
        private Label labelCPUstatus5;
        private Label labelHDstatus;
        private Button buttonClose;
    }
}