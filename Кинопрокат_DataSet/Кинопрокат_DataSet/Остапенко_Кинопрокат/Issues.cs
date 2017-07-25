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
    public partial class Issues : Form
    {
        public Form1 f1;
        public GiveFilm gfw;
        public Issues()
        {
            InitializeComponent();
        }

        public void Issues_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Фильмы' table. You can move, or remove it, as needed.
            this.фильмыTableAdapter.Fill(this.кинопрокатDataSet.Фильмы);
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Клиенты' table. You can move, or remove it, as needed.
            this.клиентыTableAdapter.Fill(this.кинопрокатDataSet.Клиенты);
            // TODO: This line of code loads data into the 'кинопрокатDataSet.Выдано_в_прокат' table. You can move, or remove it, as needed.
            this.выдано_в_прокатTableAdapter.Fill(this.кинопрокатDataSet.Выдано_в_прокат);
        }

        //Сохранение
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выданоВПрокатBindingSource.EndEdit();
            this.выдано_в_прокатTableAdapter.Update(кинопрокатDataSet.Выдано_в_прокат);
        }

        //Сопостовляем выдачу с фильмом и клиентом
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            int m = dataGridView1.CurrentCellAddress.Y;
            if (m != -1)
            {
                //Сопоставляем инфу о фильме
                var filmfind = (from film in кинопрокатDataSet.Фильмы
                              where film.ID_Фильма.ToString()== dataGridView1[1, m].Value.ToString()
                              select film);
                dataGridView2.DataSource = filmfind.ToList();

                //Сопоставляем инфу о клиенте
                var cusfind = (from cus in кинопрокатDataSet.Клиенты
                              where cus.ID_Клиента.ToString() == dataGridView1[2, m].Value.ToString()
                              select cus);
                dataGridView3.DataSource = cusfind.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                
                gfw = new GiveFilm();
                gfw.isw = this;
                gfw.ShowDialog();

            
        }

        //Удаление выдачи
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[6].Value = true;
            фильмыBindingSource.EndEdit();
            фильмыTableAdapter.Update(кинопрокатDataSet.Фильмы);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            выданоВПрокатBindingSource.EndEdit();
            выдано_в_прокатTableAdapter.Update(кинопрокатDataSet.Выдано_в_прокат);
        }
    }
}
