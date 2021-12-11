namespace EmployeeClient.Controls
{
    partial class EmployeeListFiltersControl
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
            this.Field_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Field_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Field_Post = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Field_Departament = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Field_LastName
            // 
            this.Field_LastName.Location = new System.Drawing.Point(4, 36);
            this.Field_LastName.Name = "Field_LastName";
            this.Field_LastName.Size = new System.Drawing.Size(301, 22);
            this.Field_LastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "%%Filters.Label.LastName";
            // 
            // Field_Status
            // 
            this.Field_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Field_Status.FormattingEnabled = true;
            this.Field_Status.Location = new System.Drawing.Point(311, 36);
            this.Field_Status.Name = "Field_Status";
            this.Field_Status.Size = new System.Drawing.Size(197, 24);
            this.Field_Status.Sorted = true;
            this.Field_Status.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "%%Filters.Label.Status";
            // 
            // Field_Post
            // 
            this.Field_Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Field_Post.FormattingEnabled = true;
            this.Field_Post.Location = new System.Drawing.Point(514, 36);
            this.Field_Post.Name = "Field_Post";
            this.Field_Post.Size = new System.Drawing.Size(396, 24);
            this.Field_Post.Sorted = true;
            this.Field_Post.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "%%Filters.Label.Post";
            // 
            // Field_Departament
            // 
            this.Field_Departament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Field_Departament.FormattingEnabled = true;
            this.Field_Departament.Location = new System.Drawing.Point(6, 85);
            this.Field_Departament.Name = "Field_Departament";
            this.Field_Departament.Size = new System.Drawing.Size(502, 24);
            this.Field_Departament.Sorted = true;
            this.Field_Departament.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "%%Filters.Label.Departament";
            // 
            // EmployeeListFiltersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Field_Departament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Field_Post);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Field_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Field_LastName);
            this.Name = "EmployeeListFiltersControl";
            this.Size = new System.Drawing.Size(940, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Field_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Field_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Field_Post;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Field_Departament;
        private System.Windows.Forms.Label label4;
    }
}
