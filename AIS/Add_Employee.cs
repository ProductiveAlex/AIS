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

            cancontinue = false;

            if (FullEmployeeName.Text.Length == 0)
            {
                MessageBox.Show("Введите фамилию", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FullEmployeeName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите имя", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите отчество", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            //if (EmployeePost.Text.Length < 5)
            //{
            //    MessageBox.Show("Необходимо выбрать должность сотрудника", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    EmployeePost.Focus();
            //    this.DialogResult = DialogResult.None;
            //    return;
            //}

            cancontinue = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            change_conn_state();
            if (Form == 0)
            {
                SqlStr = "INSERT INTO EmployeeList(EmployeePost, FullEmployeeName) Values (@Post , @FIO)";
                checkfields();
                if (cancontinue)
                {
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, connection);
                    Cmd.Parameters.AddWithValue("@Post", EmployeePost.Text);
                    Cmd.Parameters.AddWithValue("@FIO", FullEmployeeName.Text + " " + textBox1.Text + " " + textBox2.Text);
                    Cmd.ExecuteNonQuery();
                }
            }

            if (Form == 1)
            {
                SqlStr = "UPDATE EmployeeList SET FullEmployeeName = @FullEmployeeName, EmployeePost = @EmployeePost WHERE ID = @ID";
                checkfields();
                if (cancontinue)
                {
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, connection);

                    Cmd.Parameters.AddWithValue("@FullEmployeeName", FullEmployeeName.Text + " " + textBox1.Text + " " + textBox2.Text);
                    Cmd.Parameters.AddWithValue("@EmployeePost", EmployeePost.Text);
                    Cmd.Parameters.AddWithValue("@ID", ID);
                    Cmd.ExecuteNonQuery();
                }
            }
            change_conn_state();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void FullEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
}
