using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Housing
{
    public partial class AdminPage : Form
    {
        List<User> users;
        List<Property> properties;
        ValidateCA validateNow = new ValidateCA();


        public AdminPage()
        {
            InitializeComponent();
            users = TextFileUtilities.GetFromJson<User>("UsersData");
            properties = TextFileUtilities.GetFromJson<Property>("Properties");
        }

        private void UpdateDataGridViewStudents(DataGridView dataGridView, object dataSource)
        {
            dataGridView.DataBindings.Clear();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataSource;
            dataGridView.Columns.Clear();

            string[] dataPropertyNames = { "Name", "LastName", "Id" };
            string[] headerText = { "Name", "LastName", "Id" };

            void AddColumns(int amountOfColumns, string[] dataPropertyNames, string[] headerText)
            {
                for (int i = 0; i < amountOfColumns; i++)
                {
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = dataPropertyNames[i], HeaderText = headerText[i] });
                }
            } 
            AddColumns(3, dataPropertyNames, headerText);
            dataGridView.Columns[0].Width = 300;
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[2].Width = 600;
        }
        private void UpdateDataGridViewProperty(DataGridView dataGridView, object dataSource)
        {
            dataGridView.DataBindings.Clear();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataSource;
            dataGridView.Columns.Clear();

            string[] dataPropertyNames = { "Name", "Location" };
            string[] headerText = { "Name", "Location" };

            void AddColumns(int amountOfColumns, string[] dataPropertyNames, string[] headerText)
            {
                for (int i = 0; i < amountOfColumns; i++)
                {
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = dataPropertyNames[i], HeaderText = headerText[i] });
                }
            }
            AddColumns(2, dataPropertyNames, headerText);
            dataGridView.Columns[0].Width = 300;
            dataGridView.Columns[1].Width = 300;

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            UpdateDataGridViewStudents(dgvStudents, users);
            UpdateDataGridViewProperty(dgvProperties, properties);

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (validateNow.Isvalid_FirstName(txtFirstNameGB.Text) == false || txtFirstNameGB.Text == null)
            {
                lblFirstName.ForeColor = Color.LightCoral;
                MessageBox.Show("Invalid First name or field is empty");
                txtFirstNameGB.Focus();
                return;

            }

            else if (validateNow.Isvalid_LastName(txtLastNameGB.Text) == false || txtLastNameGB.Text == null)
            {

                lblLastName.ForeColor = Color.LightCoral;
                MessageBox.Show("Invalid Last Name or field is empty");
                txtLastNameGB.Focus();
                return;

            }


            else if (validateNow.Validate(emailInputTextbox.Text) == false || emailInputTextbox.Text == null || emailInputTextbox.TextLength > 50)
            {
                lblEmail.ForeColor = Color.LightCoral;
                MessageBox.Show("Please Enter your Email Address Correctly");
                emailInputTextbox.Focus();
                return;
            }

            else if (createPasswordTextBox.Text == "")
            {
                lblSetPassword.ForeColor = Color.LightCoral;
                MessageBox.Show("Please choose a password ");
                createPasswordTextBox.Focus();
                return;
            }

            else if (confirmPasswordTextbox.Text == "")
            {
                lblConfirmPassword.ForeColor = Color.LightCoral;
                MessageBox.Show("Please confirm your password ");
                confirmPasswordTextbox.Focus();
                return;
            }

            else if (validateNow.checkPassword(createPasswordTextBox.Text) == true || confirmPasswordTextbox.Text != createPasswordTextBox.Text)
            {
                MessageBox.Show("Password did not match");
                confirmPasswordTextbox.Focus();
                return;
            }

            else
            {
                try
                {
                    CreateNewUser(emailInputTextbox.Text, createPasswordTextBox.Text, txtLastNameGB.Text, txtFirstNameGB.Text, null);
                    System.Windows.Forms.MessageBox.Show("Account successfully created!");
                    ResetForm();
                    BackToNormal();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter all the required information");
                }
            }
            UpdateDataGridViewStudents(dgvStudents, users);


        }
        public void ResetForm()
        {
            txtFirstNameGB.Text = "";
            txtLastNameGB.Text = "";
            emailInputTextbox.Text = "";
            createPasswordTextBox.Text = "";
            confirmPasswordTextbox.Text = "";
        }

        public void BackToNormal()
        {
            lblFirstName.ForeColor = Color.FromArgb(149, 165, 166);
            lblLastName.ForeColor = Color.FromArgb(149, 165, 166);
            lblEmail.ForeColor = Color.FromArgb(149, 165, 166);
            lblConfirmPassword.ForeColor = Color.FromArgb(149, 165, 166);
            lblSetPassword.ForeColor = Color.FromArgb(149, 165, 166);

        }
        private void CreateNewUser(string email, string password, string name, string lastName, Property property)
        {
            Account account = new Account(email, password, Enumeration.Role.LANDLORD);
            users.Add(new User(name, lastName, property, account));
            TextFileUtilities.WriteToJson(users, "UsersData");
        }

        private void CreateNewProperty(string Name, string Location)
        {
            Property property = new Property(Name, Location);
            properties.Add(property);
            TextFileUtilities.WriteToJson(properties, "UsersData");
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            CreateNewProperty(tbNameProperty.Text,tbLocationProperty.Text);
            tbNameProperty.Text = string.Empty;
            tbLocationProperty.Text = string.Empty;
            UpdateDataGridViewProperty(dgvProperties, properties);

        }
    }
}
