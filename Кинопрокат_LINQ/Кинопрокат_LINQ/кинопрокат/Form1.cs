using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кинопрокат
{
    public partial class Form1 : Form
    {
        public int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //заполнение таблиц
            DataClassesDataContext context = new DataClassesDataContext();
            фильмыBindingSource.DataSource = context.Фильмы;
            клиентыBindingSource.DataSource = context.Клиенты;
        }

        #region Film

        //Добавление элемента
        private void buttonAddFilm_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(textBox1.Text, out id))
            {
                AddFilm af = new AddFilm(this);
                af.ShowDialog();
            }
            else MessageBox.Show("Вы ввели не числовое значение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Удаление элемента
        private void buttonDelFilm_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new DataClassesDataContext();
                var d = (from str in context.Фильмы
                         where str.ID_Фильма == int.Parse(textBox1.Text)
                         select str).FirstOrDefault();
                context.Фильмы.DeleteOnSubmit(d);
                context.SubmitChanges();
                фильмыBindingSource.DataSource = context.Фильмы;
            }
            catch (Exception exp) { MessageBox.Show("Нельзя удалить фильм, который выдан! \n или \n вы ввели пустой или неккоретный ID \n" + exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        //Изменение элемента
        private void buttonChanFilm_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out id))
            {
                ChangeFilm cf = new ChangeFilm(this);
                cf.ShowDialog();
            }
            else MessageBox.Show("Вы ввели не числовое значение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Cus
        private void buttonAddCus_Click(object sender, EventArgs e)
        {

            if (Int32.TryParse(textBox2.Text, out id))
            {
                AddCus ac = new AddCus(this);
                ac.ShowDialog();
            }
            else MessageBox.Show("Вы ввели не числовое значение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonChanCus_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox2.Text, out id))
            {
                ChanCus cc = new ChanCus(this);
                cc.ShowDialog();
            }
            else MessageBox.Show("Вы ввели не числовое значение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDelCus_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new DataClassesDataContext();
                var d = (from str in context.Клиенты
                         where str.ID_Клиента == int.Parse(textBox2.Text)
                         select str).FirstOrDefault();
                context.Клиенты.DeleteOnSubmit(d);
                context.SubmitChanges();
                клиентыBindingSource.DataSource = context.Клиенты;
            }
            catch (Exception exp) { 
                MessageBox.Show("Нельзя удалить клиента, которому выдан фильм! \n или \n вы ввели пустой или неккоретный ID \n" + exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
#endregion

        #region Отображение  и выделение

        private void фильмыDataGridView_Click(object sender, EventArgs e)
        {
            выданоВПрокатDataGridView.Visible = true;
            выданоВПрокатDataGridView1.Visible = false;
        }

        private void клиентыDataGridView_Click(object sender, EventArgs e)
        {
            выданоВПрокатDataGridView1.Visible = true;
            выданоВПрокатDataGridView.Visible = false;


        }

        private void клиентыDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = клиентыDataGridView[0, e.RowIndex].Value.ToString();
                if (выданоВПрокатDataGridView1.Rows.Count != 0)
                {
                    for (int i = 0; i < фильмыDataGridView.Rows.Count; i++)
                    {
                        if (фильмыDataGridView[0, i].Value.ToString() == выданоВПрокатDataGridView1[2, 0].Value.ToString())
                        {
                            фильмыDataGridView[0, i].Selected = true;
                        }
                        else
                        {
                            фильмыDataGridView[0, i].Selected = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < фильмыDataGridView.Rows.Count; i++)
                        фильмыDataGridView[0, i].Selected = false;
                }
            }
        }

        private void фильмыDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = фильмыDataGridView[0, e.RowIndex].Value.ToString();
                if (выданоВПрокатDataGridView.Rows.Count != 0)
                {
                    for (int i = 0; i < клиентыDataGridView.Rows.Count; i++)
                    {
                        if (клиентыDataGridView[0, i].Value.ToString() == выданоВПрокатDataGridView[2, 0].Value.ToString())
                        {
                            клиентыDataGridView[0, i].Selected = true;
                        }
                        else
                        {
                            клиентыDataGridView[0, i].Selected = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < клиентыDataGridView.Rows.Count; i++)
                        клиентыDataGridView[0, i].Selected = false;
                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag1 = false, flag2 = false;
            decimal money;
            int id1, id2;
            if(!decimal.TryParse(textBox5.Text, out money))
            {
                MessageBox.Show("Введите корректное поле 'Цена'", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!Int32.TryParse(textBox3.Text, out id1)  )
            {
                MessageBox.Show("Вы ввели не корректный ID Фильма", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if(!Int32.TryParse(textBox4.Text, out id2))
            {
                MessageBox.Show("Вы ввели не корректный ID Клиента", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                for (int i = 0; i < фильмыDataGridView.RowCount; i++)
                {
                    if (фильмыDataGridView[0, i].Value.ToString() == textBox3.Text)
                    {
                        flag1 = true;
                        for (int j = 0; j < клиентыDataGridView.RowCount; j++)
                        {
                            if (клиентыDataGridView[0, j].Value.ToString() == textBox4.Text)
                            {
                                flag2 = true;
                            }
                        }
                    }
                } 
            }

            if (flag1 == true && flag2 == true)
            {
                var context = new DataClassesDataContext();
                var vid = new ВыданоВПрокат();
                var user = context.GetTable<ВыданоВПрокат>().OrderByDescending(u => u.Код_Выдачи).FirstOrDefault();
                vid.Код_Выдачи = user.Код_Выдачи + 1;
                vid.ID_Фильма = int.Parse(textBox3.Text);
                vid.ID_Клиента = int.Parse(textBox4.Text);
                vid.Цена = decimal.Parse(textBox5.Text);
                context.ВыданоВПрокат.InsertOnSubmit(vid);

                var d = (from str in context.Фильмы
                         where str.ID_Фильма == int.Parse(textBox3.Text)
                         select str).FirstOrDefault();
                d.Наличие = false;

                context.SubmitChanges();
                фильмыBindingSource.DataSource = context.Фильмы;

                MessageBox.Show("Фильм выдан для просмотра нажмите на выбранный фильм", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(flag1== false) MessageBox.Show("Фильма с таким ID нет", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(flag2==false) MessageBox.Show("Клиента с таким ID нет", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int kod = int.Parse(выданоВПрокатDataGridView[0, 0].Value.ToString());
                var context = new DataClassesDataContext();
                var d = (from str in context.ВыданоВПрокат
                         where str.Код_Выдачи == kod
                         select str).FirstOrDefault();
                context.ВыданоВПрокат.DeleteOnSubmit(d);
                context.SubmitChanges();


                int idf = int.Parse(выданоВПрокатDataGridView[1,0].Value.ToString());
                var q = (from str in context.Фильмы
                         where str.ID_Фильма == idf
                         select str).FirstOrDefault();

                q.Наличие = true;
                context.SubmitChanges();
                фильмыBindingSource.DataSource = context.Фильмы;
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }
        }
    }
}
