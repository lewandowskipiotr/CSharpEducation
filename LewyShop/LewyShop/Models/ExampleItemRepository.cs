using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LewyShop.Models
{
    public class ExampleItemRepository : IItemRepository
    {

        public List<Item> AllItems =>
            new List<Item>
            {
                new Item{ItemId = 1, Name = "Czysty kod", InStock = true, Price = 30.00M, ShortDescription = "Luka's favorite book", CategoryId = 1},
                new Item{ItemId = 1, Name = "Algorytmy, kiedy myslec mniej", InStock = true, Price = 35.00M, ShortDescription = "Extra tips on how to thinking less", CategoryId = 1},
                new Item{ItemId = 1, Name = "VerdeMate Dragon", InStock = true, Price = 19.00M, ShortDescription = "The best daily yerba ever", CategoryId = 2},
                new Item{ItemId = 1, Name = "VerdeMate Anannas", InStock = true, Price = 19.00M, ShortDescription = "The best choise for terere", CategoryId = 2},
            };

        Item IItemRepository.getItemById(int itemId)
        {
            return AllItems.FirstOrDefault(i => i.ItemId == itemId);
        }
    }
}
