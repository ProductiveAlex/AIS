namespace AIS
{
    partial class InsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Inv = new System.Windows.Forms.TextBox();
            this.EqName = new System.Windows.Forms.TextBox();
            this.EqType = new System.Windows.Forms.ComboBox();
            this.EqAssign = new System.Windows.Forms.ComboBox();
            this.EqPlot = new System.Windows.Forms.ComboBox();
            this.EqState = new System.Windows.Forms.ComboBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ArriveDate = new System.Windows.Forms.DateTimePicker();
            this.PurposeAdd = new System.Windows.Forms.Button();
            this.TypeAdd = new System.Windows.Forms.Button();
            this.PlotAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инвентарный номер оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование оборудования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип оборудования";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Назначение оборудования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Участок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Состояние оборудования";
            // 
            // Inv
            // 
            this.Inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inv.Location = new System.Drawing.Point(219, 18);
            this.Inv.MaxLength = 9;
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(231, 20);
            this.Inv.TabIndex = 6;
            this.Inv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inv_KeyDown);
            this.Inv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inv_KeyPress);
            // 
            // EqName
            // 
            this.EqName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqName.Location = new System.Drawing.Point(176, 44);
            this.EqName.Name = "EqName";
            this.EqName.Size = new System.Drawing.Size(274, 20);
            this.EqName.TabIndex = 7;
            // 
            // EqType
            // 
            this.EqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqType.FormattingEnabled = true;
            this.EqType.Items.AddRange(new object[] {
            "Выберите тип оборудования",
            "Инвертор",
            "Пульвелизатор",
            "Станок",
            "Деревообрабатывающий станок",
            "Металлообрабатывающий станок"});
            this.EqType.Location = new System.Drawing.Point(176, 70);
            this.EqType.Name = "EqType";
            this.EqType.Size = new System.Drawing.Size(274, 21);
            this.EqType.TabIndex = 8;
            // 
            // EqAssign
            // 
            this.EqAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqAssign.FormattingEnabled = true;
            this.EqAssign.Items.AddRange(new object[] {
            "Назначение оборудования",
            "Кромкообрабатывающий станок",
            "Сварка",
            "Ручная дуговая сварка",
            "Окраска",
            "Лакировка",
            "Другое"});
            this.EqAssign.Location = new System.Drawing.Point(176, 97);
            this.EqAssign.Name = "EqAssign";
            this.EqAssign.Size = new System.Drawing.Size(274, 21);
            this.EqAssign.TabIndex = 9;
            this.EqAssign.SelectedIndexChanged += new System.EventHandler(this.EqAssign_SelectedIndexChanged);
            // 
            // EqPlot
            // 
            this.EqPlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqPlot.FormattingEnabled = true;
            this.EqPlot.Items.AddRange(new object[] {
            "Участок"});
            this.EqPlot.Location = new System.Drawing.Point(176, 124);
            this.EqPlot.Name = "EqPlot";
            this.EqPlot.Size = new System.Drawing.Size(274, 21);
            this.EqPlot.TabIndex = 10;
            // 
            // EqState
            // 
            this.EqState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EqState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqState.FormattingEnabled = true;
            this.EqState.Items.AddRange(new object[] {
            "Выберите состояние оборудования",
            "Работает",
            "Не работает"});
            this.EqState.Location = new System.Drawing.Point(176, 151);
            this.EqState.Name = "EqState";
            this.EqState.Size = new System.Drawing.Size(274, 21);
            this.EqState.TabIndex = 11;
            // 
            // Add_Button
            // 
            this.Add_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add_Button.Image = global::AIS.Properties.Resources.btn_ok;
            this.Add_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Button.Location = new System.Drawing.Point(131, 216);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(92, 22);
            this.Add_Button.TabIndex = 12;
            this.Add_Button.Text = "Применить";
            this.Add_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Image = global::AIS.Properties.Resources.btn_cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(247, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 22);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата поступления";
            // 
            // ArriveDate
            // 
            this.ArriveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ArriveDate.Location = new System.Drawing.Point(176, 178);
            this.ArriveDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.ArriveDate.Name = "ArriveDate";
            this.ArriveDate.Size = new System.Drawing.Size(274, 20);
            this.ArriveDate.TabIndex = 15;
            this.ArriveDate.Value = new System.DateTime(2019, 12, 8, 0, 0, 0, 0);
            // 
            // PurposeAdd
            // 
            this.PurposeAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PurposeAdd.Location = new System.Drawing.Point(456, 97);
            this.PurposeAdd.Name = "PurposeAdd";
            this.PurposeAdd.Size = new System.Drawing.Size(24, 21);
            this.PurposeAdd.TabIndex = 16;
            this.PurposeAdd.Text = "...";
            this.PurposeAdd.UseVisualStyleBackColor = true;
            // 
            // TypeAdd
            // 
            this.TypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TypeAdd.Location = new System.Drawing.Point(456, 70);
            this.TypeAdd.Name = "TypeAdd";
            this.TypeAdd.Size = new System.Drawing.Size(24, 21);
            this.TypeAdd.TabIndex = 17;
            this.TypeAdd.Text = "...";
            this.TypeAdd.UseVisualStyleBackColor = true;
            this.TypeAdd.Click += new System.EventHandler(this.TypeAdd_Click);
            // 
            // PlotAdd
            // 
            this.PlotAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PlotAdd.Location = new System.Drawing.Point(456, 124);
            this.PlotAdd.Name = "PlotAdd";
            this.PlotAdd.Size = new System.Drawing.Size(24, 21);
            this.PlotAdd.TabIndex = 18;
            this.PlotAdd.Text = "...";
            this.PlotAdd.UseVisualStyleBackColor = true;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 250);
            this.Controls.Add(this.PlotAdd);
            this.Controls.Add(this.TypeAdd);
            this.Controls.Add(this.PurposeAdd);
            this.Controls.Add(this.ArriveDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.EqState);
            this.Controls.Add(this.EqPlot);
            this.Controls.Add(this.EqAssign);
            this.Controls.Add(this.EqType);
            this.Controls.Add(this.EqName);
            this.Controls.Add(this.Inv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox Inv;
        public System.Windows.Forms.TextBox EqName;
        public System.Windows.Forms.ComboBox EqType;
        public System.Windows.Forms.ComboBox EqAssign;
        public System.Windows.Forms.ComboBox EqPlot;
        public System.Windows.Forms.ComboBox EqState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ArriveDate;
        private System.Windows.Forms.Button PurposeAdd;
        private System.Windows.Forms.Button TypeAdd;
        private System.Windows.Forms.Button PlotAdd;
    }
}