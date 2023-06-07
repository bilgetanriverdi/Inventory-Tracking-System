# Demirbaş Takip Uygulaması

## Proje Adımları:
### 1) Veri Toplama & Problem Tespiti
### 2) Sistem Analizi ve Tasarımı
### 3) Arayüz Tasarımı
### 4) Veritabanı Tasarımı
### 5) Kodlama

---

```
Bu lisans tezi kapsamında; Saint Joseph Lisesi Eğitim Vakfı Özel Küçük Prens Okulları’nda kullanılan demirbaş sisteminde
geliştirmeler ve iyileştirmeler yapılmıştır. Bu projeye başlarken kurumda zorlandığımız durumların tespiti yapılmıştır.
Bu zorlu tespitler, demirbaş takibi yapan departman çalışanlarından soru-cevap şeklinde elde edilmiştir. Elde edilen veriler 
ile projeye tam olarak nasıl başlanılacağına karar verilmiştir. Bu veriler tespit edilen problemler tablosuna işlenmiştir.
Karşılaşılan sorunlar, bu tablo sayesinde net ifadeler halinde görülmektedir. Fonksiyonel gereksinimlerde ise adım adım
geliştirmeler ve iyileştirilmeler yapılmıştır. Ardından tablolar ve çizilen modellerin iş süreç mühendisliği kapsamında
akış modelleri tasarlanmıştır. Ardından SQL Server uygulaması ile,bu tasarlanan sistemin veritabanı tasarlanmış olup tablo ilişkilendirilmeleri yapılmıştır. Bu ilişkiler, demirbaş türü tablosundaki isimlerini demirbaş sayfasına combobox şeklinde
çekebilme gibi imkanlar sağlamıştır. Ayrıca oluşturulan stored procedure sayesinde datagridview üzerinde birden fazla tablo verisi gösterime olanak sağlamıştır. Veritabanı tasarımı tamamlandıktan sonra basit bir windows form arayüzü tasarlanıp gerekli
C# kodları yazılmıştır.
```

### Uygulamanın Mimari Yapısı

![uygulamanın mimari yapısı](http://r.resimlink.com/Tf_cguKxkdU.png)

---

### Arayüz Tasarımları

Giriş Ekranı

![giriş ekranı](http://r.resimlink.com/Tf_cguKxkdU.png)


Ana Sayfa

![ana sayfa](http://r.resimlink.com/wnKoVSDEOCib.png)


Demirbaş Sayfası

![demirbaş sayfası](http://r.resimlink.com/Z31rMVK4.png)


Barkod Sayfası

![barkod sayfası](http://r.resimlink.com/n_mtcrjVC.png)

```
Textboxa girilen numaraya göre bir barkod görüntüsü oluşturuluyor ve bu görüntü picturebox aracılığıyla görüntüleniyor.
Yazdır butonu buradaki görüntüyü alıp pdf formatında bilgisayara kaydedildikten sonra yazdırma olanağı sağlıyor.
```

---

### Projenin Sonuçları

Elde edilen anket verilerinden yola çıkarak geliştirilecek uygulamada; oluşturulması gereken ana noktalar demirbaş ekleme, 
demirbaş güncelleme, fatura bilgisi ekleme, mahal ekleme, personel ekleme ve barkod oluşturma noktalarıdır. Aynı barkod
numarasıyla birden fazla kayıdın var olması sorunu, geliştirilen uygulama sayesinde çözülmüştür. Oluşturulan demirbaş ekleme
modeli, eklenmek istenen barkod numarasının önce sistemde olup olmadığını kontrol edip yoksa sisteme kaydedilmesine izin verecek
şekilde geliştirilmiştir. Verilerin excel dosyasına çekilebilmesi ise eski sistemde hiç yer almayan bir adımdı. Barkod yazdırma
işlemi ise, barkod görüntüsünü kaydedip çıktı almasına imkan tanıdığından barkod yazıcısı olmasa bile çıktı alımı yapılıp
gerekli demirbaşlara yapıştırılabilir.
