using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Data
{
    public class ProductData
    {
        public static List<Product> ProductList = new List<Product>
        {
            new Product
            {
                ID = 1,
                ProductName = "Chai",
                UnitPrice = 18,
                UnitsInStock = 39,
            },
            new Product
            {
                ID = 2,
                ProductName = "Northwoods Cranberry Sauce",
                UnitPrice = 40,
                UnitsInStock = 6,
            },
            new Product
            {
                ID = 3,
                ProductName = "Queso Cabrales",
                UnitPrice = 21,
                UnitsInStock = 22,
            },
            new Product
            {
                ID = 4,
                ProductName = "Tofu",
                UnitPrice = 23.25M,
                UnitsInStock = 35,
            },
            new Product
            {
                ID = 5,
                ProductName = "Teatime Chocolate Biscuits",
                UnitPrice = 9.20M,
                UnitsInStock = 25,
            }
        };
}
}
