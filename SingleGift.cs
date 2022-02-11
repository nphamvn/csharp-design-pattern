public class SingleGift : GiftBase
{
    public SingleGift(string name, int price) : base(name, price)
    {
    }

    public override int CalculatePrice()
    {
        Console.WriteLine($"{name} with the price {price}");
        return price;
    }
}