using System.Text.RegularExpressions;
using System.Drawing;
using System.Diagnostics;
namespace Student_Housing
{
    public partial class EntryPage : Form
    {
        List<Property>? properties;
        List<User>? students;
        ValidateCA validateNow=new ValidateCA();
        

        public EntryPage()
        {
            InitializeComponent();
            properties = TextFileUtilities.GetFromJson<Property>("Properties");
            students = TextFileUtilities.GetFromJson<User>("UsersData");
            propertiesComboBox.DataSource = properties;
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user;
            if ((user = LogIn(usernameTextbox.Text, passwordTextbox.Text)) != null && user.Account.Role == Enumeration.Role.STUDENT)
            {
                Form homePage = new HomePage(user);
                homePage.Show();
                Hide();
            }
            else if ((user = LogIn(usernameTextbox.Text, passwordTextbox.Text)) != null && user.Account.Role == Enumeration.Role.LANDLORD)
            {
                Form adminPage = new AdminPage();
                adminPage.Show();
                Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect username or password");
            }
        }

        private List<User> GetStudentsFromProperty(Property property)
        {
            List<User> housemates = new List<User>();

            foreach (User student in students)
            {
                if (student.Property.Name == property.Name)
                {
                    housemates.Add(student);
                }
                Debug.WriteLine(student.Property.Name + ' ' + property.Name);
            }
            return housemates;
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
                lblEmail.ForeColor=Color.LightCoral;
                MessageBox.Show("Please Enter your Email Address Correctly");
                emailInputTextbox.Focus();
                return;
            }

            else if(createPasswordTextBox.Text=="")
            {
                lblSetPassword.ForeColor = Color.LightCoral;
                MessageBox.Show("Please choose a password ");
                createPasswordTextBox.Focus();
                return;
            }

            else if (confirmPasswordTextbox.Text =="")
            {
                lblConfirmPassword.ForeColor = Color.LightCoral;
                MessageBox.Show("Please confirm your password ");
                confirmPasswordTextbox.Focus();
                return;
            }

            else if (validateNow.checkPassword(createPasswordTextBox.Text) == true || confirmPasswordTextbox.Text != createPasswordTextBox.Text )
            {
                MessageBox.Show("Password did not match");
                confirmPasswordTextbox.Focus();
                return;
            }

            else
            {
                try
                {
                    CreateNewUser(emailInputTextbox.Text, createPasswordTextBox.Text, txtLastNameGB.Text, txtFirstNameGB.Text, (Property)propertiesComboBox.SelectedItem);
                    System.Windows.Forms.MessageBox.Show("Account successfully created!");
                    ResetForm();
                    BackToNormal();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter all the required information");
                }
            }


            //var result = String.Concat(studentsFromJson.Select(o => o.GetName()).ToArray());      
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
        


        private User? LogIn(string email, string password)
        {
            foreach (var student in students)
            {
                if (student.GetAccount().GetEmail() == email && student.GetAccount().GetPassword() == password)
                {
                    return student;
                }

            }
            return null;
        }

        private void CreateNewUser(string email, string password, string name, string lastName, Property property)
        {
            Account account = new Account(email, password, Enumeration.Role.STUDENT);
            students.Add(new User(name, lastName, property, account));
            TextFileUtilities.WriteToJson(students, "UsersData");
        }


        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void propertiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void email_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


        }

        private void gBCreateAcoount_Enter(object sender, EventArgs e)
        {

        }

        private void EntryPage_Load(object sender, EventArgs e)
        {
            createPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextbox.PasswordChar = '*';
            passwordTextbox.PasswordChar = '*';
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}