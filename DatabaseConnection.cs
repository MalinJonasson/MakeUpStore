
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace OnlineMakeUpStore
{
    public class DatabaseConnection
    {
        string server = "localhost"; 
        string database = "OnlineMakeUpStore"; 
        string username = "root"; 
        string password = "Mems91939501!"; 

        string connectionString = "";

        public DatabaseConnection(string server, string database, string username, string password)
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
        }

        public Product GetProduct(string productName)
        {
            Product product = null;

            string query = $"SELECT * FROM product Where product_name = '{productName}'";

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            try
            {
                mySqlConnection.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product((int)reader["product_id"], (string)reader["product_name"], (string)reader["product_category"], (int)reader["product_price"]);
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return product ?? null;
        }
        public Dictionary<int, Product> GetProducts()
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            string query = "SELECT * FROM product";

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            try
            {
                mySqlConnection.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product((int)reader["product_id"], (string)reader["product_name"], (string)reader["product_category"], (int)reader["product_price"]);

                        products.Add(product.Id, product);

                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return products;
        }


        public Product AddNewProducts(string name, string category, int price)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = "CALL create_product(@name, @category, @price)";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@name", name);
            mySqlCommand.Parameters.AddWithValue("@category", category);
            mySqlCommand.Parameters.AddWithValue("@price", price);


            mySqlCommand.ExecuteScalar(); 

            mySqlConnection.Close();
            Product product = GetProduct(name);
            return product;
        }
        public void DeleteProduct(int Id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("DeleteProduct", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteCartProduct(int cartId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = $"DELETE FROM CartProduct WHERE cart_id = ({cartId});";

            MySqlCommand mySqlCommand = new(query, mySqlConnection);

            mySqlCommand.ExecuteScalar();

            mySqlConnection.Close();
        }

        public User AddNewUser(string name, string email, string userName, string password)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = "CALL create_user(@name, @email, @userName, @password)";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@name", name);
            mySqlCommand.Parameters.AddWithValue("@email", email);
            mySqlCommand.Parameters.AddWithValue("@userName", userName);
            mySqlCommand.Parameters.AddWithValue("@password", password);

            mySqlCommand.ExecuteScalar();

            mySqlConnection.Close();

            var user = GetUser(userName);

            AddCart(user[0].Id);

            return new User(user[0].Id, name, email, userName, password);
        }
        public void AddCart(int userId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = $"INSERT INTO Cart (cart_id, user_id)\r\nVALUES (DEFAULT, {userId});";

            MySqlCommand mySqlCommand = new(query, mySqlConnection);

            mySqlCommand.ExecuteScalar();

            mySqlConnection.Close();
        }

        public Cart GetCart(int userId)
        {
            string query = $"SELECT * FROM Cart WHERE user_id = '{userId}';";

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@id", userId);

            Cart cart = null;
            try
            {
                mySqlConnection.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cart = new Cart
                        {
                            Id = (int)reader["cart_id"],
                            UserId = (int)reader["user_id"]
                        };
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return cart ?? new Cart();

        }
        public Cart AddGuestCart()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = $"INSERT INTO Cart (cart_id)\r\nVALUES (DEFAULT);";

            MySqlCommand mySqlCommand = new(query, mySqlConnection);

            mySqlCommand.ExecuteScalar();

            mySqlConnection.Close();

            Cart guestCart = GetGuestCart();

            return guestCart;
        }
        public Cart GetGuestCart()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string selectQuery = "SELECT * FROM Cart WHERE user_id IS NULL;";
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, mySqlConnection);

            Cart guestCart = null;

            MySqlDataReader reader = selectCommand.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    guestCart = new Cart { Id = (int)reader["cart_id"] };
                }
            }
            catch (Exception)
            {

                throw;
            }
            reader.Close();
            mySqlConnection.Close();

            return guestCart ?? null; 
        }
        public void AddProductToCart(int cartId, int productId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = $"INSERT INTO CartProduct (cart_id, product_id)\r\nVALUES ({cartId}, {productId});";

            MySqlCommand mySqlCommand = new(query, mySqlConnection);

            mySqlCommand.ExecuteScalar();

            mySqlConnection.Close();
        }
        public void RemoveProductFromCart(int cartId, int productId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = $"DELETE FROM CartProduct WHERE cart_id = {cartId} AND product_id = {productId};";

            MySqlCommand mySqlCommand = new(query, mySqlConnection);

            mySqlCommand.ExecuteScalar();

        }
        public Dictionary<int, User> GetUser(string userName)
        {
            Dictionary<int, User> Users = new Dictionary<int, User>();

            string query = $"SELECT * FROM User WHERE user_userName = '{userName}';";

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@userName", userName);

            try
            {
                mySqlConnection.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User((int)reader["user_id"], (string)reader["user_name"], (string)reader["user_email"], (string)reader["user_userName"], (string)reader["user_password"]);
                        Users.Add(user.UserId, user);
                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return Users;
        }

        public Dictionary<int, Product> GetProductsTo(string searchText)
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "CALL search_product_by_name_and_category(@searchText)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@searchText", searchText);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product((int)reader["product_id"], (string)reader["product_name"], (string)reader["product_category"], (int)reader["product_price"]);
                    products.Add(product.Id, product);
                }

                mySqlConnection.Close();
            }

            return products;
        }
        public Dictionary<int, Product> GetProductsInCart(int cartId)
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = $"SELECT * FROM Product INNER JOIN CartProduct on CartProduct.product_id = Product.product_id Where CartProduct.cart_id = {cartId}";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@cart_id", cartId);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product((int)reader["product_id"], (string)reader["product_name"], (string)reader["product_category"], (int)reader["product_price"]);
                    products.Add(product.Id, product);
                }

                mySqlConnection.Close();
            }

            return products;
        }
        public void UpdateProduct(int productId, string newName, int newPrice, string newCategory)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "CALL UpdateProduct(@productId, @newName, @newPrice, @newCategory)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@productId", productId);
                mySqlCommand.Parameters.AddWithValue("@newName", newName);
                mySqlCommand.Parameters.AddWithValue("@newPrice", newPrice);
                mySqlCommand.Parameters.AddWithValue("@newCategory", newCategory);

                mySqlCommand.ExecuteNonQuery();

                mySqlConnection.Close();
            }
        }

        public void EmptyCartData(int cartId)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();

            string query = $"DELETE FROM cartproduct Where cart_id = {cartId}";

            MySqlCommand mySqlCommand = new(query, mySqlConnection);

            mySqlCommand.ExecuteScalar();

            mySqlConnection.Close();
        }
        public Dictionary<int, UserCartView> GetUsersWithCartProducts()
        {

            Dictionary<int, UserCartView> userCartViews = new Dictionary<int, UserCartView>();
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT * FROM UserCartView";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                int key = 0;
                using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserCartView userCartView = new UserCartView { 
                            UserId = (int)reader["user_id"],
                            UserName = (string)reader["user_name"],
                            CartId = (int)reader["cart_id"],
                            ProductId = (int)reader["product_id"],
                            ProductName = (string)reader["product_name"],
                            ProductCategory = (string)reader["product_category"],
                            ProductPrice = (int)reader["product_price"],
                        };
                        key++;
                        userCartViews.Add(key, userCartView);

                        // Skapa en sträng som representerar raden och skicka den som parameter
                        // string userInfo = $"User ID: {userId}, User Name: {userName}, Cart ID: {cartId}, Product ID: {productId}, Product Name: {productName}, Category: {productCategory}, Price: {productPrice}";

                    }
                }
                mySqlConnection.Close();
            }
            return userCartViews;
        }
    }
}
