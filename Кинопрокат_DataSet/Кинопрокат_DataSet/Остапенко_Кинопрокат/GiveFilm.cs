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
    public partial class GiveFilm : Form
    {
        public Form1 f1=new Form1();
        public Issues isw=new Issues();
        public GiveFilm()
        {
            InitializeComponent();
        }

        private void GiveFilm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Фильмы' table. You can move, or remove it, as needed.
            this.фильмыTableAdapter.Fill(this.кинопрокатDataSet.Фильмы);
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.кинопрокатDataSet.Клиенты);

        }

        //выдать фильм
        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool check = int.TryParse(textBox1.Text, out num);

            if (Convert.ToBoolean(dataGridView2.CurrentRow.Cells[6].Value) == false)
                MessageBox.Show("Фильма нет в наличии!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox1.Text == "" || check == false || num < 0)
                MessageBox.Show("Цена введена неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = int.Parse(isw.dataGridView1[0, isw.dataGridView1.RowCount-1].Value.ToString())+1;
                int filmid = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                int cusid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                кинопрокатDataSet.Выдано_в_прокат.Rows.Add(index, filmid, cusid, num);
                isw.выданоВПрокатBindingSource.EndEdit();
                isw.выдано_в_прокатTableAdapter.Update(кинопрокатDataSet.Выдано_в_прокат);
                isw.dataGridView1.DataSource = isw.выданоВПрокатBindingSource;
                isw.выдано_в_прокатTableAdapter.Fill(isw.кинопрокатDataSet.Выдано_в_прокат);
                //isw.фильмыTableAdapter.Fill(isw.кинопрокатDataSet.Фильмы);
                //isw.клиентыTableAdapter.Fill(isw.кинопрокатDataSet.Клиенты);

                //удаление наличия
                dataGridView2.CurrentRow.Cells[6].Value = false;
                фильмыBindingSource.EndEdit();
                фильмыTableAdapter.Update(кинопрокатDataSet.Фильмы);

                MessageBox.Show("Фильм успешно выдан!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
