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
        public int Form;
        public Add_Plot()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (Form == 0)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Equipment.mdb");
                conn.Open();

                string CmdText = "INSERT INTO PlotList(PlotName) Values ('"
                            + PlotName.Text + "')";

                if (PlotName.Text.Length < 2)
                {
                    MessageBox.Show("Необходимо ввести наименование участка (не менее 2 символов)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PlotName.Focus();
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

                string CmdText = "UPDATE PlotList SET PlotName = @PlotName WHERE ID = @ID";

                OleDbCommand Cmd = new OleDbCommand(CmdText, conn);

                Cmd.Parameters.AddWithValue("@PlotName", PlotName.Text);
                Cmd.Parameters.AddWithValue("@ID", ID);

                if (PlotName.Text.Length < 2)
                {
                    MessageBox.Show("Необходимо ввести наименование участка (не менее 2 символов)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PlotName.Focus();
                    this.DialogResult = DialogResult.None;
                    return;
                }

                Cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }
}
