using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class CheckoutPage : Form
    {





        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";



        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;








        public CheckoutPage()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            loadUsers();
      

        }










      



        public void loadUsers()
        {

            try
            {
                string query = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
select * from Employees  where Id = {UserProvider.id} 
END";

                dt = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;




            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }
        }





    


        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();

        }
    }
}







