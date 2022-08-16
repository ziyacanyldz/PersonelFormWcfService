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

[TSQL.txt](https://github.com/ziyacanyldz/PersonelFormWcfService/files/9350547/TSQL.txt) Dosyasındaki Tsql komutlarını kendi sql serverinizde execute ediniz.

![image](https://user-images.githubusercontent.com/96024765/184870697-eaec5da4-d483-45fc-8d83-56fb3aa632ce.png)        
Veri bağlantı adresini kendi sql server adresinizi giriniz. 

![image](https://user-images.githubusercontent.com/96024765/184871207-d85e4db1-4e03-4626-a685-3f13cdd4704f.png)      
Projeyi çalıştırırken servis ve form uygulamasının aynı anda çalışması için Solution Explorer kısmına sağ tık yapıp propertiese geliniz ve resimdeki gibi ayarlayınız.

