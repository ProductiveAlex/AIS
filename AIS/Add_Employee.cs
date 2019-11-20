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
    public partial class Add_Employee : Form
    {
        public string ID;
        public int Form;
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void FullEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (Form == 0)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Equipment.mdb");
                conn.Open();

                string CmdText = "INSERT INTO EmployeeList(EmployeePost, FullEmployeeName) Values ('"
                            + EmployeePost.Text + "' , '"
                            + FullEmployeeName.Text + "')";

                if (FullEmployeeName.Text.Length < 15)
                {
                    MessageBox.Show("Необходимо ввести полное имя сотрудника (не менее 15 символов)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FullEmployeeName.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }

                if (EmployeePost.Text.Length < 5)
                {
                    MessageBox.Show("Необходимо выбрать должность сотрудника", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmployeePost.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }

                OleDbCommand Cmd = new OleDbCommand(CmdText, conn);
                Cmd.ExecuteNonQuery();
                conn.Close();

            }
            

            if (Form == 1)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Equipment.mdb");
                conn.Open();

                string CmdText = "UPDATE EmployeeList SET FullEmployeeName = @FullEmployeeName, EmployeePost = @EmployeePost WHERE ID = @ID";

                OleDbCommand Cmd = new OleDbCommand(CmdText, conn);

                Cmd.Parameters.AddWithValue("@FullEmployeeName", FullEmployeeName.Text);
                Cmd.Parameters.AddWithValue("@EmployeePost", EmployeePost.Text);
                Cmd.Parameters.AddWithValue("@ID", ID);

                if (FullEmployeeName.Text.Length < 15)
                {
                    MessageBox.Show("Необходимо ввести полное имя сотрудника (не менее 15 символов)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FullEmployeeName.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }

                if (EmployeePost.Text.Length < 5)
                {
                    MessageBox.Show("Необходимо ввести должность сотрудника", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EmployeePost.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }

                Cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

    }
}
