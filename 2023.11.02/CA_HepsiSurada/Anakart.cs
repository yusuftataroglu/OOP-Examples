namespace CA_HepsiSurada
{
    internal class Anakart
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        private decimal _fiyat;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            } 
            set
            {
                if (value<0)
                {
                    _fiyat = 0;
                }
                else
                {
                    _fiyat = value;
                }
            }
        }
    }
}
