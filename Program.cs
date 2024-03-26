using System;

class Item
{
    public string Name {get;}
    private int quantity;
    public int Quantity {
        get {return quantity;}
        set {quantity = value;}
        }
    private DateTime createdDate;
    public DateTime CreatedDate {
        get {return createdDate;}
        set {createdDate = value;}
        }

    public Item(string name, int quantity, DateTime createdDate = default)
    {
        if(quantity < 0)
        {
            Console.WriteLine("Quantity cannot be negative.");
            return;
        }
        Name = name;
        Quantity = quantity;
        CreatedDate = createdDate == default ? DateTime.Now : createdDate;
    }

    public override string ToString()
    {
        return $"{Name} - Quantity: {Quantity}, Created Date: {CreatedDate}";
    }
} 

class Store
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        if (items.Any(i => i.Name == item.Name))
        {
            Console.WriteLine($"Item '{item.Name}' already exists in the store. Cannot add duplicate items.");
        }
        else
        {
        items.Add(item);
        Console.WriteLine($"Item '{item.Name}' added successfully.");
        }
    }
    public void printItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"{item}");
        }
    }

    public void DeleteItem(string itemName)
    {
        Item item = items.FirstOrDefault(i => i.Name == itemName);
        if (item != null)
        {
            items.Remove(item);
            Console.WriteLine($"Item '{itemName}' deleted successfully.");
        }
        else
        {
            Console.WriteLine($"Item '{itemName}' not found in the store. Cannot delete.");
        }
    }

    public int GetCurrentVolume()
    {
        return items.Sum(i => i.Quantity);
    }

    public Item FindItemByName(string itemName)
    {
        Item foundItem = items.FirstOrDefault(i => i.Name == itemName);
        if (foundItem != null)
        {
            Console.WriteLine($"Found item: {foundItem} ");
        }
        else
        {
            Console.WriteLine($"Item '{itemName}' not found.");
        }
        return foundItem;
    }

    public List<Item> SortByNameAsc()
    {
        return items.OrderBy(i => i.Name).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // items example - You do not need to follow exactly the same
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
        var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);

        
        var store = new Store();

        store.AddItem(waterBottle);
        store.AddItem(chocolateBar);
        store.AddItem(notebook);
        store.AddItem(pen);
        store.AddItem(tissuePack);
        store.AddItem(chipsBag);
        store.AddItem(sodaCan);
        store.AddItem(soap);
        store.AddItem(shampoo);
        store.AddItem(toothbrush);
        store.AddItem(coffee);
        store.AddItem(sandwich);
        store.AddItem(batteries);
        store.AddItem(umbrella);
        store.AddItem(sunscreen);

        store.AddItem(chocolateBar);
        Console.WriteLine("----------------------------------------------------------------");

        store.printItems();
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine($"The total amount of items in the store: {store.GetCurrentVolume()}");
        Console.WriteLine("----------------------------------------------------------------");

        store.DeleteItem("Burger");
        store.DeleteItem("Umbrella");
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine($"The total amount of items in the store after deletion: {store.GetCurrentVolume()}");
        Console.WriteLine("----------------------------------------------------------------");

        store.FindItemByName("Sunscreen");
        store.FindItemByName("Umbrella");
        Console.WriteLine("----------------------------------------------------------------");

        // Sort items by name
        var sortedItems = store.SortByNameAsc();
        Console.WriteLine("Sorted items by name:");
        foreach (var item in sortedItems)
        {
            Console.WriteLine($"{item}");
        }
    
        
    }
}
