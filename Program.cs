var phone = new SingleGift("Phone", 256);
phone.CalculatePrice();
Console.WriteLine();

var rootBox = new CompositeGift("Root Box", 0);
var truckToy = new SingleGift("Truck toy", 289);
var plainToy = new SingleGift("Plain toy", 587);
rootBox.Add(truckToy);
rootBox.Add(plainToy);
var childBox = new CompositeGift("Child Box", 0);
var soldierToy = new SingleGift("Soldier toy", 200);
childBox.Add(soldierToy);
rootBox.Add(childBox);

Console.WriteLine($"Total price of this composite present is: {rootBox.CalculatePrice()}");