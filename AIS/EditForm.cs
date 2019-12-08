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
    public partial class EditForm : Form
    {
        OleDbConnection connection = new OleDbConnection(MainForm.connectionstring);

        public EditForm()
        {
            InitializeComponent();
        }

        void change_conn_state()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            else
                connection.Open();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            change_conn_state();

            string CmdText = "UPDATE Eqipmentlist SET EqInv = @EqInv, EqName = @EqName, EqAssign = @EqAssign, EqType = @EqType, EqPlot = @EqPlot,  EqState = @EqState, ArriveDate = @ArriveDate"   
           + "WHERE EqListID = @EqListID";
            
            OleDbCommand Cmd = new OleDbCommand(CmdText, connection);
            Cmd.Parameters.AddWithValue("EqInv", Inv.Text);
            Cmd.Parameters.AddWithValue("EqName", EqName.Text);
            Cmd.Parameters.AddWithValue("EqAssign", EqAssign.Text);
            Cmd.Parameters.AddWithValue("EqType", EqType.Text);
            Cmd.Parameters.AddWithValue("EqPlot", EqPlot.Text);
            Cmd.Parameters.AddWithValue("EqState", EqState.Text);
            Cmd.Parameters.AddWithValue("EqListID", textBox1.Text);
            Cmd.Parameters.AddWithValue("ArriveDate", ArriveDate.Value);

            InsertForm insert = new InsertForm();
            if (!uint.TryParse(Inv.Text, out uint z))
            {
                MessageBox.Show("Инвентарный номер должен состоять только из цифр!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inv.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqName.TextLength < 10)
            {
                MessageBox.Show("Длина наименования оборудования должна быть не менее 10 символов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqAssign.SelectedIndex == 0)
            {
                MessageBox.Show("Необходимо выбрать назначение оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqAssign.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqType.SelectedIndex == 0)
            {
                MessageBox.Show("Необходимо выбрать тип оборудования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EqType.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }

            if (EqPlot.SelectedIndex == 0)
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

            Cmd.ExecuteNonQuery();
            main.RefreshEqData();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //load_comboboxes(true, true, true);
        }

        public void load_comboboxes(bool type, bool purpose, bool plot)
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
    }
}
