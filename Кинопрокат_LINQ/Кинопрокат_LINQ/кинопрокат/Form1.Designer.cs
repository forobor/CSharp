namespace кинопрокат
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.клиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.выданоВПрокатDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выданоВПрокатBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.buttonChanFilm = new System.Windows.Forms.Button();
            this.buttonDelFilm = new System.Windows.Forms.Button();
            this.buttonDelCus = new System.Windows.Forms.Button();
            this.buttonChanCus = new System.Windows.Forms.Button();
            this.buttonAddCus = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.выданоВПрокатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выданоВПрокатDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // клиентыDataGridView
            // 
            this.клиентыDataGridView.AllowUserToAddRows = false;
            this.клиентыDataGridView.AllowUserToDeleteRows = false;
            this.клиентыDataGridView.AutoGenerateColumns = false;
            this.клиентыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.клиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.клиентыDataGridView.DataSource = this.клиентыBindingSource;
            this.клиентыDataGridView.Location = new System.Drawing.Point(675, 134);
            this.клиентыDataGridView.MultiSelect = false;
            this.клиентыDataGridView.Name = "клиентыDataGridView";
            this.клиентыDataGridView.ReadOnly = true;
            this.клиентыDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.клиентыDataGridView.Size = new System.Drawing.Size(481, 220);
            this.клиентыDataGridView.TabIndex = 1;
            this.клиентыDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.клиентыDataGridView_CellClick);
            this.клиентыDataGridView.Click += new System.EventHandler(this.клиентыDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataSource = typeof(кинопрокат.Клиенты);
            // 
            // фильмыDataGridView
            // 
            this.фильмыDataGridView.AllowUserToAddRows = false;
            this.фильмыDataGridView.AllowUserToDeleteRows = false;
            this.фильмыDataGridView.AutoGenerateColumns = false;
            this.фильмыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.фильмыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.фильмыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.фильмыDataGridView.DataSource = this.фильмыBindingSource;
            this.фильмыDataGridView.Location = new System.Drawing.Point(12, 134);
            this.фильмыDataGridView.Name = "фильмыDataGridView";
            this.фильмыDataGridView.ReadOnly = true;
            this.фильмыDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.фильмыDataGridView.Size = new System.Drawing.Size(502, 220);
            this.фильмыDataGridView.TabIndex = 3;
            this.фильмыDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.фильмыDataGridView_CellClick);
            this.фильмыDataGridView.Click += new System.EventHandler(this.фильмыDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID_Фильма";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID_Фильма";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn12.HeaderText = "Название";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Режиссер";
            this.dataGridViewTextBoxColumn13.HeaderText = "Режиссер";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Рейтинг";
            this.dataGridViewTextBoxColumn14.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Наличие";
            this.dataGridViewTextBoxColumn15.HeaderText = "Наличие";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataSource = typeof(кинопрокат.Фильмы);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кинопрокат";
            // 
            // выданоВПрокатDataGridView
            // 
            this.выданоВПрокатDataGridView.AllowUserToAddRows = false;
            this.выданоВПрокатDataGridView.AutoGenerateColumns = false;
            this.выданоВПрокатDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.выданоВПрокатDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выданоВПрокатDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.выданоВПрокатDataGridView.DataSource = this.выданоВПрокатBindingSource1;
            this.выданоВПрокатDataGridView.Location = new System.Drawing.Point(359, 426);
            this.выданоВПрокатDataGridView.Name = "выданоВПрокатDataGridView";
            this.выданоВПрокатDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.выданоВПрокатDataGridView.Size = new System.Drawing.Size(451, 220);
            this.выданоВПрокатDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_Выдачи";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код_Выдачи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Фильма";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Фильма";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_Клиента";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID_Клиента";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Клиенты";
            this.dataGridViewTextBoxColumn9.HeaderText = "Клиенты";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Фильмы";
            this.dataGridViewTextBoxColumn10.HeaderText = "Фильмы";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // выданоВПрокатBindingSource1
            // 
            this.выданоВПрокатBindingSource1.DataMember = "ВыданоВПрокат";
            this.выданоВПрокатBindingSource1.DataSource = this.фильмыBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите ID_Фильма";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(246, 361);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFilm.TabIndex = 7;
            this.buttonAddFilm.Text = "Добавить";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // buttonChanFilm
            // 
            this.buttonChanFilm.Location = new System.Drawing.Point(327, 361);
            this.buttonChanFilm.Name = "buttonChanFilm";
            this.buttonChanFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonChanFilm.TabIndex = 8;
            this.buttonChanFilm.Text = "Изменить";
            this.buttonChanFilm.UseVisualStyleBackColor = true;
            this.buttonChanFilm.Click += new System.EventHandler(this.buttonChanFilm_Click);
            // 
            // buttonDelFilm
            // 
            this.buttonDelFilm.Location = new System.Drawing.Point(408, 361);
            this.buttonDelFilm.Name = "buttonDelFilm";
            this.buttonDelFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonDelFilm.TabIndex = 9;
            this.buttonDelFilm.Text = "Удалить";
            this.buttonDelFilm.UseVisualStyleBackColor = true;
            this.buttonDelFilm.Click += new System.EventHandler(this.buttonDelFilm_Click);
            // 
            // buttonDelCus
            // 
            this.buttonDelCus.Location = new System.Drawing.Point(1068, 366);
            this.buttonDelCus.Name = "buttonDelCus";
            this.buttonDelCus.Size = new System.Drawing.Size(75, 23);
            this.buttonDelCus.TabIndex = 14;
            this.buttonDelCus.Text = "Удалить";
            this.buttonDelCus.UseVisualStyleBackColor = true;
            this.buttonDelCus.Click += new System.EventHandler(this.buttonDelCus_Click);
            // 
            // buttonChanCus
            // 
            this.buttonChanCus.Location = new System.Drawing.Point(987, 366);
            this.buttonChanCus.Name = "buttonChanCus";
            this.buttonChanCus.Size = new System.Drawing.Size(75, 23);
            this.buttonChanCus.TabIndex = 13;
            this.buttonChanCus.Text = "Изменить";
            this.buttonChanCus.UseVisualStyleBackColor = true;
            this.buttonChanCus.Click += new System.EventHandler(this.buttonChanCus_Click);
            // 
            // buttonAddCus
            // 
            this.buttonAddCus.Location = new System.Drawing.Point(906, 366);
            this.buttonAddCus.Name = "buttonAddCus";
            this.buttonAddCus.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCus.TabIndex = 12;
            this.buttonAddCus.Text = "Добавить";
            this.buttonAddCus.UseVisualStyleBackColor = true;
            this.buttonAddCus.Click += new System.EventHandler(this.buttonAddCus_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(799, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите ID_Клиента";
            // 
            // выданоВПрокатBindingSource
            // 
            this.выданоВПрокатBindingSource.DataMember = "ВыданоВПрокат";
            this.выданоВПрокатBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // выданоВПрокатDataGridView1
            // 
            this.выданоВПрокатDataGridView1.AllowUserToAddRows = false;
            this.выданоВПрокатDataGridView1.AllowUserToDeleteRows = false;
            this.выданоВПрокатDataGridView1.AutoGenerateColumns = false;
            this.выданоВПрокатDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.выданоВПрокатDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выданоВПрокатDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.выданоВПрокатDataGridView1.DataSource = this.выданоВПрокатBindingSource;
            this.выданоВПрокатDataGridView1.Location = new System.Drawing.Point(359, 426);
            this.выданоВПрокатDataGridView1.Name = "выданоВПрокатDataGridView1";
            this.выданоВПрокатDataGridView1.ReadOnly = true;
            this.выданоВПрокатDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.выданоВПрокатDataGridView1.Size = new System.Drawing.Size(451, 220);
            this.выданоВПрокатDataGridView1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Код_Выдачи";
            this.dataGridViewTextBoxColumn16.HeaderText = "Код_Выдачи";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ID_Фильма";
            this.dataGridViewTextBoxColumn17.HeaderText = "ID_Фильма";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ID_Клиента";
            this.dataGridViewTextBoxColumn18.HeaderText = "ID_Клиента";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn19.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Клиенты";
            this.dataGridViewTextBoxColumn20.HeaderText = "Клиенты";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Фильмы";
            this.dataGridViewTextBoxColumn21.HeaderText = "Фильмы";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(839, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите ID_Фильма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(839, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Введите ID_Клиента";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(988, 438);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(988, 464);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Выдать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Введите цену";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(988, 492);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(842, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Для удаления выберите ФИЛЬМ из таблицы фильмы ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 686);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.выданоВПрокатDataGridView1);
            this.Controls.Add(this.buttonDelCus);
            this.Controls.Add(this.buttonChanCus);
            this.Controls.Add(this.buttonAddCus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDelFilm);
            this.Controls.Add(this.buttonChanFilm);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.выданоВПрокатDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.фильмыDataGridView);
            this.Controls.Add(this.клиентыDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданоВПрокатDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView клиентыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource выданоВПрокатBindingSource;
        private System.Windows.Forms.DataGridView фильмыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource выданоВПрокатBindingSource1;
        private System.Windows.Forms.DataGridView выданоВПрокатDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.Button buttonChanFilm;
        private System.Windows.Forms.Button buttonDelFilm;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.BindingSource фильмыBindingSource;
        private System.Windows.Forms.Button buttonDelCus;
        private System.Windows.Forms.Button buttonChanCus;
        private System.Windows.Forms.Button buttonAddCus;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView выданоВПрокатDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        public System.Windows.Forms.BindingSource клиентыBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}

