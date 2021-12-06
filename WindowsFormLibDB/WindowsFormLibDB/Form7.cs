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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void книги___сдача__получениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книги___сдача__получениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forlab03DataSet._Книги___сдача__получение". При необходимости она может быть перемещена или удалена.
            this.книги___сдача__получениеTableAdapter.Fill(this.forlab03DataSet._Книги___сдача__получение);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = книги___сдача__получениеDataGridView.Columns[0];

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = книги___сдача__получениеDataGridView.Columns[0];
                    break;
                case 1:
                    Col = книги___сдача__получениеDataGridView.Columns[1];
                    break;
                case 2:
                    Col = книги___сдача__получениеDataGridView.Columns[2];
                    break;
                case 3:
                    Col = this.книги___сдача__получениеDataGridView.Columns[3];
                    break;
                case 4:
                    Col = this.книги___сдача__получениеDataGridView.Columns[4];
                    break;
            }
            if (this.radioButton1.Checked == true)
                this.книги___сдача__получениеDataGridView.Sort(Col, ListSortDirection.Ascending);
            else
                this.книги___сдача__получениеDataGridView.Sort(Col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.книги___сдача__получениеBindingSource.Filter = "[Шифр Книги]='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < книги___сдача__получениеDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < книги___сдача__получениеDataGridView.RowCount - 1; j++)
                {
                    книги___сдача__получениеDataGridView[i, j].Style.BackColor = Color.White;
                    книги___сдача__получениеDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < книги___сдача__получениеDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < книги___сдача__получениеDataGridView.RowCount - 1; j++)
                    if (0 == String.Compare(книги___сдача__получениеDataGridView[i, j].Value.ToString(), textBox1.Text))
                    {
                        книги___сдача__получениеDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        книги___сдача__получениеDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }

        }
    }
}

