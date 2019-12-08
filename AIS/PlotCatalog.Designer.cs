namespace AIS
{
    partial class PlotCatalog
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
            this.Add_Plot = new System.Windows.Forms.ToolStripButton();
            this.Edit_Plot = new System.Windows.Forms.ToolStripButton();
            this.Delete_Plot = new System.Windows.Forms.ToolStripButton();
            this.PlotGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDataSet = new AIS.EquipmentDataSet();
            this.plotListTableAdapter = new AIS.EquipmentDataSetTableAdapters.PlotListTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlotGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(572, 55);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(251, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Поиск";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(317, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(172, 20);
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
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Участки";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Plot,
            this.Edit_Plot,
            this.Delete_Plot});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(572, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_Plot
            // 
            this.Add_Plot.Image = global::AIS.Properties.Resources.item_add;
            this.Add_Plot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_Plot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_Plot.Name = "Add_Plot";
            this.Add_Plot.Size = new System.Drawing.Size(87, 28);
            this.Add_Plot.Text = "Добавить";
            this.Add_Plot.Click += new System.EventHandler(this.Add_Plot_Click);
            // 
            // Edit_Plot
            // 
            this.Edit_Plot.Image = global::AIS.Properties.Resources.item_edit;
            this.Edit_Plot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_Plot.Name = "Edit_Plot";
            this.Edit_Plot.Size = new System.Drawing.Size(115, 28);
            this.Edit_Plot.Text = "Редактировать";
            this.Edit_Plot.Click += new System.EventHandler(this.Edit_Plot_Click);
            // 
            // Delete_Plot
            // 
            this.Delete_Plot.Image = global::AIS.Properties.Resources.item_delete;
            this.Delete_Plot.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete_Plot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_Plot.Name = "Delete_Plot";
            this.Delete_Plot.Size = new System.Drawing.Size(79, 28);
            this.Delete_Plot.Text = "Удалить";
            this.Delete_Plot.Click += new System.EventHandler(this.Delete_Plot_Click);
            // 
            // PlotGridView
            // 
            this.PlotGridView.AllowUserToAddRows = false;
            this.PlotGridView.AllowUserToDeleteRows = false;
            this.PlotGridView.AutoGenerateColumns = false;
            this.PlotGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlotGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlotGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iDDataGridViewTextBoxColumn,
            this.plotNameDataGridViewTextBoxColumn});
            this.PlotGridView.DataSource = this.plotListBindingSource;
            this.PlotGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotGridView.Location = new System.Drawing.Point(0, 55);
            this.PlotGridView.Name = "PlotGridView";
            this.PlotGridView.ReadOnly = true;
            this.PlotGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlotGridView.Size = new System.Drawing.Size(572, 371);
            this.PlotGridView.TabIndex = 8;
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
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID участка";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plotNameDataGridViewTextBoxColumn
            // 
            this.plotNameDataGridViewTextBoxColumn.DataPropertyName = "PlotName";
            this.plotNameDataGridViewTextBoxColumn.HeaderText = "Наименование участка";
            this.plotNameDataGridViewTextBoxColumn.Name = "plotNameDataGridViewTextBoxColumn";
            this.plotNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plotListBindingSource
            // 
            this.plotListBindingSource.DataMember = "PlotList";
            this.plotListBindingSource.DataSource = this.equipmentDataSet;
            // 
            // equipmentDataSet
            // 
            this.equipmentDataSet.DataSetName = "EquipmentDataSet";
            this.equipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plotListTableAdapter
            // 
            this.plotListTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(494, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBox1.Location = new System.Drawing.Point(87, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Архив";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // PlotCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 426);
            this.Controls.Add(this.PlotGridView);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 465);
            this.Name = "PlotCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlotCatalog";
            this.Load += new System.EventHandler(this.PlotCatalog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlotCatalog_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlotGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_Plot;
        private System.Windows.Forms.ToolStripButton Edit_Plot;
        private System.Windows.Forms.ToolStripButton Delete_Plot;
        private EquipmentDataSet equipmentDataSet;
        public System.Windows.Forms.DataGridView PlotGridView;
        private System.Windows.Forms.BindingSource plotListBindingSource;
        private EquipmentDataSetTableAdapters.PlotListTableAdapter plotListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}