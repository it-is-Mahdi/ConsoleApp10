using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Stock
    {
        public event EventHandler<StockChangedEventArgs> StockChanged;

        private string _stockName;
        private decimal _price;

        public string StockName
        {
            get => _stockName;
            set => _stockName = value;
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnStockChanged(new StockChangedEventArgs(_stockName, _price));
                }
            }
        }

        protected virtual void OnStockChanged(StockChangedEventArgs e)
        {
            StockChanged?.Invoke(this, e);
        }
    }
}
