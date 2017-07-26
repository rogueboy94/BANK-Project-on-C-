using System;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;
using System.Windows.Forms;
using System.Data;

namespace BANK
{
    public partial class Main_BANK_Form : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        
        public Main_BANK_Form()
        {
            InitializeComponent();
            BANK_Manager_Form bmf = new BANK_Manager_Form();
            txt_search.Visible = сотрудникиToolStripMenuItem.Visible = изменитьДанныеToolStripMenuItem.Visible = false;

            bmf.Visible = false;
            //********** Client Data Grid View Details Visibility**********//
            dgv_client.DataSource = sqlfns.AllClients();
            

            ClientsSettings();
        }

        void ClientsSettings()
        {
            dgv_client.Columns["ID"].Visible = false;
            dgv_client.Columns["Payment"].Visible = false;
            dgv_client.Columns["PhoneNumber"].Visible = false;
            dgv_client.Columns["Name"].HeaderCell.Value = "Имя Клиента";

            dgv_client.TopLeftHeaderCell.Value = "#";
        }
        //********** END **********//
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void зарегистрироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
        
        //********** Clients, Credits Data Grid View Details **********//
        private void dgv_client_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_clientID.Text = dgv_client.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txt_clientNSM.Text = dgv_client.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txt_clientPaymentNo.Text = dgv_client.Rows[e.RowIndex].Cells["Payment"].Value.ToString();

            string phone = dgv_client.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            txt_clientPhone.Text = (phone == String.Empty) ? "Нет Данных" : phone;

            //********** Credits Data Grid View Details ********** //
            dgv_credits.DataSource = sqlfns.AllCredits(dgv_client.CurrentRow.Cells[0].Value.ToString());

            CreditsSettings();
        }

        void CreditsSettings()
        {
            if (dgv_credits.Rows.Count != 0)
            {
                dgv_credits.Columns["ID"].Visible = dgv_credits.Columns["DebitorID"].Visible = false;
                dgv_credits.Columns["Amount"].HeaderCell.Value = "Сумма";
                dgv_credits.Columns["Balance"].HeaderCell.Value = "Баланс";
                dgv_credits.Columns["OpenDate"].HeaderCell.Value = "Дата Открытия";

                dgv_credits.TopLeftHeaderCell.Value = "#";
                lbl_nocredits.Visible = false;
                lbl_nopayments.Visible = false;
                dgv_payments.Show();
            }
            else
            {
                lbl_nopayments.Visible = true;
                lbl_nocredits.Visible = true;
                dgv_payments.Hide();
            }
        }
        //********** END **********//

        //********** Payments Data Grid View Details **********//
        private void dgv_credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv_payments.DataSource = sqlfns.AllPayments(dgv_credits.CurrentRow.Cells[0].Value.ToString());

            PaymentsSettings();
        }
        void PaymentsSettings()
        {
            if (dgv_payments.Rows.Count != 0)
            {
                dgv_payments.Columns["ID"].Visible = dgv_payments.Columns["CreditsID"].Visible = false;
                dgv_payments.Columns["Amount"].HeaderCell.Value = "Сумма";
                dgv_payments.Columns["PaymentDate"].HeaderCell.Value = "Дата Оплаты";

                dgv_payments.TopLeftHeaderCell.Value = "#";
                lbl_nopayments.Visible = false;
            }
            else
            {
                lbl_nopayments.Visible = true;
            }
        }

        private void Main_BANK_Form_Load(object sender, EventArgs e)
        {
            dgv_client.CellEnter += new DataGridViewCellEventHandler(dgv_client_CellEnter);
            dgv_credits.CellEnter += new DataGridViewCellEventHandler(dgv_credits_CellEnter);
        }
        //********** END **********//
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewClient addnewclient = new AddNewClient();
            
            if (addnewclient.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый Клиент успешно создан!", "Банк Менеджер", MessageBoxButtons.OK);
                dgv_client.DataSource = sqlfns.AllClients();
            }
            else
            {
                MessageBox.Show("Новый Клиент 'НЕ' создан!", "Банк Менеджер", MessageBoxButtons.OK);
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewCredit addnewcredit = new AddNewCredit();

            if (addnewcredit.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый Кредит успешно создан!", "Банк Менеджер", MessageBoxButtons.OK);
                dgv_credits.DataSource = sqlfns.AllCredits(dgv_client.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Новый Кредит 'НЕ' создан!", "Банк Менеджер", MessageBoxButtons.OK);
            }
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddNewPayments addnewpayments = new AddNewPayments();
            if (addnewpayments.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый Платеж успешно внесен!", "Банк Менеджер", MessageBoxButtons.OK);
                dgv_credits.DataSource = sqlfns.AllCredits(dgv_client.CurrentRow.Cells[0].Value.ToString());
                dgv_payments.DataSource = sqlfns.AllPayments(dgv_credits.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Новый Платеж 'НЕ' внесен!", "Банк Менеджер", MessageBoxButtons.OK);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_client.TopLeftHeaderCell.Value = "#";
            dgv_client.DataSource = sqlfns.AllClientsSearch(txt_search.Text);
            if (dgv_client.CurrentRow != null)
            {
                if (dgv_client.Columns["ID"].Visible == true && dgv_client.Columns["Payment"].Visible == true && dgv_client.Columns["PhoneNumber"].Visible == true)
                {
                    dgv_client.Columns["ID"].Visible = dgv_client.Columns["Payment"].Visible = dgv_client.Columns["PhoneNumber"].Visible = false;
                    dgv_client.Columns["Name"].HeaderCell.Value = "Имя Клиента";
                }   
            }
            else
            {
                MessageBox.Show("Данные '" + txt_search.Text + "' не найдены!");
            }
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeClientsData ccd = new ChangeClientsData();
            if (ccd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Операция успешно выполнено!", "Банк Менеджер", MessageBoxButtons.OK);
                dgv_client.DataSource = sqlfns.AllClients();
            }
            else
            {
                MessageBox.Show("Операция 'НЕ' выполнено!", "Банк Менеджер", MessageBoxButtons.OK);
                dgv_client.DataSource = sqlfns.AllClients();
            }
        }

        private void lbl_open_searchbox_Click(object sender, EventArgs e)
        {
            if (txt_search.Visible == false)
            {
                txt_search.Visible = true;
                lbl_open_searchbox.Text = "[ - ]";
            }
            else
            {
                txt_search.Visible = false;
                lbl_open_searchbox.Text = "[ + ]";
            }
        }

        private void изменитьДанныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeBankManagerData cbmd = new ChangeBankManagerData();
            if (cbmd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Операция успешно выполнено!", "Банк Менеджер", MessageBoxButtons.OK);
                dgv_client.DataSource = sqlfns.AllClients();
            }
            else
            {
                MessageBox.Show("Операция 'НЕ' выполнено!", "Банк Менеджер", MessageBoxButtons.OK);
            }
        }

        private void Main_BANK_Form_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите Выйти?", "БАНК Менеджмент", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                e.Cancel = true;
            else
                Application.ExitThread();
        }
        //********** END **********//
    }
}
