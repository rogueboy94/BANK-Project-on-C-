using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class AddNewPayments : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();

        public AddNewPayments()
        {

            InitializeComponent();
            txt_ID.Text = Guid.NewGuid().ToString();

            dgv_clients.DataSource = sqlfns.AllClients();

            if (dgv_clients.DataSource == null && dgv_clients.Rows.Count == 0)
            {
                dgv_clients.Enabled = dgv_credits.Enabled = txt_Balance.Enabled = dtp_opendate.Enabled = btn_add.Enabled = false;
                lbl_nocredits.Visible = true;
            }
            else
            {
                dgv_clients.Enabled = dgv_credits.Enabled = txt_Balance.Enabled = dtp_opendate.Enabled = btn_add.Enabled = true;
                ClientsSettings();
            }
        }

        void ClientsSettings()
        {
            dgv_clients.Columns["ID"].Visible = false;
            dgv_clients.Columns["Payment"].Visible = false;
            dgv_clients.Columns["PhoneNumber"].Visible = false;
            dgv_clients.Columns["Name"].HeaderCell.Value = "Имя Клиента";

            dgv_clients.TopLeftHeaderCell.Value = "#";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Balance.Text.Length != 0)
            {
                if (sqlfns.AddNewPayment(txt_ID.Text,
                                         dgv_credits.CurrentRow.Cells[0].Value.ToString(),
                                         txt_Balance.Text,
                                         dtp_opendate.Value.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }

                int value = int.Parse(txt_currentbalance.Text);
                int currentvalue = int.Parse(txt_Balance.Text);
                value -= currentvalue;
                txt_currentbalance.Text = value.ToString();

                sqlfns.UpdateCredits(txt_currentbalance.Text, dgv_credits.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Введите сумму!");
            }
        }

        private void dgv_clients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgv_credits.DataSource = sqlfns.AllCredits(dgv_clients.CurrentRow.Cells[0].Value.ToString());

            if (dgv_credits.DataSource == null || dgv_credits.Rows.Count == 0)
            {
                dgv_credits.Enabled = txt_Balance.Enabled = dtp_opendate.Enabled = btn_add.Enabled = false;
            }
            else
            {
                dgv_credits.Enabled = txt_Balance.Enabled = dtp_opendate.Enabled = btn_add.Enabled = true;
                dgv_credits.Columns["DebitorID"].Visible = dgv_credits.Columns["ID"].Visible = false;
            }
        }

        private void lbl_open_searchbox_Click(object sender, EventArgs e)
        {
            if (txt_search.Visible == false)
            {
                lbl_open_searchbox.Text = "[ - ]";
                txt_search.Visible = true;
            }
            else
            {
                lbl_open_searchbox.Text = "[ + ]";
                txt_search.Visible = false;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_clients.TopLeftHeaderCell.Value = "#";
            dgv_clients.DataSource = sqlfns.AllClientsSearch(txt_search.Text);
            if (dgv_clients.CurrentRow != null)
            {
                if (dgv_clients.Columns["ID"].Visible == true && dgv_clients.Columns["PhoneNumber"].Visible == true)
                {
                    dgv_clients.Columns["ID"].Visible = dgv_clients.Columns["PhoneNumber"].Visible = false;
                    dgv_clients.Columns["Name"].HeaderCell.Value = "Имя Клиента";
                }
            }
            else
            {
                MessageBox.Show("Данные '" + txt_search.Text + "' не найдены!");
            }
        }

        private void dgv_credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_currentbalance.Text = dgv_credits.CurrentRow.Cells[3].Value.ToString();
        }

        private void txt_Balance_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txt_Balance.Text) < 500 || int.Parse(txt_Balance.Text) > 1000000)
            {
                MessageBox.Show("Введенная сумма '"+ txt_Balance.Text +"' не соответсвует стандартам! Введите сумму между 500 - 1000000");
                txt_Balance.Text = "";
            }
        }
    }
}
