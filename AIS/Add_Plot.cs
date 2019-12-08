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
    public partial class Add_Plot : Form
    {
        public string ID;
        public int Form = -1;
        bool cancontinue = false;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Equipment.mdb");
        string SqlStr = "";

        public Add_Plot()
        {
            InitializeComponent();
        }

        void change_conn_state()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            else
                conn.Open();
        }

        void checkfields()
        {
            cancontinue = false;
            if (PlotName.Text.Length < 2)
            {
                MessageBox.Show("Необходимо ввести наименование участка (не менее 2 символов)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PlotName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            cancontinue = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            change_conn_state();
            if (Form == 0)
            {
                SqlStr = "INSERT INTO PlotList(PlotName) Values ('"
                            + PlotName.Text + "')";
                checkfields();
                if (cancontinue)
                {
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, conn);
                    Cmd.ExecuteNonQuery();
                }
            }
            if (Form == 1)
            {
                SqlStr = "UPDATE PlotList SET PlotName = @PlotName WHERE ID = @ID";

                OleDbCommand Cmd = new OleDbCommand(SqlStr, conn);

                Cmd.Parameters.AddWithValue("@PlotName", PlotName.Text);
                Cmd.Parameters.AddWithValue("@ID", ID);

                checkfields();

                if (cancontinue)
                {
                    Cmd = new OleDbCommand(SqlStr, conn);
                    Cmd.ExecuteNonQuery();
                }
            }
            if (Form == 3)
            {
                SqlStr = "INSERT INTO Types(TypeName) VALUES('" +
                    PlotName.Text + "')";
                checkfields();
                if (cancontinue)
                {
                    OleDbCommand Cmd = new OleDbCommand(SqlStr, conn);
                    Cmd.ExecuteNonQuery();
                }
            }
            if (Form == 4)
            {
                SqlStr = "UPDATE Types SET TypeName = @TypeName WHERE TypeID = @ID";

                OleDbCommand Cmd = new OleDbCommand(SqlStr, conn);

                Cmd.Parameters.AddWithValue("@TypeName", PlotName.Text);
                Cmd.Parameters.AddWithValue("@ID", ID);

                checkfields();

                if (cancontinue)
                {
                    Cmd = new OleDbCommand(SqlStr, conn);
                    Cmd.ExecuteNonQuery();
                }
            }
            change_conn_state();
        }
    }
}
