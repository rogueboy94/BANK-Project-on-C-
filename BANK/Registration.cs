using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BANK
{
    public partial class Registration : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        public Registration()
        {
            InitializeComponent();

            txt_ID.Text = Guid.NewGuid().ToString();
            lst_gender.SelectedIndex = 0;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Length == 0 || txt_Surname.Text.Length == 0 || txt_pass.Text.Length == 0 || lst_gender.SelectedItem == null)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else if (sqlfns.RegistrationData(txt_ID.Text, txt_pass.Text, txt_Name.Text, txt_Surname.Text, lst_gender.SelectedItem.ToString()))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}