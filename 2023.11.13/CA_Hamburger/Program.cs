//Hamburger 

/*
 *   Kullanıcı
    -Kullanıcı ad
    -şifre
    -Ad
    -Soyad
    -Adres
 * Sisteme Giriş İşlemi
 * Kullanıcı adı ve şifre
    Menu
    1-Whooper 100 TL
    2-BigMc 120 TL
    3-McTurco 150 TL
    4-Siparişler
seçim: 1


    Ekstra
    1-Ketçap, 5 TL
    2-Mayonez, 5 TL
    3-Buffalo, 7.5 TL
    4-Hardal, 6 TL

birden fazla ekstra seçimi istenildiği takdirde gerçekleştirilsin, kullanıcı ekstra yı boş olarak da geçebilsin.

    Ekstra seçin: 1,2,2,3,4

Adet: 2


    Sipariş
    -Menu
    -Adet
    -Toplam Fiyat
    -Kullanıcı
    
 --sipariş bilgisi console'da yazdırılacak.



//Introduction kurallarını kullanarak değil, (Yapısal programlama), OOP ile gerçekleştirelecek.



 */

using CA_Hamburger.Concretes;
using CA_Hamburger.Model;
using CA_Hamburger.Utils;

//global değişkenler
Siparis siparis = new Siparis();
MenuConcrete menuConcrete = new MenuConcrete();
EkstraConcrete ekstraConrete = new EkstraConcrete();
int adet = 0;


//Menü gösterme işlemi
menuConcrete.GetMenu();

//Menü seçim işlemi
menuConcrete.SelectMenu();

//Ektra menüsü gösterme işlemi
ekstraConrete.GetEkstraMenu();

//Ekstra seçim işlemi
ekstraConrete.SelectEkstraMenu();

//Seçili ekstra adlarının gösterilmesi.
Console.WriteLine(ekstraConrete.GetSelectedEkstrasNames());

//Adet miktarının alınması
adet = Quantity.GetQuantity();

//Toplam tutarın hesaplanması
Price.GetTotalPrice(adet);

//Siparis bilgilerinin gösterilmesi
FinalOrder.WriteFinalOrder();
