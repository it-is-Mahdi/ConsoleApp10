using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class StockObserver
    {
        public void Subscribe(Stock stock)
        {
            stock.StockChanged += HandleStockChange;
        }

        public void Unsubscribe(Stock stock)
        {
            stock.StockChanged -= HandleStockChange;
        }

        private void HandleStockChange(object sender, StockChangedEventArgs e)
        {
            Console.WriteLine($"Stock '{e.StockName}' price changed to {e.NewPrice:C}");
        }
    }
}
