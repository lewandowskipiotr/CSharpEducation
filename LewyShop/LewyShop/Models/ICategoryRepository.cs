using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LewyShop.Models
{
    public interface ICategoryRepository
    {
        public List<Category> AllCategories { get; }
    }
}
