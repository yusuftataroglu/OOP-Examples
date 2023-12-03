namespace CA_HepsiSurada
{
    internal class Anakart:Bilgisayar
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override decimal IndirimYap()
        {
            if (Marka.ToLower() == "asus")
            {
                return Fiyat * (1M - 0.05M);
            }
            else
            {
                return base.IndirimYap();
            }
        }
    }
}
