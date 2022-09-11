namespace WebStoreApi.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int InStockQty { get; set; }
  }
}