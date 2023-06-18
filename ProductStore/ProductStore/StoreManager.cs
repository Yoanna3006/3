using System;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace ProductStore
{
    class StoreManager
    {
        private Store store;

        public StoreManager()
        {
            store = Store.GetInstance();
        }

        public void InitializeStore()
        {
            store.Initialize();
        }
        public void DisplayStoreProducts()
        {
            var productAdapter = new ProductAdapter(store.GetAllProducts());
            productAdapter.DisplayProducts();
        }




        public bool IsProductAvailable(string productName, int quantity)
        {
            var product = store.GetProductByName(productName) as Product;
            if (product != null && product.Quantity >= quantity)
            {
                return true;
            }
            return false;
        }

        public void RemoveProductQuantity(string productName, int quantity)
        {
            var product = store.GetProductByName(productName) as Product;
            if (product != null)
            {
                product.Quantity -= quantity;
            }
        }
    }
}
