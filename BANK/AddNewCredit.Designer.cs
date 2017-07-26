namespace BANK
{
    partial class AddNewCredit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.grpbox_seach = new System.Windows.Forms.GroupBox();
            this.lbl_open_searchbox = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.debitorname_lstbox = new System.Windows.Forms.ListBox();
            this.debitorid_lstbox = new System.Windows.Forms.ListBox();
            this.dtp_opendate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.grpbox_seach.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grpbox_seach);
            this.groupBox1.Controls.Add(this.debitorname_lstbox);
            this.groupBox1.Controls.Add(this.debitorid_lstbox);
            this.groupBox1.Controls.Add(this.dtp_opendate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txt_Balance);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 548);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление Нового Кредита";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.dgv_client);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(201, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 148);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиенты";
            // 
            // dgv_client
            // 
            this.dgv_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_client.Location = new System.Drawing.Point(3, 25);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_client.Size = new System.Drawing.Size(658, 120);
            this.dgv_client.TabIndex = 0;
            // 
            // grpbox_seach
            // 
            this.grpbox_seach.BackColor = System.Drawing.Color.Gainsboro;
            this.grpbox_seach.Controls.Add(this.lbl_open_searchbox);
            this.grpbox_seach.Controls.Add(this.txt_search);
            this.grpbox_seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbox_seach.ForeColor = System.Drawing.Color.ForestGreen;
            this.grpbox_seach.Location = new System.Drawing.Point(6, 39);
            this.grpbox_seach.Name = "grpbox_seach";
            this.grpbox_seach.Size = new System.Drawing.Size(859, 73);
            this.grpbox_seach.TabIndex = 13;
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
            this.txt_search.Location = new System.Drawing.Point(82, 30);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(760, 31);
            this.txt_search.TabIndex = 0;
            this.txt_search.Visible = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // debitorname_lstbox
            // 
            this.debitorname_lstbox.DisplayMember = "Name";
            this.debitorname_lstbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debitorname_lstbox.FormattingEnabled = true;
            this.debitorname_lstbox.ItemHeight = 18;
            this.debitorname_lstbox.Location = new System.Drawing.Point(547, 168);
            this.debitorname_lstbox.Name = "debitorname_lstbox";
            this.debitorname_lstbox.Size = new System.Drawing.Size(318, 148);
            this.debitorname_lstbox.TabIndex = 12;
            this.debitorname_lstbox.ValueMember = "ID";
            // 
            // debitorid_lstbox
            // 
            this.debitorid_lstbox.DisplayMember = "ID";
            this.debitorid_lstbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debitorid_lstbox.FormattingEnabled = true;
            this.debitorid_lstbox.ItemHeight = 18;
            this.debitorid_lstbox.Location = new System.Drawing.Point(201, 168);
            this.debitorid_lstbox.Name = "debitorid_lstbox";
            this.debitorid_lstbox.Size = new System.Drawing.Size(341, 148);
            this.debitorid_lstbox.TabIndex = 11;
            this.debitorid_lstbox.ValueMember = "ID";
            // 
            // dtp_opendate
            // 
            this.dtp_opendate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_opendate.Location = new System.Drawing.Point(201, 417);
            this.dtp_opendate.Name = "dtp_opendate";
            this.dtp_opendate.Size = new System.Drawing.Size(661, 40);
            this.dtp_opendate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата добавления";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_add.Location = new System.Drawing.Point(14, 488);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(848, 50);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // txt_Balance
            // 
            this.txt_Balance.Enabled = false;
            this.txt_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Balance.Location = new System.Drawing.Point(201, 375);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.Size = new System.Drawing.Size(661, 31);
            this.txt_Balance.TabIndex = 7;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Amount.Location = new System.Drawing.Point(201, 332);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(661, 31);
            this.txt_Amount.TabIndex = 6;
            this.txt_Amount.TextChanged += new System.EventHandler(this.txt_Amount_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ID.Location = new System.Drawing.Point(201, 120);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(664, 31);
            this.txt_ID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Баланс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кредитор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // AddNewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 566);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "AddNewCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewCredit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.grpbox_seach.ResumeLayout(false);
            this.grpbox_seach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_opendate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox debitorname_lstbox;
        private System.Windows.Forms.ListBox debitorid_lstbox;
        private System.Windows.Forms.GroupBox grpbox_seach;
        private System.Windows.Forms.Label lbl_open_searchbox;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_client;
    }
}