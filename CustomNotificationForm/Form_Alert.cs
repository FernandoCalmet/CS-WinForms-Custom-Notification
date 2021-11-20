using System;
using System.Drawing;
using System.Windows.Forms;
using CustomNotificationForm.Common;

namespace CustomNotificationForm
{
    public partial class Form_Alert : Form
    {
        #region "Definición de Campos"
        private NotificationAction notificationAction;
        private int posX, posY;
        #endregion

        #region "Constructores"
        public Form_Alert()
        {
            InitializeComponent();
        }
        #endregion

        #region "Definición de Métodos"
        public void ShowAlert(string message, NotificationType eType)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string formName;

            for (int i = 1; i < 10; i++)
            {
                formName = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[formName];

                if (frm == null)
                {
                    Name = formName;
                    posX = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    posY = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(posX, posY);
                    break;
                }
            }

            posX = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch (eType)
            {
                case NotificationType.Success:
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
                    iconPictureBox1.IconColor = Color.White;
                    iconPictureBox1.BackColor = Color.SeaGreen;
                    BackColor = Color.SeaGreen;
                    break;
                case NotificationType.Error:
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bug;
                    iconPictureBox1.IconColor = Color.White;
                    iconPictureBox1.BackColor = Color.DarkRed;
                    BackColor = Color.DarkRed;
                    break;
                case NotificationType.Info:
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Info;
                    iconPictureBox1.IconColor = Color.White;
                    iconPictureBox1.BackColor = Color.RoyalBlue;
                    BackColor = Color.RoyalBlue;
                    break;
                case NotificationType.Warning:
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SkullCrossbones;
                    iconPictureBox1.IconColor = Color.White;
                    iconPictureBox1.BackColor = Color.DarkOrange;
                    BackColor = Color.DarkOrange;
                    break;
            }

            labelMessage.Text = message;
            Show();
            notificationAction = NotificationAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }
        #endregion

        #region "Métodos de Eventos"
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (notificationAction)
            {
                case NotificationAction.wait:
                    timer1.Interval = 5000;
                    notificationAction = NotificationAction.close;
                    break;
                case NotificationAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (posX < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            notificationAction = NotificationAction.wait;
                        }
                    }
                    break;
                case NotificationAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            notificationAction = NotificationAction.close;
        }
        #endregion                
    }
}
