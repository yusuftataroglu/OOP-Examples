//Abstract Klasörü: Projede kullanýlacak soyut classlar bu klasörde barýnýrlar.
	--BaseClass: Bütün classlarda olmasýný istediðimiz özellik ve metotlar bu class içerisinde tanýmlandý.
	--ICategory: Kategori ile ilgili yapýlacak olan bütün iþlemler bu interface içerisinde barýnacak.
//Concrete Klasörü: Soyut (Abstract/Interface) türetilen class'lar bu klasörde barýnýrlar.
	--Category: BaseClass'dan miras alarak BaseClass'ýn özelliklerini kendi özelliklerine dahil ettik.
	--CategoryConcrete: ICategory interface'den miras aalrak ilgili iþlemleri bünyesinde barýndýran somu class'dýr. CREATE,READ,UPDATE,DELETE

//Utils:
	--Menu: Program.cs tarafýnda kullanaýlcak olan metotlarý ve özellikleri içeren class'dýr. 
	//Ýlerleyen etaplarda bilgilendirme, durum mesajlarý, menüler, alt menüler, hata iþlemleri vs.. gibi iþlemler bu klasör içerisinde barýnacak.


//AppUser, Product, Supplier, Customer classlarýný da kullanarak projeyi tamamlayýn.

	//AppUser: Kullanýcýlarý temsil edecek. Prpje start olduðunda Console'dan giriþ yapýlmasý saðlanacak. Giriþ yapýlmadan iþlemler gerçekleþtirilmeyecek.
	//Username
	//Password
	//Email
	//First name
	//Last name
//Login iþlemi için sadece username ve password ihtiyaç olacak.
	//Yapýlan her iþlemde kullanýcý bilgileri kaydedilecek.

//Product, Supplier, Customer classlarý için tanýmlanacak ilgili özelliklere Northwind veritabanýndan ulaþabilirsiniz