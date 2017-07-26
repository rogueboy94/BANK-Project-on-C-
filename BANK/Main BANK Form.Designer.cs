namespace BANK
{
    partial class Main_BANK_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.держателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кредитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbox_seach = new System.Windows.Forms.GroupBox();
            this.lbl_open_searchbox = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_clientPhone = new System.Windows.Forms.TextBox();
            this.txt_clientPaymentNo = new System.Windows.Forms.TextBox();
            this.txt_clientNSM = new System.Windows.Forms.TextBox();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_nocredits = new System.Windows.Forms.Label();
            this.dgv_credits = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_nopayments = new System.Windows.Forms.Label();
            this.dgv_payments = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpbox_seach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.держателиToolStripMenuItem,
            this.кредитыToolStripMenuItem,
            this.платежиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарегистрироватьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зарегистрироватьToolStripMenuItem
            // 
            this.зарегистрироватьToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.зарегистрироватьToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.зарегистрироватьToolStripMenuItem.Name = "зарегистрироватьToolStripMenuItem";
            this.зарегистрироватьToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.зарегистрироватьToolStripMenuItem.Text = "Зарегистрироваться";
            this.зарегистрироватьToolStripMenuItem.Click += new System.EventHandler(this.зарегистрироватьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.выйтиToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // держателиToolStripMenuItem
            // 
            this.держателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem});
            this.держателиToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.держателиToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo;
            this.держателиToolStripMenuItem.Name = "держателиToolStripMenuItem";
            this.держателиToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.держателиToolStripMenuItem.Text = "Клиенты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.добавитьToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            this.изменитьДанныеToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.изменитьДанныеToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            this.изменитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            this.изменитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеToolStripMenuItem_Click);
            // 
            // кредитыToolStripMenuItem
            // 
            this.кредитыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.кредитыToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.кредитыToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo;
            this.кредитыToolStripMenuItem.Name = "кредитыToolStripMenuItem";
            this.кредитыToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.кредитыToolStripMenuItem.Text = "Кредиты";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.BackColor = System.Drawing.Color.Thistle;
            this.добавитьToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGreen;
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.платежиToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.платежиToolStripMenuItem.ForeColor = System.Drawing.Color.Indigo;
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.платежиToolStripMenuItem.Text = "Платежи";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.BackColor = System.Drawing.Color.Thistle;
            this.добавитьToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkGreen;
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(153, 24);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьДанныеToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сотрудникиToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // изменитьДанныеToolStripMenuItem1
            // 
            this.изменитьДанныеToolStripMenuItem1.BackColor = System.Drawing.Color.Thistle;
            this.изменитьДанныеToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGreen;
            this.изменитьДанныеToolStripMenuItem1.Name = "изменитьДанныеToolStripMenuItem1";
            this.изменитьДанныеToolStripMenuItem1.Size = new System.Drawing.Size(230, 24);
            this.изменитьДанныеToolStripMenuItem1.Text = "Изменить Данные";
            this.изменитьДанныеToolStripMenuItem1.Click += new System.EventHandler(this.изменитьДанныеToolStripMenuItem1_Click);
            // 
            // grpbox_seach
            // 
            this.grpbox_seach.BackColor = System.Drawing.Color.Gainsboro;
            this.grpbox_seach.Controls.Add(this.lbl_open_searchbox);
            this.grpbox_seach.Controls.Add(this.txt_search);
            this.grpbox_seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbox_seach.ForeColor = System.Drawing.Color.ForestGreen;
            this.grpbox_seach.Location = new System.Drawing.Point(0, 75);
            this.grpbox_seach.Name = "grpbox_seach";
            this.grpbox_seach.Size = new System.Drawing.Size(846, 73);
            this.grpbox_seach.TabIndex = 1;
            this.grpbox_seach.TabStop = false;
            this.grpbox_seach.Text = "Поиск";
            // 
            // lbl_open_searchbox
            // 
            this.lbl_open_searchbox.AutoSize = true;
            this.lbl_open_searchbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_open_searchbox.ForeColor = System.Drawing.Color.Red;
            this.lbl_open_searchbox.Location = new System.Drawing.Point(12, 33);
            this.lbl_open_searchbox.Name = "lbl_open_searchbox";
            this.lbl_open_searchbox.Size = new System.Drawing.Size(48, 25);
            this.lbl_open_searchbox.TabIndex = 1;
            this.lbl_open_searchbox.Text = "[ + ]";
            this.lbl_open_searchbox.Click += new System.EventHandler(this.lbl_open_searchbox_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(72, 30);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(765, 31);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dgv_client);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            // 
            // dgv_client
            // 
            this.dgv_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_client.Location = new System.Drawing.Point(3, 25);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.Size = new System.Drawing.Size(371, 151);
            this.dgv_client.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.txt_clientPhone);
            this.groupBox2.Controls.Add(this.txt_clientPaymentNo);
            this.groupBox2.Controls.Add(this.txt_clientNSM);
            this.groupBox2.Controls.Add(this.txt_clientID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(383, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация Клиента";
            // 
            // txt_clientPhone
            // 
            this.txt_clientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_clientPhone.Location = new System.Drawing.Point(144, 129);
            this.txt_clientPhone.Name = "txt_clientPhone";
            this.txt_clientPhone.ReadOnly = true;
            this.txt_clientPhone.Size = new System.Drawing.Size(310, 26);
            this.txt_clientPhone.TabIndex = 7;
            // 
            // txt_clientPaymentNo
            // 
            this.txt_clientPaymentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_clientPaymentNo.Location = new System.Drawing.Point(144, 95);
            this.txt_clientPaymentNo.Name = "txt_clientPaymentNo";
            this.txt_clientPaymentNo.ReadOnly = true;
            this.txt_clientPaymentNo.Size = new System.Drawing.Size(310, 26);
            this.txt_clientPaymentNo.TabIndex = 6;
            // 
            // txt_clientNSM
            // 
            this.txt_clientNSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_clientNSM.Location = new System.Drawing.Point(144, 64);
            this.txt_clientNSM.Name = "txt_clientNSM";
            this.txt_clientNSM.ReadOnly = true;
            this.txt_clientNSM.Size = new System.Drawing.Size(310, 26);
            this.txt_clientNSM.TabIndex = 5;
            // 
            // txt_clientID
            // 
            this.txt_clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_clientID.Location = new System.Drawing.Point(144, 32);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.ReadOnly = true;
            this.txt_clientID.Size = new System.Drawing.Size(310, 26);
            this.txt_clientID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Счет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.lbl_nocredits);
            this.groupBox3.Controls.Add(this.dgv_credits);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(0, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кредиты";
            // 
            // lbl_nocredits
            // 
            this.lbl_nocredits.AutoSize = true;
            this.lbl_nocredits.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nocredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_nocredits.ForeColor = System.Drawing.Color.Red;
            this.lbl_nocredits.Location = new System.Drawing.Point(6, 29);
            this.lbl_nocredits.Name = "lbl_nocredits";
            this.lbl_nocredits.Size = new System.Drawing.Size(186, 29);
            this.lbl_nocredits.TabIndex = 2;
            this.lbl_nocredits.Text = "Нет Кредитов";
            this.lbl_nocredits.Visible = false;
            // 
            // dgv_credits
            // 
            this.dgv_credits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_credits.Location = new System.Drawing.Point(3, 26);
            this.dgv_credits.MultiSelect = false;
            this.dgv_credits.Name = "dgv_credits";
            this.dgv_credits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_credits.Size = new System.Drawing.Size(840, 150);
            this.dgv_credits.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.lbl_nopayments);
            this.groupBox4.Controls.Add(this.dgv_payments);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox4.Location = new System.Drawing.Point(0, 552);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(846, 179);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Платежи";
            // 
            // lbl_nopayments
            // 
            this.lbl_nopayments.AutoSize = true;
            this.lbl_nopayments.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nopayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_nopayments.ForeColor = System.Drawing.Color.Red;
            this.lbl_nopayments.Location = new System.Drawing.Point(6, 31);
            this.lbl_nopayments.Name = "lbl_nopayments";
            this.lbl_nopayments.Size = new System.Drawing.Size(192, 29);
            this.lbl_nopayments.TabIndex = 3;
            this.lbl_nopayments.Text = "Нет Платежей";
            this.lbl_nopayments.Visible = false;
            // 
            // dgv_payments
            // 
            this.dgv_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_payments.Location = new System.Drawing.Point(3, 27);
            this.dgv_payments.Name = "dgv_payments";
            this.dgv_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_payments.Size = new System.Drawing.Size(840, 149);
            this.dgv_payments.TabIndex = 1;
            // 
            // Main_BANK_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(849, 732);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox_seach);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_BANK_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_BANK_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_BANK_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_BANK_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbox_seach.ResumeLayout(false);
            this.grpbox_seach.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem держателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кредитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.GroupBox grpbox_seach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_clientPhone;
        private System.Windows.Forms.TextBox txt_clientPaymentNo;
        private System.Windows.Forms.TextBox txt_clientNSM;
        private System.Windows.Forms.TextBox txt_clientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_credits;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_payments;
        private System.Windows.Forms.Label lbl_nocredits;
        private System.Windows.Forms.Label lbl_nopayments;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_open_searchbox;
        public System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem1;
    }
}