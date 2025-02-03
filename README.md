# Traversal Gezi Projesi

Bu projemde bir gezi şirketine ait bir websitesi oluşturdum. Bu websitesi ana sayfa, admin paneli ve üye paneli olmak üzere üç ana bölüm vardır. 
Bu bölümlere ek olarak Kayıt olma ve Giriş yapma sayfaları da bulunmaktadır.


Kullanıcı verileri için SignalR teknolojisi kullanılmıştır.
Admin Panelinde ve İletişimde Mail Gönderme işlemi vardır.

## Kullanığım teknolojiler: 
- ASP .NET Core 8
- EF Framework
- Fluent Validation
- Identity
- MailKit
- AutoMapper
- CQRS Design Pattern
- Mediatr
- SignalR
- UnitOfWork Design Pattern


## Ana Sayfa
Ana Sayfada Hakkımızda, Rotalar, Rehberlerimiz, İletişim bölümleri mevcuttur.
- **Hakkımızda** Traversal şirketine ait bilgiler bulunur.
- **Rotalar** sayfasında tur rotaları yer alırken, her rotaya ait bilgiler, kullanıcı yorumları ve yorum yapma alanı bulunur.
- **Rehberlerimiz** sayfasında rehberlere ait resim ve bir kısa yazı bulunur.
- **İletişim** bölümünde mesaj bırakma ve adres bilgileri bulunur.

![TraversalDashboard1](https://github.com/user-attachments/assets/ceb0f63f-2b74-4bbf-a8a0-b739e0130cb0)
![TraversalDashboard2](https://github.com/user-attachments/assets/74e42f60-2818-4927-af51-81c6083da1a5)
![TraversalDashboard4](https://github.com/user-attachments/assets/b4402bb9-77bc-468c-abc9-5496316e8135)
![TraversalDashboard3](https://github.com/user-attachments/assets/9c31e90c-6051-4474-84d8-b1f40c2246f0)
## Ana Sayfa - Rotalar
![TraversalRotalar](https://github.com/user-attachments/assets/2035eba5-79ae-41ba-b31b-dea6b64a16ba)
## Ana Sayfa - Bize Ulaşın
![TraversalIletisim](https://github.com/user-attachments/assets/46c3a590-bee5-46a0-b4cc-c819334160f4)
## Ana Sayfa - Rehberler
![TraversalRehberler](https://github.com/user-attachments/assets/e0069dc5-bd26-45af-b52e-479155ed5e31)

## Kullnıcı Paneli
- **Dashboard:** Kullanıcı istatistikleri, aktif tur rehberleri listelenmektedir.
- **Profilim:** Kullanıcıya it bilgiler güncellenebilir.
- **Aktif/Geçmiş/Onay Bekleyen Rezervasyonlar:** Rezervasyon durumuna göre geziler burada listelenir.
- **Yeni Rezervasyon:** Yeni rezervasyon oluşturmak için kullanılır.
- **Yorumlarım:** Kullanıcıya ait yorumlar bulunur.
- **Tur Rotaları:** Tur rotaları listelenir ve kullanıcı dilediği rotayı arayabilir.
![TraversalMemberAnasayfa](https://github.com/user-attachments/assets/8f2d807d-2e95-4c2d-a86b-b7994e7c02ca)
![TraversalMemberAktifRotalar](https://github.com/user-attachments/assets/d2732f76-df11-43c7-98fe-6b1924730e70)
![TraversalMemberYeniRez](https://github.com/user-attachments/assets/1ea5bedd-3847-4d0d-ad93-9fd3498db84b)
![TraversalMemberOnayRez](https://github.com/user-attachments/assets/2043e1b2-2684-4cc3-9f7e-783530d28fe1)
![TraversalMemberGeçmişRez](https://github.com/user-attachments/assets/c99255f2-6671-4259-a9bc-0efc71feab50)
![TraversalMemberAktifRez](https://github.com/user-attachments/assets/1f15c930-1c1e-487f-bc27-d5e166615ab1)
![TraversalMemberProfilDüzenleme](https://github.com/user-attachments/assets/bcbe6ad9-c989-499b-997f-68f6bc1a5882)
![TraversalMemberSonRotalar](https://github.com/user-attachments/assets/c7ed4de7-a3e4-4613-815e-e16f3e92548f)

## Admin Paneli
- **Dashboard:** Admin İstatistikleri paneli görünür.
- **Yorumlar:** Tüm Kullanıcılara ait yorumlar listelenir.
- **Rotalar:** Yeni tur rotaları eklenebilir ve diğer işlemler yapılabilir.
- **Misafirler:** Tüm kullanıcılar listelenir ve yaptıkları yorumlar/rezervasyonlar görüntülenir.
- **Mesajlar:** İletişim bölümünden gönderilen mesajlar listelenir.
- **Rehberlerimiz:** Tüm rehberler listelenir ve yeni eklenebilir.
- **Excel / Pdf Raporları:** Tur rotaları ve kullanıcı bilgileri Excel veya PDF formatında indirilebilir.
- **Rol İşlemleri:** Kullanıcılara ve adminlere rol atanabilir. Roller güncellenebilir.
![TraversalAdminIndex](https://github.com/user-attachments/assets/7710a641-732e-4c0c-8808-704d62875200)
![TraversalAdminRol](https://github.com/user-attachments/assets/8e2c3e73-41ee-4368-846a-6d3b54477d8e)
![TraversalAdminYeniMail](https://github.com/user-attachments/assets/22f1f356-3f87-49a9-accc-4041aacac7b9)
![TraversalAdminExcelRapor](https://github.com/user-attachments/assets/86821465-0db5-462d-9d77-fd0386d0ad1c)
![TraversalAdminYeniRehber](https://github.com/user-attachments/assets/206e52f7-abda-4b5d-b792-db35305daf82)
![TraversalAdminRehberler](https://github.com/user-attachments/assets/3bf86246-80de-487e-a5a7-18a3e6b540ab)
![TraversalAdminBizeUlaşın](https://github.com/user-attachments/assets/ca1efb2b-957f-4863-b575-d3287a8aad55)
![TraversalAdminKullanıcıListesi](https://github.com/user-attachments/assets/a4985e51-1cc3-4c68-b16d-aead3038a0e8)
![TraversalAdminTurRotaları](https://github.com/user-attachments/assets/48b8a1cb-53ac-4492-8b81-6d578399ee98)
![TraversalAdminYorumlar](https://github.com/user-attachments/assets/f2dd5f94-2cb2-4c60-ae83-31f9ba2f818b)

