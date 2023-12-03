/*
     Hepsi Surada

    1-ekran karti, anakart, islemci satışları yapılabilmeli.
    2-Bilgisayar satısı da yapılabilmeli.

    //ÖDEV

    MENU:
    1-Anakart Modelleri
    2-Ekran Modelleri
    3-Islemci Modelleri
    4-Hazır PC'ler
    ------------------------------------
    Seçim: 1
    1-Anakart Oluştur
    2-Anakart Listele
    --------------------------------
    Seçim: 4
    1-KF1500 Nvidia 15000
    2-SNN200 Saphire 2000

    Ürün gruplarına Kampanya dahil edin. Örnek vermek gerekirse Anakart ürün grubunda markası Asus olanlarda %5
    Amd markasına ait işlemcilerde %10
    Ekran kartı indirim uygulanmasın.
 */



using CA_HepsiSurada;
using System.Collections;

ArrayList pcListesi = new ArrayList();
string[] menuler = { "Anakart Modelleri", "Islemci Modelleri", "Ekran Karti Modelleri", "Hazir Pcler" };
byte secim = 0;
byte altMenuSecim = 0;

while (true)
{
    MenuGoster();
    secim = SecimYap();
    AltMenuGoster(secim);
    if (secim == 4)
    {
        continue;
    }
    altMenuSecim = AltMenuSecimYap();
    UrunOlustur(secim, altMenuSecim);
}



void MenuGoster()
{
    Console.WriteLine("");
    for (int i = 0; i < menuler.Length; i++)
    {
        Console.WriteLine($"{i + 1}- {menuler[i]}");
    }
}
byte SecimYap()
{
    while (true)
    {
        Console.WriteLine("");
        Console.Write("Lutfen bir secim yapiniz: ");
        try
        {
            byte secim = Convert.ToByte(Console.ReadLine());
            if (secim <= 0 || secim > menuler.Length)
            {
                Console.WriteLine("Gecerli bir secim yapiniz.");
                continue;
            }
            else
            {
                return secim;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }
    }

}
void AltMenuGoster(byte secim)
{
    switch (secim)
    {
        case 1:
            Console.WriteLine($"1- Anakart Olustur\n2- Anakart Listele");
            break;
        case 2:
            Console.WriteLine($"1- Islemci Olustur\n2- Islemci Modelleri");
            break;
        case 3:
            Console.WriteLine($"1- Ekran Karti Olustur\n2- Ekran Karti Modelleri");
            break;
        case 4:
            HazirPcListesiGoruntule();
            break;
        default:
            break;
    }
}
byte AltMenuSecimYap()
{
    while (true)
    {
        Console.WriteLine("");
        Console.Write("Lutfen bir secim yapiniz: ");
        try
        {
            byte altMenuSecim = Convert.ToByte(Console.ReadLine());
            if (altMenuSecim <= 0 || altMenuSecim > 2)
            {
                Console.WriteLine("Gecerli bir secim yapiniz.");
                continue;
            }
            else
            {
                return altMenuSecim;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }
    }
}
void UrunOlustur(byte secim, byte altMenuSecim)
{
    Bilgisayar pc = new Bilgisayar();
    switch (secim)
    {
        case 1:
            Anakart anakart = new Anakart();
            switch (altMenuSecim)
            {
                case 1:
                    Console.Write("Anakart markasini giriniz: ");
                    anakart.Marka = Console.ReadLine();
                    Console.Write("Anakart modelini giriniz: ");
                    anakart.Model = Console.ReadLine();
                    Console.Write("Anakart fiyatini giriniz: ");
                    try
                    {
                        anakart.Fiyat = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    pc.Anakart = anakart;
                    pcListesi.Add(pc.Anakart);
                    Console.WriteLine("---- Urun listeye eklendi. ----");
                    break;
                case 2:
                    Console.WriteLine("");
                    AnakartListesiGoruntule();
                    Console.WriteLine("");
                    break;
                default:
                    break;
            }
            break;

        case 2:
            Islemci islemci = new Islemci();
            switch (altMenuSecim)
            {
                case 1:
                    Console.Write("Islemci markasini giriniz: ");
                    islemci.Marka = Console.ReadLine();
                    Console.Write("Islemci modelini giriniz: ");
                    islemci.Model = Console.ReadLine();
                    Console.Write("Islemci fiyatini giriniz: ");
                    try
                    {
                        islemci.Fiyat = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    pc.Islemci = islemci;
                    pcListesi.Add(pc.Islemci);
                    Console.WriteLine("---- Urun listeye eklendi. ----");
                    break;
                case 2:
                    Console.WriteLine("");
                    IslemciListesiGoruntule();
                    Console.WriteLine("");
                    break;
                default:
                    break;
            }
            break;

        case 3:
            EkranKarti ekranKarti = new EkranKarti();
            switch (altMenuSecim)
            {
                case 1:
                    Console.Write("Ekran karti markasini giriniz: ");
                    ekranKarti.Marka = Console.ReadLine();
                    Console.Write("Ekran karti modelini giriniz: ");
                    ekranKarti.Model = Console.ReadLine();
                    Console.Write("Ekran karti fiyatini giriniz: ");
                    try
                    {
                        ekranKarti.Fiyat = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    pc.EkranKarti = ekranKarti;
                    pcListesi.Add(ekranKarti);
                    Console.WriteLine("---- Urun listeye eklendi. ----");
                    break;
                case 2:
                    Console.WriteLine("");
                    EkranKartiListesiGoruntule();
                    Console.WriteLine("");
                    break;
                default:
                    break;
            }
            break;
    }
}
void AnakartListesiGoruntule()
{
    foreach (object urun in pcListesi)
    {
        if (urun is Anakart)
        {
            Anakart mb = (Anakart)urun;
            Console.WriteLine($"Anakart marka: {mb.Marka}\nAnakart model: {mb.Model}\nAnakart fiyat: {mb.IndirimYap()}");
        }
    }
}
void IslemciListesiGoruntule()
{
    foreach (object urun in pcListesi)
    {
        if (urun is Islemci)
        {
            Islemci islemci = (Islemci)urun;
            Console.WriteLine($"Islemci marka: {islemci.Marka}\nIslemci model: {islemci.Model}\nIslemci fiyat: {islemci.IndirimYap()}");
        }
    }
}
void EkranKartiListesiGoruntule()
{
    foreach (object urun in pcListesi)
    {
        if (urun is EkranKarti)
        {
            EkranKarti ekranKarti = (EkranKarti)urun;
            Console.WriteLine($"Ekran karti marka: {ekranKarti.Marka}\nEkran karti model: {ekranKarti.Model}\nEkran karti fiyat: {ekranKarti.IndirimYap()}");
        }
    }
}
void HazirPcListesiGoruntule()
{
    foreach (object urun in pcListesi)
    {
        Console.WriteLine("");
        if (urun is Anakart)
        {
            Anakart anakart = (Anakart)urun;
            Console.WriteLine($"Anakart marka: {anakart.Marka}\nAnakart model: {anakart.Model}\nAnakart fiyat: {anakart.IndirimYap()}");
        }
        else if (urun is Islemci)
        {
            Islemci islemci = urun as Islemci;
            Console.WriteLine($"Islemci marka: {islemci.Marka}\nIslemci model: {islemci.Model}\nIslemci fiyat: {islemci.IndirimYap()}");
        }
        else if (urun is EkranKarti)
        {
            EkranKarti ekranKarti = (EkranKarti)urun;
            Console.WriteLine($"Ekran karti marka: {ekranKarti.Marka}\nEkran karti model: {ekranKarti.Model}\nEkran karti fiyat: {ekranKarti.IndirimYap()}");
        }
    }
}