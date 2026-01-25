namespace ReadTemp
{
    partial class FormChangePassword
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
            buttonSave = new Button();
            buttonClose = new Button();
            textBoxNewPassword = new TextBox();
            checkBoxShow = new CheckBox();
            SuspendLayout();
            // 
            // labelText1
            // 
            labelText1.AutoSize = true;
            labelText1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelText1.Location = new Point(18, 22);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(140, 15);
            labelText1.TabIndex = 1;
            labelText1.Text = "Type the new password.";
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(77, 152);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(170, 152);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(12, 55);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Size = new Size(239, 23);
            textBoxNewPassword.TabIndex = 6;
            textBoxNewPassword.TextChanged += textBoxNewPassword_TextChanged;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBoxShow.Location = new Point(12, 115);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(127, 21);
            checkBoxShow.TabIndex = 11;
            checkBoxShow.Text = "Show plain text.";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 193);
            Controls.Add(checkBoxShow);
            Controls.Add(textBoxNewPassword);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Controls.Add(labelText1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChangePassword";
            ShowIcon = false;
            Text = "Server Status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelText1;
        private Button buttonSave;
        private Button buttonClose;
        private TextBox textBoxNewPassword;
        private CheckBox checkBoxShow;
    }
}