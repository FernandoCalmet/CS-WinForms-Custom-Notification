using System;
using System.Windows.Forms;
using CustomNotificationForm.Common;

namespace CustomNotificationForm
{
    public partial class FormButtons : Form
    {
        #region "Constructores"
        public FormButtons()
        {
            InitializeComponent();
        }
        #endregion

        #region "Métodos de Eventos"
        public void Alert(string message, NotificationType eType)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(message, eType);
        }
        private void btnSuccess_Click(object sender, EventArgs e)
        {
            Alert("Success Alert", NotificationType.Success);
        }

        private void buttonWarning_Click(object sender, EventArgs e)
        {
            Alert("Warning Alert", NotificationType.Warning);
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            Alert("Error Alert", NotificationType.Error);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Alert("Info Alert", NotificationType.Info);
        }
        #endregion
    }
}
