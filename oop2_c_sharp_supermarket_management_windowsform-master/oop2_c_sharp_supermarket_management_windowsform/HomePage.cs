using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class HomePage : Form
    {

        
        


        public Form mainpage;

        public HomePage(string mode)
        {
            InitializeComponent();

          
            loadMainPanel(mode);
           
           


        }




        private void label1_Click(object sender, EventArgs e)
        {


        }
        public void loadMainPanel(string mode)
        {
            switch (mode)
            {
                case "Admin":
                   
                    loadMainForm(new AdminPage());
                    break;

                case "Supervisor":
                 
                    loadMainForm(new SupervisorPage());
                    break;
                case "ProductMng":
                 
                    loadMainForm(new InventoryManager());
                    break;
                case "Checkout":
                   
                    loadMainForm(new CheckoutPage());
                    break;
                default:
                    MessageBox.Show("Invalid User Role", "Error");
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide();
                    break;



            }
        }



        public void loadMainForm(object Form)
        {
            if (this.mainPanel.Controls.Count>0)
            { this.mainPanel.Controls.RemoveAt(0); }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;

            f.Show();

        }



      
        







      
    }
}
