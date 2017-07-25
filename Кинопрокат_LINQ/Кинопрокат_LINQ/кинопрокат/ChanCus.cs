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
    public partial class ChanCus : Form
    {
        public Form1 f1 = new Form1();
        public ChanCus(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new DataClassesDataContext();

            var d = (from str in context.Клиенты
                     where str.ID_Клиента == int.Parse(f1.textBox2.Text)
                     select str).FirstOrDefault();

            if (textBox1.Text != "")
            {
                d.Имя = textBox1.Text;
            }
            if (textBox2.Text != "")
            {
                d.Фамилия = textBox2.Text;
            }
            if (textBox3.Text != "")
            {
                d.Телефон = textBox3.Text;
            }

            context.SubmitChanges();
            f1.клиентыBindingSource.DataSource = context.Клиенты;

            this.Close();
        }
    }
}
