namespace AIS
{
    partial class EmployeeCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_Employee = new System.Windows.Forms.ToolStripButton();
            this.Edit_Employee = new System.Windows.Forms.ToolStripButton();
            this.Delete_Employee = new System.Windows.Forms.ToolStripButton();
            this.employeeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDataSet = new AIS.EquipmentDataSet();
            this.employeeListTableAdapter = new AIS.EquipmentDataSetTableAdapters.EmployeeListTableAdapter();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 55);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(228, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(294, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(157, 20);
            this.Search.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сотрудники";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Employee,
            this.Edit_Employee,
            this.Delete_Employee});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(453, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_Employee
            // 
            this.Add_Employee.Image = global::AIS.Properties.Resources.item_add;
            this.Add_Employee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_Employee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(87, 28);
            this.Add_Employee.Text = "Добавить";
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Edit_Employee
            // 
            this.Edit_Employee.Image = global::AIS.Properties.Resources.item_edit;
            this.Edit_Employee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Employee.Name = "Edit_Employee";
            this.Edit_Employee.Size = new System.Drawing.Size(115, 28);
            this.Edit_Employee.Text = "Редактировать";
            this.Edit_Employee.Click += new System.EventHandler(this.Edit_Employee_Click);
            // 
            // Delete_Employee
            // 
            this.Delete_Employee.Image = global::AIS.Properties.Resources.item_delete;
            this.Delete_Employee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete_Employee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Employee.Name = "Delete_Employee";
            this.Delete_Employee.Size = new System.Drawing.Size(79, 28);
            this.Delete_Employee.Text = "Удалить";
            this.Delete_Employee.Click += new System.EventHandler(this.Delete_Employee_Click);
            // 
            // employeeListBindingSource
            // 
            this.employeeListBindingSource.DataMember = "EmployeeList";
            this.employeeListBindingSource.DataSource = this.equipmentDataSet;
            // 
            // equipmentDataSet
            // 
            this.equipmentDataSet.DataSetName = "EquipmentDataSet";
            this.equipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeListTableAdapter
            // 
            this.employeeListTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AutoGenerateColumns = false;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.EmployeeGridView.DataSource = this.employeeListBindingSource;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.Location = new System.Drawing.Point(0, 55);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGridView.Size = new System.Drawing.Size(453, 375);
            this.EmployeeGridView.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullEmployeeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО сотрудника";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 187;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeePost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Текущая должность сотрудника";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 187;
            // 
            // EmployeeCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 430);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.EmployeeCatalog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeCatalog_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullEmployeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_Employee;
        private System.Windows.Forms.ToolStripButton Edit_Employee;
        private System.Windows.Forms.ToolStripButton Delete_Employee;
        private System.Windows.Forms.BindingSource employeeListBindingSource;
        private EquipmentDataSet equipmentDataSet;
        private EquipmentDataSetTableAdapters.EmployeeListTableAdapter employeeListTableAdapter;
        public System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}