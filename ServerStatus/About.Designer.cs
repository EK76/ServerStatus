namespace ServerStatus.ServerStatus
{
    partial class FormAbout
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
            labelText1 = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText1.Location = new Point(12, 42);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(304, 92);
            labelText1.TabIndex = 0;
            labelText1.Text = "Server Status version 1.0\r\nJune 2024 All rights reserved.\r\n\r\nKen Ekholm, @ken.ekholm@live.com";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(256, 165);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(343, 200);
            Controls.Add(buttonOk);
            Controls.Add(labelText1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            Text = "Server Status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText1;
        private Button buttonOk;
    }
}