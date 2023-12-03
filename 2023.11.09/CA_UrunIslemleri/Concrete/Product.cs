using CA_UrunIslemleri.Abstract;

namespace CA_UrunIslemleri.Concrete
{
    public class Product:BaseClass
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} Product Name: {ProductName} Unit Price: {UnitPrice} Units in Stock: {UnitsInStock} Created Date: {CreatedDate}\n";
        }
    }
}
