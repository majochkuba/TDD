namespace CarStoreApp
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(int id, string make, string model, decimal price)
        {
            Id = id;
            Make = make;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"[{Id}] {Make} {Model} - {Price} PLN";
        }
    }
}
