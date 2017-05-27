namespace eindwerkBackend.EF.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductDescription { get; set; }
        public bool FlateRate { get; set; }
        public double ProductQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double QtyShowed { get; set; }
        public string UnitType { get; set; }
        public double ProductPrice { get; set; }
        public double ToPayNoTva { get; set; }
        public double ToPay { get; set; }
    }
}