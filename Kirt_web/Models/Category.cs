﻿namespace Kirt_web.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }
    }
}
