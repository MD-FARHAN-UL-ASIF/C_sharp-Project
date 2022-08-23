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
    public partial class AdminPageAddUserPanel : Form
    {
        string role;
        string gender;
        string username;
        string firstname;
        string lastname;
        string password;
        string address;
        double salary;
        string phone;

        bool valueAssigned = false;



        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";
        SqlConnection con;
        SqlCommand cmd;

        AdminPage parent;



        public AdminPageAddUserPanel(AdminPage parent)
        {
            InitializeComponent();
            roleComboBox.Items.Add("Admin");
            roleComboBox.Items.Add("Supervisor");
            roleComboBox.Items.Add("Checkout");
            roleComboBox.Items.Add("ProductMng");
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            con = new SqlConnection(path);
            this.parent = parent;
        }





        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                assignVariables();

                writeInDatabase();

            }





            
            


            




        }



        // Assign All values to variables
        private void assignVariables()
        {
            


                username = usernameTextBox.Text.Trim();
                firstname = firstnameTextBox.Text.Trim();
                lastname = lastnameTextBox.Text.Trim();
                password = passwordTextBox.Text.Trim();
                address = addressTextBox.Text.Trim();
                role = roleComboBox.SelectedItem.ToString().Trim();
                gender = genderComboBox.SelectedItem.ToString().Trim();
                phone = phoneTextBox.Text.Trim();

                try
                {

                    salary = Convert.ToDouble(salaryTextBox.Text.Trim());
                }
                catch (FormatException)
                {
                    salaryTextBox.Focus();
                    errorProvider1.SetError(salaryTextBox, "Invalid salary!");
                    salaryTextBoxError.Text = "Invalid salary!";
                }
                



            
        }



        private void clearVariables()
        {
            usernameTextBox.Text="";
            firstnameTextBox.Text = "";
            lastnameTextBox.Text = "";
            passwordTextBox.Text = "";
            addressTextBox.Text = "";
            roleComboBox.Text = "";
            genderComboBox.Text = "";
            phoneTextBox.Text = "";

            salaryTextBox.Text = "";

        }

        private void writeInDatabase()
        {
            try
            {
                con.Open();

                string query = $@"
IF OBJECT_ID('Employees', 'U') IS NOT NULL 
BEGIN 
insert into Employees (Username, Firstname, Lastname, Password, Role, Gender, Salary, Phone, Address) 
values('{username}','{firstname}','{lastname}','{password}','{role}','{gender}','{salary}','{phone}','{address}')
END 
ELSE BEGIN 
create table Employees (Id INT NOT NULL PRIMARY KEY identity(1,1), Username NCHAR(18) NOT NULL,Firstname NCHAR(18) NOT NULL,Lastname NCHAR(18) NOT NULL, Password NVARCHAR(64) NOT NULL,Role NCHAR(18) NOT NULL, Gender NCHAR(18) NOT NULL,  Salary NUMERIC(18) NOT NULL , Phone NVARCHAR(18) NOT NULL,   Address NVARCHAR(64) NOT NULL )
insert into Employees (Username, Firstname, Lastname, Password, Role, Gender, Salary, Phone, Address) 
values('{username}','{firstname}','{lastname}','{password}','{role}','{gender}','{salary}','{phone}','{address}')
END";

                

                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New employee added", "Success");
                parent.loadAllPageWithData(username);
                clearVariables();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, ex.Message);
            }
        }


        // Validations
        private void usernameTextBox_Validating(object sender, CancelEventArgs e)

        {
            string usernameInValid = IsValidUsername(usernameTextBox.Text, "Username");

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || usernameInValid != "")
            {

                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "username is required!");
                if (usernameInValid != "")
                {
                    usernameTextBoxError.Text = usernameInValid;
                }
                else usernameTextBoxError.Text = "username is required!";

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(usernameTextBox, "");
                usernameTextBoxError.Text = "";
            }
        }

        private void firstnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string usernameInValid = IsValidUsername(firstnameTextBox.Text, "First name");

            if (string.IsNullOrWhiteSpace(firstnameTextBox.Text) || usernameInValid != "")
            {

                e.Cancel = true;
                firstnameTextBox.Focus();
                errorProvider1.SetError(firstnameTextBox, "First name is required!");

                if (usernameInValid != "")
                {
                    firstnameTextBoxError.Text = usernameInValid;
                }
                else firstnameTextBoxError.Text = "First name is required!";

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(firstnameTextBox, "");
                firstnameTextBoxError.Text = "";

            }
        }

        private void lastnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string usernameInValid = IsValidUsername(lastnameTextBox.Text, "First name");

            if (string.IsNullOrWhiteSpace(lastnameTextBox.Text) || usernameInValid != "")
            {

                e.Cancel = true;
                lastnameTextBox.Focus();
                errorProvider1.SetError(lastnameTextBox, "First name is required!");

                if (usernameInValid != "")
                {
                    lastnameTextBoxError.Text = usernameInValid;
                }
                else lastnameTextBoxError.Text = "First name is required!";

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lastnameTextBox, "");
                lastnameTextBoxError.Text = "";

            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)

        {
            string passwordInValid =IsValidPassword(passwordTextBox.Text);

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordInValid != "")
            {

                e.Cancel = true;
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Password is required!");
                if(passwordInValid != "")
                {
                    passwordTextBoxError.Text = passwordInValid;
                }
                else passwordTextBoxError.Text = "Password is required!";

            }
           
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, "");
                passwordTextBoxError.Text = "";
            }
        }

        private void confirmPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {

                e.Cancel = true;
                confirmPasswordTextBox.Focus();
                errorProvider1.SetError(confirmPasswordTextBox, "Confirm the password");
                confirmPasswordTextBoxError.Text = "Confirm the password!";


            }
            else if (passwordTextBox.Text !=confirmPasswordTextBox.Text)
            {
                e.Cancel = true;
                confirmPasswordTextBox.Focus();
                errorProvider1.SetError(confirmPasswordTextBox, "Password did not match");
                confirmPasswordTextBoxError.Text = "Password did not match";
            }

            else
            {


                e.Cancel = false;
                errorProvider1.SetError(confirmPasswordTextBox, "");
                confirmPasswordTextBoxError.Text = "";
            }

        }

        private void roleComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roleComboBox.Text))
            {
                e.Cancel = true;
                roleComboBox.Focus();
                errorProvider1.SetError(roleComboBox, "Select a role");
                roleComboBoxError.Text = "Select a role";
            }

            else
            {


                e.Cancel = false;
                errorProvider1.SetError(roleComboBox, "");
                roleComboBoxError.Text = "";
            }

        }

        private void genderComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(genderComboBox.Text))
            {
                e.Cancel = true;
                genderComboBox.Focus();
                errorProvider1.SetError(genderComboBox, "Select a gender");
                genderComboBoxError.Text = "Select a gender";
            }

            else
            {


                e.Cancel = false;
                errorProvider1.SetError(genderComboBox, "");
                genderComboBoxError.Text = "";
            }

        }

        private void salaryTextBox_Validating(object sender, CancelEventArgs e)
        {
            string salaryInvalid = IsValidSalary(salaryTextBox.Text);

            if (string.IsNullOrWhiteSpace(salaryTextBox.Text) || salaryInvalid != "")
            {

                e.Cancel = true;
                salaryTextBox.Focus();
                errorProvider1.SetError(salaryTextBox, "Salary is required!");

                if (salaryInvalid != "")
                {
                    salaryTextBoxError.Text = salaryInvalid;
                }
                else salaryTextBoxError.Text = "Salary is required!";

            }

            else
            {
                try
                {

                    double sal = Convert.ToDouble(salaryTextBox.Text);
                    e.Cancel = false;
                    errorProvider1.SetError(salaryTextBox, "");
                    salaryTextBoxError.Text = "";


                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    salaryTextBox.Focus();
                    errorProvider1.SetError(salaryTextBox, "Invalid salary!");
                    salaryTextBoxError.Text = "Invalid salary!";

                }


            }
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            string phoneInvalid = IsValidPhone(phoneTextBox.Text);

            if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || phoneInvalid != "")
            {

                e.Cancel = true;
                phoneTextBox.Focus();
                errorProvider1.SetError(phoneTextBox, "Salary is required!");

                if (phoneInvalid != "")
                {
                    phoneTextBoxError.Text = phoneInvalid;
                }
                else phoneTextBoxError.Text = "Salary is required!";

            }

            else
            {
                
                    e.Cancel = false;
                    errorProvider1.SetError(phoneTextBox, "");
                    phoneTextBoxError.Text = "";


               


            }

        }

        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                e.Cancel = true;
                addressTextBox.Focus();
                errorProvider1.SetError(addressTextBox, "Address is required");
                addressTextBoxError.Text = "Address is required";
            }

            else
            {


                e.Cancel = false;
                errorProvider1.SetError(addressTextBox, "");
                addressTextBoxError.Text = "";
            }
        }



        //helper functions for validation
        private string IsValidPassword(string password)
        {

            if (password == "" || password == null || password.Length == 0)
            {
                return "Password is required";
            }
            if (password.Length < 8)
            {
                return "Password should be at least 8 characters";
            }
            if (!password.Any(char.IsUpper))
            {
                return "Password should have at least 1 upper case character";
            }
            if (!password.Any(char.IsDigit))
            {
                return "Password should have at least 1 number";
            }


            return "";

        }

        private string IsValidUsername(string name, string nameType)
        {

            if (name == "" || name == null || name.Length == 0)
            {
                return nameType + " is required";
            }
            if (name.Length < 3)
            {
                return nameType + " cannot be so short";
            }
            if (name.Any(char.IsSymbol))
            {
                return nameType + " cannot have a symbol in it";
            }
            if (name.Any(char.IsDigit))
            {
                return nameType + " cannot contain number";
            }
            if (name.Any(char.IsPunctuation))
            {
                return nameType + " cannot have a symbol in it";
            }

            return "";

        }

        private string IsValidSalary(string salary)
        {

            if (salary == "" || salary == null || salary.Length == 0)
            {
                return "Salary is required";
            }


            if (!salary.Any(char.IsDigit))
            {
                return "Invalid Salary. Salary must be a number";
            }

            try
            {

                double sal = Convert.ToDouble(salary);
                return "";

            }
            catch (FormatException)
            {
                return "Invalid Salary. Salary must be a number";
            }




        }

        private string IsValidPhone(string phone)
        {

            if (phone == "" || phone == null || phone.Length == 0)
            {
                return "Phone number is required";
            }


            if (phone.Any(c => (!char.IsDigit(c) && c != '+' && c != '-')))
            {

                return "Invalid phone number.";
            }


            return "";






        }


    }
}
