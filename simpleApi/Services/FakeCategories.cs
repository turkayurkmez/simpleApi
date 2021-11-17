using simpleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleApi.Services
{
    public class FakeCategories
    {
        private List<Category> categories;
        public FakeCategories()
        {
            categories = new List<Category>
            {
                new Category{ Id =1, Name ="Sağlık Bakanlığı"},
                new Category{ Id =2, Name ="Finans"},
                new Category{ Id =3, Name ="İletişim"},


            };
        }
        public List<Category> GetCategories()
        {          

            return categories;
        }

        public void AddCategory(Category category) {
            categories.Add(category);
        }

    }
}
