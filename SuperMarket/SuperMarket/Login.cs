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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

 
       private void Login_Load(object sender, EventArgs e)
        {

        }


        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Exit E = new Exit();
            E.Show();
        }

        

        private void Admin_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            Emp.Show();
            this.Hide();
        }





        
    }
}
