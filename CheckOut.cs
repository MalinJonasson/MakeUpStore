namespace OnlineMakeUpStore
{
    public partial class CheckOut : Form
    {

        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "root", "Mems91939501!");
        public Manager Manager { get; set; }
        public HomePage homePage;
        public Skincare Skincare;
        public Haircare Haircare;
        public MakeUp MakeUp;
        public Cart Cart;

        public CheckOut()
        {
            InitializeComponent();
            cartGoBackToolTip.SetToolTip(goBackButton, "Home Page");
            
        }
        public void SetSkincareInstance(Skincare skincareInstance)
        {
            Skincare = skincareInstance;
        }
        public void SetHaircareInstance(Haircare haircareInstance)
        {
            Haircare = haircareInstance;
        }
        public void SetMakeUpInstance(MakeUp makeUpInstance)
        {
            MakeUp = makeUpInstance;
        }
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (Manager.CurrentUser != null)
            {
                if (Manager.CurrentUser.MyCart.productsInCart != null && Manager.CurrentUser.MyCart.productsInCart.Count > 0)
                {
                    label4.Visible = true;
                    cardNumTexBox.Visible = true;
                    purchaseButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your cart is empty. Add items to your cart before proceeding.");
                }
            }
            else
            {
                MessageBox.Show("You have to be a member to make a purchase! Go to Homepage to log in and then come back here!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            homePage.Show();
            Hide();
        }

        public void FillListBox()
        {
            cartListBox.Items.Clear();


            if (Manager.CurrentUser != null)
            {
                foreach (var product in Manager.CurrentUser.MyCart.productsInCart)
                {
                    cartListBox.Items.Add(product.Value.Name);
                }
            }
            else
            {
                var productsInGuestCart = Connection.GetProductsInCart(Manager.GuestCart.Id);
                foreach(var product in productsInGuestCart)
                {
                    cartListBox.Items.Add(product.Value.Name);
                }
            }
        }
        
        private void removeFromCartbutton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                string selectedProductName = cartListBox.SelectedItem.ToString();
                Product selectedProduct = null;
                if (Manager.CurrentUser != null)
                {
                    selectedProduct = Manager.CurrentUser.MyCart.productsInCart.Values.FirstOrDefault(p => p.Name == selectedProductName);
                }
                else
                {
                    selectedProduct = Manager.GuestCart.productsInCart.Values.FirstOrDefault(p => p.Name == selectedProductName);
                }
                
        
                if (selectedProduct != null)
                {
                     Manager.products[selectedProduct.Id] = selectedProduct;
          
                switch (selectedProduct.Category)
                {
                    case "Skincare":
                        Skincare.skincareListBox.Items.Add(selectedProduct.Name);
                        break;
                    case "Haircare":
                        Haircare.haircareListBox.Items.Add(selectedProduct.Name);
                        break;
                    case "MakeUp":
                        MakeUp.makeUpListBox.Items.Add(selectedProduct.Name);
                        break;
                    default:
                        MessageBox.Show("Invalid choice");
                        break;
                }
                    if (Manager.CurrentUser != null)
                    {
                        Manager.CurrentUser.MyCart.productsInCart.Remove(selectedProduct.Id);
                        Connection.RemoveProductFromCart(Manager.CurrentUser.MyCart.Id, selectedProduct.Id);
                        cartListBox.Items.RemoveAt(cartListBox.SelectedIndex);
                        MessageBox.Show("You removed " + selectedProduct.Name + " from your cart");
                        UpdateTotalPriceLabel();
                    }
                    else
                    {
                        Manager.GuestCart.productsInCart.Remove(selectedProduct.Id);
                        Connection.RemoveProductFromCart(Manager.GuestCart.Id, selectedProduct.Id);
                        cartListBox.Items.RemoveAt(cartListBox.SelectedIndex);
                        MessageBox.Show("You removed " + selectedProduct.Name + " from your cart");
                        UpdateTotalPriceLabel();
                    }
                }
            }
        }

        public void UpdateTotalPriceLabel()
        {
            if (Manager.CurrentUser != null)
            {
                totalPriceLabel.Text = "Total cost: " + Manager.CurrentUser.MyCart.CalculateTotalCost() + "$";
            }
            else
            {
                totalPriceLabel.Text = "Total cost: " + Manager.GuestCart.CalculateTotalCost() + "$";
            }
        }
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            if (cardNumTexBox.Text.Length == 6 && int.TryParse(cardNumTexBox.Text, out int paymentCode))
            {
                MessageBox.Show("Payment successful! Your order has been placed.");

                label4.Visible = false;
                cardNumTexBox.Visible = false;
                purchaseButton.Visible = false;

                Connection.DeleteCartProduct(Manager.CurrentUser.MyCart.Id);
                Manager.CurrentUser.MyCart.productsInCart.Clear();
                FillListBox();
                UpdateTotalPriceLabel();
            }
            else
            {
                MessageBox.Show("Invalid payment code. Please enter 6 digits.");
            }
        }
    }
}
