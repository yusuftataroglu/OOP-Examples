using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Data
{
    public class SupplierData
    {
        public static List<Supplier> SupplierList = new List<Supplier>
        {
            new Supplier
            {
                ID = 1,
                CompanyName = "Exotic Liquids",
                ContactName = "Charlotte Cooper",
                ContactTitle = "Purchasing Manager"
            },
            new Supplier
            {
                ID = 2,
                CompanyName = "Cooperativa de Quesos 'Las Cabras'",
                ContactName = "Antonio del Valle Saavedra",
                ContactTitle = "Export Administrator"
            },
            new Supplier
            {
                ID = 3,
                CompanyName = "Specialty Biscuits, Ltd.",
                ContactName = "Peter Wilson",
                ContactTitle = "Sales Representative"
            },
            new Supplier
            {
                ID = 4,
                CompanyName = "Plutzer Lebensmittelgroßmärkte AG",
                ContactName = "Martin Bein",
                ContactTitle = "International Marketing Mgr."
            },
            new Supplier
            {
                ID = 5,
                CompanyName = "Norske Meierier",
                ContactName = "Beate Vileid",
                ContactTitle = "Marketing Manager"
            }
        };
    }
}
