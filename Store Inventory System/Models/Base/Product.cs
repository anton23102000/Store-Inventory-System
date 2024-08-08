namespace Store_Inventory_System.Models.Base;

public abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    
    
    public virtual int AddQuantity(int quantity)
    {
        return Quantity += quantity;
    }
}