//Abstract Klas�r�: Projede kullan�lacak soyut classlar bu klas�rde bar�n�rlar.
	--BaseClass: B�t�n classlarda olmas�n� istedi�imiz �zellik ve metotlar bu class i�erisinde tan�mland�.
	--ICategory: Kategori ile ilgili yap�lacak olan b�t�n i�lemler bu interface i�erisinde bar�nacak.
//Concrete Klas�r�: Soyut (Abstract/Interface) t�retilen class'lar bu klas�rde bar�n�rlar.
	--Category: BaseClass'dan miras alarak BaseClass'�n �zelliklerini kendi �zelliklerine dahil ettik.
	--CategoryConcrete: ICategory interface'den miras aalrak ilgili i�lemleri b�nyesinde bar�nd�ran somu class'd�r. CREATE,READ,UPDATE,DELETE

//Utils:
	--Menu: Program.cs taraf�nda kullana�lcak olan metotlar� ve �zellikleri i�eren class'd�r. 
	//�lerleyen etaplarda bilgilendirme, durum mesajlar�, men�ler, alt men�ler, hata i�lemleri vs.. gibi i�lemler bu klas�r i�erisinde bar�nacak.


//AppUser, Product, Supplier, Customer classlar�n� da kullanarak projeyi tamamlay�n.

	//AppUser: Kullan�c�lar� temsil edecek. Prpje start oldu�unda Console'dan giri� yap�lmas� sa�lanacak. Giri� yap�lmadan i�lemler ger�ekle�tirilmeyecek.
	//Username
	//Password
	//Email
	//First name
	//Last name
//Login i�lemi i�in sadece username ve password ihtiya� olacak.
	//Yap�lan her i�lemde kullan�c� bilgileri kaydedilecek.

//Product, Supplier, Customer classlar� i�in tan�mlanacak ilgili �zelliklere Northwind veritaban�ndan ula�abilirsiniz