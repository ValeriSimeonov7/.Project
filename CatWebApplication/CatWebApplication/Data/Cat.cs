using System.ComponentModel.DataAnnotations;

namespace CatWebApplication.Data
{
    public class Cat
    {
        public int Id  { get; set; }
        public string Name { get; set; } = null!;

        [Range(0, 10)]
        public int Age { get; set; }
        public string Breed { get; set; } = null!;
        public string Picture { get; set; } = null!;
    }
}
