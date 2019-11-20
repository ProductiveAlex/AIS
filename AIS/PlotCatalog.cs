﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS
{
    public partial class PlotCatalog : Form
    {
        public PlotCatalog()
        {
            InitializeComponent();
        }

        private void PlotCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentDataSet.PlotList' table. You can move, or remove it, as needed.
            this.plotListTableAdapter.Fill(this.equipmentDataSet.PlotList);
            // TODO: This line of code loads data into the 'equipmentDataSet.PlotList' table. You can move, or remove it, as needed.
            this.plotListTableAdapter.Fill(this.equipmentDataSet.PlotList);
            Refresh_Plot();
        }

        public void Refresh_Plot()
        {
            OleDbConnection connection = new OleDbConnection(MainForm.connectionstring);
            connection.Open();

            //выбрать все из EmployeeList
            string SqlStr =
                    "SELECT *" +
                    "FROM PlotList ";

            //если поиск активен
            if (Search.Text != "")
            {
                SqlStr += "WHERE PlotName LIKE '%' + @PlotName + '%' ";
            }

            //сортировка
            SqlStr += "ORDER BY PlotName";
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SqlStr, connection);

            if (Search.Text != "")
            {
                Adapter.SelectCommand.Parameters.AddWithValue("PlotName", Search.Text);
            }

            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            PlotGridView.AutoGenerateColumns = false;
            PlotGridView.DataSource = Table;

            connection.Close();
            Thread.Sleep(200);
        }

        private void Add_Plot_Click(object sender, EventArgs e)
        {
            Add_Plot add = new Add_Plot();
            add.Text = "Добавить участок";
            add.Form = 0;

            if (add.ShowDialog() == DialogResult.OK)
            {
                Refresh_Plot();
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Edit_Plot_Click(object sender, EventArgs e)
        {
            Add_Plot edit = new Add_Plot();

            edit.Text = "Редактировать участок";
            edit.Form = 1;

            edit.ID = PlotGridView.CurrentRow.Cells[0].Value.ToString();

            edit.PlotName.Text = PlotGridView.CurrentRow.Cells[2].Value.ToString();

            if (edit.ShowDialog() == DialogResult.OK)
            {
                Refresh_Plot();
                MessageBox.Show("Данные успешно изменены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PlotCatalog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Refresh_Plot();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Refresh_Plot();
        }

        private void Delete_Plot_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(MainForm.connectionstring);
            if (PlotGridView.RowCount != 0)
            {
                try
                {
                    Conn.Open();
                    OleDbCommand Cmd = new OleDbCommand(
                                    "DELETE * FROM PlotList " +
                                    "WHERE ID = " + PlotGridView.CurrentRow.Cells[1].Value.ToString(), Conn);
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Conn.Close();
                    Refresh_Plot();
                }
            }
        }
    }
}
