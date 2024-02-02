using System.Text.RegularExpressions;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace OnlineMakeUpStore
{
    public partial class AdminLogIn : Form
    {
        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "", "");
        public HomePage HomePage;
        public Manager Manager { get; set; }
        public Skincare Skincare;
        public Haircare Haircare;
        public MakeUp MakeUp;

        public AdminLogIn()
        {
            InitializeComponent();
            adminGoBackToolTip.SetToolTip(goBackButton, "Home Page");
            FillComboBoxes();

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
        public void SetManager(Manager manager)
        {
            Manager = manager;
        }
        private void removeProductButton_Click(object sender, EventArgs e)
        {
            if (removeProductListBox.SelectedIndex != -1)
            {
                string selectedProductInfo = removeProductListBox.SelectedItem.ToString();
                var match = Regex.Match(selectedProductInfo, @"^(.*): (.*) (\d+)KR$");

                if (match.Success)
                {
                    string selectedCategory = match.Groups[1].Value.Trim();
                    string selectedProductName = match.Groups[2].Value.Trim();
                    decimal selectedProductPrice = decimal.Parse(match.Groups[3].Value);

                    var selectedProduct = Manager.products.Values.FirstOrDefault(p =>
                        p.Category == selectedCategory &&
                        p.Name == selectedProductName &&
                        p.Price == selectedProductPrice
                    );

                    if (selectedProduct != null)
                    {
                        Connection.DeleteProduct(selectedProduct.Id);
                        Manager.products.Remove(selectedProduct.Id);
                        removeProductListBox.Items.RemoveAt(removeProductListBox.SelectedIndex);
                        FindUserControl(selectedProduct);

                    }
                }
            }
        }

        public void FindUserControl(Product product)
        {
            switch (product.Category)
            {
                case "Skincare":
                    Skincare.skincareListBox.Items.Remove(product.Name);
                    MessageBox.Show("You removed: " + product.Name);
                    break;

                case "Haircare":
                    Haircare.haircareListBox.Items.Remove(product.Name);
                    MessageBox.Show("You removed: " + product.Name);
                    break;

                case "MakeUp":
                    MakeUp.makeUpListBox.Items.Remove(product.Name);
                    MessageBox.Show("You removed: " + product.Name);
                    break;

                default:
                    MessageBox.Show("Invalid choice");
                    break;
            }
        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string category = categoryComboBox.Text;
            decimal price = priceNumeric.Value;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(category) && price > 0)
            {

                Manager.CreateAndAddNewProduct(name, category, price);
                AddProductToCategoryListBox(category, name);
                removeProductListBox.Items.Add(name);

                MessageBox.Show("Product added: " + name);
                nameTextBox.Clear();
                priceNumeric.Value = priceNumeric.Minimum;
                categoryComboBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("You have to fill out all the columns");
            }

            FillListBox();
        }

        private void AddProductToCategoryListBox(string category, string productName)
        {
            switch (category)
            {
                case "Skincare":
                    Skincare.skincareListBox.Items.Add(productName);
                    break;

                case "Haircare":
                    Haircare.haircareListBox.Items.Add(productName);
                    break;

                case "MakeUp":
                    MakeUp.makeUpListBox.Items.Add(productName);
                    break;

                default:
                    MessageBox.Show("Invalid choice");
                    break;
            }

        }
        private void FillListBox()
        {
            removeProductListBox.Items.Clear();
            Manager.products = Connection.GetProducts();

            foreach (var product in Manager.products)
            {
                removeProductListBox.Items.Add(product.Value.Category + ": " + product.Value.Name + " " + product.Value.Price + "KR");
            }
        }

        private void removeProductListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (removeProductListBox.SelectedIndex != -1)
            {
                string selectedProductText = removeProductListBox.SelectedItem.ToString();
                var match = Regex.Match(selectedProductText, @"^(.*): (.*) (\d+)KR$");

                string selectedProductName = match.Groups[0].ToString().Length > 1 ? match.Groups[2].ToString() : string.Empty;
                Product selectedProduct = Manager.products.Values.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    editNameTextBox.Text = selectedProduct.Name;
                    editCategoryComboBox.Text = selectedProduct.Category;
                    editPriceTextBox.Text = selectedProduct.Price.ToString();
                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (removeProductListBox.SelectedIndex != -1)
            {
                int selectedProductKey = Manager.products.Keys.ElementAt(removeProductListBox.SelectedIndex);
                Product selectedProduct = Manager.products[selectedProductKey];

                string newCategory = editCategoryComboBox.Text;

                if (newCategory != "Skincare" && newCategory != "Haircare" && newCategory != "MakeUp")
                {
                    return;
                }

                selectedProduct.Name = editNameTextBox.Text;
                selectedProduct.Category = newCategory;

                if (int.TryParse(editPriceTextBox.Text, out int newPrice))
                {
                    selectedProduct.Price = newPrice;

                    try
                    {
                        Connection.UpdateProduct(selectedProduct.Id, selectedProduct.Name, selectedProduct.Price, selectedProduct.Category);
                    }
                    catch (Exception ex)
                    {
                        return;
                    }

                    removeProductListBox.Items[removeProductListBox.SelectedIndex] = $"{selectedProduct.Category}: {selectedProduct.Name} {selectedProduct.Price}KR";

                    Manager.products[selectedProductKey] = selectedProduct;
                    FillListBox();
                }
                else
                {
                    return;
                }
            }
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            string nameInput = usernameTextBox.Text;
            string passwordInput = passwordTextBox.Text;

            if (nameInput == Manager.AdminName && passwordInput == Manager.AdminPassword)
            {
                enterAddProductButton.Visible = true;
                enterRemoveProductButton.Visible = true;
                usersAndCarts.Visible = true;    
                logInLabel.Visible = false;
                usernameTextBox.Visible = false;
                passwordTextBox.Visible = false;
                adminLogInButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong name or password");
            }
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void usersAndCarts_Click(object sender, EventArgs e)
        {
            var userCartViews = Connection.GetUsersWithCartProducts();
            usersAndCartListBox.Items.Clear();
            foreach (var product in userCartViews)
            {
                usersAndCartListBox.Items.Add($"UserId: {product.Value.UserId} UserName: {product.Value.UserName} CartId: {product.Value.CartId} ProductName: {product.Value.ProductName}");
            }

            usersAndCartListBox.Visible = true;

            usersAndCartListBox.Visible = true;
            usersAndCartsLabel.Visible = true;
            usersAndCarts.Visible = false;

            categoryLabel.Visible = false;
            categoryComboBox.Visible = false;
            nameTextBox.Visible = false;
            priceLabel.Visible = false;
            priceNumeric.Visible = false;
            addProductButton.Visible = false;
            addAProductLabel.Visible = false;
            enterAddProductButton.Visible = false;
            enterRemoveProductButton.Visible = false;
            removeProductListBox.Visible = false;
            removeProductButton.Visible = false;
            listOfProductsLabel.Visible = false;
            removeAProductLabel.Visible = false;
            chooseToEditLabel.Visible = false;
            editNameTextBox.Visible = false;
            editPriceTextBox.Visible = false;
            editButton.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            editCategoryComboBox.Visible = false;
            logInLabel.Visible = false;
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            adminLogInButton.Visible = false;
        }
        private void enterAddProductButton_Click(object sender, EventArgs e)
        {
            categoryLabel.Visible = true;
            categoryComboBox.Visible = true;
            nameTextBox.Visible = true;
            priceLabel.Visible = true;
            priceNumeric.Visible = true;
            addProductButton.Visible = true;
            addAProductLabel.Visible = true;
            enterAddProductButton.Visible = false;
            enterRemoveProductButton.Visible = false;
        }

        private void enterRemoveProductButton_Click(object sender, EventArgs e)
        {
            FillListBox();
            removeProductListBox.Visible = true;
            removeProductButton.Visible = true;
            listOfProductsLabel.Visible = true;
            removeAProductLabel.Visible = true;
            chooseToEditLabel.Visible = true;
            editNameTextBox.Visible = true;
            editPriceTextBox.Visible = true;
            editButton.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            editCategoryComboBox.Visible = true;
            enterAddProductButton.Visible = false;
            enterRemoveProductButton.Visible = false;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            categoryLabel.Visible = false;
            categoryComboBox.Visible = false;
            nameTextBox.Visible = false;
            priceLabel.Visible = false;
            priceNumeric.Visible = false;
            addProductButton.Visible = false;
            addAProductLabel.Visible = false;
            enterAddProductButton.Visible = false;
            enterRemoveProductButton.Visible = false;
            removeProductListBox.Visible = false;
            removeProductButton.Visible = false;
            listOfProductsLabel.Visible = false;
            removeAProductLabel.Visible = false;
            chooseToEditLabel.Visible = false;
            editNameTextBox.Visible = false;
            editPriceTextBox.Visible = false;
            editButton.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            editCategoryComboBox.Visible = false;

            usersAndCartListBox.Visible = false;
            usersAndCartsLabel.Visible = false;

            logInLabel.Visible = true;
            usernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            adminLogInButton.Visible = true;

            HomePage.Show();
            Hide();
        }

        private void FillComboBoxes()
        {
            categoryComboBox.Items.Add("Skincare");
            categoryComboBox.Items.Add("Haircare");
            categoryComboBox.Items.Add("MakeUp");
            editCategoryComboBox.Items.Add("Skincare");
            editCategoryComboBox.Items.Add("Haircare");
            editCategoryComboBox.Items.Add("MakeUp");
        }

    }

}

