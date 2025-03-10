namespace TestInventoryApi.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string StockQuantity { get; set; }
        public datetime CreateDate { get; set; }
        public datetime? UpdateDate { get; set; }
    }
}