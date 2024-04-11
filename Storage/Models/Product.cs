using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Product name can contain only 20 characters")]
        public string Name { get; set; } = string.Empty;

        [Range(10,100000, ErrorMessage ="Value must be between {1} and {2}.")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }

        public int Count { get; set; }
        public string Description { get; set; }
    }
}
