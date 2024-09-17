using Facade;

namespace FacadeDesignPatternSample
{
    //استفاده از facade
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineShopingFacade shopingFacade = new OnlineShopingFacade();
            shopingFacade.PurchaseProduct();
        }
    }
}