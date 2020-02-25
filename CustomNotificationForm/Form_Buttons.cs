using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomNotificationForm
{
    public partial class Form_Buttons : Form
    {
        public Form_Buttons()
        {
            InitializeComponent();
        }
        public void Alert(string message, Form_Alert.enumType eType)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(message, eType);
        }
        private void btnSuccess_Click(object sender, EventArgs e)
        {
            this.Alert("Success Alert", Form_Alert.enumType.Success);
        }

        private void buttonWarning_Click(object sender, EventArgs e)
        {
            this.Alert("Warning Alert", Form_Alert.enumType.Warning);
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            this.Alert("Error Alert", Form_Alert.enumType.Error);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            this.Alert("Info Alert", Form_Alert.enumType.Info);
        }
    }
}
