using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: bool?
            bool? b = true;
            Console.WriteLine(b != null ? $"b = {b}" : "b is null");

            // Example 2: Create a Product object 
            Product hotProduct = new Product();
            hotProduct.Name = "Samsung Galaxy Note 7";
            Console.WriteLine($"Product name: {hotProduct.Name}");

            //// Example 3: Assign Product properties
            //Product myProduct = new Product();          
            //myProduct.ProductID = 100;
            //myProduct.Name = "Kayak";
            //myProduct.Description = "A boat for one person";
            //myProduct.Price = 750M; myProduct.Quantity = 4;
            //myProduct.Category = "Watercraft";
            //Console.WriteLine($"Product name: {myProduct.Name}, Price: {myProduct.Price:c}, Amount due: {myProduct.AmountDue:c}");

            //// Example 4: Object initializer
            //Product p = new Product
            //{
            //    ProductID = 100,
            //    Name = "Kayak",
            //    Description = "A boat for one person",
            //    Price = 750M,
            //    Quantity = 4,
            //    Category = "Watersports"
            //};

            //// Example 5: C# array
            //string[] stringArray = { "apple", "orange", "banana" };
            //foreach(var fruit in stringArray)
            //{
            //    Console.WriteLine(fruit);
            //}

            //// Example 6: C# List
            //List<int> intList = new List<int> { 10, 20, 30, 40 };

            //// Example 7: C# Dictionary (Associative array)
            //Dictionary<int, string> myDictionary = new Dictionary<int, string> { { 4131, "apple" }, { 3107, "orange" }, { 4011, "banana" } };
            //string val = myDictionary[4011];

            //// Example 8: Type inference
            //var item = new Product
            //{
            //    Name = "Kayak",
            //    Category = "Watersports",
            //    Price = 750M,
            //    Quantity = 6
            //};
            //var name = item.Name;

            //// Example 9: Anonymous type
            //var anon = new
            //{
            //    Name = "MVC",
            //    Category = "Pattern"
            //};
            //Console.WriteLine(anon.Category);
            //// Changing structure of anonymous object is not allowed in C#
            ////anon.Whatever = 12345;

            Console.WriteLine("Finished - press Enter");
            Console.Read();
        }
    }
}
