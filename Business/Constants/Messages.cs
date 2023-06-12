using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarıyla Eklendi";
        public static string ProductDeleted = "Ürün Başarıyla Silindi";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi";
        public static string ProductListed = "Ürün Başarıyla Listelendi";


        public static string CategoryAdded = "Kategori Başarıyla Eklendi";
        public static string CategoryDeleted = "Kategori Başarıyla Silindi";
        public static string CategoryUpdate = "Kategori Başarıyla Güncellendi";
        public static string CategoryListed = "Kategori Başarıyla Listelendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Hatalı Şifre";

        public static string SuccessfulLogin = "Sisteme Giriş başarılı";

        public static string UserAlreadyExists = "Bu Kullancı Zaten Mevcut";

        public static string UserRegistered="Kullanıcı Başarıyla Kaydedildi";

        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
    }
}
