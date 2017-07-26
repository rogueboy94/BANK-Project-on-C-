using System;
using System.Windows.Forms;

namespace BANK
{
    public partial class ChangeClientsData : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        
        public ChangeClientsData()
        {
            InitializeComponent();
            dgv_client.DataSource = sqlfns.AllClients();
        }

        private void dgv_client_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_client.CurrentRow.Cells[1].Value.ToString();
            txt_count.Text = dgv_client.CurrentRow.Cells[2].Value.ToString();
            txt_phone.Text = dgv_client.CurrentRow.Cells[3].Value.ToString();
        }
        
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (rb_update.Checked)
            {
                UpdateSection();
            }
            else if (rb_delete.Checked)
            {
                DeleteSection();
            }
        }

        private void UpdateSection()
        {
            if (MessageBox.Show("Вы действительно хотите Обновить данные?", "БАНК Менеджмент", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (sqlfns.UpdateClientsData(dgv_client.CurrentRow.Cells[0].Value.ToString(), txt_name.Text, txt_count.Text, txt_phone.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void DeleteSection()
        {
            if (MessageBox.Show("Вы действительно хотите Удалить данные?", "БАНК Менеджмент", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (sqlfns.DeleteClientsData(dgv_client.CurrentRow.Cells[0].Value.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void rb_update_CheckedChanged(object sender, EventArgs e)
        {
            txt_name.Enabled = txt_phone.Enabled = txt_count.Enabled = true;
            btn_update.Text = "Обновить";
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            txt_name.Enabled = txt_phone.Enabled = txt_count.Enabled = false;
            btn_update.Text = "Удалить";
        }
    }
}
