using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class BookDetailsDto:IDto
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public string Language { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
