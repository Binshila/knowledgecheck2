
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<CatFood>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            
            var catFood = new CatFood();

            Console.WriteLine("Enter Name: ");
            catFood.Name = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            catFood.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity: ");
            catFood.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Description: ");
            catFood.Description = Console.ReadLine();

            Console.WriteLine("Enter Kitten Food (true/false): ");
            catFood.KittenFood = bool.Parse(Console.ReadLine());

            recordList.Add(catFood);
        }

        // Print out the list of records
        foreach (var record in recordList)
        {
            Console.WriteLine(record);
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
    }
}

class CatFood : Product
{
    public bool KittenFood { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", KittenFood: {KittenFood}";
    }
}
