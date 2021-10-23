using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LewyShop.Models
{
    public interface IItemRepository
    {
        public List<Item> AllItems { get; }
        public Item getItemById(int itemId);

    }
}
