
namespace OnlineMakeUpStore
{
    public class UserCartView
    {
        public int UserId {  get; set; }
        public string UserName { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
    }
}
