namespace CA_UrunIslemleri.Abstract
{
    public abstract class BaseClass
    {
        public int ID { get; set; }
        public static DateTime CreatedDate { get; set; }

        public BaseClass()
        {
            CreatedDate = DateTime.Now;
        }


    }
}
