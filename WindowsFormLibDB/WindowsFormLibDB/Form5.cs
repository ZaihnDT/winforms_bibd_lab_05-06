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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void читателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forlab03DataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.forlab03DataSet.Читатели);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void читателиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = читателиDataGridView.Columns[0];

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = читателиDataGridView.Columns[0];
                    break;
                case 1:
                    Col = читателиDataGridView.Columns[1];
                    break;
                case 2:
                    Col = читателиDataGridView.Columns[2];
                    break;
                case 3:
                    Col = this.читателиDataGridView.Columns[3];
                    break;
                case 4:
                    Col = this.читателиDataGridView.Columns[4];
                    break;
                case 5:
                    Col = this.читателиDataGridView.Columns[5];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.читателиDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.читателиDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.читателиBindingSource.Filter = "ФИО='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            читателиBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < читателиDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < читателиDataGridView.RowCount - 1; j++)
                {
                    читателиDataGridView[i, j].Style.BackColor = Color.White;
                    читателиDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < читателиDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < читателиDataGridView.RowCount - 1; j++)
                    if (0 == String.Compare(читателиDataGridView[i, j].Value.ToString(), textBox1.Text))
                    {
                        читателиDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        читателиDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }
    }
}
