namespace OnlineMakeUpStore
{
    public partial class HomePage : Form
    {
        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "root", "Mems91939501!");
        public Dictionary<int, Product> products { get; set; }
        public Manager Manager = new();
        public CheckOut CheckOut = new();
        public Skincare Skincare;
        public MakeUp MakeUp;
        public Haircare Haircare;
        public AdminLogIn AdminLogIn;
        public UserLogIn UserLogIn;
        private AutoCompleteStringCollection allowedTypes;

        public HomePage()
        {
            InitializeComponent();
            cartToolTip.SetToolTip(cartButton, "Cart");
            userLogInToolTip.SetToolTip(logInUserButton, "User Log In");
            logInAdminToolTip.SetToolTip(logInAdminButton, "Admin Log In");

            skincarePage.SetHomePage(this);
            skincarePage.SetAdminManager(Manager);
            makeUpPage.SetHomePage(this);
            makeUpPage.SetAdminManager(Manager);
            haircarePage.SetHomePage(this);
            haircarePage.SetAdminManager(Manager);
            skincarePage.SetCheckOutInstance(CheckOut);
            haircarePage.SetCheckOutInstance(CheckOut);
            makeUpPage.SetCheckOutInstance(CheckOut);
            DetermineCart();
            CheckOut.Manager = Manager;
        }
        public void DetermineCart()
        {
            if (Manager.GuestCart == null)
            {
                Manager.GuestCart = Connection.GetGuestCart();
                if (Manager.GuestCart == null)
                {
                    Manager.GuestCart = Connection.AddGuestCart();;
                }
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Hide();
            CheckOut.homePage = this;
            CheckOut.FillListBox();
            CheckOut.UpdateTotalPriceLabel();
            CheckOut.SetSkincareInstance(Skincare);
            CheckOut.SetMakeUpInstance(MakeUp);
            CheckOut.SetHaircareInstance(Haircare);
            CheckOut.Show();
        }
        private void logInUserButton_Click(object sender, EventArgs e)
        {
            if (UserLogIn == null)
            {
                UserLogIn = new UserLogIn();
                UserLogIn.HomePage = this;
                UserLogIn.SetManager(Manager);
            }
            UserLogIn.Show();
            Hide();
        }

        private void logInAdminButton_Click(object sender, EventArgs e)
        {
            if (AdminLogIn == null)
            {
                AdminLogIn = new AdminLogIn();
                AdminLogIn.HomePage = this;
                AdminLogIn.SetManager(Manager);
                AdminLogIn.SetSkincareInstance(Skincare);
                AdminLogIn.SetHaircareInstance(Haircare);
                AdminLogIn.SetMakeUpInstance(MakeUp);
            }
            AdminLogIn.Show();
            Hide();
        }

        private void haircareButton_Click(object sender, EventArgs e)
        {
            haircarePage.Visible = true;
            Haircare.FillListBox();
        }

        private void makeUpButton_Click(object sender, EventArgs e)
        {
            makeUpPage.Visible = true;
            MakeUp.FillListBox();
        }

        private void skincareButton_Click(object sender, EventArgs e)
        {
            skincarePage.Visible = true;
            Skincare.FillListBox();
        }

        private void searchCatagorysTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string searchText = searchCatagorysTextBox.Text;

            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(searchText))
            {
                products = Connection.GetProductsTo(searchText);
                if (products.Count > 0)
                {
                    var firstProduct = products.Values.First();
                    ShowPanelBasedOnCategoryAndProduct(firstProduct.Id.ToString());
                }
            }
        }

        private void ShowPanelBasedOnCategoryAndProduct(string itemId)
        {
            makeUpPage.Visible = false;
            skincarePage.Visible = false;
            haircarePage.Visible = false;

            if (products.TryGetValue(Convert.ToInt32(itemId), out var product))
            {
                if (StringComparer.OrdinalIgnoreCase.Equals(product.Category, "MakeUp") ||
                    product.Name.IndexOf("MakeUp", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    makeUpPage.Visible = true;
                    MakeUp.FillListBox();
                }
                else if (StringComparer.OrdinalIgnoreCase.Equals(product.Category, "Skincare") ||
                         product.Name.IndexOf("Skincare", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    skincarePage.Visible = true;
                    Skincare.FillListBox();
                }
                else if (StringComparer.OrdinalIgnoreCase.Equals(product.Category, "Haircare") ||
                         product.Name.IndexOf("Haircare", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    haircarePage.Visible = true;
                    Haircare.FillListBox();
                }
            }
            searchCatagorysTextBox.Clear();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Manager.CurrentUser == null)
            {
               Connection.EmptyCartData(Manager.GuestCart.Id);
               MessageBox.Show("Your guest cart has been emptied", "MakeUpStore");
                
            }
            
        }
    }
}
