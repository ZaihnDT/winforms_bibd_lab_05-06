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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void шифр_КнигиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.шифр_КнигиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "forlab03DataSet.Шифр_Книги". При необходимости она может быть перемещена или удалена.
            this.шифр_КнигиTableAdapter.Fill(this.forlab03DataSet.Шифр_Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            шифр_КнигиBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.шифр_КнигиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.forlab03DataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
