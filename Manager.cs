using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace OnlineMakeUpStore
{
    public class Manager
    {
        public DatabaseConnection Connection = new("localhost", "OnlineMakeUpStore", "", "");
        public User User;
        public string AdminName = "admin";
        public string AdminPassword = "admin";
        public User CurrentUser = null;
        public Cart GuestCart;
        public Dictionary<int, Product> products = new Dictionary<int, Product>();
        public Dictionary<int, User> customers = new Dictionary<int, User>();
        
        public void CreateAndAddNewProduct(string name, string category, decimal price)
        {
            Product newProduct = Connection.AddNewProducts(name, category, (int)price);
            products.Add(newProduct.Id, newProduct);
        }
        public void RegisterNewCustomer(string name, string email, string password, string userName)
        {
            User addedUser = Connection.AddNewUser(name, email, password, userName);
            User newUser = new User(addedUser.Id, name, email, password, userName);

            customers.Add(newUser.UserId, newUser);
        }

    }
}
