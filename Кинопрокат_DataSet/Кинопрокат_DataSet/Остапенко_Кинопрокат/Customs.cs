using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Остапенко_Кинопрокат
{
    public partial class Customs : Form
    {
        public Form1 f1;
        public Customs()
        {
            InitializeComponent();
        }

        private void Customs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.кинопрокатDataSet.Клиенты);
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.кинопрокатDataSet.Клиенты);
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.кинопрокатDataSet.Клиенты);

        }

        //Поиск
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                var q1 = (from str in кинопрокатDataSet.Клиенты
                          where str.Фамилия == toolStripTextBox1.Text
                          select str).AsDataView();
                dataGridView1.DataSource = q1;
            }
            else
                dataGridView1.DataSource = клиентыBindingSource;
        }

        //Сохранение
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.клиентыTableAdapter.Update(кинопрокатDataSet.Клиенты);
        }
    }
}
