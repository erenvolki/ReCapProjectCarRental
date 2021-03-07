using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç kaydı sisteme eklendi";
        public static string CarNameInvalid = "Ekleme Başarısız-Araç adı en az 2 karakter olmalı";
        public static string CarDeleted = "Araç kaydı silindi";
        public static string CarUpdated = "Araç kaydı güncellendi";
        public static string BrandAdded = "Marka sisteme kaydedildi";
        public static string BrandDeleted = "Marka sistemenden silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorAdded = "Renk sisteme eklendi";
        public static string ColorDeleted = "Renk sistemden silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string Carbusy = "Araç Kullanımda";
        public static string RentalDeleted = "Kiralama bilgisi silindi";
        public static string NoRecording = "Kayıt bulunumadı";
        public static string RentalUptated = "Araç bilgisi güncellendi";
        public static string RentalAdded = "Araç kiralandı tabloya eklendi";
        public static string UserAdded = "Kullanıcı sisteme eklendi";
        public static string UserDeleted = "Kullanıcı sistemden silindi";
        public static string UserUpdated = "Kullanıcı güncellendi"; 
        public static string RentalDelivered = "Araç teslim edildi";
        public static string CustomerAdded = "Müşteri sisteme eklendi";
        public static string CustomerDeleted = "Müşteri sistemden silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CarImageLimitExceeded="Bir aracın en fazla 5 resmi olabilir";
        public  static string AuthorizationDenied="Bu işlem için yetkiniz bulunmamaktadır.";
        public static string UserRegistered="Kayıt oluşturuldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Giriş başarılı ";
        public static string UserAlreadyExists="Bu isimde bir kullanıcı zaten var";
        public static string AccessTokenCreated="Erişim anahtarı oluşturuldu";
    }
}
