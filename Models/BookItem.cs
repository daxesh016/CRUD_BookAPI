using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_BookAPI.Models
{
    public class BookItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Auther { get; set; }
        public decimal Price { get; set; }
    }
}
