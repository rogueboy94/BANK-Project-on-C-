using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BANK
{
    public partial class BANK_Manager_Form : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        
        public BANK_Manager_Form()
        {
            InitializeComponent();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            Main_BANK_Form bank_form = new Main_BANK_Form();
            if (txt_ID.Text.Length == 0 || txt_password.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else
            {
                if (sqlfns.AdministratorData(txt_ID.Text, txt_password.Text, "admin", "admin"))
                {
                    BANK_Manager_Form.ActiveForm.Hide();
                    bank_form.сотрудникиToolStripMenuItem.Visible = true;
                    bank_form.изменитьДанныеToolStripMenuItem.Visible = true;
                    bank_form.ShowDialog();
                }
                else if (sqlfns.WorkerData(txt_ID.Text, txt_password.Text))
                {
                    BANK_Manager_Form.ActiveForm.Hide();
                    bank_form.сотрудникиToolStripMenuItem.Visible = false;
                    bank_form.изменитьДанныеToolStripMenuItem.Visible = false;
                    bank_form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный ID или Пароль!");
                    txt_ID.Text = "";
                    txt_password.Text = "";
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            if (registration.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Ваш АККАУНТ успешно создан!");
            }
            else
            {
                MessageBox.Show("Ваш АККАУНТ 'HE' создан!");
            } 
        }

        private void BANK_Manager_Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите Выйти?", "БАНК Менеджмент", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void BANK_Manager_Form_Load(object sender, EventArgs e)
        {
            if (!CheckDatabaseExist())
            {
                GenerateDatabase();
            }
        }

        private bool CheckDatabaseExist()
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=BANK Management; Integrated Security=True");
            try
            {
                Connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void GenerateDatabase()
        {
            List<string> cmds = new List<string>();
            if (File.Exists(Application.StartupPath + "\\Script.sql"))
            {
                TextReader tr = new StreamReader(Application.StartupPath + "\\Script.sql");
                string line = "";
                string cmd = "";
                while((line = tr.ReadLine()) != null)
                {
                    if(line.Trim().ToUpper() == "GO")
                    {
                        cmds.Add(cmd);
                        cmd = "";
                    }
                    else
                    {
                        cmd += line + "\r\n";
                    }
                }
                if(cmd.Length > 0)
                {
                    cmds.Add(cmd);
                    cmd = "";
                }
                tr.Close();
            }
            if (cmds.Count > 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=BANK Management; Integrated Security=True");
                command.CommandType = System.Data.CommandType.Text;
                command.Connection.Open();
                for(int i = 0; i < cmds.Count; i++)
                {
                    command.CommandText = cmds[i];
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}