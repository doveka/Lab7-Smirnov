struct Product
{
    public string Name;
    public string Manufacturer;
    public int Year;
    public int Quantity;
    public decimal Price;
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив товаров
        Product[] products = new Product[]
        {
            new Product { Name = "Товар1", Manufacturer = "Производитель1", Year = 2021, Quantity = 10, Price = 100 },
            new Product { Name = "Товар2", Manufacturer = "Производитель2", Year = 2020, Quantity = 5, Price = 200 },
            new Product { Name = "Товар3", Manufacturer = "Производитель3", Year = 2021, Quantity = 7, Price = 150 }
        };

        decimal totalCost = 0;

        // Выводим информацию о товарах, выпущенных в текущем году, и считаем общую стоимость
        foreach (Product product in products)
        {
            if (product.Year == DateTime.Now.Year)
            {
                Console.WriteLine("Наименование: " + product.Name);
                Console.WriteLine("Производитель: " + product.Manufacturer);
                Console.WriteLine("Год выпуска: " + product.Year);
                Console.WriteLine("Количество: " + product.Quantity);
                Console.WriteLine("Цена: " + product.Price);
                Console.WriteLine();

                totalCost += product.Quantity * product.Price;
            }
        }

        Console.WriteLine("Общая стоимость всех товаров, выпущенных в текущем году: " + totalCost);
    }
}