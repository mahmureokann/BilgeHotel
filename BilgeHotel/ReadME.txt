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

- Contact sayfasý oluþturuldu.About sayfasý oluþturuldu. 

- Auth Filter(Oturumun açýlmamasý durumunda login sayfasýna geri aktarýr.) ve Exception Filter(Bu filtre sayesinde kullanýcýlarýmýza, olasý hata durumlarýnda hata sayfalarýyla açýklama yapabilir ve istediðimiz þekilde yönlendirme iþlemini gerçekleþtirebiliyoruz.Hata almamýz durumunda bizim ex filterýmýz bizi index sayfasýna geri yönlendirecek.), projeye Custom Filter klasoru altýnda oluþturuldu.

- Index sayfasý oluþturuldu.Rezervasyon ve Tatil paketleri viewleri bitmek üzere fakat MyCart viewinde CartVM classýna ulaþamýyorum. PROJEDEKÝ SIKINTILAR DEVAM ETMEKTE! 

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
                    <th>Rezervasyon Baþlangýç Tarihi</th>
                    <th>Rezervasyon Bitiþ Tarihi</th>
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











