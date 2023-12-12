namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock { StockName = "ABC", Price = 100.0M };
            StockObserver observer = new StockObserver();

            observer.Subscribe(stock); // Subscribe to the event

            
            stock.Price = 110.5M;
            stock.Price = 95.0M;

            observer.Unsubscribe(stock); // Unsubscribe from the event

           
            stock.Price = 105.3M;
        }
    }
}