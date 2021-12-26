namespace EmployeeClient.Controls.Reports.Default
{
    partial class DefaultReportFiltersControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.employeeStateFilterControl1 = new EmployeeClient.Controls.DataFiltres.EmployeeStateFilterControl();
            this.dataFilterControl2 = new EmployeeClient.Controls.DataFiltres.DataFilterControl();
            this.dataFilterControl1 = new EmployeeClient.Controls.DataFiltres.DataFilterControl();
            this.statusFilterControl1 = new EmployeeClient.Controls.DataFiltres.StatusFilterControl();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "%%DateRange.Header";
            // 
            // employeeStateFilterControl1
            // 
            this.employeeStateFilterControl1.Location = new System.Drawing.Point(550, 17);
            this.employeeStateFilterControl1.Name = "employeeStateFilterControl1";
            this.employeeStateFilterControl1.Size = new System.Drawing.Size(222, 60);
            this.employeeStateFilterControl1.TabIndex = 16;
            // 
            // dataFilterControl2
            // 
            this.dataFilterControl2.Location = new System.Drawing.Point(390, 26);
            this.dataFilterControl2.Name = "dataFilterControl2";
            this.dataFilterControl2.Size = new System.Drawing.Size(143, 40);
            this.dataFilterControl2.TabIndex = 15;
            this.dataFilterControl2.Text = "%%DateRange.EndDate";
            // 
            // dataFilterControl1
            // 
            this.dataFilterControl1.Location = new System.Drawing.Point(257, 26);
            this.dataFilterControl1.Name = "dataFilterControl1";
            this.dataFilterControl1.Size = new System.Drawing.Size(143, 51);
            this.dataFilterControl1.TabIndex = 14;
            this.dataFilterControl1.Text = "%%DateRange.StartDate";
            // 
            // statusFilterControl1
            // 
            this.statusFilterControl1.Location = new System.Drawing.Point(12, 15);
            this.statusFilterControl1.Name = "statusFilterControl1";
            this.statusFilterControl1.Size = new System.Drawing.Size(219, 66);
            this.statusFilterControl1.TabIndex = 12;
            // 
            // DefaultReportFiltersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeStateFilterControl1);
            this.Controls.Add(this.dataFilterControl2);
            this.Controls.Add(this.dataFilterControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusFilterControl1);
            this.Name = "DefaultReportFiltersControl";
            this.Size = new System.Drawing.Size(785, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataFiltres.StatusFilterControl statusFilterControl1;
        private DataFiltres.EmployeeStateFilterControl employeeStateFilterControl1;
        private DataFiltres.DataFilterControl dataFilterControl2;
        private DataFiltres.DataFilterControl dataFilterControl1;
        private System.Windows.Forms.Label label4;
    }
}
