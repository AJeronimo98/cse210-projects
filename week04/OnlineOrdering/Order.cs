using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalPrice()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.CalculateTotalCost();
            }

            // Regla de envío: USA $5, Internacional $35
            double shippingCost = _customer.IsInUSA() ? 5 : 35;
            return total + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += $"- {product.GetName()} (ID: {product.GetId()})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
    }
}