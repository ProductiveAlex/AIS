namespace AIS
{
    partial class InsertHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertHistory));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.EmployeePost = new System.Windows.Forms.ComboBox();
            this.FullEmployeeName = new System.Windows.Forms.ComboBox();
            this.EqFailName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Full = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Image = global::AIS.Properties.Resources.btn_ok;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(215, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Применить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(313, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Fail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateTime);
            this.groupBox1.Controls.Add(this.EmployeePost);
            this.groupBox1.Controls.Add(this.FullEmployeeName);
            this.groupBox1.Controls.Add(this.EqFailName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Full);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(155, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 153);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Fail
            // 
            this.Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fail.Location = new System.Drawing.Point(170, 65);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(274, 20);
            this.Fail.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Причина отказа";
            // 
            // DateTime
            // 
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime.Location = new System.Drawing.Point(170, 13);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(274, 20);
            this.DateTime.TabIndex = 27;
            this.DateTime.Tag = "ываыва";
            // 
            // EmployeePost
            // 
            this.EmployeePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeePost.FormattingEnabled = true;
            this.EmployeePost.Items.AddRange(new object[] {
            "Выберите должность сотрудника",
            "Рабочий",
            "Зав. хоз",
            "Инженер",
            "Главный инженер"});
            this.EmployeePost.Location = new System.Drawing.Point(170, 120);
            this.EmployeePost.Name = "EmployeePost";
            this.EmployeePost.Size = new System.Drawing.Size(274, 21);
            this.EmployeePost.TabIndex = 31;
            // 
            // FullEmployeeName
            // 
            this.FullEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FullEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FullEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullEmployeeName.FormattingEnabled = true;
            this.FullEmployeeName.Items.AddRange(new object[] {
            "Выберите сотрудника",
            "Шайнов Роман Владиславович",
            "Королев Кирилл Сергеевич",
            "Масюкевич Эдвард Александрович",
            "Голуб Владислав Александрович"});
            this.FullEmployeeName.Location = new System.Drawing.Point(226, 93);
            this.FullEmployeeName.Name = "FullEmployeeName";
            this.FullEmployeeName.Size = new System.Drawing.Size(218, 21);
            this.FullEmployeeName.TabIndex = 30;
            // 
            // EqFailName
            // 
            this.EqFailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqFailName.Location = new System.Drawing.Point(170, 39);
            this.EqFailName.Name = "EqFailName";
            this.EqFailName.Size = new System.Drawing.Size(274, 20);
            this.EqFailName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Назначение оборудования";
            // 
            // Full
            // 
            this.Full.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Full.AutoSize = true;
            this.Full.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Full.Location = new System.Drawing.Point(6, 96);
            this.Full.Name = "Full";
            this.Full.Size = new System.Drawing.Size(214, 13);
            this.Full.TabIndex = 34;
            this.Full.Text = "ФИО сотрудника, проводившего осмотр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Наименование события";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Дата события";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIS.Properties.Resources.form_green_add;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // InsertHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 194);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(636, 233);
            this.Name = "InsertHistory";
            this.Text = "InsertHistory";
            this.Load += new System.EventHandler(this.InsertHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox Fail;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker DateTime;
        public System.Windows.Forms.ComboBox EmployeePost;
        public System.Windows.Forms.ComboBox FullEmployeeName;
        public System.Windows.Forms.TextBox EqFailName;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label Full;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}