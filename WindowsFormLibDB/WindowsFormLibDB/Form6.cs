using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLibDB
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void шифр_КнигиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.шифр_КнигиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forlab03DataSet.Шифр_Книги". При необходимости она может быть перемещена или удалена.
            this.шифр_КнигиTableAdapter.Fill(this.forlab03DataSet.Шифр_Книги);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = шифр_КнигиDataGridView.Columns[0];

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = шифр_КнигиDataGridView.Columns[0];
                    break;
                case 1:
                    Col = шифр_КнигиDataGridView.Columns[1];
                    break;
                case 2:
                    Col = шифр_КнигиDataGridView.Columns[2];
                    break;
                case 3:
                    Col = this.шифр_КнигиDataGridView.Columns[3];
                    break;
                case 4:
                    Col = this.шифр_КнигиDataGridView.Columns[4];
                    break;
                case 5:
                    Col = this.шифр_КнигиDataGridView.Columns[5];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.шифр_КнигиDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.шифр_КнигиDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.шифр_КнигиBindingSource.Filter = "[Шифр Книги]='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < шифр_КнигиDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < шифр_КнигиDataGridView.RowCount - 1; j++)
                {
                    шифр_КнигиDataGridView[i, j].Style.BackColor = Color.White;
                    шифр_КнигиDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < шифр_КнигиDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < шифр_КнигиDataGridView.RowCount - 1; j++)
                    if (0 == String.Compare(шифр_КнигиDataGridView[i, j].Value.ToString(), textBox1.Text))
                    {
                        шифр_КнигиDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        шифр_КнигиDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }
    }
}
