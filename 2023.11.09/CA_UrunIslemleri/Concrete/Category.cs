using CA_UrunIslemleri.Abstract;

namespace CA_UrunIslemleri.Concrete
{
    public class Category:BaseClass
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"ID: {ID} Category Name: {CategoryName} Description: {Description} Created Date: {CreatedDate}\n";
        }
    }
}
