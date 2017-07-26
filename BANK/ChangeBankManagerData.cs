using System;
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
    public partial class ChangeBankManagerData : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        public ChangeBankManagerData()
        {
            InitializeComponent();
            dgv_administration.DataSource = sqlfns.GetAdministrationData();
            
            if (dgv_administration.DataSource == null || dgv_administration.Rows.Count == 0)
            {
                txt_id.Enabled = txt_password.Enabled = txt_name.Enabled = txt_surname.Enabled = btn_update.Enabled = lstgender.Enabled = false;
            }
       }

        private void dgv_administration_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_administration.CurrentRow.Cells[0].Value.ToString();
            txt_password.Text = dgv_administration.CurrentRow.Cells[1].Value.ToString(); 
            txt_name.Text = dgv_administration.CurrentRow.Cells[2].Value.ToString();
            txt_surname.Text = dgv_administration.CurrentRow.Cells[3].Value.ToString();
            
            if (dgv_administration.CurrentRow.Cells[4].Value.ToString() == "admin")
            {
                lstgender.Enabled = false;
                txt_admin.Visible = true;
            }
            else
            {
                lstgender.Enabled = true;
                txt_admin.Visible = false;
            }
            
            if (txt_admin.Visible != true)
            {
                lstgender.SelectedIndex = 0;
            }
            else
            {
                lstgender.SelectedItem = null;
            }
        }
        private void rb_update_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = txt_password.Enabled = txt_name.Enabled = txt_surname.Enabled = lstgender.Enabled = true;
            btn_update.Text = "Обновить";
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Enabled = txt_password.Enabled = txt_name.Enabled = txt_surname.Enabled = lstgender.Enabled = false;
            btn_update.Text = "Удалить";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length == 0 || txt_password.Text.Length == 0 || txt_name.Text.Length == 0 || txt_surname.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else
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
        }

        private void UpdateSection()
        {
            Guid id = Guid.Parse(txt_id.Text);

            if (MessageBox.Show("Вы действительно хотите выполнить операцию?", "БАНК Менеджмент", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (txt_admin.Visible == true || txt_name.Text == "admin" || txt_surname.Text == "admin")
                {
                    if (sqlfns.UpdateAdministrationData(id, txt_password.Text, txt_name.Text, txt_surname.Text, txt_admin.Text, dgv_administration.CurrentRow.Cells[0].Value.ToString()))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                    }
                }
                else
                {
                    if (sqlfns.UpdateAdministrationData(id, txt_password.Text, txt_name.Text, txt_surname.Text, lstgender.SelectedItem.ToString(), dgv_administration.CurrentRow.Cells[0].Value.ToString()))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                    }

                }
            }
        }

        private void DeleteSection()
        {
            if (MessageBox.Show("Вы действительно хотите выполнить операцию?", "БАНК Менеджмент", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (sqlfns.DeleteAdministrationData(dgv_administration.CurrentRow.Cells[0].Value.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void lstgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_update.Enabled = true;
        }
    }
}
