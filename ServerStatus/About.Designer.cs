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
            labelText2 = new Label();
            SuspendLayout();
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText1.Location = new Point(12, 9);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(270, 116);
            labelText1.TabIndex = 0;
            labelText1.Text = "\r\nServer Status version 1.84\r\nFebruary  2026 \r\nAll rights reserved. \r\n";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(256, 184);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelText2.Location = new Point(12, 149);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(263, 19);
            labelText2.TabIndex = 4;
            labelText2.Text = "Ken Ekholm, @ken.ekholm@live.com";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(343, 219);
            Controls.Add(labelText2);
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
        private Label labelText2;
    }
}