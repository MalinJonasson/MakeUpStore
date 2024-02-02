using System.Data;

namespace OnlineMakeUpStore
{
    public partial class MakeUp : UserControl
    {
        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "", "");
        public Manager Manager;
        public HomePage HomePage;
        public CheckOut CheckOut;
        public MakeUp()
        {
            InitializeComponent();
            makeUpToolTip.SetToolTip(backToHomePageButton, "Home Page");
        }
        public void SetCheckOutInstance(CheckOut checkOutInstance)
        {
            CheckOut = checkOutInstance;
        }
        public void SetHomePage(HomePage homePage)
        {
            HomePage = homePage;
            HomePage.MakeUp = this;
        }
        public void SetAdminManager(Manager manager)
        {
            Manager = manager;
        }
        public void FillListBox()
        {
            makeUpListBox.Items.Clear();
            Manager.products = Connection.GetProducts();

            foreach(Product product in Manager.products.Values.Where(p => p.Category == "MakeUp"))
            {
                if (Manager.CurrentUser != null)
                {
                    if (!Manager.CurrentUser.MyCart.productsInCart.ContainsKey(product.Id))
                    {
                        makeUpListBox.Items.Add(product.Name);
                    }
                }
                else
                {
                    if (!Manager.GuestCart.productsInCart.ContainsKey(product.Id))
                    {
                        makeUpListBox.Items.Add(product.Name);
                    }
                }
            }
        }
        private void goBackToHomePageButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void makeUpCartButton_Click(object sender, EventArgs e)
        {
            if (makeUpListBox.SelectedIndex != -1)
            {
                string selectedProductName = makeUpListBox.SelectedItem.ToString();
                var selectedProduct = Manager.products.Values.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    if (Manager.CurrentUser != null)
                    {
                        Connection.AddProductToCart(Manager.CurrentUser.MyCart.Id, selectedProduct.Id);
                        Manager.CurrentUser.MyCart.productsInCart.Add(selectedProduct.Id, selectedProduct);
                    }
                    else
                    {
                        Connection.AddProductToCart(Manager.GuestCart.Id, selectedProduct.Id);
                        Manager.GuestCart.productsInCart.Add(selectedProduct.Id, selectedProduct);
                    }

                    Manager.products.Remove(selectedProduct.Id);
                    makeUpListBox.Items.RemoveAt(makeUpListBox.SelectedIndex);
                }
            }
        }

        private void makeUpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (makeUpListBox.SelectedIndex != -1)
            {
                string selectedProductName = makeUpListBox.SelectedItem.ToString();
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
