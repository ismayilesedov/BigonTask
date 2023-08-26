namespace BigonTask.Areas.Admin.Models.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string StockKeepingUnit { get; set; }
        public decimal Rate { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
