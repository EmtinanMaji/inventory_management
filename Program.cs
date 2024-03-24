using System;

class Item
{
    public string Name {get;}
    private int Quantity {get; set;}
    private DateTime CreatedDate {get; set;}

    public Item(string name, int quantity, DateTime createdDate = default){
        if(quantity < 0){
            Console.WriteLine("Quantity cannot be negative.");
            return;
        }
        Name = name;
        Quantity = quantity;
        CreatedDate = createdDate == default ? DateTime.Now : createdDate;
    }
} 

class Store
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        
    }
    public void DeleteItem(string itemName)
    {
    
    }

    public int GetCurrentVolume()
    {
        return;
    }

    public Item FindItemByName(string itemName)
    {
        return;
    }

    public List<Item> SortByNameAsc()
    {
        return;
    }

}
class Program
{
    static void Main(string[] args)
    {

    }
}
