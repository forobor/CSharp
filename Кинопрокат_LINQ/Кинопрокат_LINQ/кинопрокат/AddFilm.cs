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
    public partial class AddFilm : Form
    {
        public Form1 f1 = new Form1();
        public AddFilm(Form1 f1 )
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new DataClassesDataContext();
                var film = new Фильмы();
                film.ID_Фильма = f1.id;
                film.Название = textBox1.Text;
                film.Режиссер = textBox2.Text;
                film.Рейтинг = textBox3.Text;
                film.Наличие = true;
                context.Фильмы.InsertOnSubmit(film);
                context.SubmitChanges();
                f1.фильмыBindingSource.DataSource = context.Фильмы;
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
