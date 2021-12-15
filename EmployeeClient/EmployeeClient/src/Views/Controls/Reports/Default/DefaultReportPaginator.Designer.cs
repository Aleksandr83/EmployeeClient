namespace EmployeeClient.Controls.Reports.Default
{
    partial class DefaultReportPaginator
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
            this.paginatorControl1 = new PaginatorControl();
            this.SuspendLayout();
            // 
            // paginatorControl1
            // 
            this.paginatorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginatorControl1.Location = new System.Drawing.Point(0, 0);
            this.paginatorControl1.Name = "paginatorControl1";
            this.paginatorControl1.Size = new System.Drawing.Size(736, 37);
            this.paginatorControl1.TabIndex = 0;
            this.paginatorControl1.SetRightOffsetComboBox(22);
            this.paginatorControl1.SetRightOffsetLabelRecordsCount(22);
            // 
            // RefaultReportPaginator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paginatorControl1);
            this.Name = "RefaultReportPaginator";
            this.Size = new System.Drawing.Size(736, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private PaginatorControl paginatorControl1;
    }
}
