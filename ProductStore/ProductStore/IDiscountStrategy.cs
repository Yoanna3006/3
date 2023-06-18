using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal price);
    }
}
