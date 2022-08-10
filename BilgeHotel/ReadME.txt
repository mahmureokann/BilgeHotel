BÝLGE HOTEL

- Boþ bir proje açýldý

-> ClassLibrary DAL açýldý

- Entity klasörü açýldý ve entityler eklendi ve iliþkilendirmeler yapýldý.

-Entity klasorüne BaseEntity classý açýldý.Tüm entityler, BaseEntityden miras alýyorlar.Bunun sebebi ise BLL'de Crud iþlemlerini yapabilmek.

- Enum klasoru açýldý. Title enumý açýldý.7 resepsiyon görevlisi, 11 temizlik görevlisi, 11 aþçý, 13 garson,1 elektrikçi, 1 bilgi iþlem sorumlusu, Yönetici(insan kaynaklarý),Satýþ departmaný yöneticisi,resepsiyon þefi, IT sorumlusu

- Enum klasoru içerisine Oda Türü için enum açýldý.

- Map adýnda bir klasör açýldý.Ýçerisine map claslarý açýldý ve  EntityTypeConfiguration miras verildi.Böylece Geçilebilir , geçilemez alanlarý ayarlandý.

- Context klasoru açýldý.Ýçerisine ProjectContext classý eklendi. DbContext miras verildi ve console yardýmý ile sql server'a baðlanýldý

- Configuration'da ki  Seed methodunda veriler eklendi. Enumlar sqlde sayý numarasý olarak geliyor.

-> ClassLibrary BLL açýldý.

- DataAcsess katmanýndan referans verildi ve EntityFramework indirildi.

- BLL katmaný içerisine Repository adýnda bir klasör açýldý. Ýçerisine BaseRepository classý ve IRepository adlý bir interface açýldý.

- BaseRepository içerisinde tüm classlar için ortak olan crud iþlemleri var.Farklýlýk gösteren methodlar için ise Service adlý bir class içerisinde olacak.Bu yüzden BLL katmaný Concrete adýnda bir klasor açtým.

-> Çalýþanlarýn görebileceði WFA projesi açýldý.

- ChildForm eklendi

- Çalýþanlar listelemek, eklemek, çýkarmak ve güncellemek için design iþlemi yapýldý.

- Employee için Listeleme ekleme güncelleme ve silme iþlemleri yapýldý.

- Vardiya için crud iþlemleri yapýldý.

- Müþteri bilgileri listelendi.

- Oda Tipi için crud iþlemleri yapýldý.

- Tatil paketleri için Crud iþlemleri yapýldý.

- Rezervasyon bilgileri listelendi.

- Login iþlemi için form tasarýmý oluþturuldu.Calisanlarýn ve yöneticilerin girdikleri form olarak ikiye ayrýldý.Bir sürü form var ama olsun :))) Calisanlar = CalisanMenuForm , Yonetici = MenuForm

- Login iþlemi için Calisan isen kullanýcý ad= calisan , þifre = 123 // Yönetici isen kullanýcý ad= yonetici , þifre = 123

-> ASP.net framework MVC seçilerek, MVC projesi oluþturuldu.Tüm projelerden referans verildi.Entity framework kurulumu yapýldý.

- Models klasörü içerisinde AppUserVM classý açýldý ve email , þifre uyarýlarý gerçekleþtirildi.

- WEbUI projesi icerisine bootstrap ve jquery yuklemesi yapildi.

- Models klasörü içerisine AppUserVM, Cart ve CartVM classlarý açýldý. Müþterilerin login iþlemini gerçekleþtirebilmesi için AppUserVM içerisine mail ve þifre iþlemleri için bilgiler yazýldý. CartItemVM classý içerisine toplam fiyat iþlemi gerçekleþtirildi. Carta rezervasyon bilgileri eklenirken kullanýlasý için Cart classý oluþturuldu.

- HomeController içerisinde müþteri giriþi için Cart,Register ve Login Controllerlarý oluþturuldu.

- Contact sayfasý oluþturuldu.










