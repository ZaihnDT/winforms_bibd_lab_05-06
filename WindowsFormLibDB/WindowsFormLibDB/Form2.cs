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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            читателиBindingSource.MoveFirst();
        }

        private void читателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forlab03DataSet.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.forlab03DataSet.Читатели);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            читателиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            читателиBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            читателиBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            читателиBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            читателиBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
