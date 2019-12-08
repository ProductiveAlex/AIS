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
    public partial class EqTypes : Form
    {
        string SqlStr = "";
        OleDbConnection connection = new OleDbConnection(MainForm.connectionstring);


        public EqTypes()
        {
            InitializeComponent();
        }

        void Refresh()
        {
            TypeGridView.Columns.Clear();

            SqlStr = "SELECT TypeID, TypeName AS [Тип оборудования] FROM Types ";

            if(Search.Text != "")
            {
            }

            if (Search.Text != "")
            {
                SqlStr += "WHERE TypeName LIKE '%' + @Type + '%' ";
                if (checkBox1.Checked == false)
                {
                    SqlStr += "";
                }
                else
                {
                    SqlStr += "AND Archive = false";
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
                    SqlStr += "WHERE Archive = false";
                }
            }

            OleDbDataAdapter Adapter = new OleDbDataAdapter(SqlStr, connection);

            if(Search.Text != "")
                Adapter.SelectCommand.Parameters.AddWithValue("Type", Search.Text.ToString());
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            TypeGridView.AutoGenerateColumns = true;
            TypeGridView.DataSource = Table;
        }

        private void Add_Type_Click(object sender, EventArgs e)
        {
            Add_Plot add = new Add_Plot();
            add.Form = 3;
            add.label1.Text = "Тип оборудования";
            add.Text = "Добавить тип оборудования";

            if (add.ShowDialog() == DialogResult.OK)
            {
                Refresh();
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Edit_Type_Click(object sender, EventArgs e)
        {
            Add_Plot edit = new Add_Plot();
            edit.Form = 4;
            edit.Text = "Редактировать тип оборудования";
            edit.PlotName.Text = TypeGridView.CurrentRow.Cells[1].Value.ToString();
            edit.ID = TypeGridView.CurrentRow.Cells[0].Value.ToString();
            edit.label1.Text = "Тип оборудования";

            if (edit.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные успешно обновлены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Type_Click(object sender, EventArgs e)
        {

        }

        private void EqTypes_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
