B�LGE HOTEL

- Bo� bir proje a��ld�

-> ClassLibrary DAL a��ld�

- Entity klas�r� a��ld� ve entityler eklendi ve ili�kilendirmeler yap�ld�.

-Entity klasor�ne BaseEntity class� a��ld�.T�m entityler, BaseEntityden miras al�yorlar.Bunun sebebi ise BLL'de Crud i�lemlerini yapabilmek.

- Enum klasoru a��ld�. Title enum� a��ld�.7 resepsiyon g�revlisi, 11 temizlik g�revlisi, 11 a���, 13 garson,1 elektrik�i, 1 bilgi i�lem sorumlusu, Y�netici(insan kaynaklar�),Sat�� departman� y�neticisi,resepsiyon �efi, IT sorumlusu

- Enum klasoru i�erisine Oda T�r� i�in enum a��ld�.

- Map ad�nda bir klas�r a��ld�.��erisine map claslar� a��ld� ve  EntityTypeConfiguration miras verildi.B�ylece Ge�ilebilir , ge�ilemez alanlar� ayarland�.

- Context klasoru a��ld�.��erisine ProjectContext class� eklendi. DbContext miras verildi ve console yard�m� ile sql server'a ba�lan�ld�

- Configuration'da ki  Seed methodunda veriler eklendi. Enumlar sqlde say� numaras� olarak geliyor.

-> ClassLibrary BLL a��ld�.

- DataAcsess katman�ndan referans verildi ve EntityFramework indirildi.

- BLL katman� i�erisine Repository ad�nda bir klas�r a��ld�. ��erisine BaseRepository class� ve IRepository adl� bir interface a��ld�.

- BaseRepository i�erisinde t�m classlar i�in ortak olan crud i�lemleri var.Farkl�l�k g�steren methodlar i�in ise Service adl� bir class i�erisinde olacak.Bu y�zden BLL katman� Concrete ad�nda bir klasor a�t�m.

-> �al��anlar�n g�rebilece�i WFA projesi a��ld�.

- ChildForm eklendi

- �al��anlar listelemek, eklemek, ��karmak ve g�ncellemek i�in design i�lemi yap�ld�.

- Employee i�in Listeleme ekleme g�ncelleme ve silme i�lemleri yap�ld�.

- Vardiya i�in crud i�lemleri yap�ld�.

- M��teri bilgileri listelendi.

- Oda Tipi i�in crud i�lemleri yap�ld�.

- Tatil paketleri i�in Crud i�lemleri yap�ld�.

- Rezervasyon bilgileri listelendi.

- Login i�lemi i�in form tasar�m� olu�turuldu.Calisanlar�n ve y�neticilerin girdikleri form olarak ikiye ayr�ld�.Bir s�r� form var ama olsun :))) Calisanlar = CalisanMenuForm , Yonetici = MenuForm

- Login i�lemi i�in Calisan isen kullan�c� ad= calisan , �ifre = 123 // Y�netici isen kullan�c� ad= yonetici , �ifre = 123

-> ASP.net framework MVC se�ilerek, MVC projesi olu�turuldu.T�m projelerden referans verildi.Entity framework kurulumu yap�ld�.

- Models klas�r� i�erisinde AppUserVM class� a��ld� ve email , �ifre uyar�lar� ger�ekle�tirildi.

- WEbUI projesi icerisine bootstrap ve jquery yuklemesi yapildi.

- Models klas�r� i�erisine AppUserVM, Cart ve CartVM classlar� a��ld�. M��terilerin login i�lemini ger�ekle�tirebilmesi i�in AppUserVM i�erisine mail ve �ifre i�lemleri i�in bilgiler yaz�ld�. CartItemVM class� i�erisine toplam fiyat i�lemi ger�ekle�tirildi. Carta rezervasyon bilgileri eklenirken kullan�las� i�in Cart class� olu�turuldu.

- HomeController i�erisinde m��teri giri�i i�in Cart,Register ve Login Controllerlar� olu�turuldu.

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
                        <a class="nav-link active" aria-current="page" href="#">Hakk�m�zda</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Galeri</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Rezervasyon</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Bize ula��n</a>
                    </li>
                   
                </ul>
                <form class="d-flex" role="search">
                  
                    <button type="button" class="btn btn-outline-warning me-2">Kay�t Ol!</button>
                    <button type="button" class="btn btn-outline-success">Giri� Yap!</button>

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







