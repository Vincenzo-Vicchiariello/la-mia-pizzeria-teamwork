using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;


namespace LaMiaPizzeriaNuova.Models
{
    public class Drink
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [Range(0, 2)]
        public float Liters { get; set; }
        [Required]
        [Range(0, 10)]
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
