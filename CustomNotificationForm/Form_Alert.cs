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
    public partial class Form_Alert : Form
    {
        private Form_Alert.enumAction action;
        private int posX, posY;
        public Form_Alert()
        {
            InitializeComponent();
        }
        public enum enumAction
        {
            wait,
            start,
            close
        }
        public enum enumType
        {
            Success,
            Warning,
            Error,
            Info
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enumAction.wait:
                    timer1.Interval = 5000;
                    action = enumAction.close;
                    break;
                case enumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.posX < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }

        public void showAlert(string message, enumType eType)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string formName;

            for(int i = 1; i < 10; i++)
            {
                formName = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[formName];

                if(frm == null)
                {
                    this.Name = formName;
                    this.posX = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.posY = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.posX, this.posY);
                    break;
                }
            }

            this.posX = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch(eType)
            {
                case enumType.Success:                    
                    this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
                    this.iconPictureBox1.IconColor = System.Drawing.Color.White;
                    this.iconPictureBox1.BackColor = System.Drawing.Color.SeaGreen;
                    this.BackColor = System.Drawing.Color.SeaGreen;
                    break;
                case enumType.Error:
                    this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bug;
                    this.iconPictureBox1.IconColor = System.Drawing.Color.White;
                    this.iconPictureBox1.BackColor = Color.DarkRed;
                    this.BackColor = System.Drawing.Color.DarkRed;
                    break;
                case enumType.Info:
                    this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Info;
                    this.iconPictureBox1.IconColor = System.Drawing.Color.White;
                    this.iconPictureBox1.BackColor = Color.RoyalBlue;
                    this.BackColor = System.Drawing.Color.RoyalBlue;
                    break;
                case enumType.Warning:
                    this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SkullCrossbones;
                    this.iconPictureBox1.IconColor = System.Drawing.Color.White;
                    this.iconPictureBox1.BackColor = Color.DarkOrange;
                    this.BackColor = System.Drawing.Color.DarkOrange;
                    break;
            }

            this.labelMessage.Text = message;
            this.Show();
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
