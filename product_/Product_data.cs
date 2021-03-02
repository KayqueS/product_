namespace product_
{
    class Product_data
    {
        public string Product;
        public double Value;
        public int Amount;

        public double TotalValueInStock()
        {
            return Value * Amount;
        }

        public void AddProduct(int amount)
        {
            Amount += amount;
        }

        public void RemoveProduct(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return $"{Product}, $ {Value:F2}, {Amount} unidades, Total: $ {TotalValueInStock():F2}";
        }
    }
}
