namespace AIS
{
    partial class EditHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditHistory));
            this.Fail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeePost = new System.Windows.Forms.ComboBox();
            this.FullEmployeeName = new System.Windows.Forms.ComboBox();
            this.EqFailName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Full = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fail
            // 
            this.Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fail.Location = new System.Drawing.Point(177, 63);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(274, 20);
            this.Fail.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Причина отказа";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(177, 11);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(274, 20);
            this.DateTime.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Image = global::AIS.Properties.Resources.btn_ok;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 22);
            this.button1.TabIndex = 35;
            this.button1.Text = "Применить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeePost
            // 
            this.EmployeePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeePost.FormattingEnabled = true;
            this.EmployeePost.Items.AddRange(new object[] {
            "Выберите должность сотрудника",
            "Рабочий",
            "Зав. хоз",
            "Инженер",
            "Главный инженер"});
            this.EmployeePost.Location = new System.Drawing.Point(177, 116);
            this.EmployeePost.Name = "EmployeePost";
            this.EmployeePost.Size = new System.Drawing.Size(274, 21);
            this.EmployeePost.TabIndex = 34;
            // 
            // FullEmployeeName
            // 
            this.FullEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FullEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullEmployeeName.FormattingEnabled = true;
            this.FullEmployeeName.Items.AddRange(new object[] {
            "Выберите сотрудника",
            "Шайнов Роман Владиславович",
            "Королев Кирилл Сергеевич",
            "Масюкевич Эдвард Александрович",
            "Голуб Владислав Александрович"});
            this.FullEmployeeName.Location = new System.Drawing.Point(233, 89);
            this.FullEmployeeName.Name = "FullEmployeeName";
            this.FullEmployeeName.Size = new System.Drawing.Size(218, 21);
            this.FullEmployeeName.TabIndex = 33;
            // 
            // EqFailName
            // 
            this.EqFailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqFailName.Location = new System.Drawing.Point(177, 37);
            this.EqFailName.Name = "EqFailName";
            this.EqFailName.Size = new System.Drawing.Size(274, 20);
            this.EqFailName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Должность сотрудника";
            // 
            // Full
            // 
            this.Full.AutoSize = true;
            this.Full.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Full.Location = new System.Drawing.Point(13, 92);
            this.Full.Name = "Full";
            this.Full.Size = new System.Drawing.Size(214, 13);
            this.Full.TabIndex = 30;
            this.Full.Text = "ФИО сотрудника, проводившего осмотр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Наименование события";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Дата события";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Image = global::AIS.Properties.Resources.btn_cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(236, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 22);
            this.button2.TabIndex = 39;
            this.button2.Text = "Отмена";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmployeePost);
            this.Controls.Add(this.FullEmployeeName);
            this.Controls.Add(this.EqFailName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Full);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditHistory";
            this.Text = "EditHistory";
            this.Load += new System.EventHandler(this.EditHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Fail;
        public System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox EmployeePost;
        public System.Windows.Forms.ComboBox FullEmployeeName;
        public System.Windows.Forms.TextBox EqFailName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label Full;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}