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
    public partial class AdminPageAllUserPanel : Form
    {

        AdminPage parent;

        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;



        string queryString = "";
        int operationEmployeeId;



        public AdminPageAllUserPanel(AdminPage parent, string name)
        {
            InitializeComponent();
            this.parent = parent;
            con = new SqlConnection(path);

            if(name=="")
            {
                loadAll();
            }
            else
            {
                loadQuery(name, "Username");
            }

            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(queryTextBox.Text=="")
            {
                loadAll();
            }
            else
            {
                loadQuery(queryTextBox.Text, "");
            }
        }



        private void showAllButton_Click(object sender, EventArgs e)
        {
            loadAll();

        }


        private void loadAll()
        {
            clearQueries();
            try
            {

                string sqlQUery = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
select * from Employees
END ";

                dt = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter(sqlQUery, con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                con.Close();

                

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }

        }

        private void clearQueries()
        {
            queryTextBox.Text = "";
            queryString = "";
        }

        private void loadQuery(string queryString, string queryfield)
        {
            try
            {
      
                int id = 0;

                if(queryString.All(c=>char.IsDigit(c)))
                {
                    id = Convert.ToInt32(queryString);
                }


        





                string sqlQuery = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
select * from Employees where Id = {id} OR CONVERT(varchar(20),Salary) LIKE '%{queryString}%' OR  Salary = {id} OR Username LIKE '%{queryString}%' OR Lastname LIKE '%{queryString}%' OR Firstname LIKE '%{queryString}%' OR Role = '{queryString}' OR Gender = '{queryString}' OR Phone LIKE '{queryString}%' OR Address LIKE '%{queryString}%'
END "; 
                if(queryfield != "")
                {
                    sqlQuery = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
select * from Employees where {queryfield} LIKE '%{queryString}%'
END ";
                }


                dt = new DataTable();
                con.Open();


                adapter = new SqlDataAdapter(sqlQuery, con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
               
                string EmployeeId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString().Trim();

                parent.loadEditPageWithData(EmployeeId);

                


            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;



            if (dataGridView1.SelectedRows.Count == 1)
            {
                

                string EmployeeId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();

                parent.loadEditPageWithData(EmployeeId);




            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {


                string EmployeeId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                deleteFromDatabase(EmployeeId);




            }
        }
        private void deleteFromDatabase(string idd)
        {

            try
            {
                int id = Convert.ToInt32(idd);
                con.Open();

                string sqlcommand = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
delete from Employees where  Id = {id}
END ";



                  

                cmd = new SqlCommand(sqlcommand, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("employee Deleted", "Success");

                loadAll();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Write In Database Error");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
