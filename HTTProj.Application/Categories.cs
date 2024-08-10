using HTTProj.Application.Interfaces;

namespace HTTProj.Application
{
    public class Categories : IHaveId
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
