namespace API.Models
{
    public class Purchase
    {
        public int id { get; set; } = -1;
        public int userID { get; set; } = -1;
        public DateTime orderDate { get; set; } = DateTime.Now;
        public decimal total { get; set; } = -1;
    }

    public class PurchaseInsert
    {
        public int userID { get; set; } = -1;
        public decimal total { get; set; } = -1;
        public DateTime orderDate { get; set; } = DateTime.Now;
    }

    public class PurchaseUpdate
    {
        public int id { get; set; } = -1;
        public int userID { get; set; } = -1;
        public decimal total { get; set; } = -1;
    }
}