namespace LaMiaPizzeriaNuova.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Liters { get; set; }
        public float Price { get; set; }


        public Drink()
        {

        }

        public Drink(string name, string description, float liters, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Liters = liters;
            this.Price = price;

        }

    }
}
