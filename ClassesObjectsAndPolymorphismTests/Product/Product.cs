namespace Product
{
    public class Product
    {
        private readonly string _name;
        private int _amount { get; set; }
        private double _price { get; set; }
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _amount = amountAtStart;
            _price = priceAtStart;

        }

        public void ChangeAmount(int amount)
        {
            _amount = amount;
        }

        public void ChangePrice(double price)
        {
            _price = price;
        }

        public string PrintProduct()
        {
            return $"{_name}, {_price} EUR, {_amount} Units";
        }

    }
}