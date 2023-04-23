using System.ComponentModel.DataAnnotations;

namespace Dtos.Brand
{
    public class BrandMinimalDto
    {
        public int Id { get; set; }
        [MinLength(3), MaxLength(200)]
        public string NameEN { get; set; }
        //Globalization
        [MinLength(3), MaxLength(200)]
        public string NameAR { get; set; }
        public string ImageURL { get; set; }
    }
}
