namespace AIS
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlotAdd = new System.Windows.Forms.Button();
            this.TypeAdd = new System.Windows.Forms.Button();
            this.PurposeAdd = new System.Windows.Forms.Button();
            this.ArriveDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EqState = new System.Windows.Forms.ComboBox();
            this.EqPlot = new System.Windows.Forms.ComboBox();
            this.EqAssign = new System.Windows.Forms.ComboBox();
            this.EqType = new System.Windows.Forms.ComboBox();
            this.EqName = new System.Windows.Forms.TextBox();
            this.Inv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.Image")));
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(247, 236);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(85, 22);
            this.ButtonCancel.TabIndex = 27;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Image = global::AIS.Properties.Resources.btn_ok;
            this.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new System.Drawing.Point(131, 236);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(92, 22);
            this.ButtonOK.TabIndex = 26;
            this.ButtonOK.Text = "Применить";
            this.ButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PlotAdd);
            this.groupBox1.Controls.Add(this.TypeAdd);
            this.groupBox1.Controls.Add(this.PurposeAdd);
            this.groupBox1.Controls.Add(this.ArriveDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.EqState);
            this.groupBox1.Controls.Add(this.EqPlot);
            this.groupBox1.Controls.Add(this.EqAssign);
            this.groupBox1.Controls.Add(this.EqType);
            this.groupBox1.Controls.Add(this.EqName);
            this.groupBox1.Controls.Add(this.Inv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(155, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 226);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // PlotAdd
            // 
            this.PlotAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PlotAdd.Location = new System.Drawing.Point(450, 141);
            this.PlotAdd.Name = "PlotAdd";
            this.PlotAdd.Size = new System.Drawing.Size(24, 22);
            this.PlotAdd.TabIndex = 53;
            this.PlotAdd.Text = "+";
            this.PlotAdd.UseVisualStyleBackColor = true;
            // 
            // TypeAdd
            // 
            this.TypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TypeAdd.Location = new System.Drawing.Point(450, 87);
            this.TypeAdd.Name = "TypeAdd";
            this.TypeAdd.Size = new System.Drawing.Size(24, 22);
            this.TypeAdd.TabIndex = 52;
            this.TypeAdd.Text = "+";
            this.TypeAdd.UseVisualStyleBackColor = true;
            // 
            // PurposeAdd
            // 
            this.PurposeAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PurposeAdd.Location = new System.Drawing.Point(450, 114);
            this.PurposeAdd.Name = "PurposeAdd";
            this.PurposeAdd.Size = new System.Drawing.Size(24, 22);
            this.PurposeAdd.TabIndex = 51;
            this.PurposeAdd.Text = "+";
            this.PurposeAdd.UseVisualStyleBackColor = true;
            // 
            // ArriveDate
            // 
            this.ArriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ArriveDate.Location = new System.Drawing.Point(170, 196);
            this.ArriveDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.ArriveDate.MinimumSize = new System.Drawing.Size(274, 21);
            this.ArriveDate.Name = "ArriveDate";
            this.ArriveDate.Size = new System.Drawing.Size(274, 21);
            this.ArriveDate.TabIndex = 50;
            this.ArriveDate.Value = new System.DateTime(2019, 11, 11, 12, 42, 22, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Дата поступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Номер оборудования по списку";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(213, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 47;
            // 
            // EqState
            // 
            this.EqState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqState.FormattingEnabled = true;
            this.EqState.Items.AddRange(new object[] {
            "Работает",
            "Не работает"});
            this.EqState.Location = new System.Drawing.Point(170, 169);
            this.EqState.Name = "EqState";
            this.EqState.Size = new System.Drawing.Size(274, 21);
            this.EqState.TabIndex = 46;
            // 
            // EqPlot
            // 
            this.EqPlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqPlot.FormattingEnabled = true;
            this.EqPlot.Location = new System.Drawing.Point(170, 142);
            this.EqPlot.Name = "EqPlot";
            this.EqPlot.Size = new System.Drawing.Size(274, 21);
            this.EqPlot.TabIndex = 45;
            // 
            // EqAssign
            // 
            this.EqAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqAssign.FormattingEnabled = true;
            this.EqAssign.Location = new System.Drawing.Point(170, 115);
            this.EqAssign.Name = "EqAssign";
            this.EqAssign.Size = new System.Drawing.Size(274, 21);
            this.EqAssign.TabIndex = 44;
            // 
            // EqType
            // 
            this.EqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqType.FormattingEnabled = true;
            this.EqType.Location = new System.Drawing.Point(170, 88);
            this.EqType.Name = "EqType";
            this.EqType.Size = new System.Drawing.Size(274, 21);
            this.EqType.TabIndex = 43;
            // 
            // EqName
            // 
            this.EqName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqName.Location = new System.Drawing.Point(170, 62);
            this.EqName.Name = "EqName";
            this.EqName.Size = new System.Drawing.Size(274, 20);
            this.EqName.TabIndex = 42;
            // 
            // Inv
            // 
            this.Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inv.Location = new System.Drawing.Point(213, 36);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(231, 20);
            this.Inv.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Состояние оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Участок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Назначение оборудования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Тип оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Наименование оборудования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Инвентарный номер оборудования";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIS.Properties.Resources.Equipment_add;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 267);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlotAdd;
        private System.Windows.Forms.Button TypeAdd;
        private System.Windows.Forms.Button PurposeAdd;
        private System.Windows.Forms.DateTimePicker ArriveDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox EqState;
        public System.Windows.Forms.ComboBox EqPlot;
        public System.Windows.Forms.ComboBox EqAssign;
        public System.Windows.Forms.ComboBox EqType;
        public System.Windows.Forms.TextBox EqName;
        public System.Windows.Forms.TextBox Inv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}