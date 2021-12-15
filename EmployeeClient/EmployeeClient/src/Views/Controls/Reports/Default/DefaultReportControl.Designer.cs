namespace EmployeeClient.Controls.Reports.Default
{
    partial class DefaultReportControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.defaultReportDataGridControl1 = new EmployeeClient.Controls.Reports.Default.DefaultReportDataGridControl();
            this.defaultReportDetailsDataGridControl1 = new EmployeeClient.Controls.Reports.Default.DefaultReportDetailsDataGridControl();
            this.defaultReportFiltersControl1 = new EmployeeClient.Controls.Reports.Default.DefaultReportFiltersControl();
            this.defaultReportPaginator1 = new EmployeeClient.Controls.Reports.Default.DefaultReportPaginator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 89);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.defaultReportPaginator1);
            this.splitContainer1.Panel1.Controls.Add(this.defaultReportDataGridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.defaultReportDetailsDataGridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(691, 327);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 1;
            // 
            // defaultReportDataGridControl1
            // 
            this.defaultReportDataGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultReportDataGridControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultReportDataGridControl1.Name = "defaultReportDataGridControl1";
            this.defaultReportDataGridControl1.Size = new System.Drawing.Size(691, 213);
            this.defaultReportDataGridControl1.TabIndex = 0;
            // 
            // defaultReportDetailsDataGridControl1
            // 
            this.defaultReportDetailsDataGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultReportDetailsDataGridControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultReportDetailsDataGridControl1.Name = "defaultReportDetailsDataGridControl1";
            this.defaultReportDetailsDataGridControl1.Size = new System.Drawing.Size(691, 110);
            this.defaultReportDetailsDataGridControl1.TabIndex = 0;
            // 
            // defaultReportFiltersControl1
            // 
            this.defaultReportFiltersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultReportFiltersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultReportFiltersControl1.Name = "defaultReportFiltersControl1";
            this.defaultReportFiltersControl1.Size = new System.Drawing.Size(691, 89);
            this.defaultReportFiltersControl1.TabIndex = 0;
            // 
            // defaultReportPaginator1
            // 
            this.defaultReportPaginator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.defaultReportPaginator1.Location = new System.Drawing.Point(0, 176);
            this.defaultReportPaginator1.Name = "defaultReportPaginator1";
            this.defaultReportPaginator1.Size = new System.Drawing.Size(691, 37);
            this.defaultReportPaginator1.TabIndex = 1;
            // 
            // DefaultReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.defaultReportFiltersControl1);
            this.Name = "DefaultReportControl";
            this.Size = new System.Drawing.Size(691, 416);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DefaultReportFiltersControl defaultReportFiltersControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DefaultReportDataGridControl defaultReportDataGridControl1;
        private DefaultReportDetailsDataGridControl defaultReportDetailsDataGridControl1;
        private DefaultReportPaginator defaultReportPaginator1;
    }
}
