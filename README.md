# 🎀 MVC Proje Kampı: Dinamik Sözlük Uygulaması
Merhaba! 🌸
Bu proje, Murat Yücedağ’ın Youtube’daki MVC Proje Kampı eğitim serisinden ilham alarak geliştirdiğim, N-katmanlı mimariyi ve SOLID prensiplerini temel alan bir dinamik sözlük platformudur.
## 🚀 Projenin Genel Özellikleri
🔹N-Katmanlı Mimari: Katmanlar arası bağımsızlık ve kod tekrarını azaltan modern yapı. </br>
🔹SOLID Prensipleri: Temiz, sürdürülebilir ve ölçeklenebilir kod anlayışı.</br>
🔹Yetkilendirme ve Kimlik Doğrulama: Admin ve yazar rolleriyle güvenli giriş sistemi.</br>
## 🛠️ Proje Katmanları
🔹**Presentation Layer:** Kullanıcıya sunulan web arayüzü.</br>
🔹**Business Layer:** İş kurallarının ve validasyonların merkezi.</br>
🔹**Data Access Layer:** Entity Framework ile veri erişimi.</br>
🔹**Entity Layer:** Veritabanı tablolarına karşılık gelen modeller.</br>
## 🖥️ Modüller
🔹**Admin Paneli:** Kategoriler, başlıklar, yazılar, yazarlar ve mesajlar üzerinde tam kontrol.</br>
🔹**Yazar Paneli:** Başlık oluşturma, yazı yazma, mesajlaşma ve profil yönetimi.</br>
🔹**Sözlük Paneli:** Giriş yapmadan içerik görüntüleme imkânı.</br>
🔹**Vitrin/Ana Sayfa:** Proje teknolojileri ve yaklaşımının özetlendiği hoş bir tanıtım alanı.</br>
## 💻 Kullanılan Teknolojiler
🔹ASP.NET MVC 5 </br>
🔹Entity Framework (Code First) </br>
🔹C# </br>
🔹SQL Server </br>
🔹Kurumsal Yazılım Mimari Pratikleri </br>
## 🔐 Giriş Sistemi
### 🧑🏻‍💻 Admin Paneli
#### 🔓 LogIn Paneli
Admin kullanıcıları için özel olarak tasarlanan bu giriş ekranı, yalnızca yetkili kişilerin yönetim paneline erişebilmesini sağlar. Giriş bilgileri, veritabanındaki kayıtlı verilerle dinamik bir şekilde eşleşecek şekilde yapılandırılmıştır. Bu güvenli ve esnek yapıyı kurarken, oturum yönetimi için **Session** mekanizmasından yararlandım. Böylece hem kullanıcı deneyimini iyileştirdim hem de sistemin güvenliğini artırdım.

![Image](https://github.com/user-attachments/assets/0bc493fd-a13c-420d-9dc6-d4f041781562)

#### 📱 Kategori Paneli
Admin girişi başarılı olan kullanıcıyı karşılayan ilk ekran, kategori yönetim panelidir. Bu alanda mevcut kategoriler şık ve anlaşılır bir biçimde listelenir. Kullanıcı, ekleme, düzenleme, pasif/aktif duruma alma gibi temel CRUD işlemlerini kolaylıkla gerçekleştirebilir. “Başlıklar” butonu aracılığıyla ilgili kategorinin alt başlıklarına erişebilir. Silme işlemi fiziksel olarak veri silmek yerine, veri bütünlüğünü korumak adına yalnızca görünürlük durumunu değiştirir. Bu yapı, yönetim süreçlerini hem güvenli hem de esnek hale getirir.

![Image](https://github.com/user-attachments/assets/c0007c54-a339-4d4c-895f-1f5b20ddb495)

#### 🔖 Başlıklar Paneli
Admin panelinde, sisteme kaydedilmiş tüm başlık bilgilerine kolaylıkla erişim sağlanabilir. Her başlığın sağında yer alan “Yazılar” butonu ile o başlığa ait içerikler detaylı olarak görüntülenebilir. Yönetici, “Sil” butonu sayesinde fiziksel veri kaybı yaşatmadan, başlıkların aktiflik durumunu pratik bir şekilde değiştirebilir. Bu özellik, içerik kontrolünü daha esnek ve güvenli hale getirirken, kullanıcı dostu arayüzüyle de yönetimi keyifli kılar.

![Image](https://github.com/user-attachments/assets/62bfbe02-885c-4363-afee-5115628ce7a5)

#### ✍🏼 Yazarlar Paneli
Admin, sisteme kayıtlı tüm yazarları bu alanda detaylı bir şekilde görüntüleyebilir. Dilerse ilgili yazarın paylaştığı içeriklere de kolayca ulaşabilir.

![Image](https://github.com/user-attachments/assets/a1c6b5c0-41cb-4bd2-8705-0066cd2450e8)

#### 📨 Mesajlar Paneli
Yöneticiler, gelen kutusunda yazarlardan kendilerine iletilen mesajları görüntüleyebilir; gönderilenler kısmında ise yazarlara gönderdikleri mesajları inceleyebilir. Her bir mesaja tıklayarak içeriğine doğrudan erişim sağlayabilirler.

![Image](https://github.com/user-attachments/assets/5f952b03-377d-4379-9ff1-92443f79f2f6)

#### 🚫 Hata Sayfası Paneli

![Image](https://github.com/user-attachments/assets/5750a407-2b61-42f5-b47a-feb753199f10)

#### 🌐 Siteye Git Paneli
Bu bölüme tıklandığında Vitrin bölümünün Ana sayfasına ulaşılabilir.

### ✍🏼 Yazar Paneli
#### 🔓 Yazar LogIn Paneli
Yetkilendirilmiş yazarlar, doğru e-posta ve şifre bilgileriyle sisteme güvenli bir şekilde giriş yaparak kendilerine özel yazar paneline ulaşabilirler.

![Image](https://github.com/user-attachments/assets/84a4e925-8649-4ef8-99ad-b71780e8a023)

#### 🪪 Profilim Paneli
Yazarların giriş sonrası karşılaştığı ilk ekran olan 'Profilim' sayfasında, kendilerine ait kişisel bilgileri görüntüleyebilir ve dilerlerse güncelleyebilirler.

![Image](https://github.com/user-attachments/assets/241d3feb-f9df-44ec-872c-3af732c4f8be)

#### 📣 Başlıklarım Paneli
Yazarlar, “İçerikler” bölümünde kendi oluşturdukları başlıkları listeler. İster yeni başlık ekleyebilir, ister mevcut başlıkları düzenleyebilir ya da pasif hale getirebilirler. Tüm işlemler kullanıcı dostu butonlar aracılığıyla sağlanır.

![Image](https://github.com/user-attachments/assets/65a68ee4-39eb-429c-a3a1-ccad56b26f22)

#### 📣 Tüm Başlıklar Paneli
Tüm oluşturulmuş başlıkların yer aldığı bu alanda yazarlar diledikleri başlığı inceleyebilir ve “Bu Başlığa Yaz” seçeneği ile yorumlarını paylaşabilirler.

![Image](https://github.com/user-attachments/assets/360c426d-91e0-4cdc-8ef0-1c909aa45bc0)

#### 📝 Yazılarım Paneli
Yazarlar, sisteme daha önce kendi girdikleri tüm içerikleri bu panelde toplu olarak görüntüleyebilir.

![Image](https://github.com/user-attachments/assets/fb985916-393f-4e12-b23c-cd84bc22e946)

#### 📨 Mesajlar Paneli
Adminler, mesaj yönetimi alanında yazarlardan gelen mesajları kolayca görebilir; aynı zamanda gönderdikleri iletileri de takip edebilir. Her bir mesajın içeriğine detaylı erişim, listeden ilgili mesaja tıklanarak sağlanır.

![Image](https://github.com/user-attachments/assets/fb6d13a1-a04e-4ae5-8053-cc432a6da749)

#### 🌐 Siteye Git Paneli
Bu bölüme tıklandığında Vitrin bölümünün Ana sayfasına ulaşılabilir.

## 🌐 Anasayfa Paneli(Vitrin)
### 🪄 Ana Sayfa
Bu alanda, kullanıcıya ait temel bilgilerle birlikte şık bir menü sunulmaktadır. Menüde yer alan 'Sözlük' seçeneğine tıklandığında kullanıcı, doğrudan sözlük sayfasına yönlendirilir.

![Image](https://github.com/user-attachments/assets/69b4844b-53a6-47cc-914d-daf7bbad519e)

### 🧩 Kullandığım Geliştirme Bileşenleri Paneli
 Projeyi geliştirirken aktif olarak kullandığım teknolojiler bu bölümde yer almakta. Tercih ettiğim araçlar, projenin mimarisine uygun olarak özenle seçilmiştir.

 ![Image](https://github.com/user-attachments/assets/97fc5cde-1042-4fad-985f-356268610c13)

 ### 💎 Proje Hakkında Paneli
 Projenin geliştirme sürecinde izlediğim adımları ve uyguladığım yöntemleri bu alanda detaylı şekilde paylaşmaya çalıştım.

 ![Image](https://github.com/user-attachments/assets/edf222ed-dab5-4bf9-be56-08c35c80f225)

 ### 🎨 Görseller Paneli
 Projeye ait görseller burada bulunur.

 ![Image](https://github.com/user-attachments/assets/60b6f405-3ab2-4325-86a6-db61b7515d52)

 ### 📜 Projeye Dair Notlar Paneli
 Projeye ait bazı küçük notlar burada görüntülenir.

 ![Image](https://github.com/user-attachments/assets/858501ea-979a-46ee-ba4a-10e458e6a143)

  ### 📩 İletişim Paneli
  Ziyaretçilerin admin kullanıcılarla iletişim kurmasını sağlayan bu panel, kullanıcı geri bildirimlerini kolaylaştırmak amacıyla tasarlanmıştır.

  ![Image](https://github.com/user-attachments/assets/e703998a-6b8a-465d-8756-f06095cc3358)

  ### 🗺 Footer Paneli
  Bu bölümde, kullanıcı deneyimini desteklemek adına mini bir site haritası ve konum bilgisi için iframe aracılığıyla entegre edilmiş bir harita yer almaktadır. Ayrıca sosyal medya hesaplarına erişim sağlayan bağlantılar da bulunmaktadır.

  ![Image](https://github.com/user-attachments/assets/5e99aba0-b9ed-4c50-b3cc-078361538d5d)

  ## ⭐️ Sözlük
  Sözlük sayfası, sistemde yer alan tüm başlıkları ve başlık altındaki yazıları herkese açık şekilde sunar. Bu sayfaya ulaşmak için oturum açmaya gerek yoktur; vitrin üzerinden doğrudan erişim sağlanabilir.

  ![Image](https://github.com/user-attachments/assets/fbc23439-9c8a-42d3-a817-7ea46b9f0025)

  ## 💫  Bu Proje Bana Neler Kattı?
  💠 SOLID prensiplerini öğrenmemi ve gerçek projede uygulayarak pekiştirmemi sağladı.
  💠 N-Katmanlı mimari ile nasıl yapı kurulacağını detaylıca öğrenmeme yardımcı oldu.
  💠 Pop-up yapılarını daha bilinçli şekilde kullanabilme pratiği kazandırdı.
  💠 Doğrulama (validation) süreçlerini etkili biçimde yönetmeyi öğretti.
  💠 ASP.NET MVC yapısında uygulamalı gelişim sağladım.
  💠 Hata sayfalarının entegrasyonu ile kullanıcı deneyimini artırmayı öğrendim.
  💠 Code First yaklaşımıyla migration işlemlerini daha iyi kavrayarak pekiştirdim.
