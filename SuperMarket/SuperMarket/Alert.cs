using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        public enum Enum_Action
        {
            wait,
            start,
            close
        }

        public enum Enum_type
        {
            success,
            warning,
            error
        }
        private Alert.Enum_Action action;
        private int X, Y;

        

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = Enum_Action.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case Enum_Action.wait:
                    timer1.Interval = 5000;
                    action = Enum_Action.close;
                    break;

                case Enum_Action.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.X < this.Location.X)
                    {
                        this.Left--;

                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = Enum_Action.wait;
                        }
                    }
                    break;
                case Enum_Action.close:
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

        public void showAlert(String msg,Enum_type type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string FName;
            for(int i=0; i < 10; i++)
            {
                FName = "alert" + i.ToString();
                Alert alrt = (Alert)Application.OpenForms[FName];
                if(alrt == null)
                {
                    this.Name = FName;
                    this.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width -455;
                    
                    this.Y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height *8)-40;
                    this.Location = new Point(this.X, this.Y);
                    break;
                }

            }
            this.X = Screen.PrimaryScreen.WorkingArea.Width;
            //this.X = Screen.PrimaryScreen.WorkingArea.Width - base.Width  - 5;
            switch (type)
            {
                case Enum_type.success:
                    this.guna2PictureBox1.Image = Properties.Resources.check;
                    this.BackColor = Color.SeaGreen;
                    break;

                case Enum_type.warning:
                    this.guna2PictureBox1.Image = Properties.Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;

                case Enum_type.error:
                    this.guna2PictureBox1.Image = Properties.Resources.error;
                    this.BackColor = Color.FromArgb(176, 0, 32);
                    break;



            }
            this.lblMsg.Text = msg;
            this.Show();
            this.action = Enum_Action.start;
            this.timer1.Interval = 1;
            timer1.Start();

        }
    }
}
