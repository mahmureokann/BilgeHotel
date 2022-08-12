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

- Contact sayfas� olu�turuldu.About sayfas� olu�turuldu. 

- Auth Filter(Oturumun a��lmamas� durumunda login sayfas�na geri aktar�r.) ve Exception Filter(Bu filtre sayesinde kullan�c�lar�m�za, olas� hata durumlar�nda hata sayfalar�yla a��klama yapabilir ve istedi�imiz �ekilde y�nlendirme i�lemini ger�ekle�tirebiliyoruz.Hata almam�z durumunda bizim ex filter�m�z bizi index sayfas�na geri y�nlendirecek.), projeye Custom Filter klasoru alt�nda olu�turuldu.

- Index sayfas� olu�turuldu.Rezervasyon ve Tatil paketleri viewleri bitmek �zere fakat MyCart viewinde CartVM class�na ula�am�yorum. PROJEDEK� SIKINTILAR DEVAM ETMEKTE! 

<!--@{
    ViewBag.Title = "MyCart";
    Layout = "~/Views/Shared/_Layout.cshtml";
    WebUI.Models.CartVM sepet = Session["scart"] as WebUI.Models.CartVM;
    decimal? totalPrice = 0;

    //CartVM sessionCart = Session["scart"] as CartVM; //Unboxing



}

<div class="row">
    <div class="col-md-9">
        <table class="table table-responsive">
            <thead>
                <tr>
                    <th>Tatil Paketi</th>
                    <th>Oda Tipi</th>
                    <th>Rezervasyon Ba�lang�� Tarihi</th>
                    <th>Rezervasyon Biti� Tarihi</th>
                    <th>Toplam Fiyat</th>
                </tr>
            </thead>
            <tbody>
                @foreach (var item in sepet.myCart)
                {
                    totalPrice += item.SubTotal;
                    <tr>
                        <td>@item.HolidayPackage</td>
                        <td>@item.RoomType</td>-->
@* Ekleme yapmak gerekebilir! *@
<!--<td>@item.SubTotal</td>
                </tr>
            }
        </tbody>
    </table>
</div>
<div class="col-md-3">
    <div class="card">
        <div class="card-header">
        </div>
        <div class="card-body">
            <div class="d-flex justify-content-between">-->
@*verileri yan yana yazdirmamizi saglar*@
<!--<h5>Genel Toplam: </h5>
                    <h5> @totalPrice TL</h5>
                </div>
                <div class="col-md-12 mt-5">
                    @Html.ActionLink("Rezervasyonu Tamamla", "CompleteCart", "Home", null, new { @class = "btn btn-primary" })
                    @Html.ActionLink("Devam Et", "Index", "Home", null, new { @class = "btn" })
                </div>
            </div>
        </div>
    </div>
</div>
<br />-->











