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
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using ZXing.Rendering;
using ZXing.QrCode.Internal;
using System.Threading;

namespace AIS
{
    public partial class MainForm : Form
    {
        public static string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Equipment.mdb; Persist Security Info=True; Jet OLEDB:Database Password = \"AeqU3=4S\"";
        //private Bitmap objBmp;
        public static int id;
        OleDbConnection connection = new OleDbConnection(connectionstring);
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


        public void RefreshEqData()
        {
            EqList.AutoGenerateColumns = true;
            change_conn_state();
            SqlStr =
                    "SELECT  " +
                    "Eqipmentlist.EqListID, " +
                    "Eqipmentlist.EqInv AS [Инвентарный номер], " +
                    "Eqipmentlist.EqName AS Наименование, " +
                    "STR(Eqipmentlist.EqPurposeID) + \". \" + EqPurpose.PurposeName AS Назначение, " +
                    "STR(Eqipmentlist.EqTypeID) + \". \" + Types.TypeName AS Тип, " +
                    "STR(Eqipmentlist.EqPlotID) + \". \" + PlotList.PlotName AS Участок, " +
                    "Eqipmentlist.EqState AS Состояние, " +
                    "Users.Login + \" | \" + Users.LastName + \" \" + LEFT(Users.FirstName, 1) + \". \" + LEFT(Users.Patronymic, 1) + \".\" AS [ID пользователя добавившего оборудование], " +
                    "Eqipmentlist.ArriveDate AS [Дата поступления] " +
                    "FROM ((((Eqipmentlist " +
                    "INNER JOIN EqPurpose ON Eqipmentlist.EqPurposeID = EqPurpose.ID) " +
                    "INNER JOIN Types ON Eqipmentlist.EqTypeID = Types.TypeID) " +
                    "INNER JOIN PlotList ON Eqipmentlist.EqPlotID = PlotList.ID) " +
                    "INNER JOIN Users ON Eqipmentlist.UserID = Users.ID) ";
            if (Search.Text != "")
            {
            }

            if (Search.Text != "")
            {
                SqlStr += "WHERE Eqipmentlist.EqName LIKE '%' + @EqName + '%' ";
                if (checkBox1.Checked == false)
                {
                    SqlStr += "";
                }
                else
                {
                    SqlStr += "AND Eqipmentlist.Archive = false";
                }
            }
            else
            {
                //если true то выбрать без архива
                if (checkBox1.Checked == true)
                {
                    SqlStr += "";
                }
                else
                {
                    SqlStr += "WHERE Eqipmentlist.Archive = false";
                }
            }


            OleDbDataAdapter Adapter = new OleDbDataAdapter(SqlStr, connection);
            if (Search.Text != "")
            {
                Adapter.SelectCommand.Parameters.AddWithValue("EqName", Search.Text.ToString());
            }
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            EqList.DataSource = Table;
           // EqList.Columns[0].Visible = false;
            Thread.Sleep(200);
            change_conn_state();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table_Type.SelectedIndex = 0;
            RefreshEqData();
            RefreshDataRequest(0);
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            InsertForm AddEqForm = new InsertForm();
            AddEqForm.Text = "Добавить оборудование";

            try
            {
                Array.Resize(ref AddEqForm.invnumbers, EqList.Rows.Count);
                for (int i = 0; i < EqList.Rows.Count; i++)
                {
                    if (EqList.Rows.Count != 0)
                        AddEqForm.invnumbers[i] = EqList.Rows[i].Cells[1].Value.ToString();
                }
                //загрузка значений в комбобокс "Участок"
                change_conn_state();
            }
            finally
            {
                change_conn_state();
            }

            if (AddEqForm.ShowDialog() == DialogResult.OK)
            {
                RefreshEqData();
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            if (EqList.RowCount != 0)
            {
                editForm.Text = "Редактировать оборудование";
                editForm.textBox1.Text = EqList.CurrentRow.Cells[0].Value.ToString();
                editForm.Inv.Text = EqList.CurrentRow.Cells[1].Value.ToString();
                editForm.EqName.Text = EqList.CurrentRow.Cells[2].Value.ToString();

                editForm.load_comboboxes(true, true, true);

                editForm.EqAssign.SelectedIndex = editForm.EqAssign.FindStringExact(EqList.CurrentRow.Cells[3].Value.ToString());
                editForm.EqType.SelectedIndex = editForm.EqType.FindStringExact(EqList.CurrentRow.Cells[4].Value.ToString());
                editForm.EqPlot.SelectedIndex = editForm.EqPlot.FindStringExact(EqList.CurrentRow.Cells[5].Value.ToString());
                editForm.EqState.SelectedIndex = editForm.EqState.FindStringExact(EqList.CurrentRow.Cells[6].Value.ToString());

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Данные успешно обновлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshEqData();
                }
            }
            else
            {
                MessageBox.Show("Нечего редактировать!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshEqData();
            RefreshDataRequest(id);
        }

        private void EqList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //обновление историй по нажатию на ячейку в "Оборудование"
            RefreshDataRequest(id);
        }

        public void RefreshDataRequest(int id)
        {
            // загрузка данных о выдачах из БД
            if (EqList.CurrentRow != null)
            {
                string SqlStr = "";
                try
                {
                    if (id == 0)
                    {
                        label2.Text = "История отказов";
                        dataGridView2.Visible = false;
                        SqlStr =
                            "SELECT * " +
                            "FROM EqFailHistory " +
                            "WHERE EqListID = " + EqList.CurrentRow.Cells[0].Value.ToString();

                    }

                    if (id == 1)
                    {
                        label2.Text = "История тех. обслуживания";
                        dataGridView2.Visible = true;
                        SqlStr =
                            "SELECT * " +
                            "FROM EqTechHistory " +
                            "WHERE EqListID = " + EqList.CurrentRow.Cells[0].Value.ToString();

                    }

                    change_conn_state();

                    OleDbDataAdapter Adapter = new OleDbDataAdapter(SqlStr, connection);

                    DataTable Table = new DataTable();
                    Adapter.Fill(Table);

                    if (id == 0)
                    {
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = Table;
                    }

                    if (id == 1)
                    {
                        dataGridView2.AutoGenerateColumns = false;
                        dataGridView2.DataSource = Table;
                    }

                    Thread.Sleep(200);
                }
                finally
                {
                    change_conn_state();
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (EqList.CurrentRow != null)
            {
                if (MessageBox.Show("Удалить выбранную запись об оборудовании вместе с соответствующими историями?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        change_conn_state();
                        OleDbCommand Cmd = new OleDbCommand(
                            "Update EqFailHistory SET Archive = true " +
                            "WHERE EqListID = " + EqList.CurrentRow.Cells[0].Value.ToString(), connection);
                        Cmd.ExecuteNonQuery(); // удаление возможных историй

                        Cmd.CommandText =
                            "Update EqTechHistory SET Archive = true " +
                            "WHERE EqListID = " + EqList.CurrentRow.Cells[0].Value.ToString();
                        Cmd.ExecuteNonQuery(); // удаление возможных историй

                        Cmd.CommandText =
                            "Update Eqipmentlist SET Archive = true " +
                            "WHERE EqListID = " + EqList.CurrentRow.Cells[0].Value.ToString();
                        Cmd.ExecuteNonQuery(); // удаление самого поступления
                    }
                    finally
                    {
                        MessageBox.Show("Данные успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshEqData();
                        RefreshDataRequest(id);
                        change_conn_state();
                    }
                }
            }
            else
            {
                MessageBox.Show("Нечего удалять!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Table_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            id = Table_Type.SelectedIndex;
            RefreshDataRequest(id);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            RefreshEqData();
        }

        private void AddHistory_Click(object sender, EventArgs e)
        {
            InsertHistory history = new InsertHistory();

            if (EqList.RowCount != 0)
            {
                try
                {
                    //загрузка значений в комбобокс "Участок"
                    change_conn_state();
                    OleDbDataAdapter Adapter = new OleDbDataAdapter(
                        "SELECT * " +
                        "FROM EmployeeList " +
                        "ORDER BY FullEmployeeName", connection);
                    DataTable Table = new DataTable();
                    Adapter.Fill(Table);
                    history.FullEmployeeName.ValueMember = "ID";
                    history.FullEmployeeName.DisplayMember = "FullEmployeeName";
                    history.FullEmployeeName.DataSource = Table;
                    history.FullEmployeeName.SelectedIndex = -1;
                }
                finally
                {
                    change_conn_state();
                }


                history.ID = EqList.CurrentRow.Cells[0].Value.ToString();
                if (id == 0)
                {
                    history.Text = "Добавить запись об отказе";
                    if (history.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.RefreshEqData();
                        this.RefreshDataRequest(id);
                    }
                }

                if (id == 1)
                {
                    history.Text = "Добавить запись об обслуживании";
                    history.Fail.Visible = false;
                    history.label3.Visible = false;

                    history.label4.Location = new Point(12, 93);
                    history.Full.Location = history.label3.Location;
                    history.EmployeePost.Location = new Point(176, 90);
                    history.FullEmployeeName.Location = new Point(233, 63);

                    history.Size = new Size(480, 185);
                    history.button1.Location = new Point(history.button1.Location.X, history.button1.Location.Y - 25);
                    history.button2.Location = new Point(history.button2.Location.X, history.button2.Location.Y - 25);

                    if (history.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.RefreshEqData();
                        this.RefreshDataRequest(id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Отсутствует оборудование для добавления!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void EqList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshDataRequest(id);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                //если выбрано Отказы
                if (dataGridView1.RowCount != 0)
                {
                    EditHistory editFailForm = new EditHistory();
                    editFailForm.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    editFailForm.DateTime.Enabled = false;
                    editFailForm.DateTime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    editFailForm.EqFailName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    editFailForm.Fail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    try
                    {
                        //загрузка значений в комбобокс "Участок"
                        change_conn_state();
                        OleDbDataAdapter Adapter = new OleDbDataAdapter(
                            "SELECT * " +
                            "FROM EmployeeList " +
                            "ORDER BY FullEmployeeName", connection);
                        DataTable Table = new DataTable();
                        Adapter.Fill(Table);
                        editFailForm.FullEmployeeName.ValueMember = "ID";
                        editFailForm.FullEmployeeName.DisplayMember = "FullEmployeeName";
                        editFailForm.FullEmployeeName.DataSource = Table;
                        editFailForm.FullEmployeeName.SelectedIndex = -1;
                    }
                    finally
                    {
                        change_conn_state();
                    }

                    editFailForm.EmployeePost.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    editFailForm.Text = "Редактировать отказ";
                    if (editFailForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Данные успешно обновлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataRequest(id);
                        //RefreshEqData();
                    }
                }
                else
                {
                    MessageBox.Show("Нечего редактировать!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            if (id == 1)
            {
                //если выбрана Тех.обслуживание
                EditHistory editTechForm = new EditHistory();

                if (dataGridView2.RowCount != 0)
                {
                    editTechForm.ID = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    editTechForm.DateTime.Enabled = false;
                    editTechForm.DateTime.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    editTechForm.EqFailName.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

                    try
                    {
                        //загрузка значений в комбобокс "Участок"
                        change_conn_state();
                        OleDbDataAdapter Adapter = new OleDbDataAdapter(
                            "SELECT * " +
                            "FROM EmployeeList " +
                            "ORDER BY FullEmployeeName", connection);
                        DataTable Table = new DataTable();
                        Adapter.Fill(Table);
                        editTechForm.FullEmployeeName.ValueMember = "ID";
                        editTechForm.FullEmployeeName.DisplayMember = "FullEmployeeName";
                        editTechForm.FullEmployeeName.DataSource = Table;
                        editTechForm.FullEmployeeName.SelectedIndex = -1;
                    }
                    finally
                    {
                        change_conn_state();
                    }

                    editTechForm.EmployeePost.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    editTechForm.Fail.Enabled = false;
                    editTechForm.label3.Enabled = false;
                    editTechForm.Text = "Редактировать запись истории оборудования";
                    if (editTechForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Данные успешно обновлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshDataRequest(id);
                        RefreshEqData();
                    }
                }
                else
                {
                    MessageBox.Show("Нечего редактировать!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentRow == null && id == 0) || (dataGridView2.CurrentRow == null && id == 1))
            {
                MessageBox.Show("Нечего удалять!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dataGridView1.CurrentRow != null && id == 0)
            {
                if (MessageBox.Show("Удалить выбранную запись истории оборудования?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    change_conn_state();
                    SqlStr = "DELETE * FROM EqFailHistory " +
                        "WHERE EqFailID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, connection);
                    Cmd.ExecuteNonQuery(); // удаление возможных историй
                    change_conn_state();
                    RefreshDataRequest(id);
                    Thread.Sleep(200);
                    MessageBox.Show("Данные успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //RefreshDataRequest(id);
                }
            }


            if (dataGridView2.CurrentRow != null && id == 1)
            {
                if (MessageBox.Show("Удалить выбранную запись истории оборудования?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    change_conn_state();

                    SqlStr =
                        "DELETE * FROM EqTechHistory " +
                        "WHERE EqTechID = " + dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, connection);
                    Cmd.ExecuteNonQuery(); // удаление возможных историй
                    change_conn_state();
                    RefreshDataRequest(id);
                    MessageBox.Show("Данные успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void справкаToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AisHelpUser.exe", HelpNavigator.TableOfContents);

        }

        private void руководствоСистемногоПрограммистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AisHelpProg.exe", HelpNavigator.TableOfContents);

        }

        private void руководствоОператораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AisHelpOper.exe", HelpNavigator.TableOfContents);

        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа была разработана учащимся 17-П группы 3-го курса УО \"БГАЭК\" Шайновым Романом", "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void оПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа \"Учет отказа оборудования\" была создана для более удобного учета оборудования на производстве, а также его техниической истории и истории отказов данного оборудования", "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //экспорт данных в ворд
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            if (EqList.Rows.Count != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Word Documents (*.docx)|*.docx";

                sfd.FileName = "Экспорт.docx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(EqList, sfd.FileName);
                }
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //добавить строки
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //конец цикла слов
                } //конец цикла столбцов

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = false;

                //ориентация страницы
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                //автоперенос
                oDoc.AutoHyphenation = true;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //формат таблицы
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();


                //стиль таблицы
                //oDoc.Application.Selection.Tables[1].set_Style("Plain Table 1");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //стиль заголовков
                oDoc.Application.Selection.Tables[1].Range.Font.Name = "Times New Roman";

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                // oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Range.Font.Size = 12;
                oDoc.Application.Selection.Tables[1].AllowAutoFit = true;


                // добавить строку заголовка вручную
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                DateTime now = DateTime.Now;
                var culture = new CultureInfo("ru-RU");

                //текст заголовка
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range footerString = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerString.Text = "Всего оборудования на предприятии на " + now.ToString("dd.MM.yyyy") + ": " + DGV.RowCount.ToString() + " ед.";
                    footerString.Font.Size = 12;
                    footerString.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    footerString.ParagraphFormat.FirstLineIndent = 0;

                    Word.Range headerRange = section.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    //  headerRange.Text = "your header text";
                    headerRange.Font.Size = 12;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                oDoc.SaveAs2(filename);
            }
            else
            {
                MessageBox.Show("Нечего экспортировать!", "Экспорт в Word", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //кнопка "Экспорт в Excel"
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Книга Excel (*.xlsx)|*.xlsx";

            sfd.FileName = "Экспорт.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Excel(EqList, sfd.FileName);
            }
        }

        //функция "Экспорт в Excel"
        public void Export_Data_To_Excel(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Visible = true;

                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    for (int j = 0; j < DGV.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (DGV[i, j].Value).ToString();

                    }
                }

                //наименования столбцов
                ExcelApp.Rows[1].Font.Bold = true;

                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    ExcelApp.Cells[1, i + 1] = DGV.Columns[i].HeaderText;
                }

                //авторазмер столбцов
                ExcelApp.Columns.AutoFit();

                //ExcelApp.Cells.BorderAround2();

                //сохранить файл
                ExcelApp.Application.ActiveWorkbook.SaveAs(filename);
            }
            else
            {
                MessageBox.Show("Нечего экспортировать!", "Экспорт в Excel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //функция печати
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            //путь хранения файла temp
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\temp.docx";

            //создание диалога печати
            PrintDialog pDialog = new PrintDialog();

            //вывод документа на печать
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;

                //если файл существует, то сразу удалить, а потом создать
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                //сразу создать документ, а потом распечатать его
                Export_Data_To_Word(EqList, "temp.docx");

                wordApp.ActivePrinter = pDialog.PrinterSettings.PrinterName;

                wordApp.ActiveDocument.PrintOut();

                //закрыть текущий документ
                wordApp.ActiveDocument.Close();

                //закрыть программу после печати
                wordApp.Application.Quit();
            }

            //удалить файл после печати
            File.Delete(path);
        }

        private void справочникСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeCatalog employee = new EmployeeCatalog();
            employee.Text = "Справочник сотрудников";

            employee.ShowDialog();
        }

        private void ПечатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //qr коды
        private void ToolStripButton16_Click(object sender, EventArgs e)
        {
            QRcode qrcode = new QRcode();

            if (EqList.RowCount != 0)
            {
                qrcode.s0 = EqList.CurrentRow.Cells[0].Value.ToString();
                qrcode.s1 = EqList.CurrentRow.Cells[1].Value.ToString();
                qrcode.s2 = EqList.CurrentRow.Cells[2].Value.ToString();
                qrcode.Text = "QR код";
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(EqList.CurrentRow.Cells[0].Value.ToString() + " " + EqList.CurrentRow.Cells[2].Value.ToString());
                Bitmap logo = new Bitmap(Properties.Resources.SimpleStore_png);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                qrcode.pictureBox1.Image = bitmap;

                if (qrcode.ShowDialog() != DialogResult.Cancel)
                {
                    this.RefreshEqData();
                }
            }
            else
            {
                MessageBox.Show("Не для чего генерировать!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //сочетание Ctrl+F для перехода на поиск
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                Search.Focus();
            }
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из программы?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        //назначение оборудования
        private void ToolStripButton17_Click(object sender, EventArgs e)
        {

            OleDbConnection Conn = new OleDbConnection(connectionstring);

            if (MessageBox.Show("Удалить выбранную запись истории оборудования?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                change_conn_state();
                SqlStr = "INSERT INTO EqPurpose (PurposeName) VALUES ('Проверка');";
                OleDbCommand Cmd = new OleDbCommand(SqlStr, Conn);
                Cmd.ExecuteNonQuery(); // удаление возможных историй
                Conn.Close();
                RefreshDataRequest(id);
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //выхов справочника участков
        private void НазначениеОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlotCatalog plot = new PlotCatalog();
            plot.Text = "Справочник участков";

            plot.ShowDialog();
        }

        private void УчасткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqTypes types = new EqTypes();
            types.ShowDialog();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshEqData();
        }
    }
}


