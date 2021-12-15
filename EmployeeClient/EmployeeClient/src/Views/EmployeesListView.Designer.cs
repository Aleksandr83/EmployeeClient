namespace EmployeeClient.Views
{
    partial class EmployeesListView
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
            this.employeeListFiltersControl1 = new EmployeeClient.Controls.EmployeeListFiltersControl();
            this.employeePaginatorControl1 = new EmployeeClient.Controls.EmployeePaginatorControl();
            this.employeeDataGridViewControl1 = new EmployeeClient.Controls.EmployeeDataGridViewControl();
            this.SuspendLayout();
            // 
            // employeeListFiltersControl1
            // 
            this.employeeListFiltersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeListFiltersControl1.Location = new System.Drawing.Point(0, 0);
            this.employeeListFiltersControl1.Name = "employeeListFiltersControl1";
            this.employeeListFiltersControl1.Size = new System.Drawing.Size(982, 125);
            this.employeeListFiltersControl1.TabIndex = 1;
            // 
            // employeePaginatorControl1
            // 
            this.employeePaginatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeePaginatorControl1.Location = new System.Drawing.Point(0, 439);
            this.employeePaginatorControl1.Name = "employeePaginatorControl1";
            this.employeePaginatorControl1.Size = new System.Drawing.Size(982, 39);
            this.employeePaginatorControl1.TabIndex = 3;
            // 
            // employeeDataGridViewControl1
            // 
            this.employeeDataGridViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridViewControl1.Location = new System.Drawing.Point(0, 125);
            this.employeeDataGridViewControl1.Name = "employeeDataGridViewControl1";
            this.employeeDataGridViewControl1.Size = new System.Drawing.Size(982, 314);
            this.employeeDataGridViewControl1.TabIndex = 4;
            // 
            // EmployeesListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeDataGridViewControl1);
            this.Controls.Add(this.employeePaginatorControl1);
            this.Controls.Add(this.employeeListFiltersControl1);
            this.Name = "EmployeesListView";
            this.Size = new System.Drawing.Size(982, 478);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.EmployeeListFiltersControl employeeListFiltersControl1;
        private Controls.EmployeePaginatorControl employeePaginatorControl1;
        private Controls.EmployeeDataGridViewControl employeeDataGridViewControl1;
    }
}
