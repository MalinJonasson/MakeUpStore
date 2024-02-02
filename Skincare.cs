
namespace OnlineMakeUpStore
{
    public partial class Skincare : UserControl
    {
        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "root", "Mems91939501!");
        public Manager Manager { get; set; }
        public HomePage HomePage { get; set; }
        public AdminLogIn AdminLogIn;
        public CheckOut CheckOut;
        public Skincare()
        {
            InitializeComponent();
            skincareToolTip.SetToolTip(backToHomePageButton, "Home Page");
        }

        public void SetCheckOutInstance(CheckOut checkOutInstance)
        {
            CheckOut = checkOutInstance;
        }

        public void SetHomePage(HomePage homePage)
        {
            HomePage = homePage;
            HomePage.Skincare = this;
        }

        public void SetAdminManager(Manager manager)
        {
            Manager = manager;
        }

        public void FillListBox()
        {
            skincareListBox.Items.Clear();
            Manager.products = Connection.GetProducts();

            foreach (Product product in Manager.products.Values.Where(p => p.Category == "Skincare"))
            {
                if (Manager.CurrentUser != null)
                {
                    if (!Manager.CurrentUser.MyCart.productsInCart.ContainsKey(product.Id))
                    {
                        skincareListBox.Items.Add(product.Name);
                    }
                }
                else
                {
                    if (!Manager.GuestCart.productsInCart.ContainsKey(product.Id))
                    {
                        skincareListBox.Items.Add(product.Name);
                    }
                }
            }
        }
        private void backToHomePageButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void skincareCartButton_Click(object sender, EventArgs e)
        {
            if (skincareListBox.SelectedIndex != -1)
            {
                string selectedProductName = skincareListBox.SelectedItem.ToString();
                var selectedProduct = Manager.products.Values.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    if (Manager.CurrentUser != null)
                    {
                        //Manager.CurrentUser.MyCart.productsInCart[selectedProduct.Id] = selectedProduct;
                        Connection.AddProductToCart(Manager.CurrentUser.MyCart.Id, selectedProduct.Id);
                        Manager.CurrentUser.MyCart.productsInCart.Add(selectedProduct.Id, selectedProduct);
                    }
                    else
                    {
                        Connection.AddProductToCart(Manager.GuestCart.Id, selectedProduct.Id);
                        Manager.GuestCart.productsInCart.Add(selectedProduct.Id, selectedProduct);
                    }

                    Manager.products.Remove(selectedProduct.Id);
                    skincareListBox.Items.RemoveAt(skincareListBox.SelectedIndex);
                }
            }
        }

        private void skincareListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skincareListBox.SelectedIndex != -1)
            {
                string selectedProductName = skincareListBox.SelectedItem.ToString();
                var selectedProduct = Manager.products.Values.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    priceLabel.Text = "Price: " + selectedProduct.Price.ToString() + "$";
                }
                else
                {
                    Manager.products = Connection.GetProducts();
                }
            }
        }
    }
}

    

