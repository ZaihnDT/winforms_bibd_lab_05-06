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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void книги___сдача__получениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книги___сдача__получениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forlab03DataSet._Книги___сдача__получение". При необходимости она может быть перемещена или удалена.
            this.книги___сдача__получениеTableAdapter.Fill(this.forlab03DataSet._Книги___сдача__получение);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.RemoveCurrent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книги___сдача__получениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);
        }

        private void дата_ВозвратаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            книги___сдача__получениеBindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
