namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool IsInUSA()
        {
            // Encapsulación: El cliente le pregunta a su objeto dirección
            return _address.IsInUSA();
        }

        public string GetName() => _name;
        public Address GetAddress() => _address;
    }
}