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

namespace AIS
{
    public partial class InsertForm : Form
    {
        public string[] invnumbers;
        bool nonNumberEntered = false;
        OleDbConnection connection = new OleDbConnection(MainForm.connectionstring);
        string OldSelected = "";
        DataTable EqInvs = new DataTable();


        public InsertForm()
        {
            InitializeComponent();
        }

        void change_conn_state()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Закрыто");
            }
            else
            {
                connection.Open();
                MessageBox.Show("Открыто");
            }
        }

        void load_inv_numb()
        {
            change_conn_state();

            OleDbDataAdapter Adapter = new OleDbDataAdapter(
                       "SELECT EqInv " +
                       "FROM Eqipmentlist " +
                       "ORDER BY EqInv", connection);
            Adapter.Fill(EqInvs);
            change_conn_state();
        }

        void load_comboboxes(bool type, bool purpose, bool plot)
        {
            change_conn_state();

            if (type)
            {
                OleDbDataAdapter Adapter = new OleDbDataAdapter(
                       "SELECT TypeID, STR(TypeID) + \". \" + TypeName AS [Наименование типа] " +
                       "FROM Types " +
                       "ORDER BY TypeName", connection);
                DataTable Table = new DataTable();
                Adapter.Fill(Table);
                EqType.ValueMember = "TypeID";
                EqType.DisplayMember = "Наименование типа";
                EqType.DataSource = Table;
                EqType.SelectedIndex = 0;
            }

            if (purpose)
            {
                OleDbDataAdapter Adapter = new OleDbDataAdapter(
                       "SELECT ID, STR(ID) + \". \"  + PurposeName AS [Назначение] " +
                       "FROM EqPurpose " +
                       "ORDER BY PurposeName", connection);
                DataTable Table = new DataTable();
                Adapter.Fill(Table);
                EqAssign.ValueMember = "ID";
                EqAssign.DisplayMember = "Назначение";
                EqAssign.DataSource = Table;
                EqAssign.SelectedIndex = 0;
            }

            if (plot)
            {
                OleDbDataAdapter Adapter = new OleDbDataAdapter(
                       "SELECT ID, STR(ID) + \". \"  + PlotName AS [Наименование участка] " +
                       "FROM PlotList " +
                       "ORDER BY PlotName", connection);
                DataTable Table = new DataTable();
                Adapter.Fill(Table);
                EqPlot.ValueMember = "ID";
                EqPlot.DisplayMember = "Наименование участка";
                EqPlot.DataSource = Table;
                EqPlot.SelectedIndex = 0;
            }
            change_conn_state();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow inv in EqInvs.Rows)
                if (Inv.Text == inv[0].ToString())
                {
                    MessageBox.Show("Инвентарный номер должен иметь уникальное значение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Inv.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }

            if (EqName.TextLength == 0)
            {
                MessageBox.Show("Введите наименование оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqAssign.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать назначение оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqAssign.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqType.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать тип оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqType.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqPlot.SelectedIndex == -1)
            {
                MessageBox.Show("Необходимо выбрать участок эксплуатации оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqPlot.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqState.SelectedIndex == 0)
            {
                MessageBox.Show("Необходимо выбрать текущее состояние оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqState.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            change_conn_state();
            string CmdText = "INSERT INTO Eqipmentlist(EqInv, EqName, EqPurposeID, EqTypeID, EqPlotID, EqState, ArriveDate, UserID) Values ('"
                + Inv.Text + "' , '"
                + EqName.Text + " ' , "
                + EqAssign.Text.Substring(0, EqAssign.Text.IndexOf('.')) + " , "
                + EqType.Text.Substring(0, EqAssign.Text.IndexOf('.')) + " , "
                + EqPlot.Text.Substring(0, EqAssign.Text.IndexOf('.')) + " , '"
                + EqState.Text + "' , '"
                + ArriveDate.Value + "', 1) ";
            //1 пока не сделаны пользователи


            OleDbCommand Cmd = new OleDbCommand(CmdText, connection);
            Cmd.ExecuteNonQuery();
            change_conn_state();
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EqAssign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            load_comboboxes(true, true, true);
            load_inv_numb();
            ArriveDate.MaxDate = DateTime.Today;
            EqState.SelectedIndex = 0;
        }

        private void Inv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // проверка на корректность ввода
            if (nonNumberEntered == true)
            {
                //прекратить ввод, если некорректный ввод
                e.Handled = true;
            }
        }

        private void Inv_KeyDown(object sender, KeyEventArgs e)
        {
            //проверка на ввод (является ли введенный символ числом или нет)
            nonNumberEntered = false;
            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
            {
                nonNumberEntered = false;
                // определение верхнего ряда цифр
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // определение клавиш на NumPad'е
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        // Является ли BackSpace'ом
                        if (e.KeyCode != Keys.Back)
                        {
                            // Является ли клавишей NumPad
                            if (e.KeyCode != Keys.NumLock)
                                //если нет, тогда вернуть значение true для срабатывания триггера в KyePressed
                                nonNumberEntered = true;
                        }
                    }
                }
                //Если цифра нажата, но при этом нажата и клавиша Shift (т.е. спецсимвол)
                if (Control.ModifierKeys == Keys.Shift)
                {
                    nonNumberEntered = true;
                }

                //поддержка сочетаний ctrl+z и ctrl+y
                if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
                {
                    nonNumberEntered = false;
                }
            }
        }

        private void TypeAdd_Click(object sender, EventArgs e)
        {
            Add_Plot add = new Add_Plot();
            add.Form = 3;
            add.label1.Text = "Тип оборудования";
            add.Text = "Добавить тип оборудования";

            if (add.ShowDialog() == DialogResult.OK)
            {
                OldSelected = EqType.Text;
                load_comboboxes(true, false, false);
                EqType.SelectedIndex = EqType.FindStringExact(OldSelected);
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PurposeAdd_Click(object sender, EventArgs e)
        {

        }

        private void PlotAdd_Click(object sender, EventArgs e)
        {
            Add_Plot add = new Add_Plot();
            add.Text = "Добавить участок";
            add.Form = 0;

            if (add.ShowDialog() == DialogResult.OK)
            {
                OldSelected = EqPlot.Text;
                load_comboboxes(false, false, true);
                EqPlot.SelectedIndex = EqPlot.FindStringExact(OldSelected);
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
