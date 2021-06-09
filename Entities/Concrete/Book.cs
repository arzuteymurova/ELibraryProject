using Core.Entities;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Language { get; set; }
        public int Count { get; set; }
        public decimal  Price { get; set; }
    }
}
