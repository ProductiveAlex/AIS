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

        public InsertForm()
        {
            InitializeComponent();
            EqAssign.SelectedIndex = 0;
            EqType.SelectedIndex = 0;
            //EqPlot.SelectedIndex = 0;
            EqState.SelectedIndex = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();

            OleDbConnection conn = new OleDbConnection(MainForm.connectionstring);
            conn.Open();
            string CmdText = "INSERT INTO Eqipmentlist(EqInv, EqName, EqAssign, EqType, EqPlot, EqState, ArriveDate) Values ('"
                + Inv.Text + "' , '"
                + EqName.Text + " ' , '"
                + EqAssign.Text + "' , '"
                + EqType.Text + "' , '"
                + EqPlot.Text + "' , '"
                + EqState.Text + "' , '"
                + ArriveDate.Value + "') ";



            if (!uint.TryParse(Inv.Text, out uint z))
            {
                MessageBox.Show("Инвентарный номер должен состоять только из цифр и быть в длину не более 9 символов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inv.Focus();

                this.DialogResult = DialogResult.None;
                return;
            }


            bool check = true;
            int i = 0;


            //проверка на существование данного инвентарного номера
            while (check && i < invnumbers.Length)
            {
                
                if (invnumbers.Length != 0)
                {
                    if (Inv.Text == invnumbers[i].ToString())
                    {
                        MessageBox.Show(i.ToString());
                        MessageBox.Show("Инвентарный номер должен иметь уникальное значение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Inv.Focus();
                        this.DialogResult = DialogResult.None;
                        check = false;
                        return;
                    }
                    i++;
                }
                else
                {
                    check = false;
                }
            }

            //for (i = 0; i < invnumbers.Length; i++)
            //{
            //    if (Inv.Text == invnumbers[i].ToString())
            //    {
            //        MessageBox.Show(invnumbers[i].ToString());
            //        MessageBox.Show("Инвентарный номер должен иметь уникальное значение", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        Inv.Focus();
            //        this.DialogResult = DialogResult.None;
            //        return;
            //    }
            //}

            if (EqName.TextLength <= 9)
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

            OleDbCommand Cmd = new OleDbCommand(CmdText, conn);
            Cmd.ExecuteNonQuery();
            conn.Close();
            main.RefreshEqData();

        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EqAssign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentDataSet3.Eqipmentlist' table. You can move, or remove it, as needed.
            //this.eqipmentlistTableAdapter.Fill(this.equipmentDataSet3.Eqipmentlist);



        }
    }
}
