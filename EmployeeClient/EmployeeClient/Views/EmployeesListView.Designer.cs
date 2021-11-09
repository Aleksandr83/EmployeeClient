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
            this.employeeDataGridViewControl1 = new EmployeeClient.Controls.EmployeeDataGridViewControl();
            this.SuspendLayout();
            // 
            // employeeListFiltersControl1
            // 
            this.employeeListFiltersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeListFiltersControl1.Location = new System.Drawing.Point(0, 0);
            this.employeeListFiltersControl1.Name = "employeeListFiltersControl1";
            this.employeeListFiltersControl1.Size = new System.Drawing.Size(813, 125);
            this.employeeListFiltersControl1.TabIndex = 1;
            // 
            // employeeDataGridViewControl1
            // 
            this.employeeDataGridViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridViewControl1.Location = new System.Drawing.Point(0, 125);
            this.employeeDataGridViewControl1.Name = "employeeDataGridViewControl1";
            this.employeeDataGridViewControl1.Size = new System.Drawing.Size(813, 353);
            this.employeeDataGridViewControl1.TabIndex = 2;
            // 
            // EmployeesListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeDataGridViewControl1);
            this.Controls.Add(this.employeeListFiltersControl1);
            this.Name = "EmployeesListView";
            this.Size = new System.Drawing.Size(813, 478);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.EmployeeListFiltersControl employeeListFiltersControl1;
        private Controls.EmployeeDataGridViewControl employeeDataGridViewControl1;
    }
}
