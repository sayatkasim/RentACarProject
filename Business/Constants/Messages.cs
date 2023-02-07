using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string CarsLists = "Araçlar Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarNotFound = "Araç Bulunamadı";
        public static string CarCountOfModelError = "Aynı Plakada Araç Tanımlanamaz";
        public static string BrandlimitEceded = "Marka Sınırı Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz Bulunmuyor";
        public static string UserAdded = "Kullanıcı Sisteme Eklendi";
        public static string UserRegistered = "Kullanıcı Kayıt Edildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Şifre Hatalı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string SuccessfulLogin = "Kullanıcı Girişi Başarılı";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
