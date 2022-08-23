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
    public partial class MessagingPage : Form
    {


        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";



        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;








        public MessagingPage()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            loadUsers();
            loadMainForm(new MessagesChat());
        }


        public void loadUsers()
        {

            try
            {
                string query = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
select * from Employees Where Id <> {UserProvider.id}
END";

                dt = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    for(int index=0;index< dt.Rows.Count;index++)
                    {
                        Contacts(int.Parse(dt.Rows[index].Field<int>("Id").ToString().Trim()), dt.Rows[index].Field<string>("Username").Trim());
                    }

                    
                }
                
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }
        }

        private Button Contacts(int id, string name)
        {
            Button con = new Button();

            con.Dock = System.Windows.Forms.DockStyle.Top;
            con.Size = new Size(200, 50);
            con.Name = name+"_button";
            con.Text = name;
            con.Click += (sender, EventArgs) => { openUser(sender, EventArgs, id); };
                

           
            ContactPanel.Controls.Add(con);



            return con;
        }


        private void openUser(object sender, EventArgs e, int id)
        {

            loadMainForm(new MessagesChat(id));

        }



        public void loadMainForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            { this.MainPanel.Controls.RemoveAt(0); }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }
    }
}







