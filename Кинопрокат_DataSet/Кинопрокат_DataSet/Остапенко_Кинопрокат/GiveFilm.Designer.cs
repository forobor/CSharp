namespace Остапенко_Кинопрокат
{
    partial class GiveFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кинопрокатDataSet = new Остапенко_Кинопрокат.КинопрокатDataSet();
            this.клиентыTableAdapter = new Остапенко_Кинопрокат.КинопрокатDataSetTableAdapters.КлиентыTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыTableAdapter = new Остапенко_Кинопрокат.КинопрокатDataSetTableAdapters.ФильмыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинопрокатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выдача фильма ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выдать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите клиента:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 205);
            this.dataGridView1.TabIndex = 8;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.кинопрокатDataSet;
            // 
            // кинопрокатDataSet
            // 
            this.кинопрокатDataSet.DataSetName = "КинопрокатDataSet";
            this.кинопрокатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(473, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите фильм:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФильмаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.режиссерDataGridViewTextBoxColumn,
            this.рейтингDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.наличиеDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.фильмыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(473, 151);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(456, 205);
            this.dataGridView2.TabIndex = 10;
            // 
            // iDФильмаDataGridViewTextBoxColumn
            // 
            this.iDФильмаDataGridViewTextBoxColumn.DataPropertyName = "ID_Фильма";
            this.iDФильмаDataGridViewTextBoxColumn.HeaderText = "ID_Фильма";
            this.iDФильмаDataGridViewTextBoxColumn.Name = "iDФильмаDataGridViewTextBoxColumn";
            this.iDФильмаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // режиссерDataGridViewTextBoxColumn
            // 
            this.режиссерDataGridViewTextBoxColumn.DataPropertyName = "Режиссер";
            this.режиссерDataGridViewTextBoxColumn.HeaderText = "Режиссер";
            this.режиссерDataGridViewTextBoxColumn.Name = "режиссерDataGridViewTextBoxColumn";
            this.режиссерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рейтингDataGridViewTextBoxColumn
            // 
            this.рейтингDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.Name = "рейтингDataGridViewTextBoxColumn";
            this.рейтингDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            this.годDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наличиеDataGridViewCheckBoxColumn
            // 
            this.наличиеDataGridViewCheckBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewCheckBoxColumn.Name = "наличиеDataGridViewCheckBoxColumn";
            this.наличиеDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.кинопрокатDataSet;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // GiveFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 412);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GiveFilm";
            this.Text = "GiveFilm";
            this.Load += new System.EventHandler(this.GiveFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинопрокатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private КинопрокатDataSet кинопрокатDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private КинопрокатDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private КинопрокатDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтингDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеDataGridViewCheckBoxColumn;
    }
}