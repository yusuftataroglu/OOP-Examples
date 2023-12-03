using CA_UrunIslemleri.Abstract;
using CA_UrunIslemleri.Data;
using CA_UrunIslemleri.Utils;

namespace CA_UrunIslemleri.Concrete
{
    public class CategoryConcrete : ICategory
    {
        public void Create()
        {
            try
            {
                Category category = new Category();
                Console.Write("Kategori ID'si giriniz: ");
                category.ID = Convert.ToInt32(Console.ReadLine());
                foreach (Category item in CategoryData.CategoryList)
                {
                    if (item.ID == category.ID)
                    {
                        Message.FailureMessage("Bu ID'ye sahip bir kategori mevcut!");
                        Create();
                    }
                    else
                    {
                        Console.Write("Kategori adi giriniz: ");
                        category.CategoryName = Console.ReadLine();
                        Console.Write("Kategori aciklamasi giriniz: ");
                        category.Description = Console.ReadLine();
                        CategoryData.CategoryList.Add(category);
                        Message.SuccessMessage("*****Kategori eklendi.*****");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void Delete()
        {
            int id = 0;
            Console.Write("Silinecek kategorinin ID'sini giriniz: ");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Delete();
            }
            foreach (Category item in CategoryData.CategoryList)
            {
                if (item.ID == id)
                {
                    CategoryData.CategoryList.Remove(item);
                    Message.SuccessMessage("*****Kategori silindi.*****");
                    break;
                }               
            }
            Message.InfoMessage("-----Boyle bir kategori bulunamadı.-----");

        }

        public void GetCategoryList()
        {
            Console.WriteLine("------Category List------");
            foreach (Category category in CategoryData.CategoryList)
            {
                Console.WriteLine(category.ToString());
            }
        }

        public Category GetById()
        {
            int id = 0;
            Console.Write("Kategori ID'sini giriniz: ");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetById();
            }
            foreach (Category category in CategoryData.CategoryList)
            {
                if (category.ID == id)
                {
                    return category;
                }
            }
            Message.InfoMessage("-----Kategori bulunamadi.-----");
            return null;
        }

        public Category SearchCategory()
        {
            Console.Write("Kategori adi giriniz: ");
            string categoryName = Console.ReadLine();
            foreach (Category category in CategoryData.CategoryList)
            {
                if (category.CategoryName.ToLower() == categoryName.ToLower()) ;
                {
                    return category;
                }
            }
            Message.InfoMessage("-----Kategori bulunamadi.-----");
            return null;
        }

        public int TotalCategory()
        {
            return CategoryData.CategoryList.Count;
        }

        public void Update()
        {
            Category updatedCategory = new Category();
            Console.Write("Guncellemek istediginiz kategorinin ID'sini giriniz: ");
            try
            {
                updatedCategory.ID = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Update();
            }
            foreach (Category category in CategoryData.CategoryList)
            {
                if (category.ID == updatedCategory.ID)
                {            
                    category.ID = updatedCategory.ID;
                    Console.Write("Kategori adi: ");
                    updatedCategory.CategoryName = Console.ReadLine();
                    category.CategoryName = updatedCategory.CategoryName;
                    Console.Write("Kategori aciklamasi: ");
                    updatedCategory.Description = Console.ReadLine();
                    category.Description = updatedCategory.Description;
                    Message.SuccessMessage("*****Kategori bilgileri guncellendi.*****");
                    break;
                }
            }
            Message.InfoMessage("-----Kategori bulunamadi.-----");
        }
    }
}
