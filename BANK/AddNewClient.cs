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
    public partial class AddNewClient : Form
    {
        SQLFunctions sqlfns = new SQLFunctions();
        public AddNewClient()
        {
            InitializeComponent();

            txt_ID.Text = Guid.NewGuid().ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (sqlfns.AddNewClients(txt_ID.Text, txt_NSM.Text, txt_count.Text, txt_phone.Text))
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
