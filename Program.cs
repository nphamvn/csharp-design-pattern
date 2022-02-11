var modifyPrice = new ModifyPrice();
var product = new Product("Laptop", 1000);
Console.WriteLine("Original price: " + product);

Excute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
Excute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 50));
Console.WriteLine("Modified price: " + product);

modifyPrice.UndoActions();
Console.WriteLine("Undo actions: " + product);

static void Excute(Product product, ModifyPrice modifyPrice, ICommand command)
{
    modifyPrice.SetCommand(command);
    modifyPrice.Invoke();
}