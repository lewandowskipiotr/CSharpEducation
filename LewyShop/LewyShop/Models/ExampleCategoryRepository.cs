using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LewyShop.Models
{
    /*
     This class is created to add example data to our repository of categories. In the futre I'll attach database to this project so I'll be able to use data from the database.
     */
    public class ExampleCategoryRepository : ICategoryRepository
    {

        // Check construction of this statement =>  I'm not feeling comfortable with using it. Check details!
        public List<Category> AllCategories =>
            new List<Category>
            { 
                new Category{ CategoryId = 1, Name= "Books"},
                new Category{ CategoryId = 2, Name= "Yerba mate"}              
            };

    }
}
