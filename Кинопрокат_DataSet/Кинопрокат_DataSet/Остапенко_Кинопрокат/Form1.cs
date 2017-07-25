using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Остапенко_Кинопрокат
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Фильмы' table. You can move, or remove it, as needed.
            this.фильмыTableAdapter.Fill(this.кинопрокатDataSet.Фильмы);
            dataGridView1.Columns[6].ReadOnly = true;


        }

        //Поиск
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                var q1 = (from str in кинопрокатDataSet.Фильмы
                          where str.Название == toolStripTextBox1.Text
                          select str).AsDataView();
                dataGridView1.DataSource = q1;
            }
            else
                dataGridView1.DataSource = фильмыBindingSource;
        }

        //Сохранение
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмыBindingSource.EndEdit();
            this.фильмыTableAdapter.Update(кинопрокатDataSet.Фильмы);
        }

        //Окно с пользователями
        private void button1_Click(object sender, EventArgs e)
        {
            Customs cw = new Customs();
            cw.f1 = this;
            cw.ShowDialog();

        }

        //Окно с выдачей
        private void button2_Click(object sender, EventArgs e)
        {
            Issues iw = new Issues();
            iw.f1 = this;
            iw.ShowDialog();
        }



        //Выход
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //обновить и сохранить
        private void button3_Click(object sender, EventArgs e)
        {
            фильмыBindingSource.EndEdit();
            фильмыTableAdapter.Update(кинопрокатDataSet);
            Form1_Load(this, e);

        }
    }
}
