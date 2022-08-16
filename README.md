# PersonelFormWcfService
![image](https://user-images.githubusercontent.com/96024765/184867752-163b7a52-f4b9-4f51-908e-ea77c1cc2607.png)                                   
Bu form projesinde veri tabanımdaki personeller tablosunu gridwievde listeleyip bu tabloya form üzerinden ekleme , güncelleme , silme ve id si girilen veriyi bulma 
işlemlerini gerçekleştirdim.

Veri tabanıma bağlantı yolunu config dosyasında girdim. Bu bağlantıyı PersonelManagerLibrary DLL'inde oluşturduğum PersonelManager sınıfında kullandım. Tüm veri tabanı 
işlemlerini bu sınıfta gerçekleştirdim. Bu işlemleri yaparken veri tabanımda ekleme , silme , güncelleme , listeleme , getirbyid işlemleri için  oluşturmuş olduğum stored
procedure'leri kullandım. Bu işlemleri başka platformarda da kullanabilmek için bir WCF Servis oluşturdum ve PersonelManagerLibrary DLL'ini kullanarak bu işlemleri WCF
Serviste yazdım. C# Form uygulamasına servis referance kısmından oluşturmuş olduğum WCF Servisi referans verdim. Servisin metodlarını kullanarak gerekli işlemleri 
gerçekleştirdim.

# Projenin Çalıştırılması
