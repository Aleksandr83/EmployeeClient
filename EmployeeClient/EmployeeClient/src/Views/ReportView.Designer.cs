namespace EmployeeClient.Views
{
    partial class ReportView
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
            this.reportSelectorControl1 = new EmployeeClient.Controls.ReportSelectorControl();
            this.defaultReportControl1 = new EmployeeClient.Controls.Reports.Default.DefaultReportControl();
            this.SuspendLayout();
            // 
            // reportSelectorControl1
            // 
            this.reportSelectorControl1.Visible = false;
            this.reportSelectorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportSelectorControl1.Location = new System.Drawing.Point(0, 0);
            this.reportSelectorControl1.Name = "reportSelectorControl1";
            this.reportSelectorControl1.Size = new System.Drawing.Size(813, 73);
            this.reportSelectorControl1.TabIndex = 0;
            // 
            // defaultReportControl1
            // 
            this.defaultReportControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultReportControl1.Location = new System.Drawing.Point(0, 73);
            this.defaultReportControl1.Name = "defaultReportControl1";
            this.defaultReportControl1.Size = new System.Drawing.Size(813, 423);
            this.defaultReportControl1.TabIndex = 1;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defaultReportControl1);
            this.Controls.Add(this.reportSelectorControl1);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(813, 496);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ReportSelectorControl reportSelectorControl1;
        private Controls.Reports.Default.DefaultReportControl defaultReportControl1;
    }
}
