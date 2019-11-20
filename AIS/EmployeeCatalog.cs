using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Globalization;
using System.Drawing.Printing;
using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.CSharp;
using System.IO;
using System.Threading;

namespace AIS
{
    public partial class EmployeeCatalog : Form
    {
        public EmployeeCatalog()
        {
            InitializeComponent();
        }

        private void EmployeeCatalog_Load(object sender, EventArgs e)
        {
            Refresh_Employee();
        }

        public void Refresh_Employee()
        {
            OleDbConnection connection = new OleDbConnection(MainForm.connectionstring);
            connection.Open();
            
            //выбрать все из EmployeeList
            string SqlStr =
                    "SELECT *" +
                    "FROM EmployeeList ";

            //если поиск активен
            if (Search.Text != "")
            {
                SqlStr += "WHERE FullEmployeeName LIKE '%' + @FullEmployeeName + '%' OR EmployeePost LIKE '%' +  @EmployeePost + '%' ";
            }

            //сортировка
            SqlStr += "ORDER BY FullEmployeeName";
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SqlStr, connection);

            if (Search.Text != "")
            {
                Adapter.SelectCommand.Parameters.AddWithValue("FullEmployeeName", Search.Text);
                Adapter.SelectCommand.Parameters.AddWithValue("EmployeePost", Search.Text);
            }

            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            EmployeeGridView.AutoGenerateColumns = false;
            EmployeeGridView.DataSource = Table;

            connection.Close();
            Thread.Sleep(200);
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Add_Employee add = new Add_Employee();
            add.Text = "Добавить сотрудника";
            add.pictureBox1.Image = Properties.Resources.add_user_128px;
            add.Form = 0;

            if (add.ShowDialog() == DialogResult.OK)
            {
                Refresh_Employee();
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Refresh_Employee();
        }

        private void Edit_Employee_Click(object sender, EventArgs e)
        {
            Add_Employee edit = new Add_Employee();

            edit.Text = "Редактировать сотрудника";
            edit.pictureBox1.Image = Properties.Resources.edit;
            edit.Form = 1;

            edit.ID = EmployeeGridView.CurrentRow.Cells[0].Value.ToString();

            edit.FullEmployeeName.Text = EmployeeGridView.CurrentRow.Cells[1].Value.ToString();
            edit.EmployeePost.Text = EmployeeGridView.CurrentRow.Cells[2].Value.ToString();

            if (edit.ShowDialog() == DialogResult.OK)
            {
                Refresh_Employee();
                MessageBox.Show("Данные успешно изменены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Delete_Employee_Click(object sender, EventArgs e)
        {

            OleDbConnection Conn = new OleDbConnection(MainForm.connectionstring);
            if (EmployeeGridView.RowCount != 0)
            {
                try
                {
                    Conn.Open();
                    OleDbCommand Cmd = new OleDbCommand(
                                    "DELETE * FROM EmployeeList " +
                                    "WHERE ID = " + EmployeeGridView.CurrentRow.Cells[0].Value.ToString(), Conn);
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Conn.Close();
                    Refresh_Employee();
                }
            }            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EmployeeCatalog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Refresh_Employee();
            }
        }
    }
}
