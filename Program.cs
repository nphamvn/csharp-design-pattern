var products = new List<Product>
{
    new Product { Name = "Monitor", Price = 200.50 },
    new Product { Name = "Mouse", Price = 20.41 },
    new Product { Name = "Keyboard", Price = 30.15}
};

// Create a ProductStockReportBuilder object for products
var builder = new ProductStockReportBuilder(products);
var director = new ProductStockReportDirector(builder);

// The Director ask the Builder to build the ProductStockReport object.
director.BuildStockReport();

//Get ProductStockReport object from the Builder
var report = builder.GetReport();

Console.WriteLine(report);
