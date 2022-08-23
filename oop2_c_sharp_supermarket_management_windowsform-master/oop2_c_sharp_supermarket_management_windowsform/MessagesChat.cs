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
    public partial class MessagesChat : Form
    {
        int contact = 0;
        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";

        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;

        public MessagesChat()
        {
            InitializeComponent();
            panel1.Visible = false;
            messagesBox.Visible = false;

        }

        public MessagesChat(int id)
        {
            InitializeComponent();
            panel1.Visible = true;
            messagesBox.Visible = true;


            con = new SqlConnection(path);
            contact = id;
            loadUsers(id);
        }



        public void loadUsers(int id)
        {

            try
            {
                string query = $@"
IF OBJECT_ID('Messages', 'U') IS NOT NULL 
BEGIN 
select * from Messages Where (Sender = {UserProvider.id} and Reciever = {id}) or (Sender = {id} and Reciever = {UserProvider.id})
END";

                dt = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();
                messagesBox.Controls.Clear();


                if (dt.Rows.Count > 0)
                {
                    for (int index = 0; index < dt.Rows.Count; index++)
                    {
                        MessageCon(int.Parse(dt.Rows[index][1].ToString().Trim()), int.Parse(dt.Rows[index][2].ToString().Trim()), dt.Rows[index][3].ToString().Trim());
                    }


                }
                
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }
        }

        private Label Messages(int sender,int reciever,  string text)
        {
            Label txt = new Label();
            if(sender==UserProvider.id)
            {
                txt.Dock = System.Windows.Forms.DockStyle.Right;
                txt.BackColor = Color.Ivory;

            }
            else
            {
                txt.Dock = System.Windows.Forms.DockStyle.Left;
                txt.BackColor = Color.Beige;
            }

txt.Padding= new System.Windows.Forms.Padding(10);
            txt.Name = text ;
            txt.Text = text;

            // messagesBox.Controls.Add(txt);



            return txt;
        }

        private Panel MessageCon(int sender, int reciever, string text)
        {
            Panel Cont1 = new Panel();
            Cont1.Dock = System.Windows.Forms.DockStyle.Top;
            Panel Cont = new Panel();
            Cont.Dock = System.Windows.Forms.DockStyle.Top;
            Cont.Padding = new System.Windows.Forms.Padding(10);
            

            Cont.Controls.Add(Messages(sender, reciever, text));
            MessageChatBox.Controls.Add(Cont);


            return Cont;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            writeInDatabase();
        }

        private void writeInDatabase()
        {
            try
            {
                con.Open();

                string query = $@"
IF OBJECT_ID('Messages', 'U') IS NOT NULL 
BEGIN 
insert into Messages (Sender, Reciever, Text) 
values({UserProvider.id},{contact},'{textBox1.Text}')
END 
ELSE BEGIN 
create table Messages (Id INT NOT NULL PRIMARY KEY identity(1,1), Sender INT NOT NULL ,Reciever INT NOT NULL ,   Text NVARCHAR(100) NOT NULL )
insert into Messages (Sender, Reciever, Text) 
values({UserProvider.id},{contact},'{textBox1.Text}')
END";



                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                loadUsers(contact);



            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, ex.Message);
            }
        }

        private void MessagesChat_Load(object sender, EventArgs e)
        {

        }
    }
}





