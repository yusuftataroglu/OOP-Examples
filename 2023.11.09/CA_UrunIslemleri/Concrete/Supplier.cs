using CA_UrunIslemleri.Abstract;

namespace CA_UrunIslemleri.Concrete
{
    public class Supplier:BaseClass
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public override string ToString()
        {
            return $"ID: {ID} Company Name: {CompanyName} Contact Name: {ContactName} Contact Title: {ContactTitle} Created Date: {CreatedDate}\n";
        }
    }
}
