public class ProductCommand : ICommand
{
    private readonly Product _product;
    private readonly PriceAction _priceAction;
    private readonly int _amount;

    public ProductCommand(Product product, PriceAction priceAction, int amount)
    {
        _product = product;
        _priceAction = priceAction;
        _amount = amount;
    }

    public void ExecuteAction()
    {
        switch (_priceAction)
        {
            case PriceAction.Increase:
                _product.IncreasePrice(_amount);
                break;
            case PriceAction.Decrease:
                _product.DecreasePrice(_amount);
                break;
        }
    }
}