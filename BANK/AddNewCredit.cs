using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class AddNewCredit : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        public AddNewCredit()
        {
            InitializeComponent();
            txt_ID.Text = Guid.NewGuid().ToString();
            
            if (sqlfns.AllClients().Count == 0)
            {
                txt_Amount.Enabled = txt_Balance.Enabled = dtp_opendate.Enabled = btn_add.Enabled = false;
            }

            dgv_client.DataSource = sqlfns.AllClients();
            dgvSettings();
        }

        public void dgvSettings()
        {
            dgv_client.TopLeftHeaderCell.Value = "#";
            dgv_client.Columns["Name"].HeaderCell.Value = "Имя";
            dgv_client.Columns["Payment"].HeaderCell.Value = "Счет";
            dgv_client.Columns[0].Visible = dgv_client.Columns[3].Visible = false;
        }
        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            txt_Amount.Text = txt_Amount.Text.Trim().Replace(" ", "");
            txt_Balance.Text = txt_Amount.Text;
        }
        
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (txt_Amount.Text.Length == 0)
            {
                MessageBox.Show("Введите Сумму!");
            }
            else
            {
                if (sqlfns.AddNewCredits(txt_ID.Text,
                                      dgv_client.CurrentRow.Cells[0].Value.ToString(),
                                      txt_Amount.Text,
                                      txt_Balance.Text,
                                      dtp_opendate.Value.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
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

        public void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_client.TopLeftHeaderCell.Value = "#";
            dgv_client.DataSource = sqlfns.AllClientsSearch(txt_search.Text);
            if (dgv_client.CurrentRow != null)
            {
                if (dgv_client.Columns["Payment"].Visible == true && dgv_client.Columns["PhoneNumber"].Visible == true)
                {
                    dgv_client.Columns["Payment"].Visible = dgv_client.Columns["PhoneNumber"].Visible = false;
                    dgv_client.Columns["Name"].HeaderCell.Value = "Имя Клиента";
                }
            }
            else
            {
                MessageBox.Show("Данные '" + txt_search.Text + "' не найдены!");
            }
        }
    }
}
