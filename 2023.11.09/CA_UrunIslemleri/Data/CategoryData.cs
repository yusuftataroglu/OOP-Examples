using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Data
{
    public class CategoryData
    {
        public static List<Category> CategoryList=new List<Category> 
        {
            new Category
            {
                ID = 1,
                CategoryName = "Beverages",
                Description = "Soft drinks, coffees, teas, beers, and ales",
            },
            new Category
            {
                ID = 2,
                CategoryName = "Condiments",
                Description = "Sweet and savory sauces, relishes, spreads, and seasonings",
            },
            new Category
            {
                ID = 3,
                CategoryName = "Confections",
                Description = "Desserts, candies, and sweet breads",
            },
            new Category
            {
                ID = 4,
                CategoryName = "Dairy Products",
                Description = "Cheeses",
            },
            new Category
            {
                ID = 5,
                CategoryName = "Grains/Cereals",
                Description = "Breads, crackers, pasta, and cereal",
            }
        };
    }
}
