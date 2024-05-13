namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            button5 = new Button();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            listView2 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(742, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveCaption;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(734, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задачи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(301, 96);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 11;
            label5.Text = "Оценка задачи:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(302, 53);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 10;
            label4.Text = "Номер Задачи:";
            label4.Click += label4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(212, 319);
            button5.Name = "button5";
            button5.Size = new Size(93, 64);
            button5.TabIndex = 1;
            button5.Text = "Добавить в выполненные задачи";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(395, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Отлично", "Хорошо", "Можно было лучше", "Плохо" });
            comboBox2.Location = new Point(395, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Готово", "В процессе" });
            comboBox1.Location = new Point(153, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(558, 56);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(35, 56);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Название задачи:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Готовность задачи:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(569, 32);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 3;
            label1.Text = "Срок выполнения задач:";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(17, 319);
            button2.Name = "button2";
            button2.Size = new Size(90, 64);
            button2.TabIndex = 2;
            button2.Text = "Добавить задачу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(113, 319);
            button1.Name = "button1";
            button1.Size = new Size(93, 64);
            button1.TabIndex = 1;
            button1.Text = "Удалить задачу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader10, columnHeader9 });
            listView1.GridLines = true;
            listView1.Location = new Point(17, 158);
            listView1.Name = "listView1";
            listView1.Size = new Size(510, 155);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Название Задачи";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Готовность";
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Срок выполнения";
            columnHeader4.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.DisplayIndex = 4;
            columnHeader10.Text = "Номер задачи";
            columnHeader10.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 3;
            columnHeader9.Text = "Оценка";
            columnHeader9.Width = 80;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-105, -64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(909, 466);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(734, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Выполненные задачи";
            // 
            // button3
            // 
            button3.Location = new Point(129, 314);
            button3.Name = "button3";
            button3.Size = new Size(206, 58);
            button3.TabIndex = 6;
            button3.Text = "Удалить выполненную задачу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader8, columnHeader7, columnHeader3, columnHeader6 });
            listView2.GridLines = true;
            listView2.Location = new Point(36, 29);
            listView2.Name = "listView2";
            listView2.Size = new Size(420, 279);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 1;
            columnHeader5.Text = "Название задачи";
            columnHeader5.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.DisplayIndex = 4;
            columnHeader8.Text = "Статус";
            // 
            // columnHeader7
            // 
            columnHeader7.DisplayIndex = 3;
            columnHeader7.Text = "Дата";
            columnHeader7.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 0;
            columnHeader3.Text = "№Задачи";
            columnHeader3.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 2;
            columnHeader6.Text = "Оценка";
            columnHeader6.Width = 80;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(734, 398);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView listView1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ListView listView2;
        private TextBox textBox2;
        private ColumnHeader columnHeader3;
        private ComboBox comboBox2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader5;
        private Button button5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label5;
        private Label label4;
    }
}
