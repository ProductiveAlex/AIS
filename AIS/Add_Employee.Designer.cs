namespace AIS
{
    partial class Add_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Employee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmployeePost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FullEmployeeName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmployeePost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FullEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(146, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // EmployeePost
            // 
            this.EmployeePost.Location = new System.Drawing.Point(107, 70);
            this.EmployeePost.Name = "EmployeePost";
            this.EmployeePost.Size = new System.Drawing.Size(183, 20);
            this.EmployeePost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО сотрудника";
            // 
            // FullEmployeeName
            // 
            this.FullEmployeeName.Location = new System.Drawing.Point(107, 39);
            this.FullEmployeeName.Name = "FullEmployeeName";
            this.FullEmployeeName.Size = new System.Drawing.Size(183, 20);
            this.FullEmployeeName.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AIS.Properties.Resources.add_user_128px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Image = global::AIS.Properties.Resources.btn_cancel;
            this.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.Location = new System.Drawing.Point(242, 160);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(85, 22);
            this.ButtonCancel.TabIndex = 29;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Image = global::AIS.Properties.Resources.btn_ok;
            this.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new System.Drawing.Point(126, 160);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(92, 22);
            this.ButtonOK.TabIndex = 28;
            this.ButtonOK.Text = "Применить";
            this.ButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 194);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox EmployeePost;
        public System.Windows.Forms.TextBox FullEmployeeName;
    }
}