using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Data
{
    public class CustomerData
    {
        public static List<Customer> CustomerList = new List<Customer>
        {
            new Customer
            {
                ID = 1,
                CompanyName = "Alfreds Futterkiste",
                ContactName = "Maria Anders",
                ContactTitle ="Sales Representative",
                Country = "Germany",
                Phone = "030-0074321",
            },
            new Customer
            {
                ID = 2,
                CompanyName = "Comércio Mineiro",
                ContactName = "Pedro Afonso",
                ContactTitle ="Sales Associate",
                Country = "Brazil",
                Phone = "(11) 555-7647",
            },
            new Customer
            {
                ID = 3,
                CompanyName = "Ernst Handel",
                ContactName = "Roland Mendel",
                ContactTitle ="Sales Manager",
                Country = "Austria",
                Phone = "7675-3425",
            },
            new Customer
            {
                ID = 4,
                CompanyName = "France Restauration",
                ContactName = "Carine Schmitt",
                ContactTitle ="Marketing Manager",
                Country = "France",
                Phone = "40.32.21.21",
            },
            new Customer
            {
                ID = 5,
                CompanyName = "Great Lakes Food Market",
                ContactName = "Howard Snyder",
                ContactTitle ="Marketing Manager",
                Country = "USA",
                Phone = "(503) 555-7555",
            }
        };
    }
}
