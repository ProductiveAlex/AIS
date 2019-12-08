namespace AIS
{
    partial class EqTypes
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
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.Add_Type = new System.Windows.Forms.ToolStripButton();
            this.Edit_Type = new System.Windows.Forms.ToolStripButton();
            this.Delete_Type = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TypeGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqPurposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDataSet = new AIS.EquipmentDataSet();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqPurposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(453, 31);
            this.miniToolStrip.TabIndex = 1;
            // 
            // Add_Type
            // 
            this.Add_Type.Image = global::AIS.Properties.Resources.item_add;
            this.Add_Type.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_Type.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_Type.Name = "Add_Type";
            this.Add_Type.Size = new System.Drawing.Size(87, 28);
            this.Add_Type.Text = "Добавить";
            this.Add_Type.Click += new System.EventHandler(this.Add_Type_Click);
            // 
            // Edit_Type
            // 
            this.Edit_Type.Image = global::AIS.Properties.Resources.item_edit;
            this.Edit_Type.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Type.Name = "Edit_Type";
            this.Edit_Type.Size = new System.Drawing.Size(115, 28);
            this.Edit_Type.Text = "Редактировать";
            this.Edit_Type.Click += new System.EventHandler(this.Edit_Type_Click);
            // 
            // Delete_Type
            // 
            this.Delete_Type.Image = global::AIS.Properties.Resources.item_delete;
            this.Delete_Type.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete_Type.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Type.Name = "Delete_Type";
            this.Delete_Type.Size = new System.Drawing.Size(79, 28);
            this.Delete_Type.Text = "Удалить";
            this.Delete_Type.Click += new System.EventHandler(this.Delete_Type_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Типы оборудования";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(379, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(143, 20);
            this.Search.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(313, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 55);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(525, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Type,
            this.Edit_Type,
            this.Delete_Type});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(594, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TypeGridView
            // 
            this.TypeGridView.AllowUserToAddRows = false;
            this.TypeGridView.AllowUserToDeleteRows = false;
            this.TypeGridView.AutoGenerateColumns = false;
            this.TypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iDDataGridViewTextBoxColumn,
            this.purposeNameDataGridViewTextBoxColumn});
            this.TypeGridView.DataSource = this.eqPurposeBindingSource;
            this.TypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeGridView.Location = new System.Drawing.Point(0, 55);
            this.TypeGridView.Name = "TypeGridView";
            this.TypeGridView.ReadOnly = true;
            this.TypeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TypeGridView.Size = new System.Drawing.Size(594, 376);
            this.TypeGridView.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 205;
            // 
            // purposeNameDataGridViewTextBoxColumn
            // 
            this.purposeNameDataGridViewTextBoxColumn.DataPropertyName = "PurposeName";
            this.purposeNameDataGridViewTextBoxColumn.HeaderText = "Тип оборудования";
            this.purposeNameDataGridViewTextBoxColumn.Name = "purposeNameDataGridViewTextBoxColumn";
            this.purposeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.purposeNameDataGridViewTextBoxColumn.Width = 205;
            // 
            // eqPurposeBindingSource
            // 
            this.eqPurposeBindingSource.DataMember = "EqPurpose";
            this.eqPurposeBindingSource.DataSource = this.equipmentDataSet;
            // 
            // equipmentDataSet
            // 
            this.equipmentDataSet.DataSetName = "EquipmentDataSet";
            this.equipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox1.Location = new System.Drawing.Point(185, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Архив";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // EqTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 431);
            this.Controls.Add(this.TypeGridView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 470);
            this.Name = "EqTypes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EqTypes";
            this.Load += new System.EventHandler(this.EqTypes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqPurposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton Add_Type;
        private System.Windows.Forms.ToolStripButton Edit_Type;
        private System.Windows.Forms.ToolStripButton Delete_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.DataGridView TypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eqPurposeBindingSource;
        private EquipmentDataSet equipmentDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}