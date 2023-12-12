using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class StockChangedEventArgs : EventArgs
{
    public string StockName { get; }
    public decimal NewPrice { get; }

    public StockChangedEventArgs(string stockName, decimal newPrice)
    {
        StockName = stockName;
        NewPrice = newPrice;
    }
}
