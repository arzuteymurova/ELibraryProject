using Core.Entities;

namespace Entities.Concrete
{
    public class Author : IEntity
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int BookCount { get; set; }

    }
}