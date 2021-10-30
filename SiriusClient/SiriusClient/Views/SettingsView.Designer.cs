using SiriusClient.Properties;

namespace SiriusClient.Views
{
    partial class SettingsView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Field_ServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Field_Database = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Field_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Field_Password = new System.Windows.Forms.TextBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.Field_IsSavePassword = new System.Windows.Forms.CheckBox();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "%%View.Settings.DB.ServerName";
            // 
            // Field_ServerName
            // 
            this.Field_ServerName.Location = new System.Drawing.Point(90, 93);
            this.Field_ServerName.Name = "Field_ServerName";
            this.Field_ServerName.Size = new System.Drawing.Size(294, 22);
            this.Field_ServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "%%View.Settings.DB.Database";
            // 
            // Field_Database
            // 
            this.Field_Database.Location = new System.Drawing.Point(90, 142);
            this.Field_Database.Name = "Field_Database";
            this.Field_Database.Size = new System.Drawing.Size(294, 22);
            this.Field_Database.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "%%View.Settings.DB.Login";
            // 
            // Field_Login
            // 
            this.Field_Login.Location = new System.Drawing.Point(90, 191);
            this.Field_Login.Name = "Field_Login";
            this.Field_Login.Size = new System.Drawing.Size(294, 22);
            this.Field_Login.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "%%View.Settings.DB.Password";
            // 
            // Field_Password
            // 
            this.Field_Password.Location = new System.Drawing.Point(90, 240);
            this.Field_Password.Name = "Field_Password";
            this.Field_Password.PasswordChar = '*';
            this.Field_Password.Size = new System.Drawing.Size(294, 22);
            this.Field_Password.TabIndex = 7;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(223, 312);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(160, 25);
            this.ConnectionButton.TabIndex = 8;
            this.ConnectionButton.Text = "%%View.Settings.DB.ConnectionButton";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // Field_IsSavePassword
            // 
            this.Field_IsSavePassword.AutoSize = true;
            this.Field_IsSavePassword.Checked = true;
            this.Field_IsSavePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Field_IsSavePassword.Location = new System.Drawing.Point(90, 269);
            this.Field_IsSavePassword.Name = "Field_IsSavePassword";
            this.Field_IsSavePassword.Size = new System.Drawing.Size(260, 20);
            this.Field_IsSavePassword.TabIndex = 9;
            this.Field_IsSavePassword.Text = "%%View.Settings.DB.IsSavePassword";
            this.Field_IsSavePassword.UseVisualStyleBackColor = true;
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Location = new System.Drawing.Point(391, 240);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(177, 25);
            this.ResetPasswordButton.TabIndex = 10;
            this.ResetPasswordButton.Text = "%%View.Settings.DB.ResetPasswordButton";
            this.ResetPasswordButton.UseVisualStyleBackColor = true;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.Field_IsSavePassword);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.Field_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Field_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Field_Database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Field_ServerName);
            this.Controls.Add(this.label1);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(903, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Field_ServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Field_Database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Field_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Field_Password;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.CheckBox Field_IsSavePassword;
        private System.Windows.Forms.Button ResetPasswordButton;
    }
}
