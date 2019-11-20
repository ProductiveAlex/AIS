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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PlotGridView = new System.Windows.Forms.DataGridView();
            this.equipmentDataSet = new AIS.EquipmentDataSet();
            this.eqPurposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlotGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqPurposeBindingSource)).BeginInit();
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
            // 
            // Delete_Type
            // 
            this.Delete_Type.Image = global::AIS.Properties.Resources.item_delete;
            this.Delete_Type.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete_Type.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Type.Name = "Delete_Type";
            this.Delete_Type.Size = new System.Drawing.Size(79, 28);
            this.Delete_Type.Text = "Удалить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Участки";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(293, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(157, 20);
            this.Search.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(227, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск";
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
            this.panel1.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Type,
            this.Edit_Type,
            this.Delete_Type});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(453, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PlotGridView
            // 
            this.PlotGridView.AllowUserToAddRows = false;
            this.PlotGridView.AllowUserToDeleteRows = false;
            this.PlotGridView.AutoGenerateColumns = false;
            this.PlotGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlotGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iDDataGridViewTextBoxColumn,
            this.purposeNameDataGridViewTextBoxColumn});
            this.PlotGridView.DataSource = this.eqPurposeBindingSource;
            this.PlotGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotGridView.Location = new System.Drawing.Point(0, 55);
            this.PlotGridView.Name = "PlotGridView";
            this.PlotGridView.ReadOnly = true;
            this.PlotGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlotGridView.Size = new System.Drawing.Size(453, 375);
            this.PlotGridView.TabIndex = 11;
            // 
            // equipmentDataSet
            // 
            this.equipmentDataSet.DataSetName = "EquipmentDataSet";
            this.equipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eqPurposeBindingSource
            // 
            this.eqPurposeBindingSource.DataMember = "EqPurpose";
            this.eqPurposeBindingSource.DataSource = this.equipmentDataSet;
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
            // EqTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 430);
            this.Controls.Add(this.PlotGridView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EqTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EqTypes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlotGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqPurposeBindingSource)).EndInit();
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
        public System.Windows.Forms.DataGridView PlotGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eqPurposeBindingSource;
        private EquipmentDataSet equipmentDataSet;
    }
}