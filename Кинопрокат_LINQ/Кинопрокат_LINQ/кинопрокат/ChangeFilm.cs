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
    public partial class ChangeFilm : Form
    {
        public Form1 f1 = new Form1();
        public ChangeFilm(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new DataClassesDataContext();

            var d = (from str in context.Фильмы
                     where str.ID_Фильма == int.Parse(f1.textBox1.Text)
                     select str).FirstOrDefault();

            if (textBox1.Text != "")
            {
                d.Название = textBox1.Text;
            }
            if (textBox2.Text != "")
            {
                d.Режиссер = textBox2.Text;
            }
            if (textBox3.Text != "")
            {
                d.Рейтинг = textBox3.Text;
            }

            context.SubmitChanges();
            f1.фильмыBindingSource.DataSource = context.Фильмы;

            this.Close();
        }
    }
}
