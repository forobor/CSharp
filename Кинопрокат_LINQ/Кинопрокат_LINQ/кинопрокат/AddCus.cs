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
    public partial class AddCus : Form
    {
        Form1 f1 = new Form1();
        public AddCus(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new DataClassesDataContext();
                var cus = new Клиенты();
                cus.ID_Клиента = int.Parse(f1.textBox2.Text);
                cus.Имя = textBox1.Text;
                cus.Фамилия = textBox2.Text;
                cus.Телефон = textBox3.Text;
                context.Клиенты.InsertOnSubmit(cus);
                context.SubmitChanges();
                f1.клиентыBindingSource.DataSource = context.Клиенты;
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
