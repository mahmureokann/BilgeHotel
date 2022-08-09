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

- 



<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/Content/bootstrap")
</head>
<body>


    <nav class="navbar navbar-expand-lg bg-light navbar navbar-dark bg-dark">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">
                Bilge Hotel
            </a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">Hakkýmýzda</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Galeri</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Rezervasyon</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Bize ulaþýn</a>
                    </li>
                   
                </ul>
                <form class="d-flex" role="search">
                  
                    <button type="button" class="btn btn-outline-warning me-2">Kayýt Ol!</button>
                    <button type="button" class="btn btn-outline-success">Giriþ Yap!</button>

                    @RenderBody()
                </form>
            </div>
        </div>
    </nav>


    @Scripts.Render("~/content/jquery")
    @Scripts.Render("~/content/bootstrap")
    @RenderSection("scripts", required: false)
</body>
</html>







