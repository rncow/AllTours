namespace AllTours
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxOrderPrice = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxIsOrderPaid = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.labelExclusive = new System.Windows.Forms.Label();
            this.textBoxExclusive = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(606, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать генерацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(606, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Остановить генерацию";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(606, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Очистить БД";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Location = new System.Drawing.Point(606, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "Посмотреть БД";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добро пожаловать. Снова.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(359, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxName.Location = new System.Drawing.Point(15, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(384, 17);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxPhone.Location = new System.Drawing.Point(437, 88);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(128, 17);
            this.textBoxPhone.TabIndex = 9;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxEmail.Location = new System.Drawing.Point(15, 133);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(384, 17);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 26);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBoxOrderPrice
            // 
            this.textBoxOrderPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrderPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxOrderPrice.Location = new System.Drawing.Point(437, 133);
            this.textBoxOrderPrice.Name = "textBoxOrderPrice";
            this.textBoxOrderPrice.Size = new System.Drawing.Size(128, 17);
            this.textBoxOrderPrice.TabIndex = 12;
            this.textBoxOrderPrice.TextChanged += new System.EventHandler(this.TextBoxOrderPrice_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 284);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 26);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonAddOrder.Enabled = false;
            this.buttonAddOrder.FlatAppearance.BorderSize = 0;
            this.buttonAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonAddOrder.Location = new System.Drawing.Point(12, 366);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(152, 44);
            this.buttonAddOrder.TabIndex = 14;
            this.buttonAddOrder.Text = "Создать заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.ButtonAddOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(434, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(13, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Тур";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(434, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Итоговая цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(10, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Тип билета";
            // 
            // checkBoxIsOrderPaid
            // 
            this.checkBoxIsOrderPaid.AutoSize = true;
            this.checkBoxIsOrderPaid.FlatAppearance.BorderSize = 0;
            this.checkBoxIsOrderPaid.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.checkBoxIsOrderPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIsOrderPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBoxIsOrderPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxIsOrderPaid.Location = new System.Drawing.Point(14, 328);
            this.checkBoxIsOrderPaid.Name = "checkBoxIsOrderPaid";
            this.checkBoxIsOrderPaid.Size = new System.Drawing.Size(150, 22);
            this.checkBoxIsOrderPaid.TabIndex = 21;
            this.checkBoxIsOrderPaid.Text = "Заказ оплачен?";
            this.checkBoxIsOrderPaid.UseVisualStyleBackColor = true;
            this.checkBoxIsOrderPaid.CheckedChanged += new System.EventHandler(this.CheckBoxIsOrderPaid_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label.Location = new System.Drawing.Point(692, 263);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 22;
            this.label.Text = "labeltest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Тип тура";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Classic",
            "Business",
            "World",
            "Exclusive"});
            this.comboBox3.Location = new System.Drawing.Point(16, 180);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 26);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrganization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelOrganization.Location = new System.Drawing.Point(225, 159);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(98, 18);
            this.labelOrganization.TabIndex = 26;
            this.labelOrganization.Text = "Организация";
            this.labelOrganization.Visible = false;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrganization.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxOrganization.Location = new System.Drawing.Point(228, 180);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(366, 17);
            this.textBoxOrganization.TabIndex = 25;
            this.textBoxOrganization.Visible = false;
            // 
            // labelExclusive
            // 
            this.labelExclusive.AutoSize = true;
            this.labelExclusive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExclusive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelExclusive.Location = new System.Drawing.Point(225, 159);
            this.labelExclusive.Name = "labelExclusive";
            this.labelExclusive.Size = new System.Drawing.Size(148, 18);
            this.labelExclusive.TabIndex = 28;
            this.labelExclusive.Text = "Пожелания клиента";
            this.labelExclusive.Visible = false;
            // 
            // textBoxExclusive
            // 
            this.textBoxExclusive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxExclusive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExclusive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExclusive.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxExclusive.Location = new System.Drawing.Point(228, 183);
            this.textBoxExclusive.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.textBoxExclusive.Multiline = true;
            this.textBoxExclusive.Name = "textBoxExclusive";
            this.textBoxExclusive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExclusive.Size = new System.Drawing.Size(366, 130);
            this.textBoxExclusive.TabIndex = 27;
            this.textBoxExclusive.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::AllTours.Properties.Resources._240px_Windows_Settings_app_icon;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(747, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 44);
            this.button5.TabIndex = 29;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button6.Location = new System.Drawing.Point(741, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 29);
            this.button6.TabIndex = 30;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 29);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelExclusive);
            this.Controls.Add(this.textBoxExclusive);
            this.Controls.Add(this.labelOrganization);
            this.Controls.Add(this.textBoxOrganization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBoxIsOrderPaid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxOrderPrice);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxOrderPrice;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxIsOrderPaid;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.TextBox textBoxOrganization;
        private System.Windows.Forms.Label labelExclusive;
        private System.Windows.Forms.TextBox textBoxExclusive;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
    }
}

