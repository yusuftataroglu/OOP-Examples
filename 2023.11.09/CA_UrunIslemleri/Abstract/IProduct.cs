using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Abstract
{
    public interface IProduct
    {
        //Create
        void Create(Product product);

        //Read
        void GetProductList();

        //Update
        void Update(Product updatedProduct);

        //Delete
        void Delete(int id);

        //Get By Id
        Product GetById(int id);

        //Search
        Product SearchProduct(string value);

        //Total Product Count
        int TotalProduct();
    }
}
