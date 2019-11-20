using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AIS
{
    public partial class EditHistory : Form
    {
        public string ID;
        public EditHistory()
        {
            InitializeComponent();
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (FullEmployeeName.SelectedValue != "")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                FullEmployeeName.SelectedIndex = 0;
            }

#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (EmployeePost.SelectedValue != "")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                EmployeePost.SelectedIndex = 0;
            }
        }

        private void Check()
        {
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

            if (FullEmployeeName.SelectedIndex == 0)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            try
            {
                OleDbConnection conn = new OleDbConnection(MainForm.connectionstring);
                conn.Open();
                string CmdText = "";

                if (MainForm.id == 0)
                {
                    CmdText = "UPDATE EqFailHistory SET DateTimeFail = @DateTimeFail, EqFailName = @EqFailName, FailReason = @FailReason, FullEmployeeName = @FullEmployeeName, EmployeePost = @EmployeePost "
                   + "WHERE EqFailID = @EqFailID";
                }
                else
                {
                    CmdText = "UPDATE EqTechHistory SET DateTimeTech = @DateTimeTech, EqTechName = @EqTechName, FullEmployeeName = @FullEmployeeName, EmployeePost = @EmployeePost "
                   + "WHERE EqTechID = @EqTechID";
                }
                    OleDbCommand Cmd = new OleDbCommand(CmdText, conn);
                if (MainForm.id == 0)
                {
                    Cmd.Parameters.AddWithValue("DateTimeFail", DateTime.Value);
                    Cmd.Parameters.AddWithValue("EqFailName", EqFailName.Text);
                    Cmd.Parameters.AddWithValue("FailReason", Fail.Text);
                    Cmd.Parameters.AddWithValue("FullEmployeeName", FullEmployeeName.Text);
                    Cmd.Parameters.AddWithValue("EmployeePost", EmployeePost.Text);
                    Cmd.Parameters.AddWithValue("EqFailID", ID);
                    
                    Check();

                }
                else
                {
                    Cmd.Parameters.AddWithValue("DateTimeTech", DateTime.Value);
                    Cmd.Parameters.AddWithValue("EqTechName", EqFailName.Text);
                    Cmd.Parameters.AddWithValue("FullEmployeeName", FullEmployeeName.Text);
                    Cmd.Parameters.AddWithValue("EmployeePost", EmployeePost.Text);
                    Cmd.Parameters.AddWithValue("EqTechID", ID);
                    Check();
                }
                Cmd.ExecuteNonQuery();
                conn.Close();

            }

            finally
            {
               // main.RefreshEqData();
                main.RefreshDataRequest(MainForm.id);
            }
        }

        private void EditHistory_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
