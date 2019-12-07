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
        OleDbConnection connection = new OleDbConnection(MainForm.connectionstring);
        bool cancontinue = false;
        string SqlStr = "";

        void change_conn_state()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            else
            {
                connection.Open();
            }
        }

        public Add_Employee()
        {
            InitializeComponent();
        }

        void checkfields()
        {
            string[] contains = new string[26] {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                "+", "-", "/", "\\", ".", "!", "@", "#", "№", "$",
                "%", "^", "&", "*", "(", ")" };//проверка на корректность вводимого ФИО
            bool flag = false;
            cancontinue = false;

            foreach (string cont in contains)
            {
                if (FullEmployeeName.Text.Contains(cont))
                {
                    MessageBox.Show("Некорректно введено ФИО (в ФИО не может быть цифр))", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    flag = true;
                    FullEmployeeName.Focus();
                    return;
                }
            }

            if (flag)
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

            cancontinue = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (Form == 0)
            {
                change_conn_state();

                SqlStr = "INSERT INTO EmployeeList(EmployeePost, FullEmployeeName) Values ('"
                            + EmployeePost.Text + "' , '"
                            + FullEmployeeName.Text + "')";


                if (cancontinue)
                {
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, connection);
                    Cmd.ExecuteNonQuery();
                }
                change_conn_state();
            }


            if (Form == 1)
            {
                change_conn_state();

                SqlStr = "UPDATE EmployeeList SET FullEmployeeName = @FullEmployeeName, EmployeePost = @EmployeePost WHERE ID = @ID";

                OleDbCommand Cmd = new OleDbCommand(SqlStr, connection);

                Cmd.Parameters.AddWithValue("@FullEmployeeName", FullEmployeeName.Text);
                Cmd.Parameters.AddWithValue("@EmployeePost", EmployeePost.Text);
                Cmd.Parameters.AddWithValue("@ID", ID);

                checkfields();

                if (cancontinue)
                    Cmd.ExecuteNonQuery();

                change_conn_state();
            }
        }
    }
}
