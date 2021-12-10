using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SuperMarket
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            ShowProduct();
        }
        public void Pop_Alert(String msg, Alert.Enum_type type)
        {
            Alert frm = new Alert();
            frm.showAlert(msg, type);

        }
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Exit E = new Exit();
            E.Show();
        }
        SqlConnection Connexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fardo\Documents\SuperMarket.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowProduct()
        {
            Connexion.Open();
            string query = "select * from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connexion);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var DS = new DataSet();
            sda.Fill(DS);
            ProductsDGV.DataSource = DS.Tables[0];
            Connexion.Close();

        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            P_Name.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            P_Price.Text = ProductsDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        /*private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
           
        }*/
    }
}
