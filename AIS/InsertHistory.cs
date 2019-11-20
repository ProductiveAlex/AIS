using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AIS
{
    public partial class InsertHistory : Form
    {
        public string ID;
        public InsertHistory()
        {
            InitializeComponent();
            FullEmployeeName.SelectedIndex = 0;
            EmployeePost.SelectedIndex = 0;
        }

        public void InsertHistory_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            string CmdText = "";
            OleDbConnection conn = new OleDbConnection(MainForm.connectionstring);
            conn.Open();

            if (MainForm.id == 0)
            {
                CmdText = "INSERT INTO EqFailHistory(EqListID, DateTimeFail, EqFailName, FailReason, EmployeePost, FullEmployeeName) Values ('"
                        + ID + "' , '"
                        + DateTime.Value + "' , '"
                        + EqFailName.Text + "' , '"
                        + Fail.Text + "' , '"
                        + EmployeePost.Text + "' , '"
                        + FullEmployeeName.Text + "')";
            }

            if (MainForm.id != 0)
            {
                CmdText = "INSERT INTO EqTechHistory(EqListID, DateTimeTech, EqTechName, FullEmployeeName, EmployeePost) Values ('"
                        + ID.ToString() + "' , '"
                        + DateTime.Value + "' , '"
                        + EqFailName.Text + "' , '"
                        + FullEmployeeName.Text + "' , '"
                        + EmployeePost.Text + "')";
            }

            if (EqFailName.TextLength <= 10)
            {
                MessageBox.Show("Длина наименования операции должна быть не менее 10 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqFailName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (Fail.TextLength <= 10 && MainForm.id == 0)
            {
                MessageBox.Show("Длина причины отказа должна быть не менее 10 символов", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fail.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (FullEmployeeName.SelectedValue == "")
            {
                MessageBox.Show("Необходимо выбрать сотрудника", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FullEmployeeName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EmployeePost.SelectedIndex == 0)
            {
                MessageBox.Show("Необходимо выбрать должность сотрудника", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmployeePost.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            OleDbCommand Cmd = new OleDbCommand(CmdText, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();
            main.RefreshEqData();
            main.RefreshDataRequest(MainForm.id);



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
