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
            this.Field_BdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Field_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Field_Password = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "%%View.Settings.BD.ServerName";
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
            this.label2.Text = "%%View.Settings.BD.Database";
            // 
            // Field_BdName
            // 
            this.Field_BdName.Location = new System.Drawing.Point(90, 142);
            this.Field_BdName.Name = "Field_BdName";
            this.Field_BdName.Size = new System.Drawing.Size(294, 22);
            this.Field_BdName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "%%View.Settings.BD.Login";
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
            this.label4.Text = "%%View.Settings.BD.Password";
            // 
            // Field_Password
            // 
            this.Field_Password.Location = new System.Drawing.Point(90, 240);
            this.Field_Password.Name = "Field_Password";
            this.Field_Password.PasswordChar = '*';
            this.Field_Password.Size = new System.Drawing.Size(294, 22);
            this.Field_Password.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(223, 301);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "%%View.Settings.BD.SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Field_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Field_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Field_BdName);
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
        private System.Windows.Forms.TextBox Field_BdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Field_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Field_Password;
        private System.Windows.Forms.Button SaveButton;
    }
}
