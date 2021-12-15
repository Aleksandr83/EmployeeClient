namespace EmployeeClient.Controls
{
    partial class PaginatorControl
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
            this.CountRecordsFilterComboBox = new System.Windows.Forms.ComboBox();
            this.OpenConfigFileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PageInfo = new System.Windows.Forms.Label();
            this.RecordsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountRecordsFilterComboBox
            // 
            this.CountRecordsFilterComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.CountRecordsFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountRecordsFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountRecordsFilterComboBox.FormattingEnabled = true;
            this.CountRecordsFilterComboBox.Location = new System.Drawing.Point(536, 5);
            this.CountRecordsFilterComboBox.Name = "CountRecordsFilterComboBox";
            this.CountRecordsFilterComboBox.Size = new System.Drawing.Size(103, 24);
            this.CountRecordsFilterComboBox.TabIndex = 2;
            // 
            // OpenConfigFileButton
            // 
            this.OpenConfigFileButton.FlatAppearance.BorderSize = 0;
            this.OpenConfigFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenConfigFileButton.Image = global::EmployeeClient.Properties.Resources.prev_btn;
            this.OpenConfigFileButton.Location = new System.Drawing.Point(3, 6);
            this.OpenConfigFileButton.Name = "OpenConfigFileButton";
            this.OpenConfigFileButton.Size = new System.Drawing.Size(22, 22);
            this.OpenConfigFileButton.TabIndex = 6;
            this.OpenConfigFileButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EmployeeClient.Properties.Resources.next_btn;
            this.button1.Location = new System.Drawing.Point(31, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PageInfo
            // 
            this.PageInfo.AutoSize = true;
            this.PageInfo.Location = new System.Drawing.Point(60, 11);
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Size = new System.Drawing.Size(87, 16);
            this.PageInfo.TabIndex = 8;
            this.PageInfo.Text = "PageInfoText";
            // 
            // RecordsCount
            // 
            this.RecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordsCount.AutoSize = true;
            this.RecordsCount.Location = new System.Drawing.Point(379, 9);
            this.RecordsCount.Name = "RecordsCount";
            this.RecordsCount.Size = new System.Drawing.Size(93, 16);
            this.RecordsCount.TabIndex = 9;
            this.RecordsCount.Text = "RecordsCount";
            // 
            // PaginatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RecordsCount);
            this.Controls.Add(this.PageInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenConfigFileButton);
            this.Controls.Add(this.CountRecordsFilterComboBox);
            this.Name = "PaginatorControl";
            this.Size = new System.Drawing.Size(922, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CountRecordsFilterComboBox;
        private System.Windows.Forms.Button OpenConfigFileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PageInfo;
        private System.Windows.Forms.Label RecordsCount;
    }
}
