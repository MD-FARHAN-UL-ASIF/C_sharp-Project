using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class AdminPage : Form
    {




       
        public AdminPage()
        {
            InitializeComponent();
            loadMainPanel("all");
        }



        public void loadMainPanel(string page)
        {
            switch (page)
            {
                case "all":
                   
                    loadMainForm(new AdminPageAllUserPanel(this, ""));
                    break;

                case "edit":

                    loadMainForm(new AdminPageEditUserPanel(this , ""));
                    break;
                case "add":

                    loadMainForm(new AdminPageAddUserPanel(this));
                    break;
                case "message":

                    loadMainForm(new MessagingPage());
                    break;

                default:
                    loadMainForm(new AdminPageAllUserPanel(this, ""));
                    break;



            }
        }

        public void loadMainForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            { this.mainPanel.Controls.RemoveAt(0); }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }





        public void loadEditPageWithData(string id)
        {
            loadMainForm(new AdminPageEditUserPanel(this, id));
        }

        public void loadAllPageWithData(string name)
        {
            loadMainForm(new AdminPageAllUserPanel(this, name));
        }






        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }




        

        private void allUserButton_Click_1(object sender, EventArgs e)
        {
            this.loadMainPanel("all");
        }

        private void editUserButton_Click_1(object sender, EventArgs e)
        {
            this.loadMainPanel("edit");
        }

        private void addUserButton_Click_1(object sender, EventArgs e)
        {
            this.loadMainPanel("add");
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {
            this.loadMainPanel("message");
        }
    }
}
