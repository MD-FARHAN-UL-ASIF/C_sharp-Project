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
    
    public partial class InventoryManagerAddProduct : Form
    {
        InventoryManager parent;
        private double price;

        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";
        SqlConnection con;
        SqlCommand cmd;




        public InventoryManagerAddProduct(InventoryManager parent)
        {
            InitializeComponent();
            con = new SqlConnection(path);
            this.parent = parent;
            categoryComboBox.Items.Add("meat");
            categoryComboBox.Items.Add("vegetables");
            categoryComboBox.Items.Add("bakery");
            categoryComboBox.Items.Add("dairy");
            categoryComboBox.Items.Add("accessories");
            categoryComboBox.Items.Add("equipment");
            categoryComboBox.Items.Add("tools");
            typeComboBox.Items.Add("disposabl");
            typeComboBox.Items.Add("nondisposable");
            
            dateTimePicker.MinDate = System.DateTime.Today.AddDays(1);
            dateTimePicker.Value = System.DateTime.Today.AddDays(1);
        }

  

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                writeInDatabase();

            }
            else
            {
                
            }
        }



        private void writeInDatabase()
        {
            try
            {
                

                con.Open();
                string query = $@"
IF OBJECT_ID('Products', 'U') IS NOT NULL 
BEGIN 
insert into Products(Name, Manufacturer, Category, Price, Type, Expr, Description) 
values('{nameTextBox.Text.Trim()}', '{manufacturerTextBox.Text.Trim()}', '{categoryComboBox.SelectedItem}', '{price}', '{typeComboBox.SelectedItem}', '{dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', '{descriptionTextBox.Text.Trim()}') 
END 
ELSE BEGIN 
create table Products (Id INT NOT NULL PRIMARY KEY identity(1,1), Name NCHAR(18) NOT NULL, Manufacturer NCHAR(18) NOT NULL, Category NCHAR(18) NOT NULL, Price NUMERIC(18) NOT NULL,  Type NCHAR(18) NOT NULL, Expr date NOT NULL , Description NVARCHAR(64) NOT NULL )
insert into Products(Name, Manufacturer, Category, Price, Type, Expr, Description) 
values('{nameTextBox.Text.Trim()}', '{manufacturerTextBox.Text.Trim()}', '{categoryComboBox.SelectedItem}', '{price}', '{typeComboBox.SelectedItem}', '{dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', '{descriptionTextBox.Text.Trim()}') 
END";

               
                
                
                
                cmd = new SqlCommand(query, con);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New product added", "Success");
                parent.loadAllPageWithData(nameTextBox.Text);


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Database Error");
            }
        }



        private bool validate()
        {
            string error = "";
            if(validateProductName() != "")
            {
                error += "\n"+validateProductName(); 
            }
            if(validateManufacturer() != "")
            {
                error += "\n" + validateManufacturer();
            }
            if (validateCategory() != "")
            {
                error += "\n" + validateCategory();
            }
            if (validatePrice() != "")
            {
                error += "\n" + validatePrice();
            }
            if (validateType() != "")
            {
                error += "\n" + validateType();
            }
            if (validateDate()!="")
            {
                error += "\n" + validateDate();
               
            }
            if (validateDescription() != "")
            {
                error += "\n" + validateDescription();
            }




            if(error!="")
            {
                MessageBox.Show(error,"Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        private string validateProductName()
        {
            string error="";

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {

                
               
                error = "Product name is required!";


            }

            else
            {
                if (nameTextBox.Text == "" || nameTextBox.Text == null || nameTextBox.Text.Length == 0)
                {

                    error = "Product name is required!";
                }
                else if (nameTextBox.Text.Length < 3)
                {

                    error = "Product name cannot be so short";
                }
                else if (nameTextBox.Text.Any(char.IsSymbol))
                {

                    error = "Product name cannot have a symbol in it";
                }
                else if (nameTextBox.Text.Any(char.IsDigit))
                {

                    error = "Product name cannot contain number";
                }
                else if (nameTextBox.Text.Any(char.IsPunctuation))
                {

                    error = "Product name cannot have a symbol in it";
                }

            }

            if(error!="")
            {
                nameTextBox.Focus();
                nameTextBoxError.Text = error;
                return error;
               
            }
            nameTextBoxError.Text = "";
            return "";

        }

        private string validateManufacturer()
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(manufacturerTextBox.Text))
            {



                error = "Product name is required!";


            }

            else
            {
                if (manufacturerTextBox.Text == "" || manufacturerTextBox.Text == null || manufacturerTextBox.Text.Length == 0)
                {

                    error = "Product name is required!";
                }
                else if (manufacturerTextBox.Text.Length < 3)
                {

                    error = "Product name cannot be so short";
                }
                else if (manufacturerTextBox.Text.Any(char.IsSymbol))
                {

                    error = "Product name cannot have a symbol in it";
                }
                else if (manufacturerTextBox.Text.Any(char.IsDigit))
                {

                    error = "Product name cannot contain number";
                }
                else if (manufacturerTextBox.Text.Any(char.IsPunctuation))
                {

                    error = "Product name cannot have a symbol in it";
                }

            }

            if (error != "")
            {
                manufacturerTextBox.Focus();
                manufactureTextBoxError.Text = error;
                return error;

            }
            manufactureTextBoxError.Text = "";
            return "";

        }



        private string validateDescription()
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {



                error = "Product Description is required!";


            }

            else
            {
                if (descriptionTextBox.Text == "" || descriptionTextBox.Text == null || descriptionTextBox.Text.Length == 0)
                {

                    error = "Product Description is required!";
                }
                else if (descriptionTextBox.Text.Length < 5)
                {

                    error = "Product Descriptio cannot be so short";
                }
               

            }

            if (error != "")
            {
                descriptionTextBox.Focus();
                descriptionTextBoxError.Text = error;
                return error;

            }
            descriptionTextBoxError.Text = "";
            return "";

        }


        private string validatePrice()
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(priceTextBox.Text))
            {



                error = "Price is required!";


            }

            else
            {
                if (priceTextBox.Text == "" || priceTextBox.Text == null || priceTextBox.Text.Length == 0)
                {

                    error = "Price is required!";
                }
                else if (!double.TryParse(priceTextBox.Text, out price))
                {

                    error = "Price is invalid";
                }
                
            }

            if (error != "")
            {
                priceTextBox.Focus();
                priceTextBoxError.Text = error;
                return error;

            }
            priceTextBoxError.Text = "";
            return "";

        }

        private string validateCategory()
        {
            string error = "";

            if (categoryComboBox.SelectedIndex==-1)
            {



                error = "Select a category!";


            }

            

            if (error != "")
            {
                categoryComboBox.Focus();
                categoryComboBoxError.Text = error;
                return error;

            }
            categoryComboBoxError.Text = "";
            return "";

        }

        private string validateType()
        {
            string error = "";

            if (typeComboBox.SelectedIndex == -1)
            {



                error = "Select a Type!";


            }



            if (error != "")
            {
                typeComboBox.Focus();
                typeComboBoxError.Text = error;
                return error;

            }
            typeComboBoxError.Text = "";
            return "";

        }



        private string validateDate()
        {
            string error = "";

            if (dateTimePicker.Value.ToString() == "")
            {



                error = "Select a Date!";


            }



            if (error != "")
            {
                typeComboBox.Focus();
                typeComboBoxError.Text = error;
                return error;

            }
            typeComboBoxError.Text = "";
            return "";

        }
    }
}


