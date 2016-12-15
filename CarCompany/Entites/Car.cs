using System.ComponentModel.DataAnnotations;

namespace CarCompany.Entites
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }
}