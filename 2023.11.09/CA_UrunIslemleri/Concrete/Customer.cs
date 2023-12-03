using CA_UrunIslemleri.Abstract;

namespace CA_UrunIslemleri.Concrete
{
    public class Customer:BaseClass
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return $"ID: {ID} Company Name: {CompanyName} Contact Name: {ContactName} Contact Title: {ContactTitle} Country: {Country} Phone: {Phone} Created Date: {CreatedDate}\n";
        }
    }
}
