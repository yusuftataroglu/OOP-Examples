using CA_UrunIslemleri.Abstract;
using CA_UrunIslemleri.Data;
using CA_UrunIslemleri.Utils;

namespace CA_UrunIslemleri.Concrete
{
    public class ProductConcrete
    {
        public void Create(Product product)
        {
            ProductData.ProductList.Add(product);
            //Product.CreatedDate = BaseClass.CreateDate();
            Message.SuccessMessage("*****Urun eklendi.*****");
        }


        public void Delete(int id)
        {
            foreach (Product item in ProductData.ProductList)
            {
                if (item.ID == id)
                {
                    ProductData.ProductList.Remove(item);
                    Message.SuccessMessage("*****Urun silindi.*****");
                    break;
                }
                else
                {
                    Message.InfoMessage("-----Boyle bir urun bulunamadı.-----");
                }
            }
            
        }

        public void GetProductList()
        {
            Console.WriteLine("------Product List------");
            foreach (Product product in ProductData.ProductList)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public Product GetById(int id)
        {
            foreach (Product product in ProductData.ProductList)
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            Message.InfoMessage("-----Urun bulunamadi.-----");
            return null;
        }

        public Product SearchProduct(string productName)
        {
            foreach (Product product in ProductData.ProductList)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }
            Message.InfoMessage("-----Urun bulunamadi.-----");
            return null;
        }

        public int TotalProduct()
        {
            return ProductData.ProductList.Count;
        }

        public void Update(Product updatedProduct)
        {
            foreach (Product product in ProductData.ProductList)
            {
                if (product.ID == updatedProduct.ID)
                {
                    product.ID = updatedProduct.ID;
                    product.ProductName = updatedProduct.ProductName;
                    product.UnitPrice = updatedProduct.UnitPrice;
                    product.UnitsInStock = updatedProduct.UnitsInStock;
                    //Product.CreatedDate = BaseClass.CreateDate();
                    Message.SuccessMessage("*****Urun bilgileri guncellendi.*****");
                    break;
                }
                else
                {
                    Message.InfoMessage("-----Urun bulunamadi.-----");
                }
            }
            
        }
    }
}
