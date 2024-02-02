

namespace OnlineMakeUpStore
{
    public partial class UserLogIn : Form
    {

        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "root", "Mems91939501!");
        public Dictionary<int, User> Customers { get; set; }
        public HomePage HomePage { get; set; }
        public Manager Manager { get; set; }
        public UserLogIn()
        {
            InitializeComponent();
        }
        public void SetManager(Manager manager)
        {
            Manager = manager;
        }
        private void logInUserButton_Click(object sender, EventArgs e)
        {
            string userName = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            
            var userInDataBase = Connection.GetUser(userName);

            var allCustomers = userInDataBase.Values.ToList();
            bool userFound = false;

           foreach (var user in allCustomers)
           {
                if (userName == user.UserName && password == user.Password)
                {
                    // Anropa LogInUser för att hantera inloggningen och kundvagnen
                    //Manager.LogInUser(user.Id);
                    
                    Manager.CurrentUser = user;
                    Manager.CurrentUser.MyCart = Connection.GetCart(Manager.CurrentUser.Id);
                    Manager.CurrentUser.MyCart.productsInCart = Connection.GetProductsInCart(Manager.CurrentUser.MyCart.Id);
                    if (Manager.GuestCart.productsInCart.Count() != 0)
                    {
                        foreach (var product in Manager.GuestCart.productsInCart.Values)
                        {
                            if (!Manager.CurrentUser.MyCart.productsInCart.ContainsKey(product.Id))
                            {
                                Manager.CurrentUser.MyCart.productsInCart.Add(product.Id, product);
                            }
                            Connection.EmptyCartData(Manager.GuestCart.Id);
                        }
                    }
                    Manager.GuestCart.productsInCart = new Dictionary<int, Product>();
                    MessageBox.Show("Log in successful " + user.Name);
                    VisibilityLogInButton();

                    userFound = true;
                    break;
                }
           }

            if (!userFound)
            {
                MessageBox.Show("Invalid username or password");
                VisibilityRegisterButton();
            }

            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            string name = addNameTextBox.Text;
            string userName = addUserNameTextBox.Text;
            string password = addPasswordTextBox.Text;
            string email = addEmailTextBox.Text;

            bool isAlreadyRegistered = false;

            foreach (var user in Manager.customers.Values)
            {
                if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
                {
                    if (userName == user.UserName || password == user.Password)
                    {
                        isAlreadyRegistered = true;
                        break;
                    }
                }
            }

            if (!isAlreadyRegistered)
            {
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(userName) 
                    && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(email))
                {
                    Manager.RegisterNewCustomer(name, userName, password, email);
                    MessageBox.Show("Welcome " + name + "!");
                    addNameTextBox.Clear();
                    addUserNameTextBox.Clear();
                    addPasswordTextBox.Clear();
                    addEmailTextBox.Clear();

                    VisibilityRegisterButton();
                }
                else
                {
                    MessageBox.Show("You have to fill out all the boxes");
                }
            }
            else
            {
                MessageBox.Show("Username or password is already taken. Please try again");
                addUserNameTextBox.Clear();
                addPasswordTextBox.Clear();
            }
        }

        private void toRegisterMemberButton_Click(object sender, EventArgs e)
        {
            VisibilityToRegisterButton();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (Manager.CurrentUser == null)
            {
                logOutButton.Visible = false;
                VisibilityRegisterButton();
            }

            HomePage.Show();
            Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Manager.CurrentUser = null;
            VisibilityLogOutButton();
        }

        private void VisibilityRegisterButton()
        {
            userNameLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordLabel.Visible = true;
            passwordTextBox.Visible = true;
            logInUserButton.Visible = true;
            newCostumerMessageLabel.Visible = true;
            toRegisterMemberButton.Visible = true;
            userNameLabel2.Visible = false;
            passwordLabel2.Visible = false;
            nameLabel.Visible = false;
            emailLabel.Visible = false;
            addNameTextBox.Visible = false;
            addPasswordTextBox.Visible = false;
            addUserNameTextBox.Visible = false;
            addEmailTextBox.Visible = false;
            registerButton.Visible = false;
        }

        private void VisibilityToRegisterButton()
        {
            userNameLabel.Visible = false;
            usernameTextBox.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            logInUserButton.Visible = false;
            toRegisterMemberButton.Visible = false;
            newCostumerMessageLabel.Visible = false;
            userNameLabel2.Visible = true;
            passwordLabel2.Visible = true;
            nameLabel.Visible = true;
            emailLabel.Visible = true;
            addNameTextBox.Visible = true;
            addPasswordTextBox.Visible = true;
            addUserNameTextBox.Visible = true;
            addEmailTextBox.Visible = true;
            registerButton.Visible = true;
        }

        private void VisibilityLogOutButton()
        {
            userNameLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordLabel.Visible = true;
            passwordTextBox.Visible = true;
            logInUserButton.Visible = true;
            newCostumerMessageLabel.Visible = true;
            toRegisterMemberButton.Visible = true;
            logOutButton.Visible = false;
        }

        private void VisibilityLogInButton()
        {
            userNameLabel.Visible = false;
            usernameTextBox.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            logInUserButton.Visible = false;
            newCostumerMessageLabel.Visible = false;
            toRegisterMemberButton.Visible = false;
            userNameLabel2.Visible = false;
            passwordLabel2.Visible = false;
            nameLabel.Visible = false;
            emailLabel.Visible = false;
            addNameTextBox.Visible = false;
            addPasswordTextBox.Visible = false;
            addUserNameTextBox.Visible = false;
            addEmailTextBox.Visible = false;
            registerButton.Visible = false;
            logOutButton.Visible = true;
        }
    }
}
